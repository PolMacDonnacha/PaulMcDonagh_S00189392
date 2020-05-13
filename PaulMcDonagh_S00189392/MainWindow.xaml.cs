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

        public int phoneIndex;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var query = from phone in db.Phones
                        select new
                        {
                            phone.OS_Image,
                            phone.Name
                        };
            foreach (var item in db.Phones)
            {
                allPhones.Add(item);
            }
            lbx_Phones.ItemsSource = allPhones;
            lbx_Phones.SelectedIndex = 0;
            Phone p = lbx_Phones.SelectedItem as Phone;
            phoneIndex = p.PhoneID - 1;
            txblk_Price.Text = ($" {p.Price:c}");

            BitmapImage phoneIMG = new BitmapImage(new Uri($"{p.Phone_Image}", UriKind.RelativeOrAbsolute));
            img_Phone.Source = phoneIMG;
        }

        private void lbx_Phones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone p = lbx_Phones.SelectedItem as Phone;
            if (p!= null)
            {
                txblk_Price.Text = null;
                txblk_Price.Text = ($" {p.Price:c}");
                BitmapImage phoneIMG = new BitmapImage(new Uri($"{p.Phone_Image}", UriKind.RelativeOrAbsolute));
                img_Phone.Source = phoneIMG;
            }

        }
    }
}
