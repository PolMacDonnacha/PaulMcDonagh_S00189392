﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PaulMcDonagh_S00189392;
using System.Threading.Tasks;

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone p1 = new Phone("Samsung S20", 500, "Android", "/images/android.png", "images/s20.jpg");
            Phone p2 = new Phone("iPhone 11", 600, "IOS", "/images/apple.png", "images/iphone11.jpg");
        }
    }
}
