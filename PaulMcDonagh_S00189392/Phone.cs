using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PaulMcDonagh_S00189392
{
    public class Phone
    {
        public int PhoneID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Operating_System { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        public void IncreasePrice(decimal percent)
        {
            Price += ((percent/100) * Price);
        }
        public Phone(string _name,decimal _price, string _os, string _osImage, string _phoneImg)
        {
            Name = _name;
            Price = _price;
            Operating_System = _os;
            OS_Image = _osImage;
            Phone_Image = _phoneImg;
        }
        public Phone() { }
        
    }
    public class PhoneData : DbContext
    {
        public PhoneData() : base("MyPhoneData") { }
        public DbSet<Phone> Phones { get; set; }
    }
}
