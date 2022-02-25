using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kapitel_14
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
            string[] animalsArrayen = { "gris", "apa", "hund" };
            Array.Sort(animalsArrayen);

            //Console.WriteLine("Sök efter en djurart i databasen");
            //var iskrivetDjure = Console.ReadLine();
            var iskrivetDjure = textBox1.Text;

            var index = Array.FindIndex(animalsArrayen, row => row.Contains(iskrivetDjure));


            if (index >= 0)
            {
                //Console.WriteLine($"Position: {index}");
                label1.Text = index.ToString();
            }

            else
            {
                //Console.WriteLine($"{iskrivetDjure} finns INTE med i databasen");
                label1.Text = "Finns INTE med i databasen";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
