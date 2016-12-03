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
        }

        private void textBox_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

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
            string data = "test data aaaa";
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

        }

        private static string WinDir = Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\";
        private static string RasDialFileName = "rasdial.exe";
        private static string VPNPROCESS = WinDir + RasDialFileName;
        public string IPToPing { get; set; }
        // VPN名称
        public string VPNName { get; set; }
        // VPN用户名
        public string UserName { get; set; }
        // VPN密码
        public string PassWord { get; set; }

        public void VPNHelper(string _vpnIP, string _vpnName, string _userName, string _passWord)
        {
            this.IPToPing = "111.111.111.111";
            this.VPNName = "123456";
            this.UserName = "123456";
            this.PassWord = "123456";
        }

        /// 尝试连接VPN(默认VPN)
        /// </summary>
        /// <returns></returns>
        public void TryConnectVPN()
        {
            this.TryConnectVPN(this.VPNName, this.UserName, this.PassWord);
        }

        private void TryConnectVPN(string vPNName, string userName, string passWord)
        {
            throw new NotImplementedException();
        }

    }
}
