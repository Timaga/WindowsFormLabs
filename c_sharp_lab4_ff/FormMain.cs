using c_sharp_lab4;
namespace c_sharp_lab4_ff
{
    public partial class FormMain : Form
    {
        private Employer _Employer; 
        private Aspirante _Aspirante;
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void ÒÓÁ‰‡Ú¸ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var emp = new Employer();
            Employers formClient = new Employers(emp);
            if (formClient.ShowDialog() == DialogResult.OK)
            {
                Recruting.EmployersMap.Add(emp.EmployerId, emp);
                UpdateEmployerList();
            }
           
        }

        private void Â‰‡ÍÚËÓ‚‡Ú¸ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var employer = listViewEmployer.SelectedItems[0].Tag as Employer;
            Employers formClient = new Employers(employer);
            if (formClient.ShowDialog() == DialogResult.OK)
            {
                UpdateEmployerList();
            }
        }

        private void UpdateEmployerList()
        {
            listViewEmployer.Items.Clear();
            foreach (var item in Recruting.EmployersMap)
            {
                var client = item.Value;
                var listViewItem = new ListViewItem
                {
                    Tag = client,
                    Text = client.ToString()
                };
                listViewEmployer.Items.Add(listViewItem);
            }
        }

        private void ÒÓÁ‰‡Ú¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            var room = new Aspirante();
           AspiranteForm formRoom = new AspiranteForm(room);
            if (formRoom.ShowDialog() == DialogResult.OK)
            {
                Recruting.Aspirants.Add(room.AspiranteId, room);
                UpdateRoomsList();
            }
        }

        private void Â‰‡ÍÚËÓ‚‡Ú¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var room = listViewAspirante.SelectedItems[0].Tag as Aspirante;
            AspiranteForm formRoom = new AspiranteForm(room);
            if (formRoom.ShowDialog() == DialogResult.OK)
            {
                UpdateRoomsList();
            }
        }

        private void UpdateRoomsList()
        {
            listViewAspirante.Items.Clear();
            foreach (var item in Recruting.Aspirants)
            {
                var room = item.Value;
                var listViewItem = new ListViewItem
                {
                    Tag = room,
                    Text = room.ToString()
                };
                listViewAspirante.Items.Add(listViewItem);
            }
        }

        private void ‰Ó·‡‚ËÚ¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settlement = new Settlement();
           SettlementForm formSettlement = new SettlementForm(settlement);
            if (formSettlement.ShowDialog() == DialogResult.OK)
            {
               Recruting.Settlements.Add(settlement);
                UpdateSettlementList();
            }
        }
        private void editSettlementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void UpdateSettlementList()
        {
            listViewOffers.Items.Clear();
            foreach (var settlement in Recruting.Settlements)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = settlement,
                    Text = settlement.Aspirante.ToString()
                };
                
                listViewItem.SubItems.Add(settlement.Employer.ToString());
                
                listViewItem.SubItems.Add(settlement.post.ToString());
                listViewItem.SubItems.Add(settlement.Commission.ToString());
                listViewOffers.Items.Add(listViewItem);

                /*  listViewItem.SubItems.Add(settlement.StartDate.ToShortDateString());
                  listViewItem.SubItems.Add(settlement.EndDate.ToShortDateString());*/

            }
        }

        private void listViewOffers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewEmployer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ‡·ÓÚÓ‰‡ÚÂÎ¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Â‰‡ÍÚËÓ‚‡Ú¸ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var settlement = listViewOffers.SelectedItems[0].Tag as Settlement;
            SettlementForm formSettlement = new SettlementForm(settlement);
            if (formSettlement.ShowDialog() == DialogResult.OK)
            {
                UpdateSettlementList();
            }
        }
    }
}