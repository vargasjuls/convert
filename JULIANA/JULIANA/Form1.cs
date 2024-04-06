using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JULIANA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox1.Text);
            if (frcomboBox1.SelectedItem == "PESO" && tocomboBox2.SelectedItem == "DOLLAR")
            {
                double conver = i * 0.018;
                display_txt.Text = "CONVERTED AMOUNT : " + conver + "\t $";

            }
            if (frcomboBox1.SelectedItem == "PESO" && tocomboBox2.SelectedItem == "WON")
            {
                double conver = i * 23.88;
                display_txt.Text = "CONVERTED AMOUNT : " + conver + "\t ₩";
            }
            if (frcomboBox1.SelectedItem == "PESO" && tocomboBox2.SelectedItem == "YEN")
            {
                double conver = i * 2.68;
                display_txt.Text = "CONVERTED AMOUNT : " + conver + "\t  ¥";
            }
            if (frcomboBox1.SelectedItem == "DOLLAR" && tocomboBox2.SelectedItem == "PESO")
            {
                double conver = i * 56.59;
                display_txt.Text = "CONVERTED AMOUNT : " + conver + "\t ₱";

            }
            if (frcomboBox1.SelectedItem == "DOLLAR" && tocomboBox2.SelectedItem == "WON")
            {
                double conver = i * 1351.27;
                display_txt.Text = "CONVERTED AMOUNT : " + conver + "\t ₩";
            }
            if (frcomboBox1.SelectedItem == "DOLLAR" && tocomboBox2.SelectedItem == "YEN")
            {
                double conver = i * 151.61;
                display_txt.Text = "CONVERTED AMOUNT : " + conver + "\t  ¥";
            }
            if (frcomboBox1.SelectedItem == "WON" && tocomboBox2.SelectedItem == "PESO")
            {
                double conver = i * 0.042;
                display_txt.Text = "CONVERTED AMOUNT : " + conver + "\t ₱";

            }
            if (frcomboBox1.SelectedItem == "WON" && tocomboBox2.SelectedItem == "DOLLAR")
            {
                double conver = i * 0.00074;
                display_txt.Text = "CONVERTED AMOUNT : " + conver + "\t $";
            }
            if (frcomboBox1.SelectedItem == "WON" && tocomboBox2.SelectedItem == "YEN")
            {
                double conver = i * 0.11;
                display_txt.Text = "CONVERTED AMOUNT : " + conver + "\t  ¥";
            }
            if (frcomboBox1.SelectedItem == "YEN" && tocomboBox2.SelectedItem == "PESO")
            {
                double conver = i * 0.37;
                display_txt.Text = "CONVERTED AMOUNT : " + conver + "\t ₱";

            }
            if (frcomboBox1.SelectedItem == "YEN" && tocomboBox2.SelectedItem == "DOLLAR")
            {
                double conver = i * 0.0066;
                display_txt.Text = "CONVERTED AMOUNT : " + conver + "\t $";
            }
            if (frcomboBox1.SelectedItem == "YEN" && tocomboBox2.SelectedItem == "WON")
            {
                double conver = i * 8.91;
                display_txt.Text = "CONVERTED AMOUNT : " + conver + "\t ₩";
            }
            
        }
    }
}
