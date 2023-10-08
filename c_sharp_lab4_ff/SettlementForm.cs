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
        private readonly Recruting _recruting = Recruting.Instance;
        private Settlement _settlement;
        public Settlement Settlement
        {
            get { return _settlement; }
            set
            {
                _settlement = value;
                EmployerBox.SelectedItem = _settlement.Employer;
                AspiranteBox.SelectedItem = _settlement.Aspirante;
                dolzhBox.Text = _settlement.post;
                CommissionUpDown.Value = _settlement.Commission; 
            }
        }

        public SettlementForm()
        {
            InitializeComponent();
            _recruting.AspiranteAdded += _recruting_AspiranteAdded;
            _recruting.AspiranteRemoved += _recruting_AspiranteRemoved;
            _recruting.EmployerAdded += _recruting_EmployerAdded;
            _recruting.EmployerRemoved += _recruting_EmployerRemoved;
            foreach (var item in _recruting.Employers)
            {
               
                EmployerBox.Items.Add(item);
            }
            foreach (var item in _recruting.Aspirantes)
            {
                
                AspiranteBox.Items.Add(item);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Settlement.Aspirante = AspiranteBox.SelectedItem as Aspirante;
            Settlement.Employer = EmployerBox.SelectedItem as Employer;
            Settlement.Commission = (int)CommissionUpDown.Value;
            Settlement.post = dolzhBox.Text;
           
        }
        private void _recruting_EmployerRemoved(object sender, EventArgs e)
        {
            int key = (int)sender;
            for (int i = 0; i < EmployerBox.Items.Count; i++)
            {
                var room = EmployerBox.Items[i] as Employer;
                if (room?.EmployerId == key)
                {
                    EmployerBox.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _recruting_EmployerAdded(object sender, EventArgs e)
        {
            EmployerBox.Items.Add(sender);
        }

        private void _recruting_AspiranteRemoved(object sender, EventArgs e)
        {
            int key = (int)sender;
            for (int i = 0; i < AspiranteBox.Items.Count; i++)
            {
                var client = AspiranteBox.Items[i] as Aspirante;
                if (client?.AspiranteId == key)
                {
                    AspiranteBox.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _recruting_AspiranteAdded(object sender, EventArgs e)
        {
            AspiranteBox.Items.Add(sender);
        }

        private void SettlementForm_Load(object sender, EventArgs e)
        {

        }

        private void EmployerBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
