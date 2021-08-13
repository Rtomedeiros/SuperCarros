using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperCarros
{
    public partial class FormIntro : Form
    {
        public FormIntro()
        {
            InitializeComponent();
        }

        private void FormIntro_Load(object sender, EventArgs e)
        {

        }

        private void novoJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovoJogo frmNovoJogo = new FormNovoJogo();
            frmNovoJogo.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void editarCartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditarCartas frmEditarCartas = new FormEditarCartas();
            frmEditarCartas.ShowDialog();
        }
    }
}
