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
           /* foreach (var item in Hotel.Clients)
            {
                var client = item.Value;
                comboBoxClient.Items.Add(client);
            }
            foreach (var item in Hotel.Rooms)
            {
                var room = item.Value;
                comboBoxRoom.Items.Add(room);
            }
            comboBoxClient.SelectedItem = settlement.Client;
            comboBoxRoom.SelectedItem = settlement.Room;
            dateTimePickerStartDate.Value = settlement.StartDate;
            dateTimePickerEndDate.Value = settlement.EndDate;*/
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SettlementForm_Load(object sender, EventArgs e)
        {

        }
    }
}
