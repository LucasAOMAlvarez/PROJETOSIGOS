using MySql.Data.MySqlClient;
using PROJETOSIGOS.Conexão;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PROJETOSIGOS
{
    public partial class CriandoCliente : Form
    {
        public CriandoCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturar os dados
                string nome = txtbNome.Text.Trim();

                string cpf = Regex.Replace(txtbCpf.Text, @"\D", "");

                string telefone = Regex.Replace(txtbTell.Text, @"\D", "");

                // Validar nome
                if (string.IsNullOrWhiteSpace(nome))
                {
                    MessageBox.Show("Informe o nome do cliente!");
                    txtbNome.Focus();
                    return;
                }

                // Validar CPF ou CNPJ
                if (cpf.Length != 11 && cpf.Length != 14)
                {
                    MessageBox.Show("Informe um CPF ou CNPJ válido em quantidade de dígitos!");
                    txtbCpf.Focus();
                    return;
                }

                // Validar telefone
                if (telefone.Length != 10 && telefone.Length != 11)
                {
                    MessageBox.Show("Informe um telefone válido!");
                    txtbTell.Focus();
                    return;
                }

                Conexao conexao = new Conexao();

                using (MySqlConnection conn = conexao.Conectar())
                {
                    string sql = @"
                INSERT INTO TBL_CLIENTES
                (CPF_CNPJ_CLIENTE, NM_CLIENTE, FONE_CLIENTE)
                VALUES
                (@cpf, @nome, @telefone)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@cpf", cpf);
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@telefone", telefone);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Cliente cadastrado com sucesso!");

                this.Close();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Esse CPF/CNPJ já está cadastrado!");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar cliente: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
