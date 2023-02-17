using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3
{
    public partial class Form1 : Form
    {
        SqlConnection conexao = new SqlConnection("Data Source=OSA0625222W10-1;Initial Catalog=Ex3;Integrated Security=True");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        // Nova
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comando.Connection = conexao;
            CarregarLista();
        }

        private void LimparTxt()
        {
            txbNome.Clear();
            txbCPF.Clear();
            txbDataNascimento.Clear();
        }

        private void LimparLista()
        {
            lbNome.Items.Clear();
            lbDataNascimento.Items.Clear();
            lbCPF.Items.Clear();
        }
        private void CarregarLista()
        {
            conexao.Open();
            comando.CommandText = "select * from Cadastro";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lbNome.Items.Add(dr[0].ToString());
                    lbDataNascimento.Items.Add(dr[1].ToString());
                    lbCPF.Items.Add(dr[2].ToString());
                }
            }
            conexao.Close();
        }

        private void Alinhar(object sender)
        {
            ListBox l = sender as ListBox;

            //Se algum dado na listbox estiver selecionado:
            if (l.SelectedIndex != -1)
            {
                lbNome.SelectedIndex = l.SelectedIndex; // Todas as listbox recebem a seleção equivalente.
                lbDataNascimento.SelectedIndex = l.SelectedIndex;
                lbCPF.SelectedIndex = l.SelectedIndex;

                txbNome.Text = lbNome.SelectedItem.ToString(); //Os textboxs recebem o valor selecionado.
                txbDataNascimento.Text = lbDataNascimento.SelectedItem.ToString();
                txbCPF.Text = lbCPF.SelectedItem.ToString();
            }
        }

        private void lbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alinhar(sender);
        }

        private void lbDataNascimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alinhar(sender);
        }

        private void lbCPF_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alinhar(sender);
        }

        private void lbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alinhar(sender);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            conexao.Open();
            comando.CommandText = "insert into Cadastro(Nome, DataNascimento, CPF) values ('" + txbNome.Text + "','" + txbDataNascimento.Text + "','" + txbCPF.Text + "')";
            comando.ExecuteNonQuery();
            conexao.Close();
            //Teste
            LimparLista();
            CarregarLista();
            LimparTxt();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            conexao.Open();
            comando.CommandText = "delete from Cadastro where nome = '" + txbNome.Text + "'";
            comando.ExecuteNonQuery();
            conexao.Close();

            LimparLista();
            CarregarLista();
            LimparTxt();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            conexao.Open();
            comando.CommandText = "update Cadastro set nome = '" + txbNome.Text + "',DataNascimento = '" + txbDataNascimento.Text + "', CPF = '" + txbCPF.Text + "' where nome = '" + lbNome.SelectedItem.ToString() + "'";

            comando.ExecuteNonQuery();
            conexao.Close();
            LimparLista();
            CarregarLista();
            LimparTxt();

            txbNome.Focus();
        }
    }
}
