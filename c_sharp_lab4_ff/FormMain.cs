using c_sharp_lab4;
namespace c_sharp_lab4_ff
{
    public partial class FormMain : Form
    {
        private readonly Recruting _recruting = Recruting.Instance;
        readonly AspiranteForm _formAspitante = new AspiranteForm();
        readonly Employers _formEmployers = new Employers();
        readonly SettlementForm _formSettlement = new SettlementForm();
        public FormMain()
        {
            InitializeComponent();
            _recruting.AspiranteAdded += _recruting_AsprianteAdded;
            _recruting.EmployerAdded += _recruting_EmployerAdded;
            _recruting.SettlementAdded += _recruting_SettlementAdded;
            _recruting.AspiranteRemoved += _recruting_AspiranteRemoved;
            _recruting.EmployerRemoved += _recruting_EmployerRemoved;
            _recruting.SettlementRemoved += _recruting_SettlementRemoved;
        }
        private void _recruting_SettlementRemoved(object sender, EventArgs e)
        {
            var settlement = sender as Settlement;
            for (int i = 0; i < listViewOffers.Items.Count; i++)
            {
                if ((Settlement)listViewOffers.Items[i].Tag == settlement)
                {
                    listViewOffers.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _recruting_EmployerRemoved(object sender, EventArgs e)
        {
            var EmployerNumber = (int)sender;
            for (int i = 0; i < listViewEmployer.Items.Count; i++)
            {
                if (((Employer)listViewEmployer.Items[i].Tag).EmployerId == EmployerNumber)
                {
                    listViewEmployer.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _recruting_AspiranteRemoved(object sender, EventArgs e)
        {
            var AspiranteId = (int)sender;
            for (int i = 0; i < listViewAspirante.Items.Count; i++)
            {
                if (((Aspirante)listViewAspirante.Items[i].Tag).AspiranteId == AspiranteId)
                {
                    listViewAspirante.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _recruting_SettlementAdded(object sender, EventArgs e)
        {
            var settlement = sender as Settlement;
            if (settlement != null)
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
            }
        }

        private void _recruting_AsprianteAdded(object sender, EventArgs e)
        {
            var client = sender as Aspirante;
            if (client != null)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = client,
                    Text = client.ToString()
                };
                listViewAspirante.Items.Add(listViewItem);
            }
        }
        private void _recruting_EmployerAdded(object sender, EventArgs e)
        {
            var employer = sender as Employer;
            if (employer != null)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = employer,
                    Text = employer.ToString()
                };
                listViewEmployer.Items.Add(listViewItem);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
       
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void ñîçäàòüToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var employer = new Employer();
            _formEmployers.Employer = employer;
            if (_formEmployers.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _recruting.AddEmployer(employer);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

        }

        private void ðåäàêòèðîâàòüToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var employer = listViewEmployer.SelectedItems[0].Tag as Employer;
                _formEmployers.Employer = employer;
                if (_formEmployers.ShowDialog() == DialogResult.OK)
                {
                    listViewEmployer.SelectedItems[0].Text = _formEmployers.Employer.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Íå âûáðàíà ñòðîêà ñ Ðàáîòîäàòåëåì");
            }
        }

        private void UpdateEmployerList()
        {
            listViewEmployer.Items.Clear();
            foreach (var item in Recruting._employersMap)
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

        private void ñîçäàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var aspirante = new Aspirante();
           _formAspitante.Aspirante = aspirante;
            if (_formAspitante.ShowDialog() == DialogResult.OK)
            {
                try
                {
                   _recruting.AddAspirante(aspirante);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void ðåäàêòèðîâàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var aspirante = listViewAspirante.SelectedItems[0].Tag as Aspirante;
                _formAspitante.Aspirante = aspirante;
                if (_formAspitante.ShowDialog() == DialogResult.OK)
                {
                    listViewAspirante.SelectedItems[0].Text = _formAspitante.Aspirante.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Íå âûáðàíà ñòðîêà ñ íîìåðîì");
            }
        }

        private void UpdateRoomsList()
        {
           /* listViewAspirante.Items.Clear();
            foreach (var item in Recruting.Aspirants)
            {
                var room = item.Value;
                var listViewItem = new ListViewItem
                {
                    Tag = room,
                    Text = room.ToString()
                };
                listViewAspirante.Items.Add(listViewItem);
            }*/
        }

        private void äîáàâèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settlement = new Settlement();
           _formSettlement.Settlement = settlement;
            if (_formSettlement.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _recruting.AddSettlement(settlement);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        private void editSettlementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
       

        private void listViewOffers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewEmployer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewEmployer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var client = listViewEmployer.SelectedItems[0].Tag as Employer;
                    if (client != null)
                    {
                        _recruting.RemoveEmployer(client.EmployerId);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Íå âûáðàíà ñòðîêà ñ Ðàáîòîäàòåëåì");
                }
            }
        }

        private void listViewAspirante_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var room = listViewAspirante.SelectedItems[0].Tag as Aspirante;
                    if (room != null)
                    {
                        _recruting.RemoveAspirante(room.AspiranteId);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Íå âûáðàíà ñòðîêà ñ Ñîèñêàòåëåì");
                }
            }

        }
        private void listViewSettlement_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var settlement = listViewOffers.SelectedItems[0].Tag as Settlement;
                    if (settlement != null)
                    {
                        _recruting.RemoveSettlement(settlement);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Íå âûáðàíà ñòðîêà ñî ñäåëêîé");
                }
            }
        }
            private void ðàáîòîäàòåëüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ðåäàêòèðîâàòüToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                var settlement = listViewOffers.SelectedItems[0].Tag as Settlement;
                _formSettlement.Settlement = settlement;
                if (_formSettlement.ShowDialog() == DialogResult.OK)
                {
                    settlement = _formSettlement.Settlement;
                    var listViewItem = listViewOffers.SelectedItems[0];
                    listViewItem.Text = settlement.Employer.ToString();
                    listViewItem.SubItems[1].Text = settlement.Aspirante.ToString();
                    listViewItem.SubItems[2].Text = settlement.post.ToString();
                    listViewItem.SubItems[3].Text = settlement.Commission.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Íå âûáðàíà ñòðîêà ñ ïîñåëåíèåì");
            }
        }
    }
}