namespace c_sharp_exercise2
{
    public partial class Form1 : Form
    {
        double totalPrice = 0;
        double totalTax = 0;
        double tax = 0;

        List<object[]> table = new List<object[]>();

        public Form1()
        {
            InitializeComponent();
            comboBoxAmount.DropDownStyle = ComboBoxStyle.DropDownList;
            for (int i = 1; i <= 10; i++)
            {
                comboBoxAmount.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int amount = int.Parse(comboBoxAmount.SelectedItem.ToString());
            double price = double.Parse(textBoxPrice.Text);
            string name = textBoxName.Text;

            table.Add(new object[] { amount, price, name});


            printShippingCosts();

            coverletter();
            richTextBox1.Text += "Menge\t\t\tPreis\t\t\tUst. 19%\t\tGesamt\t\t\tArtikel\n";
            for (int i = 0; i < table.Count; i++)
            {
                printRow(i);
            }
        }

        void printRow(int rowNumber)
        {
            invoice((int)table[rowNumber][0], (double)table[rowNumber][1], (string)table[rowNumber][2]);
        }

        void invoice(int amount, double price, string product) // Auflistung der Kosten
        {
            double total = amount * price;
            tax = total * 0.19;
            totalPrice = totalPrice + total;
            totalTax = totalTax + tax;

            richTextBox1.Text += amount + "\t\t\t" + Math.Round(price, 2) + "€\t\t\t" + Math.Round(tax, 2) + "€\t\t" + Math.Round(total, 2) + "€\t\t\t" + product + @"
";

        }

        void printShippingCosts()
        {
            if (totalPrice > 30)
            {
                richTextBox1.Text += "\n";
                richTextBox1.Text += "Versandkosten:\t\t" + 0 + "€\n";
            }

            else if (totalPrice > 15)
            {
                richTextBox1.Text += "Versandkosten:\t\t" + 2.99 + "€\t\t\t" + Math.Round(2.99 * 0.19, 2) + "€\n";
                totalPrice = totalPrice + 2.99;
                totalTax = totalTax + 2.99 * 0.19;
            }
            else
            {
                richTextBox1.Text += "Versandkosten:\t\t" + 5.99 + "€\t\t\t" + Math.Round(5.99 * 0.19, 2) + "€\n";
                totalPrice = totalPrice + 5.99;
                totalTax = totalTax + 5.99 * 0.19;
            }

            // Print total sum
            richTextBox1.Text += "Gesamtsumme:\t\t" + Math.Round(totalPrice, 2) + "€\n";

            // Print total tax
            richTextBox1.Text += "Gesamte Ust.:\t\t" + Math.Round(totalTax, 2) + "€\n";

        }

        void coverletter() // Text der Rechnung
        {
            string name = "Herr Maier";
            string date = "02.07.2025";

            richTextBox1.Text = "Hallo " + name + @",
Hiermit übersende ich Ihnen die Rechnung für meine Leistungen am " + date + @".
Vielen Dank, dass Sie unsere Dienste genutzt haben. 

Mit freundlichen Grüßen
Tim Salzer

";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
