using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiscreenApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
               
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Login button was pressed!");

            // UI:  get data from text boxes
            string n = textBox1.Text;
            string p = textBox2.Text;

            // send data through your Form2 constructor
            Form2 screen2 = new Form2(n, p);

            // Show the next screen
            screen2.ShowDialog();

            // When screen 2 closes, grab the data from screen 2 and display it in console!
            Console.WriteLine("Data from screen 2: " + screen2.stuff);
            Console.WriteLine(screen2.age);
            Console.WriteLine(screen2.color);

            // Also display it in the UI
            label4.Text = screen2.stuff;
            label5.Text = screen2.age;
            label6.Text = screen2.color;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
