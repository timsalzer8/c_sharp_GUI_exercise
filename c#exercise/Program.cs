using System;
using System.Numerics;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace c_sharp_exercise
{
    class Program
    {
        static double totalPrice = 0;
        static double totalTax = 0;
        static double tax = 0;

        static object[,] table =
        {
    { 2, 8.49, "Platine" },     // erste Reihe
    { 3, 1.95, "Schraube" },    // zweite Reihe
    { 1, 4.95, "Lötzinn" },     // dritte Reihe
    { 5, 0.99, "Kabelbinder" }, // vierte Reihe
    { 2, 12.50, "Netzteil" },   // fünfte Reihe
    { 10, 0.15, "Widerstand" }, // sechste Reihe
    { 4, 2.75, "Kondensator" }, // siebte Reihe
    { 1, 39.90, "Multimeter" }, // achte Reihe
    { 6, 0.45, "LED rot" },     // neunte Reihe
    { 2, 7.80, "Breadboard" }   // zehnte Reihe
};

        /** Dies ist eine Demonstration,
         * 
         * 
         * 
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
            Console.WriteLine("Menge\t\t\tPreis\t\t\tUst. 19%\t\tGesamt\t\t\tArtikel");
            
            for(int i = 0; i < table.GetLength(0); i++)
            { 
            printRow(i);
            }

            printShippingCosts();

            static void printRow(int rowNumber)
            {
            invoice((int)table[rowNumber, 0], (double)table[rowNumber, 1], table[rowNumber, 2].ToString());
            }

            static void printShippingCosts()
            {
                if (totalPrice > 30)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Versandkosten:\t\t" + 0 + "€");
                }

                else if (totalPrice > 15)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Versandkosten:\t\t" + 2.99 + "€\t\t\t" + Math.Round(2.99 * 0.19, 2) + "€");
                    totalPrice = totalPrice + 2.99;
                    totalTax = totalTax + 2.99 * 0.19;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Versandkosten:\t\t" + 5.99 + "€\t\t\t" + Math.Round(5.99 * 0.19, 2) + "€");
                    totalPrice = totalPrice + 5.99;
                    totalTax = totalTax + 5.99 * 0.19;
                }

                // Print total sum
                Console.WriteLine("");
                Console.WriteLine("Gesamtsumme:\t\t" + Math.Round(totalPrice, 2) + "€");

                // Print total tax
                Console.WriteLine("");
                Console.WriteLine("Gesamte Ust.:\t\t" + Math.Round(totalTax, 2) + "€");

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
                tax = total * 0.19;
                totalPrice = totalPrice + total;
                totalTax = totalTax + tax;

                Console.WriteLine(amount + "\t\t\t" + Math.Round(price, 2) + "€\t\t\t" + Math.Round(tax, 2) + "€\t\t\t" + Math.Round(total, 2) + "€\t\t\t" + product);

            }

        }
    }
}