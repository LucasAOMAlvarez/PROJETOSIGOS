using MySql.Data.MySqlClient;
using PROJETOSIGOS.Conexão;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJETOSIGOS
{
    public partial class ConsultaOS : Form
    {
        public ConsultaOS()
        {
            InitializeComponent();
            ConfigurarGrid();
            CarregarOrdensServico();

            cbxStatus.Items.Clear();

            cbxStatus.Items.Add("Todas");
            cbxStatus.Items.Add("Aberta");
            cbxStatus.Items.Add("Em andamento");
            cbxStatus.Items.Add("Finalizado");
            cbxStatus.Items.Add("Cancelado");

            cbxStatus.SelectedIndex = 0;

            cbxStatus.SelectedIndexChanged += cbxStatus_SelectedIndexChanged;

            CarregarOrdensServico();
        }

        private void txtbPesquisa_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxStatus.SelectedItem != null)
            {
                string status = cbxStatus.SelectedItem.ToString();

                CarregarOrdensServico(status);
            }

            AplicarFiltros();
        }

        private void btnFecharOS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigurarGrid()
        {
            dgvOSGeren.AutoGenerateColumns = true;
            dgvOSGeren.ReadOnly = true;
            dgvOSGeren.AllowUserToAddRows = false;
            dgvOSGeren.AllowUserToDeleteRows = false;
            dgvOSGeren.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOSGeren.MultiSelect = false;
            dgvOSGeren.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CarregarOrdensServico(string status = "Todas")
        {
            try
            {
                Conexao conexao = new Conexao();

                using (MySqlConnection conn = conexao.Conectar())
                {
                    string sql = @"
                SELECT
                    OS.ID_OS AS 'Nº O.S.',
                    C.NM_CLIENTE AS 'Cliente',
                    E.MDL_EQUIP AS 'Equipamento',
                    OS.DT_ENTRADA AS 'Data de Entrada',
                    OS.VALOR_TOTAL AS 'Valor Total',
                    OS.STATUS_ATUAL AS 'Status'
                FROM TBL_ORDEM_SERVICOS OS
                INNER JOIN TBL_CLIENTES C
                    ON OS.FK_CLIENTE = C.CPF_CNPJ_CLIENTE
                LEFT JOIN TBL_EQUIPAMENTOS E
                    ON OS.FK_EQUIPAMENTO = E.COD_EQUIP
                WHERE (@status = 'Todas'
                    OR OS.STATUS_ATUAL = @status)
                ORDER BY OS.ID_OS DESC";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", status);

                        using (MySqlDataAdapter adapter =
                            new MySqlDataAdapter(cmd))
                        {
                            DataTable tabela = new DataTable();
                            adapter.Fill(tabela);
                            dgvOSGeren.DataSource = tabela;
                        }
                    }
                }

                dgvOSGeren.Columns["Valor Total"].DefaultCellStyle.Format = "C2";
                dgvOSGeren.Columns["Data de Entrada"].DefaultCellStyle.Format =
                    "dd/MM/yyyy HH:mm";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar Ordens de Serviço: " + ex.Message);
            }
        }

        private void AplicarFiltros()
        {
            string status = cbxStatus.SelectedItem?.ToString() ?? "Todas";
            string pesquisa = txtbPesquisa.Text.Trim();

            try
            {
                Conexao conexao = new Conexao();

                using (MySqlConnection conn = conexao.Conectar())
                {
                    string sql = @"
                SELECT
                    OS.ID_OS AS 'Nº O.S.',
                    C.NM_CLIENTE AS 'Cliente',
                    E.MDL_EQUIP AS 'Equipamento',
                    OS.DT_ENTRADA AS 'Data de Entrada',
                    OS.VALOR_TOTAL AS 'Valor Total',
                    OS.STATUS_ATUAL AS 'Status'
                FROM TBL_ORDEM_SERVICOS OS
                INNER JOIN TBL_CLIENTES C
                    ON OS.FK_CLIENTE = C.CPF_CNPJ_CLIENTE
                LEFT JOIN TBL_EQUIPAMENTOS E
                    ON OS.FK_EQUIPAMENTO = E.COD_EQUIP
                WHERE
                    (@status = 'Todas' OR OS.STATUS_ATUAL = @status)
                    AND (
                        CAST(OS.ID_OS AS CHAR) LIKE @pesquisa
                        OR C.NM_CLIENTE LIKE @pesquisa
                    )
                ORDER BY OS.ID_OS DESC";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable tabela = new DataTable();
                            adapter.Fill(tabela);

                            dgvOSGeren.DataSource = tabela;
                        }
                    }
                }

                dgvOSGeren.Columns["Valor Total"].DefaultCellStyle.Format = "C2";
                dgvOSGeren.Columns["Data de Entrada"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar O.S.: " + ex.Message);
            }
        }
    }
}
