using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2200_WoodsC_Participation02
{
    public class Phone
    {

        //constructor

        public Phone(string[] phone)
        {
            Make = phone[0];
            Model = phone[1];
            DisplaySize = phone[2];
            Storage = phone[3];
            Price = decimal.Parse(phone[4]);

        }

        //properties

        public string Make { get; set; }
        public string Model { get; set; }
        public string DisplaySize { get; set; }
        public string Storage { get; set; }
        public decimal Price { get; set; }
    }
}
