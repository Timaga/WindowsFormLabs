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
            _Employer= new Employer();
            Employers formClient = new Employers(_Employer);
            if (formClient.ShowDialog() == DialogResult.OK)
            {
                _Employer = formClient.Employer;
            }
        }

        private void Â‰‡ÍÚËÓ‚‡Ú¸ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Employers formClient = new Employers(_Employer);
            if (formClient.ShowDialog() == DialogResult.OK)
            {
                _Employer = formClient.Employer;
            }
        }

        private void ÒÓÁ‰‡Ú¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Aspirante = new Aspirante();
            AspiranteForm aspiranteForm = new AspiranteForm(_Aspirante);
            if (aspiranteForm.ShowDialog() == DialogResult.OK)
            {
                _Aspirante = aspiranteForm.Aspirante ;
            }
        }

        private void Â‰‡ÍÚËÓ‚‡Ú¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AspiranteForm aspiranteForm = new AspiranteForm(_Aspirante);
            if (aspiranteForm.ShowDialog() == DialogResult.OK)
            {
                _Aspirante = aspiranteForm.Aspirante;
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
            var settlement = listViewOffers.SelectedItems[0].Tag as Settlement;
            SettlementForm formSettlement = new SettlementForm(settlement);
            if (formSettlement.ShowDialog() == DialogResult.OK)
            {
                UpdateSettlementList();
            }
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
                listViewItem.SubItems.Add(settlement.Commission.ToString());
                listViewItem.SubItems.Add(settlement.Aspirante.ToString());
                listViewItem.SubItems.Add(settlement.Employer.ToString());
                listViewItem.SubItems.Add(settlement.StartDate.ToShortDateString());
                listViewItem.SubItems.Add(settlement.EndDate.ToShortDateString());
                listViewOffers.Items.Add(listViewItem);
            }
        }

        private void listViewOffers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}