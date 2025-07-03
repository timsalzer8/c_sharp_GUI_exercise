using System;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace c_sharp_exercise
{
    class Program
    {
        /** Dies ist eine Demonstration,
         * dass mit diesem Command
         * mehrere Zeilen Kommentar
         * möglich sind
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Print the cover letter on the command line
            coverletter();

            Console.WriteLine("");
            Console.WriteLine("Menge\t\tPreis\t\tGesamt\t\tArtikel");

            invoice(2, 8.49, "Platine");
            invoice(3, 1.99, "Schraube");
            invoice(1, 4.95, "Lötzinn");
        }

        static void coverletter() // Text der Rechnung
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

        static void invoice(int amount, double price, string product) // Auflistung der Kosten
        {
            double total = amount * price;

            Console.WriteLine(amount + "\t\t" + price + "€\t\t" + total + "€\t\t" + product);

        }

    }
}