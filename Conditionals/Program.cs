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

            //Console.WriteLine("How many people are in your party?");
            //int numberOfPeople = int.Parse(Console.ReadLine());

            //Console.WriteLine("What is your total bill?");
            //double totalBill = double.Parse(Console.ReadLine());

            ////Define billWithDiscount outside of conditional statements
            //double billWithDiscount;


            //if (totalBill >= 50)
            //{
            //    billWithDiscount = totalBill * .9;
            //}
            //else
            //{
            //    billWithDiscount = totalBill * .95;
            //}

            //double costPerPerson = billWithDiscount / numberOfPeople;
            //Console.WriteLine("Your individual total is: $" + costPerPerson);


            //Console.WriteLine("What is your age?");
            //int age = int.Parse(Console.ReadLine());

            //if(age >=0 && age<=2)
            //{
            //    Console.WriteLine("Still in Mama's Arms");
            //}
            //else if (age >= 3 && age <= 4)
            //{
            //    Console.WriteLine("Preschool Maniac");
            //}
            //else if (age >= 5 && age <= 11)
            //{
            //    Console.WriteLine("Elementary School");
            //}
            //else if (age >= 12 && age <= 14)
            //{
            //    Console.WriteLine("Middle School");
            //}
            //else if (age >= 15 && age <= 18)
            //{
            //    Console.WriteLine("High School");
            //}
            //else if (age >= 19 && age <= 22)
            //{
            //    Console.WriteLine("College");
            //}
            //else if (age >= 23 && age <= 65)
            //{
            //    Console.WriteLine("Working for the Man");
            //}
            //else if (age >= 66 && age <= 100)
            //{
            //    Console.WriteLine("The Golden Years");
            //}
            //else 
            //{
            //    Console.WriteLine("This Program is for Humans");
            //}


            Console.WriteLine("Enter a number from zero to ten as a word.");
            string digit = Console.ReadLine();

            switch(digit)
            {
                case "zero":
                    Console.WriteLine("0");
                    break;
                case "one":
                    Console.WriteLine("1");
                break;
                case "two":
                    Console.WriteLine("2");
                    break;
                case "three":
                    Console.WriteLine("3");
                    break;
                case "four":
                    Console.WriteLine("4");
                    break;
                case "five":
                    Console.WriteLine("5");
                    break;
                case "six":
                    Console.WriteLine("6");
                    break;
                case "seven":
                    Console.WriteLine("7");
                    break;
                case "eight":
                    Console.WriteLine("8");
                    break;
                case "nine":
                    Console.WriteLine("9");
                    break;
                case "ten":
                    Console.WriteLine("10");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }



        }
    }
}

