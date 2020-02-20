using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace _P__GOT_Quote
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            

            
        }

        private void txt_getQuote_Click(object sender, RoutedEventArgs e)
        {
            string path = "https://got-quotes.herokuapp.com/quotes";

            GoT_API goT_API;

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(path).Result;

                goT_API = JsonConvert.DeserializeObject<GoT_API>(json);
            }

                lst_quotes.Items.Add(goT_API.ToString());
            
        }
    }
}
