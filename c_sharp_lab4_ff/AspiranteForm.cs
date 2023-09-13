using c_sharp_lab4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sharp_lab4_ff
{
    public partial class AspiranteForm : Form
    {
        public AspiranteForm()
        {
            InitializeComponent();
        }

        public Aspirante Aspirante { get; }

        public AspiranteForm(Aspirante aspirante)
        {
            InitializeComponent();
            Aspirante = aspirante;
            SecondNameBox.Text = Aspirante.SecondName;
            FirstNameBox.Text = Aspirante.FirstName;
            LastNameBox.Text = Aspirante.LastName;
            Qualification_box.Text = Aspirante.Qualification;
            activityBox.Text = Aspirante.Activity;
            OthereData_Box.Text = Aspirante.OthereData;
            pay.Value = Aspirante.Wage;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AspiranteForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aspirante.FirstName = SecondNameBox.Text;
            Aspirante.Wage = (int)pay.Value;
            Aspirante.SecondName= FirstNameBox.Text;
            Aspirante.LastName= LastNameBox.Text;
            Aspirante.Qualification= Qualification_box.Text;
            Aspirante.Activity= activityBox.Text;
            Aspirante.OthereData= OthereData_Box.Text;
        }
    }
}
