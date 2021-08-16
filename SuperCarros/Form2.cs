﻿using System;
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
        int[] idP1Sel = new int[3];  //vetor de inteiro para guardar os IDs das 3 cartas selecionadas pelo jogador;
        int[] idComSel = new int[3];  //vetor de inteiro para guardar os IDs das 3 cartas selecionadas pelo computador;
        int idmaxSel; //inteiro para guardar o maior valor de id.

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
            FormIntro frmIntro = new FormIntro();
            var rand = new Random(); //Instanciando o gerador de números aleatórios usando o valor fornecido pelo sistema como semente.
            bool idsCompDiferentes = false;

            SqlConnection sqlConexao = new SqlConnection("Data Source=DESKTOP-BLNRK54\\SQLEXPRESS;Initial Catalog=bd_SuperCarros;Integrated Security=True");
            //If se a textBoxC1 não estiver vazia, receber o dado do ID selecionado para a CARTA 1.
            if (textBoxC1.Text != string.Empty)
            {
                try
                {
                    sqlConexao.Open();
                    SqlCommand cmd1 = new SqlCommand("SELECT id, marca, nome, velMax, potencia, motor, aceleracaoTempo, peso FROM Carro WHERE id =" + textBoxC1.Text, sqlConexao);
                    //cmd.CommandType = CommandType.Text;
                    cmd1.ExecuteNonQuery();
                    //Usar o SqlDataReader para receber os dados da CARTA 1 selecionada.
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    dr1.Read();
                    //textBoxC2.Text = dr[0].ToString();
                    idP1Sel[0] = int.Parse(dr1[0].ToString());  //Atribuindo o dado de indice 0 (id) do comando Sql para um inteiro.
                    sqlConexao.Close();
                    //MessageBox.Show("idCARTA_1 = " + idP1[0]);
                }
                catch
                {
                    MessageBox.Show("Erro ao buscar o dado para a Carta 1!");
                }
            }

            //If se a textBoxC2 não estiver vazia, receber o dado do ID selecionado para a CARTA 2.
            if (textBoxC2.Text != string.Empty)
            {
                try
                {
                    sqlConexao.Open();
                    SqlCommand cmd2 = new SqlCommand("SELECT id, marca, nome, velMax, potencia, motor, aceleracaoTempo, peso FROM Carro WHERE id =" + textBoxC2.Text, sqlConexao);
                    //cmd.CommandType = CommandType.Text;
                    cmd2.ExecuteNonQuery();
                    //Usar o SqlDataReader para receber os dados da CARTA 2 selecionada.
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    dr2.Read();
                    //textBoxC2.Text = dr[0].ToString();
                    idP1Sel[1] = int.Parse(dr2[0].ToString());  //Atribuindo o dado de indice 0 (id) do comando Sql para um inteiro.
                    sqlConexao.Close();
                    //MessageBox.Show("idCARTA_2 = " + idP1[1]);
                }
                catch
                {
                    MessageBox.Show("Erro ao buscar o dado para a Carta 2!");
                }
            }

            //If se a textBoxC3 não estiver vazia, receber o dado do ID selecionado para a CARTA 3.
            if (textBoxC3.Text != string.Empty)
            {
                try
                {
                    sqlConexao.Open();
                    SqlCommand cmd3 = new SqlCommand("SELECT id, marca, nome, velMax, potencia, motor, aceleracaoTempo, peso FROM Carro WHERE id =" + textBoxC3.Text, sqlConexao);
                    //cmd.CommandType = CommandType.Text;
                    cmd3.ExecuteNonQuery();
                    //Usar o SqlDataReader para receber os dados da CARTA 3 selecionada.
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    dr3.Read();
                    //textBoxC2.Text = dr[0].ToString();
                    idP1Sel[2] = int.Parse(dr3[0].ToString());  //Atribuindo o dado de indice 0 (id) do comando Sql para um inteiro.
                    sqlConexao.Close();
                    //MessageBox.Show("idCARTA_3 = " + idP1[2]);
                }
                catch
                {
                    MessageBox.Show("Erro ao buscar o dado para a Carta 3!");
                }
            }

            try
            {
                sqlConexao.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(id) FROM Carro", sqlConexao);
                //cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                //Usar o SqlDataReader para receber os dados do MAIOR ID.
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                //textBoxC2.Text = dr[0].ToString();
                idmaxSel = int.Parse(dr[0].ToString());  //Atribuindo o dado de indice 0 (id) do comando Sql para um inteiro.
                sqlConexao.Close();
                //MessageBox.Show("idMaximo = " + idmax);
            }
            catch
            {
                MessageBox.Show("Erro ao buscar o valor máximo do id!");
            }

            //Se para verificar se os ids selecionados pelo jogador são diferentes entre si.
            if((idP1Sel[0] == idP1Sel[1]) || (idP1Sel[0] == idP1Sel[2]) || (idP1Sel[1] == idP1Sel[2]))
            {
                //Tem id igual.
                MessageBox.Show("Selecione Cartas diferentes!");
            }
            else
            {
                //São ids diferentes.
                //MessageBox.Show("São diferentes!");

                //While para rodar até escolher 3 ids de cartas para o computador diferentes entre sí e, diferentes do jogador.
                while(idsCompDiferentes == false)
                {
                    //for para rodar e atribuir os 3 ids randomicamente ao Computador.
                    for (int i = 0; i < 3; i++)
                    {
                        idComSel[i] = rand.Next(1, (idmaxSel+1)); //Atribuindo valores de id randomicamente para o Computador (Dentro dos ids disponíveis no BD).
                    }
                    //Se para verificar se os ids random selecionados para o computador são diferentes entre si.
                    if ((idComSel[0] != idComSel[1]) && (idComSel[0] != idComSel[2]) && (idComSel[1] != idComSel[2]))
                    {
                        //Os ids Selecionador para o Computador são diferentes entre sí.
                        
                        //Se para verificar se o idComSel[0] é diferente dos ids selecionados pelo Jogador.
                        if((idComSel[0] != idP1Sel[0]) && (idComSel[0] != idP1Sel[1]) && (idComSel[0] != idP1Sel[2]))
                        {
                            //Se para verificar se o idComSel[1] é diferente dos ids selecionados pelo Jogador.
                            if ((idComSel[1] != idP1Sel[0]) && (idComSel[1] != idP1Sel[1]) && (idComSel[1] != idP1Sel[2]))
                            {
                                //Se para verificar se o idComSel[2] é diferente dos ids selecionados pelo Jogador.
                                if ((idComSel[2] != idP1Sel[0]) && (idComSel[2] != idP1Sel[1]) && (idComSel[2] != idP1Sel[2]))
                                {
                                    idsCompDiferentes = true; //Condição para parar o while.
                                }
                            }
                        }
                    } 
                }

                /*MessageBox.Show("idP1Sel[0]: " + idP1Sel[0] + "   idComSel[0]: " + idComSel[0] +
                "\nidP1Sel[1]: " + idP1Sel[1] + "   idComSel[1]: " + idComSel[1] +
                "\nidP1Sel[2]: " + idP1Sel[2] + "   idComSel[2]: " + idComSel[2]);*/

                frmIntro.idSelNovoJogo(idP1Sel, idComSel); //Enviando o valor de idP1Sel para idP1 e idComSel para idCom, no FormIntro.

                frmIntro.ShowDialog();  //Abre uma nova tela de jogo.
                /*//frmIntro.Refresh(); //Atualizar a Tela principal.
                //this.Close(); //Fechar a tela de Seleção de cartas - Novo Jogo.
                //this.DialogResult = DialogResult.Cancel;*/
            }
        }
    }
}
