using System;
using System.Windows.Forms;

namespace tcc
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastro cadastro = new frmCadastro();
            cadastro.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPacientes paciente = new frmPacientes();
            paciente.Show();
        }

        private void lampadaDeFendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLampada video = new frmLampada();
            video.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
