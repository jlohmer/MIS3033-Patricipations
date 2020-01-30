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

namespace _P__WPF___Classes
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

        private void btn_sumbit_Click(object sender, RoutedEventArgs e)
        {
            EntryForm entry1 = new EntryForm();
            entry1.Name = txt_name.Text;
            entry1.Address = txt_address.Text;
            entry1.ZipCode = Convert.ToInt32(txt_zipcode.Text);

            

            lst_submissions.Items.Add(entry1);


            
        }
    }
}
