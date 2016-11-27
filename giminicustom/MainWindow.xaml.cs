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
            this.lst_PingResult.Items.Clear();

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
                lst_PingResult.Items.Add("主机地址：" + reply.Address.ToString());
                lst_PingResult.Items.Add("往返时间：" + reply.RoundtripTime);


            }
            else
                lst_PingResult.Items.Add(reply.Status.ToString());

        }

        }

        

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        
        }
    }
}