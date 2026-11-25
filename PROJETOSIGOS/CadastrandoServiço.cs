using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PROJETOSIGOS.Conexão;
using System.Globalization;

namespace PROJETOSIGOS
{
    public partial class CadastrandoServiço : Form
    {
        public CadastrandoServiço()
        {
            InitializeComponent();
        }

        private void lblCadastrandoServ_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarServ_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddServ_Click(object sender, EventArgs e)
        {
            string nome = txtbNomeServ.Text.Trim();

            // Validar nome
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Informe o nome do serviço!");
                txtbNomeServ.Focus();
                return;
            }

            // Converter preço para decimal
            if (!decimal.TryParse(
                txtbPreco.Text,
                NumberStyles.Number,
                CultureInfo.GetCultureInfo("pt-BR"),
                out decimal preco))
            {
                MessageBox.Show("Informe um preço válido!");
                txtbPreco.Focus();
                return;
            }

            if (preco <= 0)
            {
                MessageBox.Show("O preço deve ser maior que zero!");
                txtbPreco.Focus();
                return;
            }

            try
            {
                Conexao conexao = new Conexao();

                using (MySqlConnection conn = conexao.Conectar())
                {
                    string sql = @"
                INSERT INTO TBL_SERVICOS
                (NM_SERVICO, PRECO_SERVICO)
                VALUES
                (@nome, @preco)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@preco", preco);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Serviço cadastrado com sucesso!");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao cadastrar serviço: " + ex.Message
                );
            }
        }
    }
}
