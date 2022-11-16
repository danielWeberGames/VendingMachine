using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine01
{ 

    class Globals
    {
        public static float price;
    }
    class Program
    {
        static void Main(string[] args)
        {
            DrawAsciiArt();

            ChooseMenu();

            TakeInMoney();
            
            Console.ReadKey();
        }


        static void DrawAsciiArt()
        {
            Console.WriteLine("Vending Machine");
            Console.WriteLine(" ______________");
            Console.WriteLine("|..............|");
            Console.WriteLine("|..............|");
            Console.WriteLine("|..............|");
            Console.WriteLine("|..............|");
            Console.WriteLine("|..............|");
            Console.WriteLine("|..............|");
            Console.WriteLine("|..............|");
            Console.WriteLine("|..............|");
            Console.WriteLine("|______________|");
            Console.WriteLine(" V            V");
            Console.WriteLine("");
        }

        static void ChooseMenu()
        {
            float sodePrice = 2.50f;
            float chipsPrice = 1.25f;
            float fruitPrice = 0.50f;

            Console.WriteLine("Soda : " + sodePrice.ToString("N2") + ", Chips : " + chipsPrice.ToString("N2") + ", Fruit : " + fruitPrice.ToString("N2"));
            Console.WriteLine("Please pick a snack");

            string selection = Console.ReadLine().ToLower();
            switch (selection)
            {
                case "soda":
                    Globals.price = sodePrice;
                    Console.WriteLine("a soda cost " + sodePrice.ToString("N2"));
                    break;

                case "chips":
                    Globals.price = chipsPrice;
                    Console.WriteLine("a bag of chips cost " + chipsPrice.ToString("N2"));
                    break;

                case "fruit":
                    Globals.price = fruitPrice;
                    Console.WriteLine("a piece of fruit cost " + fruitPrice.ToString("N2"));
                    break;
                default:
                    Console.WriteLine("invalid selection");
                    break;
            }
        }
        static void TakeInMoney()
        {
            Console.WriteLine("Please enter money");
            float inputAmount = 0;

            while (inputAmount < Globals.price)
            {
                inputAmount = float.Parse(Console.ReadLine());
                if (inputAmount > Globals.price)
                {
                    break;
                }
                Console.WriteLine("not enough, please enter a new amount");
            }

            float change = inputAmount - Globals.price;

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
