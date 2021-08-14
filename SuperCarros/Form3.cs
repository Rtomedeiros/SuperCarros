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
    public partial class FormEditarCartas : Form
    {
        Image arquivoIMG;
        string arquivoIMG_nomefile;

        public FormEditarCartas()
        {
            InitializeComponent();
        }

        private void FormEditarCartas_Load(object sender, EventArgs e)
        {
            //Ao abrir a janela de Editar cartas o BD será atualizado e mostrado no DataGrid.
            dataGridViewEditarCartas.DataSource = getData();
        }

        private DataTable getData()
        {
            //Criando a função para Mostrar os dados do BD no DataGrid.
            DataTable dtTabelaEditCar = new DataTable();
            SqlConnection sqlConexao = new SqlConnection("Data Source=DESKTOP-BLNRK54\\SQLEXPRESS;Initial Catalog=bd_SuperCarros;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Carro", sqlConexao);
            SqlCommand cmd = new SqlCommand("SELECT id, marca, nome, velMax, potencia, motor, aceleracaoTempo, peso FROM Carro", sqlConexao);

            sqlConexao.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            dtTabelaEditCar.Load(reader);
            return dtTabelaEditCar;
        }

        private void dataGridViewEditarCartas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCriarCarta_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConexao = new SqlConnection("Data Source=DESKTOP-BLNRK54\\SQLEXPRESS;Initial Catalog=bd_SuperCarros;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO Carro (imagem, marca, nome, velMax, potencia, motor, aceleracaoTempo, peso) VALUES ('" + arquivoIMG_nomefile + "','"
                + textBoxEditMar.Text + "','" + textBoxEditNom.Text + "'," + textBoxEditVel.Text + "," + textBoxEditPot.Text + "," + textBoxEditMot.Text
                + "," + textBoxEditAce.Text + "," + textBoxEditPes.Text + ")", sqlConexao);
            //If se a pictureBox não estiver vazia, ou seja, com uma imagem, salvar os dados no BD.
            if (pictureBoxUpImg.Image != null)
                try
                {
                    sqlConexao.Open();
                    cmd.ExecuteNonQuery();
                    sqlConexao.Close();
                    dataGridViewEditarCartas.DataSource = getData(); //Atualizar a BD no DataGrid.
                    MessageBox.Show("Nova Carta criada!");
                }
                catch
                {
                    MessageBox.Show("Problema ao criar a carta!" +
                        "\nPreencha os campos corretamente:" +
                        "\nImagem, Marca, Nome, Vel. Máx., Pot., Motor, Acel. e Peso.");
                }
            else
            {
                MessageBox.Show("Imagem não selecionada!");
            }
        }

        private void buttonAbrirImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();

            f.Filter = "JPG(*.JPG)|*.jpg";

            if (f.ShowDialog() == DialogResult.OK)
            {
                arquivoIMG = Image.FromFile(f.FileName);
                pictureBoxUpImg.Image = arquivoIMG;
                arquivoIMG_nomefile = f.FileName; //Salvando o caminho da imagem.
            }
        }

        private void pictureBoxUpImg_Click(object sender, EventArgs e)
        {
            //Se clicar na imagem, limpa a picturebox.
            pictureBoxUpImg.Image = null;
        }

        private void buttonUpCarta_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConexao = new SqlConnection("Data Source=DESKTOP-BLNRK54\\SQLEXPRESS;Initial Catalog=bd_SuperCarros;Integrated Security=True");
            //If se a pictureBox não estiver nula, ou seja, com uma imagem, fazer o update do caminho da imagem no BD.
            if (pictureBoxUpImg.Image != null)
            {
                SqlCommand cmd1 = new SqlCommand("UPDATE Carro SET imagem = '" + arquivoIMG_nomefile + "' WHERE id =" + textBoxEditID.Text, sqlConexao);
                try
                {
                    sqlConexao.Open();
                    cmd1.ExecuteNonQuery();
                    sqlConexao.Close();
                    dataGridViewEditarCartas.DataSource = getData(); //Atualizar a BD no DataGrid.
                    MessageBox.Show("Imagem atualizada!");
                }
                catch
                {
                    MessageBox.Show("Problema ao atualizar a imagem!");
                }
            }

            //If se a textBoxEditMar não estiver vazia, fazer o update da Marca no BD.
            if (textBoxEditMar.Text != string.Empty)
            {
                SqlCommand cmd2 = new SqlCommand("UPDATE Carro SET marca = '" + textBoxEditMar.Text + "' WHERE id =" + textBoxEditID.Text, sqlConexao);
                try
                {
                    sqlConexao.Open();
                    cmd2.ExecuteNonQuery();
                    sqlConexao.Close();
                    dataGridViewEditarCartas.DataSource = getData(); //Atualizar a BD no DataGrid.
                    MessageBox.Show("Marca atualizada!");
                }
                catch
                {
                    MessageBox.Show("Problema ao atualizar a marca!");
                }
            }

            //If se a textBoxEditNom não estiver vazia, fazer o update do nome no BD.
            if (textBoxEditNom.Text != string.Empty)
            {
                SqlCommand cmd3 = new SqlCommand("UPDATE Carro SET nome = '" + textBoxEditNom.Text + "' WHERE id =" + textBoxEditID.Text, sqlConexao);
                try
                {
                    sqlConexao.Open();
                    cmd3.ExecuteNonQuery();
                    sqlConexao.Close();
                    dataGridViewEditarCartas.DataSource = getData(); //Atualizar a BD no DataGrid.
                    MessageBox.Show("Nome atualizado!");
                }
                catch
                {
                    MessageBox.Show("Problema ao atualizar o nome!");
                }
            }

            //If se a textBoxEditVel não estiver vazia, fazer o update da velocidade máx. no BD.
            if (textBoxEditVel.Text != string.Empty)
            {
                SqlCommand cmd4 = new SqlCommand("UPDATE Carro SET velMax = " + textBoxEditVel.Text + " WHERE id =" + textBoxEditID.Text, sqlConexao);
                try
                {
                    sqlConexao.Open();
                    cmd4.ExecuteNonQuery();
                    sqlConexao.Close();
                    dataGridViewEditarCartas.DataSource = getData(); //Atualizar a BD no DataGrid.
                    MessageBox.Show("Velocidade Máx. atualizada!");
                }
                catch
                {
                    MessageBox.Show("Problema ao atualizar a Velocidade Máx.!");
                }
            }

            //If se a textBoxEditPot não estiver vazia, fazer o update da potência no BD.
            if (textBoxEditPot.Text != string.Empty)
            {
                SqlCommand cmd5 = new SqlCommand("UPDATE Carro SET potencia = " + textBoxEditPot.Text + " WHERE id =" + textBoxEditID.Text, sqlConexao);
                try
                {
                    sqlConexao.Open();
                    cmd5.ExecuteNonQuery();
                    sqlConexao.Close();
                    dataGridViewEditarCartas.DataSource = getData(); //Atualizar a BD no DataGrid.
                    MessageBox.Show("Potência atualizada!");
                }
                catch
                {
                    MessageBox.Show("Problema ao atualizar a Potência!");
                }
            }

            //If se a textBoxEditMot não estiver vazia, fazer o update do motor no BD.
            if (textBoxEditMot.Text != string.Empty)
            {
                SqlCommand cmd6 = new SqlCommand("UPDATE Carro SET motor = " + textBoxEditMot.Text + " WHERE id =" + textBoxEditID.Text, sqlConexao);
                try
                {
                    sqlConexao.Open();
                    cmd6.ExecuteNonQuery();
                    sqlConexao.Close();
                    dataGridViewEditarCartas.DataSource = getData(); //Atualizar a BD no DataGrid.
                    MessageBox.Show("Motor atualizado!");
                }
                catch
                {
                    MessageBox.Show("Problema ao atualizar o Motor!");
                }
            }

            //If se a textBoxEditAce não estiver vazia, fazer o update da aceleração no BD.
            if (textBoxEditAce.Text != string.Empty)
            {
                SqlCommand cmd7 = new SqlCommand("UPDATE Carro SET aceleracaoTempo = " + textBoxEditAce.Text + " WHERE id =" + textBoxEditID.Text, sqlConexao);
                try
                {
                    sqlConexao.Open();
                    cmd7.ExecuteNonQuery();
                    sqlConexao.Close();
                    dataGridViewEditarCartas.DataSource = getData(); //Atualizar a BD no DataGrid.
                    MessageBox.Show("Aceleração atualizada!");
                }
                catch
                {
                    MessageBox.Show("Problema ao atualizar a Aceleração!");
                }
            }

            //If se a textBoxEditPes não estiver vazia, fazer o update do peso no BD.
            if (textBoxEditPes.Text != string.Empty)
            {
                SqlCommand cmd8 = new SqlCommand("UPDATE Carro SET peso = " + textBoxEditPes.Text + " WHERE id =" + textBoxEditID.Text, sqlConexao);
                try
                {
                    sqlConexao.Open();
                    cmd8.ExecuteNonQuery();
                    sqlConexao.Close();
                    dataGridViewEditarCartas.DataSource = getData(); //Atualizar a BD no DataGrid.
                    MessageBox.Show("Peso atualizado!");
                }
                catch
                {
                    MessageBox.Show("Problema ao atualizar o Peso!");
                }
            }
        }
    }
}
