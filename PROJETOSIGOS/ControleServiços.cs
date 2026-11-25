using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PROJETOSIGOS.Conexão;

namespace PROJETOSIGOS
{
    public partial class ControleServiços : Form
    {
        public ControleServiços()
        {
            InitializeComponent();
            CarregarServicos();
        }

        private void CarregarServicos()
        {
            ltbServicos.Items.Clear();

            try
            {
                Conexao conexao = new Conexao();

                using (MySqlConnection conn = conexao.Conectar())
                {
                    string sql = @"
                SELECT NM_SERVICO, PRECO_SERVICO
                FROM TBL_SERVICOS
                ORDER BY NM_SERVICO";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nome = reader["NM_SERVICO"].ToString();

                            decimal preco = Convert.ToDecimal(
                                reader["PRECO_SERVICO"]
                            );

                            ltbServicos.Items.Add(
                                $"{nome} - {preco:C2}"
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao carregar serviços: " + ex.Message
                );
            }
        }

        private void btnCriarServico_Click(object sender, EventArgs e)
        {
            CadastrandoServiço cadastServ = new CadastrandoServiço();
            cadastServ.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAtualizar_Click(object sender, EventArgs e)
        {
            CarregarServicos();
        }
    }
}
