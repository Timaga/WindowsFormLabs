﻿using c_sharp_lab4;
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
        private Employer _employer;
        public Employer Employer
        {
            get { return _employer; }
            set
            {
                _employer = value;
                NameBox.Text = Employer.Name;
                PhoneBox.Text = Employer.PhoneNumber;
                activityBox.Text = Employer.Activity;
                adressBox.Text = Employer.Adress;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Employer.Name = NameBox.Text;
            Employer.PhoneNumber = PhoneBox.Text;
            Employer.Activity = activityBox.Text;
            Employer.Adress=adressBox.Text;
        }

        private void Employers_Load(object sender, EventArgs e)
        {

        }
    }
}
