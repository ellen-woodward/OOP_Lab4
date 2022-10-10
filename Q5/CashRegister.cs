using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class CashRegister
    {
        public decimal Total { get; set; }
        public int NumberofItems { get; set; }

        public static int id = 0;

        public int RegisterID { get; set; }

        public static decimal totalCash = 0;
        public static int totalNumberofItems = 0;


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

            totalCash += price;
            totalNumberofItems++;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Cash Register {RegisterID} Total : {Total}");
            Console.WriteLine($"Cash Register {RegisterID} Number of Items : {NumberofItems}");
        }

        public void TotalInfo()
        {
            Console.WriteLine($"Overall total : {totalCash} \nOverall number of items : {totalNumberofItems}");
        }
    }
}
