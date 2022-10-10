using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class CashRegister
    {
        public decimal Total { get; set; }
        public int NumberofItems { get; set; }

        public static int id = 0;

        public int RegisterID { get; set; }


        public CashRegister()
        {
            RegisterID = ++id;
        }

        public void AddItem()
        {
            Console.Write($"Enter price of item for Cash Register {RegisterID}: ");
            decimal price = Decimal.Parse(Console.ReadLine());

            Total += price;
            NumberofItems++;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Cash Register {RegisterID} Total : {Total}");
            Console.WriteLine($"Cash Register {RegisterID} Number of Items : {NumberofItems}");
        }
    }
}
