using System.Runtime.CompilerServices;

namespace AbstractionIntroApp
{
    internal class Program
    {
        // In C#, an abstract classs is a special type of class that cannot be instantiated. An abstract class is designed to be inherited by subclasses that either implement or override its methods. In other words, abstract classes are either partially implemented or not implemented at all.
        public abstract class Printer
        {
            public string modelNumber = "Default";

            public abstract double Price { get; set; } 

            public abstract string PrintMethod(); // Forces an override method when used. 

            public string CompanyInfo()
            {
                return "Hewlett Packard";
            }
        }

        public class InkJet : Printer
        {
            public string modelType = "Hyper-Jet";
            double price;

            public override double Price {
                get { return price; } 
                set { // Checks the price. 
                    if (price < 0) // If less than zero, set price to zero.
                    {
                        price = 0;
                    }
                    else // If else, set price to value. 
                    {
                        price = value;
                    }
                }
            }

            public override string PrintMethod() // This override method must be implemented when inheriting from Printer class because of method abstraction. 
            {
                return $"{base.modelNumber}, {this.modelType}";
            }
        }

        static void Main(string[] args)
        {
            InkJet inkJet = new InkJet();
            inkJet.modelNumber = "INKJ2341Y";
            inkJet.modelType = "Ink Jet Style Printer";
            inkJet.Price = 100;

            Console.WriteLine($"{inkJet.CompanyInfo()}\n{inkJet.modelNumber}, {inkJet.PrintMethod()}\n{inkJet.Price}");


            // Printer can't be instantiated because the class is abstracted. Code below will throw an error for that reason.

            /* Printer printer = new Printer();
            printer.modelNumber = "HP345x";

            Console.WriteLine($"{printer.CompanyInfo()}, {printer.modelNumber}"); */

        }
    }
}
