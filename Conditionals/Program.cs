using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many people are in your party?");
            int numberOfPeople = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your total bill?");
            double totalBill = double.Parse(Console.ReadLine());

            //Define billWithDiscount outside of conditional statements
            double billWithDiscount;
           

            if (totalBill >= 50)
            {
                billWithDiscount = totalBill * .9;
            }
            else
            {
                billWithDiscount = totalBill * .95;
            }

            double costPerPerson = billWithDiscount / numberOfPeople;
            Console.WriteLine("Your individual total is: $" + costPerPerson);






        }
    }
}

