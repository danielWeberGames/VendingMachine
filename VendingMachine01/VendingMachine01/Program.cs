using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine01
{ 
    class Program
    {
        static void Main(string[] args)
        {
            DrawAsciiArt();

            float price = 2.50f;
            Console.WriteLine("A soda cost $" + price.ToString("N2"));
            Console.WriteLine("Please enter money");

            TakeInMoney(price);
            
            Console.ReadKey();
        }


        static void DrawAsciiArt()
        {
            Console.WriteLine("Vending Machine");
            Console.WriteLine(" ______________");
            Console.WriteLine("|..............|");
            Console.WriteLine("|..............|");
            Console.WriteLine("|.....SODA.....|");
            Console.WriteLine("|..............|");
            Console.WriteLine("|..............|");
            Console.WriteLine("|..............|");
            Console.WriteLine("|..............|");
            Console.WriteLine("|..............|");
            Console.WriteLine("|______________|");
            Console.WriteLine(" V            V");
            Console.WriteLine("");
        }

        static void TakeInMoney(float price)
        {
            float inputAmount = 0;

            while (inputAmount < price)
            {
                inputAmount = float.Parse(Console.ReadLine());
                if (inputAmount > price)
                {
                    break;
                }
                Console.WriteLine("not enough, please enter a new amount");
            }

            float change = inputAmount - price;

            ReturnChange(change);

        }

        static void ReturnChange(float totalChange)
        {
            int dollars = 0;
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;
            int pennies = 0;

            Console.WriteLine("Enjoy the soda, your change is");
            Console.WriteLine("$" + totalChange.ToString("N2"));

            while (totalChange >= 1)
            {
                totalChange -= 1;
                dollars++;
            }

            while (totalChange >= 0.25f)
            {
                totalChange -= 0.25f;
                quarters++;
            }

            while (totalChange >= 0.10f)
            {
                totalChange -= 0.1f;
                dimes++;
            }
            while (totalChange >= 0.05f)
            {
                totalChange -= 0.05f;
                nickels++;
            }
            while (totalChange >= 0.01f)
            {
                totalChange -= 0.01f;
                pennies++;
            }
            Console.WriteLine("return " + dollars + " dollars, " + quarters + " quarters, " + dimes + " dimes, " + nickels + " nickels, " + pennies + " pennies");

        }
    }

}
