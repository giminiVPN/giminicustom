using GeminiVPN.ViewModels;
using GeminiVPN.Views;
using log4net;
using log4net.Config;
using Microsoft.Practices.Unity;
using Prism.Logging;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace GeminiVPN
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            new Bootstrapper(this).Run();
        }

        public class Bootstrapper : UnityBootstrapper
        {
            public Bootstrapper(App app)
            {
                Application = app;
            }

            public App Application { get; }

            protected override ILoggerFacade CreateLogger()
            {
                XmlConfigurator.Configure();

                return new BootstrapperLogger();
            }

            protected override void ConfigureContainer()
            {
                base.ConfigureContainer();

                Container.RegisterType<MainShell>();
                Container.RegisterType<MainShellViewModel>();
            }

            protected override DependencyObject CreateShell()
            {
                return Container.Resolve<MainShell>();
            }

            protected override void InitializeShell()
            {
                Application.MainWindow = (Window)Shell;
                Application.MainWindow.Show();
            }
        }

        public class BootstrapperLogger : ILoggerFacade
        {
            public ILog Logger { get; }

            public BootstrapperLogger()
            {
                Logger = LogManager.GetLogger(typeof(Bootstrapper));
            }

            public void Log(string message, Category category, Priority priority)
            {
                switch (category)
                {
                    case Category.Debug:
                        Logger.DebugFormat("[{0}] {1}", priority, message);
                        break;
                    case Category.Exception:
                        Logger.ErrorFormat("[{0}] {1}", priority, message);
                        break;
                    case Category.Info:
                        Logger.InfoFormat("[{0}] {1}", priority, message);
                        break;
                    case Category.Warn:
                        Logger.WarnFormat("[{0}] {1}", priority, message);
                        break;
                    default:
                        Logger.InfoFormat("[{0}] {1}", priority, message);
                        break;
                }
            }
        }
    }
}
