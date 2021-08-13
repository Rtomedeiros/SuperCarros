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
    }
}
