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
        int[] idCom = new int[3];  //vetor de inteiro para guardar os IDs das 3 cartas selecionadas pelo computador;
        //int idmax; //inteiro para guardar o maior valor de id.
        //bool NovoJogo = false;
        
        //Declarando os demais dados do Jogador para recebe-los do BD e atribuí-los nas variáveis.
        string[] imgP1 = new string[3];
        string[] marcaP1 = new string[3];
        string[] nomeP1 = new string[3];
        int[] velMaxP1 = new int[3];
        int[] potP1 = new int[3];
        int[] motorP1 = new int[3];
        double[] aceP1 = new double[3];
        int[] pesoP1 = new int[3];

        //Declarando os demais dados do Computador para recebe-los do BD e atribuí-los nas variáveis.
        string[] imgCom = new string[3];
        string[] marcaCom = new string[3];
        string[] nomeCom = new string[3];
        int[] velMaxCom = new int[3];
        int[] potCom = new int[3];
        int[] motorCom = new int[3];
        double[] aceCom = new double[3];
        int[] pesoCom = new int[3];

        //Criar as imagens para atribuir o caminho e mostrar as imagens dos carros;
        Image arquivoIMGP1, arquivoIMGCom;

        public FormIntro()
        {
            InitializeComponent();
        }

        private void FormIntro_Load(object sender, EventArgs e)
        {
            //Condição para iniciar um novo jogo.
            //Se os ids selecionados do jogador são diferentes de 0, startar o jogo.
            if ((idP1[0] != 0) && (idP1[1] != 0) && (idP1[2] != 0))
            {
                //Os ids do jogador são válidos.
                //MessageBox.Show("Ids armazenados com sucesso!");

                mostrarCartasP1();  //Chamando a Função para mostrar as cartas do Jogador na Tela do Jogo (Dentro dela já atribui as cartas do jogador nas variáveis).
                atribuirCartasCom();  //Chamando a Função para atribuir as cartas do Computador nas variáveis.

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

        //Criando uma função pública para fazer o "recebimento" dos valores de IDs selecionados no FormNovoJogo.
        public void idSelNovoJogo(int[] idP1Sel, int[] idComSel)
        {
            idP1[0] = idP1Sel[0];
            idP1[1] = idP1Sel[1];
            idP1[2] = idP1Sel[2];
            idCom[0] = idComSel[0];
            idCom[1] = idComSel[1];
            idCom[2] = idComSel[2];
        }

        /*//Criando uma função para realizar o jogo.
        private void comecarNovoJogo()
        {

        }*/

        //Função para mostrar na tela do jogo as cartas do Jogador.
        private void mostrarCartasP1()
        {
            //Fazer a atribuição dos demais dados das cartas do Jogador, do BD para as variáveis.
            SqlConnection sqlConexao = new SqlConnection("Data Source=DESKTOP-BLNRK54\\SQLEXPRESS;Initial Catalog=bd_SuperCarros;Integrated Security=True");

            //Mostrar CARTA 1 do Jogador.
            try
            {
                sqlConexao.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT imagem, marca, nome, velMax, potencia, motor, aceleracaoTempo, peso FROM Carro WHERE id =" + idP1[0], sqlConexao);
                //cmd.CommandType = CommandType.Text;
                cmd1.ExecuteNonQuery();
                //Usar o SqlDataReader para receber os dados da CARTA 1 selecionada.
                SqlDataReader dr1 = cmd1.ExecuteReader();
                dr1.Read();
                imgP1[0] = dr1[0].ToString();  //Atribuindo o dado de indice 0 (imagem) do comando Sql para uma string.
                marcaP1[0] = dr1[1].ToString();  //Atribuindo o dado de indice 1 (marca) do comando Sql para uma string.
                nomeP1[0] = dr1[2].ToString();  //Atribuindo o dado de indice 2 (nome) do comando Sql para uma string.
                velMaxP1[0] = int.Parse(dr1[3].ToString());  //Atribuindo o dado de indice 3 (velMax) do comando Sql para um inteiro.
                potP1[0] = int.Parse(dr1[4].ToString());  //Atribuindo o dado de indice 4 (potencia) do comando Sql para um inteiro.
                motorP1[0] = int.Parse(dr1[5].ToString());  //Atribuindo o dado de indice 5 (motor) do comando Sql para um inteiro.
                aceP1[0] = double.Parse(dr1[6].ToString());  //Atribuindo o dado de indice 6 (aceleracao) do comando Sql para um double.
                pesoP1[0] = int.Parse(dr1[7].ToString()); //Atribuindo o dado de indice 7 (peso) do comando Sql para um inteiro.
                sqlConexao.Close();
                //Mostrar na tela os dados da Carta 1 selecionada do Jogador.
                textBoxC1Marca.Text = marcaP1[0];
                textBoxC1Nome.Text = nomeP1[0];
                textBoxC1Vel.Text = velMaxP1[0].ToString();
                textBoxC1Pot.Text = potP1[0].ToString();
                textBoxC1Mot.Text = motorP1[0].ToString();
                textBoxC1Ace.Text = aceP1[0].ToString();
                textBoxC1Pes.Text = pesoP1[0].ToString();
            }
            catch
            {
                MessageBox.Show("Não foi possível Mostrar a Carta 1 do Jogador!");
            }

            //Mostrar CARTA 2 do Jogador.
            try
            {
                sqlConexao.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT imagem, marca, nome, velMax, potencia, motor, aceleracaoTempo, peso FROM Carro WHERE id =" + idP1[1], sqlConexao);
                //cmd.CommandType = CommandType.Text;
                cmd2.ExecuteNonQuery();
                //Usar o SqlDataReader para receber os dados da CARTA 2 selecionada.
                SqlDataReader dr2 = cmd2.ExecuteReader();
                dr2.Read();
                imgP1[1] = dr2[0].ToString();  //Atribuindo o dado de indice 0 (imagem) do comando Sql para uma string.
                marcaP1[1] = dr2[1].ToString();  //Atribuindo o dado de indice 1 (marca) do comando Sql para uma string.
                nomeP1[1] = dr2[2].ToString();  //Atribuindo o dado de indice 2 (nome) do comando Sql para uma string.
                velMaxP1[1] = int.Parse(dr2[3].ToString());  //Atribuindo o dado de indice 3 (velMax) do comando Sql para um inteiro.
                potP1[1] = int.Parse(dr2[4].ToString());  //Atribuindo o dado de indice 4 (potencia) do comando Sql para um inteiro.
                motorP1[1] = int.Parse(dr2[5].ToString());  //Atribuindo o dado de indice 5 (motor) do comando Sql para um inteiro.
                aceP1[1] = double.Parse(dr2[6].ToString());  //Atribuindo o dado de indice 6 (aceleracao) do comando Sql para um double.
                pesoP1[1] = int.Parse(dr2[7].ToString()); //Atribuindo o dado de indice 7 (peso) do comando Sql para um inteiro.
                sqlConexao.Close();
                //Mostrar na tela os dados da Carta 2 selecionada do Jogador.
                textBoxC2Marca.Text = marcaP1[1];
                textBoxC2Nome.Text = nomeP1[1];
                textBoxC2Vel.Text = velMaxP1[1].ToString();
                textBoxC2Pot.Text = potP1[1].ToString();
                textBoxC2Mot.Text = motorP1[1].ToString();
                textBoxC2Ace.Text = aceP1[1].ToString();
                textBoxC2Pes.Text = pesoP1[1].ToString();
            }
            catch
            {
                MessageBox.Show("Não foi possível Mostrar a Carta 2 do Jogador!");
            }

            //Mostrar CARTA 3 do Jogador.
            try
            {
                sqlConexao.Open();
                SqlCommand cmd3 = new SqlCommand("SELECT imagem, marca, nome, velMax, potencia, motor, aceleracaoTempo, peso FROM Carro WHERE id =" + idP1[2], sqlConexao);
                //cmd.CommandType = CommandType.Text;
                cmd3.ExecuteNonQuery();
                //Usar o SqlDataReader para receber os dados da CARTA 3 selecionada.
                SqlDataReader dr3 = cmd3.ExecuteReader();
                dr3.Read();
                imgP1[2] = dr3[0].ToString();  //Atribuindo o dado de indice 0 (imagem) do comando Sql para uma string.
                marcaP1[2] = dr3[1].ToString();  //Atribuindo o dado de indice 1 (marca) do comando Sql para uma string.
                nomeP1[2] = dr3[2].ToString();  //Atribuindo o dado de indice 2 (nome) do comando Sql para uma string.
                velMaxP1[2] = int.Parse(dr3[3].ToString());  //Atribuindo o dado de indice 3 (velMax) do comando Sql para um inteiro.
                potP1[2] = int.Parse(dr3[4].ToString());  //Atribuindo o dado de indice 4 (potencia) do comando Sql para um inteiro.
                motorP1[2] = int.Parse(dr3[5].ToString());  //Atribuindo o dado de indice 5 (motor) do comando Sql para um inteiro.
                aceP1[2] = double.Parse(dr3[6].ToString());  //Atribuindo o dado de indice 6 (aceleracao) do comando Sql para um double.
                pesoP1[2] = int.Parse(dr3[7].ToString()); //Atribuindo o dado de indice 7 (peso) do comando Sql para um inteiro.
                sqlConexao.Close();
                //Mostrar na tela os dados da Carta 3 selecionada do Jogador.
                textBoxC3Marca.Text = marcaP1[2];
                textBoxC3Nome.Text = nomeP1[2];
                textBoxC3Vel.Text = velMaxP1[2].ToString();
                textBoxC3Pot.Text = potP1[2].ToString();
                textBoxC3Mot.Text = motorP1[2].ToString();
                textBoxC3Ace.Text = aceP1[2].ToString();
                textBoxC3Pes.Text = pesoP1[2].ToString();
            }
            catch
            {
                MessageBox.Show("Não foi possível Mostrar a Carta 3 do Jogador!");
            }
        }

        //Função para atribuir os dados das cartas do Computador nas variáveis dele.
        private void atribuirCartasCom()
        {
            //Fazer a atribuição dos demais dados das cartas do Computador, do BD para as variáveis.
            SqlConnection sqlConexao = new SqlConnection("Data Source=DESKTOP-BLNRK54\\SQLEXPRESS;Initial Catalog=bd_SuperCarros;Integrated Security=True");

            //Atribuir dados da CARTA 1 do Computador para as suas respectivas variáveis.
            try
            {
                sqlConexao.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT imagem, marca, nome, velMax, potencia, motor, aceleracaoTempo, peso FROM Carro WHERE id =" + idCom[0], sqlConexao);
                //cmd.CommandType = CommandType.Text;
                cmd1.ExecuteNonQuery();
                //Usar o SqlDataReader para receber os dados da CARTA 1 selecionada.
                SqlDataReader dr1 = cmd1.ExecuteReader();
                dr1.Read();
                imgCom[0] = dr1[0].ToString();  //Atribuindo o dado de indice 0 (imagem) do comando Sql para uma string.
                marcaCom[0] = dr1[1].ToString();  //Atribuindo o dado de indice 1 (marca) do comando Sql para uma string.
                nomeCom[0] = dr1[2].ToString();  //Atribuindo o dado de indice 2 (nome) do comando Sql para uma string.
                velMaxCom[0] = int.Parse(dr1[3].ToString());  //Atribuindo o dado de indice 3 (velMax) do comando Sql para um inteiro.
                potCom[0] = int.Parse(dr1[4].ToString());  //Atribuindo o dado de indice 4 (potencia) do comando Sql para um inteiro.
                motorCom[0] = int.Parse(dr1[5].ToString());  //Atribuindo o dado de indice 5 (motor) do comando Sql para um inteiro.
                aceCom[0] = double.Parse(dr1[6].ToString());  //Atribuindo o dado de indice 6 (aceleracao) do comando Sql para um double.
                pesoCom[0] = int.Parse(dr1[7].ToString()); //Atribuindo o dado de indice 7 (peso) do comando Sql para um inteiro.
                sqlConexao.Close();
            }
            catch
            {
                MessageBox.Show("Não foi possível atribuir os dados da Carta 1 do Computador!");
            }

            //Atribuir dados da CARTA 2 do Computador para as suas respectivas variáveis.
            try
            {
                sqlConexao.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT imagem, marca, nome, velMax, potencia, motor, aceleracaoTempo, peso FROM Carro WHERE id =" + idCom[1], sqlConexao);
                //cmd.CommandType = CommandType.Text;
                cmd2.ExecuteNonQuery();
                //Usar o SqlDataReader para receber os dados da CARTA 2 selecionada.
                SqlDataReader dr2 = cmd2.ExecuteReader();
                dr2.Read();
                imgCom[1] = dr2[0].ToString();  //Atribuindo o dado de indice 0 (imagem) do comando Sql para uma string.
                marcaCom[1] = dr2[1].ToString();  //Atribuindo o dado de indice 1 (marca) do comando Sql para uma string.
                nomeCom[1] = dr2[2].ToString();  //Atribuindo o dado de indice 2 (nome) do comando Sql para uma string.
                velMaxCom[1] = int.Parse(dr2[3].ToString());  //Atribuindo o dado de indice 3 (velMax) do comando Sql para um inteiro.
                potCom[1] = int.Parse(dr2[4].ToString());  //Atribuindo o dado de indice 4 (potencia) do comando Sql para um inteiro.
                motorCom[1] = int.Parse(dr2[5].ToString());  //Atribuindo o dado de indice 5 (motor) do comando Sql para um inteiro.
                aceCom[1] = double.Parse(dr2[6].ToString());  //Atribuindo o dado de indice 6 (aceleracao) do comando Sql para um double.
                pesoCom[1] = int.Parse(dr2[7].ToString()); //Atribuindo o dado de indice 7 (peso) do comando Sql para um inteiro.
                sqlConexao.Close();
            }
            catch
            {
                MessageBox.Show("Não foi possível atribuir os dados da Carta 2 do Computador!");
            }

            //Atribuir dados da CARTA 3 do Computador para as suas respectivas variáveis.
            try
            {
                sqlConexao.Open();
                SqlCommand cmd3 = new SqlCommand("SELECT imagem, marca, nome, velMax, potencia, motor, aceleracaoTempo, peso FROM Carro WHERE id =" + idCom[2], sqlConexao);
                //cmd.CommandType = CommandType.Text;
                cmd3.ExecuteNonQuery();
                //Usar o SqlDataReader para receber os dados da CARTA 3 selecionada.
                SqlDataReader dr3 = cmd3.ExecuteReader();
                dr3.Read();
                imgCom[2] = dr3[0].ToString();  //Atribuindo o dado de indice 0 (imagem) do comando Sql para uma string.
                marcaCom[2] = dr3[1].ToString();  //Atribuindo o dado de indice 1 (marca) do comando Sql para uma string.
                nomeCom[2] = dr3[2].ToString();  //Atribuindo o dado de indice 2 (nome) do comando Sql para uma string.
                velMaxCom[2] = int.Parse(dr3[3].ToString());  //Atribuindo o dado de indice 3 (velMax) do comando Sql para um inteiro.
                potCom[2] = int.Parse(dr3[4].ToString());  //Atribuindo o dado de indice 4 (potencia) do comando Sql para um inteiro.
                motorCom[2] = int.Parse(dr3[5].ToString());  //Atribuindo o dado de indice 5 (motor) do comando Sql para um inteiro.
                aceCom[2] = double.Parse(dr3[6].ToString());  //Atribuindo o dado de indice 6 (aceleracao) do comando Sql para um double.
                pesoCom[2] = int.Parse(dr3[7].ToString()); //Atribuindo o dado de indice 7 (peso) do comando Sql para um inteiro.
                sqlConexao.Close();
            }
            catch
            {
                MessageBox.Show("Não foi possível atribuir os dados da Carta 3 do Computador!");
            }
        }

        private void buttonSelCarta_Click(object sender, EventArgs e)
        {
            //MessageBox para visualizar os ids selecionados para o jogador e o computador.
            MessageBox.Show("Ids selecionados do Jogador e Computador:" +
                "\nCarta1_P1: " + idP1[0] + "   Carta1_Comp: " + idCom[0] +
                "\nCarta2_P1: " + idP1[1] + "   Carta2_Comp: " + idCom[1] + 
                "\nCarta3_P1: " + idP1[2] + "   Carta3_Comp: " + idCom[2]);

            //MessageBox para visualizar os caminhos das imagens das cartas do jogador e computador.
            //MessageBox.Show("imgP1[0]: "+ imgP1[0] + "\n\nimgP1[1]: " + imgP1[1] + "\n\nimgP1[2]: " + imgP1[2]);
            //MessageBox.Show("imgCom[0]: "+ imgCom[0] + "\n\nimgCom[1]: " + imgCom[1] + "\n\nimgCom[2]: " + imgCom[2]);

            //MessageBox para visualizar os dados das cartas do computador.
            /*MessageBox.Show("        idCom[0]: " + idCom[0] + "         idCom[1]: " + idCom[1] + "                  idCom[2]: " + idCom[2] +
                "\n marcaCom[0]: " + marcaCom[0] + "         marcaCom[1]: " + marcaCom[1] + "        marcaCom[2]: " + marcaCom[2] +
                "\n  nomeCom[0]: " + nomeCom[0] + "           nomeCom[1]: " + nomeCom[1] + "          nomeCom[2]: " + nomeCom[2] +
                "\nvelMaxCom[0]: " + velMaxCom[0] + "       velMaxCom[1]: " + velMaxCom[1] + "      velMaxCom[2]: " + velMaxCom[2] +
                "\n   potCom[0]: " + potCom[0] + "             potCom[1]: " + potCom[1] + "            potCom[2]: " + potCom[2] +
                "\n motorCom[0]: " + motorCom[0] + "         motorCom[1]: " + motorCom[1] + "        motorCom[2]: " + motorCom[2] +
                "\n   aceCom[0]: " + aceCom[0] + "             aceCom[1]: " + aceCom[1] + "            aceCom[2]: " + aceCom[2] +
                "\n  pesoCom[0]: " + pesoCom[0] + "           pesoCom[1]: " + pesoCom[1] + "          pesoCom[2]: " + pesoCom[2]);*/

        }

        private void radioButtonC1_CheckedChanged(object sender, EventArgs e)
        {
            //Se estiver marcada o radioButtonC1, mostrar os dados da Carta 1 no groupBox Principal do Jogador.

            //Se o imgP1[0] não estiver nulo, mostrar os dados da Carta 1.
            if (imgP1[0] != null)
            {
                arquivoIMGP1 = Image.FromFile(imgP1[0]);
                pictureBoxP1.Image = arquivoIMGP1;
                textBoxP1Marca.Text = marcaP1[0];
                textBoxP1Nome.Text = nomeP1[0];
                textBoxP1Vel.Text = velMaxP1[0].ToString();
                textBoxP1Pot.Text = potP1[0].ToString();
                textBoxP1Mot.Text = motorP1[0].ToString();
                textBoxP1Ace.Text = aceP1[0].ToString();
                textBoxP1Pes.Text = pesoP1[0].ToString();
            }
        }

        private void textBoxC1Marca_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonC2_CheckedChanged(object sender, EventArgs e)
        {
            //Se estiver marcada o radioButtonC2, mostrar os dados da Carta 2 no groupBox Principal do Jogador.

            //Se o imgP1[1] não estiver nulo, mostrar os dados da Carta 2.
            if (imgP1[1] != null)
            {
                arquivoIMGP1 = Image.FromFile(imgP1[1]);
                pictureBoxP1.Image = arquivoIMGP1;
                textBoxP1Marca.Text = marcaP1[1];
                textBoxP1Nome.Text = nomeP1[1];
                textBoxP1Vel.Text = velMaxP1[1].ToString();
                textBoxP1Pot.Text = potP1[1].ToString();
                textBoxP1Mot.Text = motorP1[1].ToString();
                textBoxP1Ace.Text = aceP1[1].ToString();
                textBoxP1Pes.Text = pesoP1[1].ToString();
            }
        }

        private void radioButtonC3_CheckedChanged(object sender, EventArgs e)
        {
            //Se estiver marcada o radioButtonC3, mostrar os dados da Carta 3 no groupBox Principal do Jogador.

            //Se o imgP1[2] não estiver nulo, mostrar os dados da Carta 3.
            if (imgP1[2] != null)
            {
                arquivoIMGP1 = Image.FromFile(imgP1[2]);
                pictureBoxP1.Image = arquivoIMGP1;
                textBoxP1Marca.Text = marcaP1[2];
                textBoxP1Nome.Text = nomeP1[2];
                textBoxP1Vel.Text = velMaxP1[2].ToString();
                textBoxP1Pot.Text = potP1[2].ToString();
                textBoxP1Mot.Text = motorP1[2].ToString();
                textBoxP1Ace.Text = aceP1[2].ToString();
                textBoxP1Pes.Text = pesoP1[2].ToString();
            }
        }

        private void textBoxP1Nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
