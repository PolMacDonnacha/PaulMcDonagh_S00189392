using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulMcDonagh_S00189392
{
    public class Phone
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Operating_System { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        public void IncreasePrice(decimal percent)
        {
            Price += percent/100;
        }
    }
}
