namespace c_sharp_exercise2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            comboBoxAmount = new ComboBox();
            textBoxPrice = new TextBox();
            textBoxName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(583, 45);
            button1.Name = "button1";
            button1.Size = new Size(84, 26);
            button1.TabIndex = 0;
            button1.Text = "Hinzufügen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBoxAmount
            // 
            comboBoxAmount.FormattingEnabled = true;
            comboBoxAmount.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBoxAmount.Location = new Point(27, 76);
            comboBoxAmount.Name = "comboBoxAmount";
            comboBoxAmount.Size = new Size(121, 23);
            comboBoxAmount.TabIndex = 1;
            comboBoxAmount.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(210, 76);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 2;
            textBoxPrice.Text = "5,95";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(357, 76);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(175, 23);
            textBoxName.TabIndex = 3;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(357, 51);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 4;
            label1.Text = "Produktname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 51);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Anzahl";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 51);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 6;
            label3.Text = "Preis";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(27, 132);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1395, 496);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 765);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(textBoxPrice);
            Controls.Add(comboBoxAmount);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Rechnungsvorlagen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBoxAmount;
        private TextBox textBoxPrice;
        private TextBox textBoxName;
        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBox1;
    }
}
