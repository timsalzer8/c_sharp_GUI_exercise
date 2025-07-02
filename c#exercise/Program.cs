using System;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace c_sharp_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            coverletter();

            Console.WriteLine("Menge    Preis   Gesamt");

            invoice(2, 8.49);
            invoice(3, 1.99);
            invoice(1, 4.95);

        }

        static void coverletter()
        {
            string name = "Herr Maier";
            string date = "02.07.2025";

            Console.WriteLine("Hallo " + name + @",
Hiermit übersende ich Ihnen die Rechnung für meine Leistungen am " + date + @".
Vielen Dank, dass Sie unsere Dienste genutzt haben.

Mit freundlichen Grüßen
Tim Salzer
");
        }

        static void invoice(int amount, double price)
        {
            double total = amount * price;

            Console.WriteLine(amount + "        " + price + "€   " + total + "€");

        }
    }
}