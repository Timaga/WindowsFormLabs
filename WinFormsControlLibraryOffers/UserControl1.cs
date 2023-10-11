using c_sharp_lab4;

namespace WinFormsControlLibraryOffers
{
    public partial class UserControl1 : UserControl
    {

        private readonly Recruting _recruting = Recruting.Instance;
        public Settlement Settlement { get; }

        private bool _selected;

        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                if (value)
                {
                    var controls = Parent?.Controls;
                    if (controls != null)
                    {
                        foreach (var control in controls)
                        {
                            if (!(control is UserControl1)) continue;
                            var userControlSettlement = control as UserControl1;
                            if (userControlSettlement != this)
                            {
                                userControlSettlement.Selected = false;
                            }
                        }
                    }
                }
                _selected = value;
                Refresh();
            }
        }


        public UserControl1(Settlement  settlement)
        {
            InitializeComponent();
            Settlement = settlement;
        }


        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
           AspiranteTextBox.Text = $@"{Settlement.Aspirante.SecondName} {Settlement.Aspirante.FirstName[0]}.{Settlement.Aspirante.LastName[0]}.";
           textBoxEmployer.Text = $@"{Settlement.Employer.Name}";
            TextBoxComission.Text = $@"{Settlement.Commission}";
            textBoxPost.Text = $@"{Settlement.post}";
            if (Settlement.Commission > 10000)
            {
                TextBoxComission.BackColor = Color.Green;
            }
            else
            {
                TextBoxComission.BackColor = Settlement.Commission < 10000 ? Color.Yellow : Color.Red;
            }
            BackColor = _selected ? Color.CornflowerBlue : DefaultBackColor;

        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
            Selected = true;
        }



        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmployer_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _recruting.RemoveSettlement(Settlement);
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана запись о сделке");
            }
        }
    }
}