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

namespace PaulMcDonagh_S00189392
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public PhoneData db = new PhoneData();
        public List<Phone> allPhones = new List<Phone>();
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var query = from phone in db.Phones
                        select phone;
            foreach (var item in db.Phones)
            {
                allPhones.Add(item);
            }

            lbx_Phones.ItemsSource = allPhones;
            lbx_Phones.SelectedIndex = 0;
            Phone p = lbx_Phones.SelectedItem as Phone;

            txblk_Price.Text = ($" {p.Price:c}");
        }
    }
}
