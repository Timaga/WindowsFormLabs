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
    public partial class Employers : Form
    {
        public Employers()
        {
            InitializeComponent();
        }
        public Employer Employer { get; }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        public Employers(Employer employer)
        {
            InitializeComponent();
            Employer = employer;
            textBox1.Text = Employer.Name;
            textBox2.Text = Employer.PhoneNumber;
            textBox3.Text = Employer.Activity;

            textBox4.Text = Employer.Adress;
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Employer.Name = textBox1.Text;
            Employer.PhoneNumber = textBox3.Text;
            Employer.Activity = textBox4.Text;
            Employer.Adress=textBox2.Text;
        }

        private void Employers_Load(object sender, EventArgs e)
        {

        }
    }
}
