using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PROJETOSIGOS.Conexão;
using System.Data;

namespace PROJETOSIGOS
{
    public partial class CriandoOS : Form
    {
        public CriandoOS()
        {
            InitializeComponent();

            CarregarClientes();
            CarregarEquipamentos();
            CarregarServicos();
            ConfigurarGridServicos();
            CarregarTecnicos();
            ConfigurarGridTecnicos();
        }


        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxEquipamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvServicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxServicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nmrUpServicos_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddServicos_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxServicos.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um serviço!");
                    return;
                }

                DataRowView servico =
                    (DataRowView)cbxServicos.SelectedItem;

                int codigo = Convert.ToInt32(
                    servico["COD_SERVICO"]);

                string nome = servico["NM_SERVICO"].ToString();

                decimal preco = Convert.ToDecimal(
                    servico["PRECO_SERVICO"]);

                int quantidade = Convert.ToInt32(
                    nmrUpServicos.Value);

                DataRow existente = null;

                foreach (DataRow linha in tabelaServicosOS.Rows)
                {
                    if (Convert.ToInt32(linha["COD_SERVICO"]) == codigo)
                    {
                        existente = linha;
                        break;
                    }
                }

                if (existente != null)
                {
                    int novaQuantidade =
                        Convert.ToInt32(existente["QUANTIDADE"])
                        + quantidade;

                    existente["QUANTIDADE"] = novaQuantidade;

                    existente["SUBTOTAL"] = novaQuantidade * preco;
                }
                else
                {
                    tabelaServicosOS.Rows.Add(
                        codigo,
                        nome,
                        quantidade,
                        preco,
                        quantidade * preco
                    );
                }

                MessageBox.Show("Serviço adicionado com sucesso!");

                nmrUpServicos.Value = 1;

                AtualizarTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao adicionar serviço: " + ex.Message);
            }
        }

        private void btnRemoverServico_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvServicos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um serviço para remover!");
                    return;
                }

                int indice = dgvServicos.SelectedRows[0].Index;

                tabelaServicosOS.Rows.RemoveAt(indice);

                AtualizarTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover serviço: " + ex.Message);
            }
        }

        private void dgvTecnicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxTecnicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddTecnicos_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxTecnicos.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um técnico!");
                    return;
                }

                int codigo = Convert.ToInt32(cbxTecnicos.SelectedValue);
                string nome = cbxTecnicos.Text;

                foreach (DataRow linha in tabelaTecnicosOS.Rows)
                {
                    if (Convert.ToInt32(linha["ID_TECNICO"]) == codigo)
                    {
                        MessageBox.Show("Esse técnico já foi adicionado!");
                        return;
                    }
                }

                tabelaTecnicosOS.Rows.Add(codigo, nome);

                cbxTecnicos.SelectedIndex = -1;

                MessageBox.Show("Técnico adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar técnico: " + ex.Message);
            }
        }

        private void btnRemoverTecnicos_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTecnicos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um técnico para remover!");
                    return;
                }

                int indice = dgvTecnicos.SelectedRows[0].Index;

                tabelaTecnicosOS.Rows.RemoveAt(indice);

                MessageBox.Show("Técnico removido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover técnico: " + ex.Message);
            }
        }

        private void btnCriarOS_Click(object sender, EventArgs e)
        {
            // 1. Validações
            if (cbxCliente.SelectedItem == null)
            {
                MessageBox.Show("Selecione um cliente!");
                return;
            }

            if (cbxEquipamento.SelectedItem == null)
            {
                MessageBox.Show("Selecione um equipamento!");
                return;
            }

            if (tabelaServicosOS.Rows.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos um serviço!");
                return;
            }

            if (tabelaTecnicosOS.Rows.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos um técnico!");
                return;
            }

            try
            {
                // 2. Calcular o total diretamente da tabela
                decimal valorTotal = 0;

                foreach (DataRow linha in tabelaServicosOS.Rows)
                {
                    valorTotal += Convert.ToDecimal(linha["SUBTOTAL"]);
                }

                Conexao conexao = new Conexao();

                using (MySqlConnection conn = conexao.Conectar())
                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        // 3. Inserir a Ordem de Serviço
                        string sqlOS = @"
                    INSERT INTO TBL_ORDEM_SERVICOS
                    (DESC_OS, DT_ENTRADA, STATUS_ATUAL,
                     FK_CLIENTE, FK_EQUIPAMENTO, VALOR_TOTAL)
                    VALUES
                    (@descricao, @data, @status,
                     @cliente, @equipamento, @total)";

                        using (MySqlCommand cmd = new MySqlCommand(sqlOS, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@descricao", "Ordem de Serviço");
                            cmd.Parameters.AddWithValue("@data", DateTime.Now);
                            cmd.Parameters.AddWithValue("@status", "Aberta");
                            cmd.Parameters.AddWithValue("@cliente", cbxCliente.SelectedValue);
                            cmd.Parameters.AddWithValue("@equipamento", cbxEquipamento.SelectedValue);
                            cmd.Parameters.AddWithValue("@total", valorTotal);

                            cmd.ExecuteNonQuery();
                        }

                        // 4. Recuperar o ID da O.S.
                        int idOS;

                        using (MySqlCommand cmdID = new MySqlCommand(
                            "SELECT LAST_INSERT_ID()", conn, trans))
                        {
                            idOS = Convert.ToInt32(cmdID.ExecuteScalar());
                        }

                        // 5. Salvar os serviços
                        string sqlServicos = @"
                    INSERT INTO TBL_OS_SERVICOS
                    (FK_OS, FK_SERVICOS, QTND_SERVICOS, PRECO_UNITARIO)
                    VALUES
                    (@os, @servico, @quantidade, @preco)";

                        foreach (DataRow linha in tabelaServicosOS.Rows)
                        {
                            using (MySqlCommand cmd = new MySqlCommand(sqlServicos, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@os", idOS);
                                cmd.Parameters.AddWithValue("@servico", linha["COD_SERVICO"]);
                                cmd.Parameters.AddWithValue("@quantidade", linha["QUANTIDADE"]);
                                cmd.Parameters.AddWithValue("@preco", linha["PRECO_UNITARIO"]);

                                cmd.ExecuteNonQuery();
                            }
                        }

                        // 6. Salvar os técnicos
                        string sqlTecnicos = @"
                    INSERT INTO tbl_tecnicos_os
                    (FK_TECNICO, FK_OS)
                    VALUES
                    (@tecnico, @os)";

                        foreach (DataRow linha in tabelaTecnicosOS.Rows)
                        {
                            using (MySqlCommand cmd = new MySqlCommand(sqlTecnicos, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@tecnico", linha["ID_TECNICO"]);
                                cmd.Parameters.AddWithValue("@os", idOS);

                                cmd.ExecuteNonQuery();
                            }
                        }

                        // 7. Confirmar a transação
                        trans.Commit();

                        MessageBox.Show(
                            "Ordem de Serviço criada com sucesso!\nNúmero: " + idOS,
                            "Sucesso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao criar Ordem de Serviço:\n" + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void CarregarClientes()
        {
            try
            {
                Conexao conexao = new Conexao();

                using (MySqlConnection conn = conexao.Conectar())
                {
                    string sql = @"SELECT CPF_CNPJ_CLIENTE, NM_CLIENTE
                           FROM TBL_CLIENTES
                           ORDER BY NM_CLIENTE";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn))
                    {
                        DataTable tabela = new DataTable();

                        adapter.Fill(tabela);

                        cbxCliente.DataSource = tabela;
                        cbxCliente.DisplayMember = "NM_CLIENTE";
                        cbxCliente.ValueMember = "CPF_CNPJ_CLIENTE";

                        cbxCliente.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao carregar clientes: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void CarregarEquipamentos()
        {
            try
            {
                Conexao conexao = new Conexao();

                using (MySqlConnection conn = conexao.Conectar())
                {
                    string sql = @"SELECT COD_EQUIP, MDL_EQUIP, MARCA_EQUIP
                           FROM TBL_EQUIPAMENTOS
                           ORDER BY COD_EQUIP";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn))
                    {
                        DataTable tabela = new DataTable();

                        adapter.Fill(tabela);

                        cbxEquipamento.DataSource = tabela;
                        cbxEquipamento.DisplayMember = "MDL_EQUIP";
                        cbxEquipamento.ValueMember = "COD_EQUIP";

                        cbxEquipamento.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar equipamentos: " + ex.Message);
            }

        }

        private void CarregarServicos()
        {
            try
            {
                Conexao conexao = new Conexao();

                using (MySqlConnection conn = conexao.Conectar())
                {
                    string sql = @"SELECT COD_SERVICO, NM_SERVICO, PRECO_SERVICO
                           FROM TBL_SERVICOS
                           ORDER BY NM_SERVICO";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn))
                    {
                        DataTable tabela = new DataTable();

                        adapter.Fill(tabela);

                        cbxServicos.DataSource = tabela;
                        cbxServicos.DisplayMember = "NM_SERVICO";
                        cbxServicos.ValueMember = "COD_SERVICO";

                        cbxServicos.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar serviços: " + ex.Message);
            }
        }

        private void ConfigurarGridServicos()
        {
            tabelaServicosOS = new DataTable();

            tabelaServicosOS.Columns.Add("COD_SERVICO", typeof(int));
            tabelaServicosOS.Columns.Add("SERVICO", typeof(string));
            tabelaServicosOS.Columns.Add("QUANTIDADE", typeof(int));
            tabelaServicosOS.Columns.Add("PRECO_UNITARIO", typeof(decimal));
            tabelaServicosOS.Columns.Add("SUBTOTAL", typeof(decimal));

            dgvServicos.DataSource = tabelaServicosOS;

            dgvServicos.Columns["COD_SERVICO"].Visible = false;

            dgvServicos.Columns["SERVICO"].HeaderText = "Serviço";
            dgvServicos.Columns["QUANTIDADE"].HeaderText = "Quantidade";
            dgvServicos.Columns["PRECO_UNITARIO"].HeaderText = "Preço Unitário";
            dgvServicos.Columns["SUBTOTAL"].HeaderText = "Subtotal";

            dgvServicos.Columns["PRECO_UNITARIO"].DefaultCellStyle.Format = "C2";
            dgvServicos.Columns["SUBTOTAL"].DefaultCellStyle.Format = "C2";

            dgvServicos.AllowUserToAddRows = false;
            dgvServicos.ReadOnly = true;
            dgvServicos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void AtualizarTotal()
        {
            decimal total = 0;

            foreach (DataRow linha in tabelaServicosOS.Rows)
            {
                total += Convert.ToDecimal(linha["SUBTOTAL"]);
            }

            lblTotalDir.Text = total.ToString("C2");
        }

        private void CarregarTecnicos()
        {
            try
            {
                Conexao conexao = new Conexao();

                using (MySqlConnection conn = conexao.Conectar())
                {
                    string sql = @"
                SELECT ID_TECNICO, NM_TECNICO
                FROM TBL_TECNICOS
                ORDER BY NM_TECNICO";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    cbxTecnicos.DataSource = tabela;
                    cbxTecnicos.DisplayMember = "NM_TECNICO";
                    cbxTecnicos.ValueMember = "ID_TECNICO";
                    cbxTecnicos.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar técnicos: " + ex.Message);
            }
        }

        private void ConfigurarGridTecnicos()
        {
            tabelaTecnicosOS = new DataTable();

            tabelaTecnicosOS.Columns.Add("ID_TECNICO", typeof(int));
            tabelaTecnicosOS.Columns.Add("TECNICO", typeof(string));

            dgvTecnicos.DataSource = tabelaTecnicosOS;

            dgvTecnicos.Columns["ID_TECNICO"].Visible = false;
            dgvTecnicos.Columns["TECNICO"].HeaderText = "Técnico responsável";

            dgvTecnicos.AllowUserToAddRows = false;
            dgvTecnicos.ReadOnly = true;
            dgvTecnicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTecnicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private DataTable tabelaServicosOS;
        private DataTable tabelaTecnicosOS;

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}