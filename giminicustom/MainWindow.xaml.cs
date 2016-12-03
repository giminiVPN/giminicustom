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
using System.Net.NetworkInformation;
using System.Diagnostics;
using DotRas;
using System.IO;
using VPNConnector;
using System.Threading;

namespace giminicustom
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Closed += MainWindow_Closed;
        }

        // 窗口关闭时调用
        private void MainWindow_Closed(object sender, EventArgs e)
        {
            var vpnConnector = new VPNConnector("106.187.35.127", "Japan", textBox_Copy.Text, textBox_Copy1.Password, Protocol.PPTP);
            vpnConnector.TryDelete();

        }

        private void textBox_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckUserNameAndPassword();
        }

        private void textBox_Copy1_PasswordChanged(object sender, RoutedEventArgs e)
        {
            CheckUserNameAndPassword();
        }

        private void CheckUserNameAndPassword()
        {
            button1_Copy.IsEnabled = !string.IsNullOrEmpty(textBox_Copy.Text) && !string.IsNullOrEmpty(textBox_Copy1.Password);
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.label1.Content = null;

            string ipStr = "service-public1.universe.robertsspaceindustries.com";
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();
            options.DontFragment = true;
            string data = "HelloFromChina";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 1000;

            PingReply reply = pingSender.Send(ipStr, timeout);

            if (reply.Status == IPStatus.Success)
            {
                label1.Content = "往返时间：" + reply.RoundtripTime + "ms";
            }
            else
            {
                label1.Content = reply.Status.ToString();
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void button1_Copy_Click(object sender, RoutedEventArgs e)
        {
            var vpnConnector = new VPNConnector("106.187.35.127", "Japan", textBox_Copy.Text, textBox_Copy1.Password, Protocol.PPTP);
            vpnConnector.TryCreateOrUpdate();
            vpnConnector.TryConnect();
            
        }

        public class VPNConnector
        {
            public VPNConnector(string serverAddress, string userName, string passWord)
               : this(serverAddress, serverAddress, userName, passWord, Protocol.PPTP)
            {

            }
            public VPNConnector(string serverAddress, string connectionName, string userName, string passWord)
                : this(serverAddress, connectionName, userName, passWord, Protocol.PPTP)
            {

            }
            public VPNConnector(string serverAddress, string connectionName, string userName, string passWord, Protocol protocal)
            {
                this.serverAddress = "106.187.35.127";
                this.connectionName = "Japan";
                this.userName = "Cribug";
                this.passWord = "Cribug2016";
                this.protocol = Protocol.PPTP;
                this.rasDialFileName = System.IO.Path.Combine(WinDir, "rasdial.exe");
            }

            private static string WinDir = Environment.GetFolderPath(Environment.SpecialFolder.System);
            private string rasDialFileName;
            private readonly string serverAddress;
            private readonly string connectionName;
            private readonly string userName;
            private readonly string passWord;
            private readonly Protocol protocol;
            private readonly static string allUserPhoneBookPath = RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.AllUsers);
            private bool _createOrUpdate;

            public string RasDialFileName
            {
                get { return rasDialFileName; }
                set
                {
                    if (File.Exists(value))
                    {
                        rasDialFileName = value;
                    }

                    throw new FileNotFoundException();
                }
            }

            public bool IsActive
            {
                get
                {
                    using (Process myProcess = new Process())
                    {
                        myProcess.StartInfo.CreateNoWindow = true;
                        myProcess.StartInfo.UseShellExecute = false;
                        myProcess.StartInfo.RedirectStandardInput = true;
                        myProcess.StartInfo.RedirectStandardOutput = true;
                        myProcess.StartInfo.FileName = "cmd.exe";
                        myProcess.Start();
                        myProcess.StandardInput.WriteLine("ipconfig");
                        myProcess.StandardInput.WriteLine("exit");
                        myProcess.WaitForExit();

                        string content = myProcess.StandardOutput.ReadToEnd();
                        if (content.Contains("0.0.0.0"))
                        {
                            return true;
                        }

                        return false;
                    }

                }
            }

            public RasDevice RasDevice
            {
                get
                {
                    var name = Enum.GetName(typeof(Protocol), this.protocol);
                    var rasDevice = RasDevice.GetDevices().FirstOrDefault(c => c.Name.Contains(name));
                    if (rasDevice == null)
                    {
                        throw new Exception("No device found.");
                    }
                    return rasDevice;
                }
            }

            public RasVpnStrategy RasVpnStrategy
            {
                get
                {
                    if (protocol == Protocol.PPTP)
                    {
                        return RasVpnStrategy.PptpFirst;
                    }
                    else
                    {
                        return RasVpnStrategy.IkeV2First;
                    }
                }
            }

            public bool WaitUntilActive(int timeOut = 10)
            {
                for (int i = 0; i < timeOut; i++)
                {
                    if (!this.IsActive)
                    {
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        return true;
                    }
                }

                return false;
            }

            public bool WaitUntilInActive(int timeOut = 10)
            {
                for (int i = 0; i < timeOut; i++)
                {
                    if (this.IsActive)
                    {
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        return true;
                    }
                }

                return false;
            }

            public bool TryConnect()
            {
                try
                {
                    string args = $"{connectionName} {userName} {passWord}";
                    ProcessStartInfo myProcess = new ProcessStartInfo(rasDialFileName, args);
                    myProcess.CreateNoWindow = true;
                    myProcess.UseShellExecute = false;
                    Process.Start(myProcess);
                }
                catch (Exception Ex)
                {
                    Debug.Assert(false, Ex.ToString());
                }

                WaitUntilActive();
                if (IsActive)
                {
                    return true;
                }

                return false;
            }

            public void CreateOrUpdate()
            {
                using (var dialer = new RasDialer())
                using (var allUsersPhoneBook = new RasPhoneBook())
                {
                    allUsersPhoneBook.Open(true);
                    if (allUsersPhoneBook.Entries.Contains(connectionName))
                    {
                        allUsersPhoneBook.Entries[connectionName].PhoneNumber = connectionName;
                        allUsersPhoneBook.Entries[connectionName].VpnStrategy = RasVpnStrategy;
                        allUsersPhoneBook.Entries[connectionName].Device = RasDevice;
                        allUsersPhoneBook.Entries[connectionName].Update();
                    }
                    else
                    {
                        RasEntry entry = RasEntry.CreateVpnEntry(connectionName, serverAddress, RasVpnStrategy, RasDevice);
                        allUsersPhoneBook.Entries.Add(entry);
                        dialer.EntryName = connectionName;
                        dialer.PhoneBookPath = allUserPhoneBookPath;
                    }
                }
            }

            public void TryCreateOrUpdate()
            {
                if (_createOrUpdate)
                {
                    return;
                }
                CreateOrUpdate();
                _createOrUpdate = true;
            }

            public bool TryDisconnect()
            {
                try
                {
                    string args = $@"{connectionName} /d";
                    ProcessStartInfo myProcess = new ProcessStartInfo(rasDialFileName, args);
                    myProcess.CreateNoWindow = true;
                    myProcess.UseShellExecute = false;
                    Process.Start(myProcess);
                }
                catch (Exception Ex)
                {
                    Debug.Assert(false, Ex.ToString());
                }

                WaitUntilInActive();
                if (!IsActive)
                {
                    return true;
                }

                return false;
            }
            public void TryDelete()
            {
                using (var dialer = new RasDialer())
                using (var allUsersPhoneBook = new RasPhoneBook())
                {
                    allUsersPhoneBook.Open(true);
                    if (allUsersPhoneBook.Entries.Contains(connectionName))
                    {
                        TryDisconnect();
                        WaitUntilInActive();
                        allUsersPhoneBook.Entries.Remove(connectionName);
                    }
                }
            }

        }



    }
}
