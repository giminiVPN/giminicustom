using GeminiVPN.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Practices.Unity;

namespace GeminiVPN.Views
{
    public partial class MainShell : Window
    {
        public MainShell()
        {
            InitializeComponent();
        }

        [Dependency]
        public new MainShellViewModel DataContext
        {
            get { return base.DataContext as MainShellViewModel; }
            set { base.DataContext = value; }
        }
    }
}
