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
            
            // Print the cover letter on the command line
            coverletter();

            Console.WriteLine("");
            Console.WriteLine("Menge\t\tPreis\t\tGesamt\t\tArtikel");

            /** Diese Zeilen zur Demonstration,
             * dass mit diesem command,
             * mehrere Zeilen Kommentar
             * geschrieben werden kann
             */
            invoice(1, 8.49, "Platine");
            invoice(3, 1.99, "Schrauben");
            invoice(2, 4.89, "Lötzinn");
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