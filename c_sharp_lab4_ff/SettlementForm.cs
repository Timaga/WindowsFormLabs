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
    public partial class SettlementForm : Form
    {
        public SettlementForm()
        {
            InitializeComponent();
        }
        public Settlement Settlement { get; }
        public SettlementForm(Settlement settlement)
        {
            InitializeComponent();
            Settlement = settlement;
            foreach (var item in Recruting.EmployersMap)
            {
                var client = item.Value;
                EmployerBox.Items.Add(client);
            }
            foreach (var item in Recruting.Aspirants)
            {
                var room = item.Value;
                AspiranteBox.Items.Add(room);
            }
            EmployerBox.SelectedItem = settlement.Employer;
            AspiranteBox.SelectedItem = settlement.Aspirante;
            dolzhBox.Text = settlement.post;
            CommissionUpDown.Value = settlement.Commission;
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Settlement.Aspirante = AspiranteBox.SelectedItem as Aspirante;
            Settlement.Employer = EmployerBox.SelectedItem as Employer;
            Settlement.Commission = (int)CommissionUpDown.Value;
            Settlement.post = dolzhBox.Text;
           
        }

        private void SettlementForm_Load(object sender, EventArgs e)
        {

        }

        private void EmployerBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
