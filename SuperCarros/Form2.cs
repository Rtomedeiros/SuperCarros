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
    public partial class FormNovoJogo : Form
    {
        int[] idP1 = new int[3];
        int[] idCom = new int[3];
        int idmax;

        public FormNovoJogo()
        {
            InitializeComponent();
        }

        private void FormNovoJogo_Load(object sender, EventArgs e)
        {
            //Ao abrir a janela de Novo Jogo o BD será atualizado e mostrado no DataGrid.
            dataGridViewNovoJogo.DataSource = getData();
        }
        private DataTable getData()
        {
            //Criando a função para Mostrar os dados do BD no DataGrid.
            DataTable dtTabelaNJ = new DataTable();
            SqlConnection sqlConexao = new SqlConnection("Data Source=DESKTOP-BLNRK54\\SQLEXPRESS;Initial Catalog=bd_SuperCarros;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Carro", sqlConexao);
            SqlCommand cmd = new SqlCommand("SELECT id, marca, nome, velMax, potencia, motor, aceleracaoTempo, peso FROM Carro", sqlConexao);

            sqlConexao.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            dtTabelaNJ.Load(reader);
            return dtTabelaNJ;
        }

        private void buttonSelCarNJ_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConexao = new SqlConnection("Data Source=DESKTOP-BLNRK54\\SQLEXPRESS;Initial Catalog=bd_SuperCarros;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand("SELECT MAX(id) FROM Carro", sqlConexao);
            try
            {
                sqlConexao.Open();
                SqlCommand cmd = new SqlCommand("SELECT id, imagem, marca, nome, velMax, potencia, motor, aceleracaoTempo, peso FROM Carro WHERE id = ?", sqlConexao);
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = textBoxC1.Text;
                cmd.CommandType = CommandType.Text;
                //Usar o SqlDataReader para receber os dados da carta 1 selecionada.
                SqlDataReader dtreader;
                dtreader = cmd.ExecuteReader();
                //Insere as informações recebidas do banco para os componentes do form.
                dtreader.Read();
                textBoxC3.Text = dtreader.GetString(0);

                sqlConexao.Close();
            }
            catch
            {
                //MessageBox.Show("Erro ao buscar o valor máximo do id!");
                MessageBox.Show("Erro ao buscar o dado!");
            }

            //this.Close(); //Fechar a tela de Seleção de cartas - Novo Jogo.
        }
    }
}
