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
       

        private void lbx_Phones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone p = lbx_Phones.SelectedItem as Phone;
            if (p!= null)
            {
                txblk_Price.Text = null;
                txblk_Price.Text = p.Price.ToString();
                BitmapImage phoneIMG = new BitmapImage(new Uri($"{p.Phone_Image}", UriKind.RelativeOrAbsolute));
                img_Phone.Source = phoneIMG;
            }

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            var query = from phone in db.Phones
                        select phone;
            allPhones.Clear();
            foreach (Phone _phone in db.Phones)
            {
                allPhones.Add(_phone);
            }
            lbx_Phones.ItemsSource = query.ToList();
            lbx_Phones.SelectedIndex = 0;
            Phone p = lbx_Phones.SelectedItem as Phone;
            txblk_Price.Text = p.Price.ToString();

            BitmapImage phoneIMG = new BitmapImage(new Uri($"{p.Phone_Image}", UriKind.RelativeOrAbsolute));
            img_Phone.Source = phoneIMG;
        }
    }
}
