namespace PROJETOSIGOS
{
    partial class CriandoOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCriandoOS = new Label();
            lblCliente = new Label();
            lblEquipamento = new Label();
            btnAddServicos = new Button();
            btnAddTecnicos = new Button();
            btnCriarOS = new Button();
            cbxServicos = new ComboBox();
            nmrUpServicos = new NumericUpDown();
            dgvServicos = new DataGridView();
            cbxCliente = new ComboBox();
            cbxEquipamento = new ComboBox();
            cbxTecnicos = new ComboBox();
            lblSevicos = new Label();
            dgvTecnicos = new DataGridView();
            lblTecnicos = new Label();
            btnRemoverServico = new Button();
            lblTotalDir = new Label();
            lblTotalEsq = new Label();
            btnRemoverTecnicos = new Button();
            btnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)nmrUpServicos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTecnicos).BeginInit();
            SuspendLayout();
            // 
            // lblCriandoOS
            // 
            lblCriandoOS.AutoEllipsis = true;
            lblCriandoOS.AutoSize = true;
            lblCriandoOS.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCriandoOS.ForeColor = SystemColors.ButtonFace;
            lblCriandoOS.Location = new Point(169, 24);
            lblCriandoOS.Margin = new Padding(0);
            lblCriandoOS.Name = "lblCriandoOS";
            lblCriandoOS.RightToLeft = RightToLeft.No;
            lblCriandoOS.Size = new Size(257, 25);
            lblCriandoOS.TabIndex = 2;
            lblCriandoOS.Text = "Criando Ordem de Serviço";
            lblCriandoOS.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = SystemColors.ButtonFace;
            lblCliente.Location = new Point(58, 74);
            lblCliente.Margin = new Padding(0);
            lblCliente.Name = "lblCliente";
            lblCliente.RightToLeft = RightToLeft.No;
            lblCliente.Size = new Size(50, 16);
            lblCliente.TabIndex = 3;
            lblCliente.Text = "Cliente:";
            lblCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEquipamento
            // 
            lblEquipamento.AutoSize = true;
            lblEquipamento.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEquipamento.ForeColor = SystemColors.ButtonFace;
            lblEquipamento.Location = new Point(58, 105);
            lblEquipamento.Margin = new Padding(0);
            lblEquipamento.Name = "lblEquipamento";
            lblEquipamento.RightToLeft = RightToLeft.No;
            lblEquipamento.Size = new Size(85, 16);
            lblEquipamento.TabIndex = 4;
            lblEquipamento.Text = "Equipamento:";
            lblEquipamento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddServicos
            // 
            btnAddServicos.BackColor = Color.FromArgb(105, 139, 239);
            btnAddServicos.Cursor = Cursors.Hand;
            btnAddServicos.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
            btnAddServicos.FlatStyle = FlatStyle.Flat;
            btnAddServicos.Font = new Font("Leelawadee UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddServicos.ForeColor = SystemColors.ButtonFace;
            btnAddServicos.ImageAlign = ContentAlignment.TopCenter;
            btnAddServicos.Location = new Point(58, 321);
            btnAddServicos.Margin = new Padding(0);
            btnAddServicos.Name = "btnAddServicos";
            btnAddServicos.Size = new Size(139, 23);
            btnAddServicos.TabIndex = 8;
            btnAddServicos.Text = "Adicionar Serviço";
            btnAddServicos.UseVisualStyleBackColor = false;
            btnAddServicos.Click += btnAddServicos_Click;
            // 
            // btnAddTecnicos
            // 
            btnAddTecnicos.BackColor = Color.FromArgb(105, 139, 239);
            btnAddTecnicos.Cursor = Cursors.Hand;
            btnAddTecnicos.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
            btnAddTecnicos.FlatStyle = FlatStyle.Flat;
            btnAddTecnicos.Font = new Font("Leelawadee UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTecnicos.ForeColor = SystemColors.ButtonFace;
            btnAddTecnicos.ImageAlign = ContentAlignment.TopCenter;
            btnAddTecnicos.Location = new Point(58, 476);
            btnAddTecnicos.Margin = new Padding(0);
            btnAddTecnicos.Name = "btnAddTecnicos";
            btnAddTecnicos.Size = new Size(139, 23);
            btnAddTecnicos.TabIndex = 9;
            btnAddTecnicos.Text = "Adicionar Técnico";
            btnAddTecnicos.UseVisualStyleBackColor = false;
            btnAddTecnicos.Click += btnAddTecnicos_Click;
            // 
            // btnCriarOS
            // 
            btnCriarOS.BackColor = Color.YellowGreen;
            btnCriarOS.Cursor = Cursors.Hand;
            btnCriarOS.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
            btnCriarOS.FlatStyle = FlatStyle.Flat;
            btnCriarOS.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriarOS.ForeColor = SystemColors.ButtonFace;
            btnCriarOS.ImageAlign = ContentAlignment.TopCenter;
            btnCriarOS.Location = new Point(58, 586);
            btnCriarOS.Margin = new Padding(0);
            btnCriarOS.Name = "btnCriarOS";
            btnCriarOS.Size = new Size(487, 28);
            btnCriarOS.TabIndex = 10;
            btnCriarOS.Text = "Criar O.S";
            btnCriarOS.UseVisualStyleBackColor = false;
            btnCriarOS.Click += btnCriarOS_Click;
            // 
            // cbxServicos
            // 
            cbxServicos.BackColor = SystemColors.WindowFrame;
            cbxServicos.ForeColor = SystemColors.Window;
            cbxServicos.FormattingEnabled = true;
            cbxServicos.Location = new Point(58, 292);
            cbxServicos.Name = "cbxServicos";
            cbxServicos.Size = new Size(419, 23);
            cbxServicos.TabIndex = 11;
            cbxServicos.SelectedIndexChanged += cbxServicos_SelectedIndexChanged;
            // 
            // nmrUpServicos
            // 
            nmrUpServicos.BackColor = SystemColors.WindowFrame;
            nmrUpServicos.ForeColor = SystemColors.Window;
            nmrUpServicos.Location = new Point(495, 293);
            nmrUpServicos.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmrUpServicos.Name = "nmrUpServicos";
            nmrUpServicos.Size = new Size(50, 23);
            nmrUpServicos.TabIndex = 12;
            nmrUpServicos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nmrUpServicos.ValueChanged += nmrUpServicos_ValueChanged;
            // 
            // dgvServicos
            // 
            dgvServicos.BackgroundColor = SystemColors.GrayText;
            dgvServicos.BorderStyle = BorderStyle.None;
            dgvServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicos.GridColor = SystemColors.AppWorkspace;
            dgvServicos.Location = new Point(58, 168);
            dgvServicos.Name = "dgvServicos";
            dgvServicos.Size = new Size(487, 118);
            dgvServicos.TabIndex = 13;
            dgvServicos.CellContentClick += dgvServicos_CellContentClick;
            // 
            // cbxCliente
            // 
            cbxCliente.BackColor = SystemColors.WindowFrame;
            cbxCliente.Cursor = Cursors.Hand;
            cbxCliente.ForeColor = SystemColors.Window;
            cbxCliente.FormattingEnabled = true;
            cbxCliente.Location = new Point(111, 72);
            cbxCliente.Name = "cbxCliente";
            cbxCliente.Size = new Size(434, 23);
            cbxCliente.TabIndex = 14;
            cbxCliente.SelectedIndexChanged += cbxCliente_SelectedIndexChanged;
            // 
            // cbxEquipamento
            // 
            cbxEquipamento.BackColor = SystemColors.WindowFrame;
            cbxEquipamento.ForeColor = SystemColors.Window;
            cbxEquipamento.FormattingEnabled = true;
            cbxEquipamento.Location = new Point(146, 103);
            cbxEquipamento.Name = "cbxEquipamento";
            cbxEquipamento.Size = new Size(399, 23);
            cbxEquipamento.TabIndex = 15;
            cbxEquipamento.SelectedIndexChanged += cbxEquipamento_SelectedIndexChanged;
            // 
            // cbxTecnicos
            // 
            cbxTecnicos.BackColor = SystemColors.WindowFrame;
            cbxTecnicos.ForeColor = SystemColors.Window;
            cbxTecnicos.FormattingEnabled = true;
            cbxTecnicos.Location = new Point(58, 447);
            cbxTecnicos.Name = "cbxTecnicos";
            cbxTecnicos.Size = new Size(487, 23);
            cbxTecnicos.TabIndex = 16;
            cbxTecnicos.SelectedIndexChanged += cbxTecnicos_SelectedIndexChanged;
            // 
            // lblSevicos
            // 
            lblSevicos.AutoSize = true;
            lblSevicos.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSevicos.ForeColor = SystemColors.ButtonFace;
            lblSevicos.Location = new Point(58, 149);
            lblSevicos.Margin = new Padding(0);
            lblSevicos.Name = "lblSevicos";
            lblSevicos.RightToLeft = RightToLeft.No;
            lblSevicos.Size = new Size(58, 16);
            lblSevicos.TabIndex = 17;
            lblSevicos.Text = "Serviços";
            lblSevicos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvTecnicos
            // 
            dgvTecnicos.BackgroundColor = SystemColors.WindowFrame;
            dgvTecnicos.BorderStyle = BorderStyle.None;
            dgvTecnicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTecnicos.GridColor = SystemColors.ControlDark;
            dgvTecnicos.Location = new Point(58, 387);
            dgvTecnicos.Name = "dgvTecnicos";
            dgvTecnicos.Size = new Size(487, 54);
            dgvTecnicos.TabIndex = 18;
            dgvTecnicos.CellContentClick += dgvTecnicos_CellContentClick;
            // 
            // lblTecnicos
            // 
            lblTecnicos.AutoSize = true;
            lblTecnicos.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTecnicos.ForeColor = SystemColors.ButtonFace;
            lblTecnicos.Location = new Point(58, 368);
            lblTecnicos.Margin = new Padding(0);
            lblTecnicos.Name = "lblTecnicos";
            lblTecnicos.RightToLeft = RightToLeft.No;
            lblTecnicos.Size = new Size(55, 16);
            lblTecnicos.TabIndex = 19;
            lblTecnicos.Text = "Técnicos";
            lblTecnicos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRemoverServico
            // 
            btnRemoverServico.BackColor = Color.FromArgb(255, 77, 81);
            btnRemoverServico.Cursor = Cursors.Hand;
            btnRemoverServico.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
            btnRemoverServico.FlatStyle = FlatStyle.Flat;
            btnRemoverServico.Font = new Font("Leelawadee UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoverServico.ForeColor = SystemColors.ButtonFace;
            btnRemoverServico.ImageAlign = ContentAlignment.TopCenter;
            btnRemoverServico.Location = new Point(406, 321);
            btnRemoverServico.Margin = new Padding(0);
            btnRemoverServico.Name = "btnRemoverServico";
            btnRemoverServico.Size = new Size(139, 23);
            btnRemoverServico.TabIndex = 20;
            btnRemoverServico.Text = "Remover Serviço";
            btnRemoverServico.UseVisualStyleBackColor = false;
            btnRemoverServico.Click += btnRemoverServico_Click;
            // 
            // lblTotalDir
            // 
            lblTotalDir.AutoSize = true;
            lblTotalDir.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDir.ForeColor = Color.YellowGreen;
            lblTotalDir.Location = new Point(467, 531);
            lblTotalDir.Name = "lblTotalDir";
            lblTotalDir.Size = new Size(78, 25);
            lblTotalDir.TabIndex = 21;
            lblTotalDir.Text = "R$ 0,00";
            // 
            // lblTotalEsq
            // 
            lblTotalEsq.AutoSize = true;
            lblTotalEsq.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalEsq.ForeColor = Color.YellowGreen;
            lblTotalEsq.Location = new Point(58, 531);
            lblTotalEsq.Name = "lblTotalEsq";
            lblTotalEsq.Size = new Size(58, 25);
            lblTotalEsq.TabIndex = 22;
            lblTotalEsq.Text = "Total:";
            // 
            // btnRemoverTecnicos
            // 
            btnRemoverTecnicos.BackColor = Color.FromArgb(255, 77, 81);
            btnRemoverTecnicos.Cursor = Cursors.Hand;
            btnRemoverTecnicos.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
            btnRemoverTecnicos.FlatStyle = FlatStyle.Flat;
            btnRemoverTecnicos.Font = new Font("Leelawadee UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoverTecnicos.ForeColor = SystemColors.ButtonFace;
            btnRemoverTecnicos.ImageAlign = ContentAlignment.TopCenter;
            btnRemoverTecnicos.Location = new Point(406, 476);
            btnRemoverTecnicos.Margin = new Padding(0);
            btnRemoverTecnicos.Name = "btnRemoverTecnicos";
            btnRemoverTecnicos.Size = new Size(139, 23);
            btnRemoverTecnicos.TabIndex = 23;
            btnRemoverTecnicos.Text = "Remover Técnico";
            btnRemoverTecnicos.UseVisualStyleBackColor = false;
            btnRemoverTecnicos.Click += btnRemoverTecnicos_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(255, 77, 81);
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Leelawadee UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = SystemColors.ButtonFace;
            btnFechar.ImageAlign = ContentAlignment.TopCenter;
            btnFechar.Location = new Point(544, 5);
            btnFechar.Margin = new Padding(0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(51, 24);
            btnFechar.TabIndex = 24;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // CriandoOS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(600, 650);
            ControlBox = false;
            Controls.Add(btnFechar);
            Controls.Add(btnRemoverTecnicos);
            Controls.Add(lblTotalEsq);
            Controls.Add(lblTotalDir);
            Controls.Add(btnRemoverServico);
            Controls.Add(lblTecnicos);
            Controls.Add(dgvTecnicos);
            Controls.Add(lblSevicos);
            Controls.Add(cbxTecnicos);
            Controls.Add(cbxEquipamento);
            Controls.Add(cbxCliente);
            Controls.Add(dgvServicos);
            Controls.Add(nmrUpServicos);
            Controls.Add(cbxServicos);
            Controls.Add(btnCriarOS);
            Controls.Add(btnAddTecnicos);
            Controls.Add(btnAddServicos);
            Controls.Add(lblEquipamento);
            Controls.Add(lblCliente);
            Controls.Add(lblCriandoOS);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "CriandoOS";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIGOS";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)nmrUpServicos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTecnicos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCriandoOS;
        private Label lblCliente;
        private Label lblEquipamento;
        private Button btnAddServicos;
        private Button btnAddTecnicos;
        private Button btnCriarOS;
        private ComboBox cbxServicos;
        private NumericUpDown nmrUpServicos;
        private DataGridView dgvServicos;
        private ComboBox cbxCliente;
        private ComboBox cbxEquipamento;
        private ComboBox cbxTecnicos;
        private Label lblSevicos;
        private DataGridView dgvTecnicos;
        private Label lblTecnicos;
        private Button btnRemoverServico;
        private Label lblTotalDir;
        private Label lblTotalEsq;
        private Button btnRemoverTecnicos;
        private Button btnFechar;
    }
}