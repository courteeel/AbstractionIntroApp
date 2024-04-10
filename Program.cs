using System.Runtime.CompilerServices;

namespace AbstractionIntroApp
{
    internal class Program
    {
        // In C#, an abstract classs is a special type of class that cannot be instantiated. An abstract class is designed to be inherited by subclasses that either implement or override its methods. In other words, abstract classes are either partially implemented or not implemented at all.
        public abstract class Printer
        {
            public string modelNumber = "Default";

            public abstract string PrintMethod(); // Forces an override method when used

            public string CompanyInfo()
            {
                return "Hewlett Packard";
            }
        }

        public class InkJet : Printer
        {
            public string modelType = "Hyper-Jet";
            public override string PrintMethod() // This override method must be implemented when inheriting from Printer class because of method abstraction. 
            {
                return $"Model Type: {modelType}";
            }
        }

        static void Main(string[] args)
        {
            InkJet inkJet = new InkJet();
            inkJet.modelNumber = "INKJ2341Y";
            inkJet.modelType = "Ink Jet Style Printer";

            Console.WriteLine($"{inkJet.CompanyInfo()}\n{inkJet.modelNumber}, {inkJet.PrintMethod()}");


            // Printer can't be instantiated because the class is abstracted. Code below will throw an error for that reason.

            /* Printer printer = new Printer();
            printer.modelNumber = "HP345x";

            Console.WriteLine($"{printer.CompanyInfo()}, {printer.modelNumber}"); */

        }
    }
}