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

        private void ñîçäàòüToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _Employer= new Employer();
            Employers formClient = new Employers(_Employer);
            if (formClient.ShowDialog() == DialogResult.OK)
            {
                _Employer = formClient.Employer;
            }
        }

        private void ğåäàêòèğîâàòüToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Employers formClient = new Employers(_Employer);
            if (formClient.ShowDialog() == DialogResult.OK)
            {
                _Employer = formClient.Employer;
            }
        }

        private void ñîçäàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Aspirante = new Aspirante();
            AspiranteForm aspiranteForm = new AspiranteForm(_Aspirante);
            if (aspiranteForm.ShowDialog() == DialogResult.OK)
            {
                _Aspirante = aspiranteForm.Aspirante ;
            }
        }

        private void ğåäàêòèğîâàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AspiranteForm aspiranteForm = new AspiranteForm(_Aspirante);
            if (aspiranteForm.ShowDialog() == DialogResult.OK)
            {
                _Aspirante = aspiranteForm.Aspirante;
            }
        }
    }
}