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
    public partial class Form2 : Form
    {

        // 1. Make a global variable to store the data
        public string stuff = "";
        public string age = "";
        public string color = "";
        

        public Form2(string name, string password)
        {
            InitializeComponent();
            Console.WriteLine("Person Name: " + name);

            // update your user interface
            label2.Text = name;
            label3.Text = password;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Go Back button pressed!");

            // 2. get the data from the text box
            // 3. set the global variable
            stuff = textBox1.Text;
            age = "25";
            color = "blue";


            // 4. close the window
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
