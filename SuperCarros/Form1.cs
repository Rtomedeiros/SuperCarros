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
        int[] idP1 = new int[3];  //vetor de inteiro para guardar os IDs das 3 cartas selecionadas pelo jogador;
        //int[] idCom = new int[3];  //vetor de inteiro para guardar os IDs das 3 cartas selecionadas pelo computador;
        //int idmax; //inteiro para guardar o maior valor de id.
        bool NovoJogo = false;

        public FormIntro()
        {
            InitializeComponent();
        }

        private void FormIntro_Load(object sender, EventArgs e)
        {
            if((idP1[0] != 0) && (idP1[1] != 0) && (idP1[2] != 0))
            {
                //MessageBox.Show("Ids armazenados com sucesso!");
            }
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

        //Criando uma função pública para fazer o "recebimento" do valor de id selecionado no FormNovoJogo.
        public void idSelNovoJogo(int[] idP1Sel)
        {
            idP1[0] = idP1Sel[0];
            idP1[1] = idP1Sel[1];
            idP1[2] = idP1Sel[2];
        }

        /*//Criando uma função para realizar o jogo.
        private void NovoGame()
        {

        }*/

        private void buttonSelCarta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("idP1[0]: " + idP1[0] + "\nidP1[1]: " + idP1[1] + "\nidP1[2]: " + idP1[2]);
        }
    }
}
