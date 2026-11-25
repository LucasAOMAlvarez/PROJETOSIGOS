namespace PROJETOSIGOS
{
    partial class ConsultaOS
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
            lblCadastroDeCliente = new Label();
            dgvOSGeren = new DataGridView();
            btnFecharOS = new Button();
            cbxStatus = new ComboBox();
            txtbPesquisa = new TextBox();
            lblPesquisar = new Label();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOSGeren).BeginInit();
            SuspendLayout();
            // 
            // lblCadastroDeCliente
            // 
            lblCadastroDeCliente.AutoEllipsis = true;
            lblCadastroDeCliente.AutoSize = true;
            lblCadastroDeCliente.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCadastroDeCliente.ForeColor = SystemColors.ButtonFace;
            lblCadastroDeCliente.Location = new Point(293, 37);
            lblCadastroDeCliente.Margin = new Padding(0);
            lblCadastroDeCliente.Name = "lblCadastroDeCliente";
            lblCadastroDeCliente.RightToLeft = RightToLeft.No;
            lblCadastroDeCliente.Size = new Size(195, 25);
            lblCadastroDeCliente.TabIndex = 5;
            lblCadastroDeCliente.Text = "Ordens de Serviços";
            lblCadastroDeCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvOSGeren
            // 
            dgvOSGeren.BackgroundColor = SystemColors.GrayText;
            dgvOSGeren.BorderStyle = BorderStyle.None;
            dgvOSGeren.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOSGeren.GridColor = SystemColors.AppWorkspace;
            dgvOSGeren.Location = new Point(58, 151);
            dgvOSGeren.Name = "dgvOSGeren";
            dgvOSGeren.Size = new Size(681, 253);
            dgvOSGeren.TabIndex = 14;
            // 
            // btnFecharOS
            // 
            btnFecharOS.BackColor = Color.FromArgb(255, 77, 81);
            btnFecharOS.Cursor = Cursors.Hand;
            btnFecharOS.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
            btnFecharOS.FlatStyle = FlatStyle.Flat;
            btnFecharOS.Font = new Font("Leelawadee UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFecharOS.ForeColor = SystemColors.ButtonFace;
            btnFecharOS.ImageAlign = ContentAlignment.TopCenter;
            btnFecharOS.Location = new Point(740, 9);
            btnFecharOS.Margin = new Padding(0);
            btnFecharOS.Name = "btnFecharOS";
            btnFecharOS.Size = new Size(51, 24);
            btnFecharOS.TabIndex = 25;
            btnFecharOS.Text = "Fechar";
            btnFecharOS.UseVisualStyleBackColor = false;
            btnFecharOS.Click += btnFecharOS_Click;
            // 
            // cbxStatus
            // 
            cbxStatus.BackColor = SystemColors.WindowFrame;
            cbxStatus.Cursor = Cursors.Hand;
            cbxStatus.ForeColor = SystemColors.Window;
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Location = new Point(581, 117);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(158, 23);
            cbxStatus.TabIndex = 27;
            cbxStatus.SelectedIndexChanged += cbxStatus_SelectedIndexChanged;
            // 
            // txtbPesquisa
            // 
            txtbPesquisa.BackColor = SystemColors.WindowFrame;
            txtbPesquisa.BorderStyle = BorderStyle.None;
            txtbPesquisa.Cursor = Cursors.IBeam;
            txtbPesquisa.ForeColor = SystemColors.Window;
            txtbPesquisa.Location = new Point(58, 121);
            txtbPesquisa.MaxLength = 150;
            txtbPesquisa.Name = "txtbPesquisa";
            txtbPesquisa.Size = new Size(517, 16);
            txtbPesquisa.TabIndex = 28;
            txtbPesquisa.TextChanged += txtbPesquisa_TextChanged;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPesquisar.ForeColor = SystemColors.ButtonFace;
            lblPesquisar.Location = new Point(62, 98);
            lblPesquisar.Margin = new Padding(0);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.RightToLeft = RightToLeft.No;
            lblPesquisar.Size = new Size(65, 16);
            lblPesquisar.TabIndex = 29;
            lblPesquisar.Text = "Pesquisar";
            lblPesquisar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = SystemColors.ButtonFace;
            lblStatus.Location = new Point(584, 98);
            lblStatus.Margin = new Padding(0);
            lblStatus.Name = "lblStatus";
            lblStatus.RightToLeft = RightToLeft.No;
            lblStatus.Size = new Size(44, 16);
            lblStatus.TabIndex = 30;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ConsultaOS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(lblStatus);
            Controls.Add(lblPesquisar);
            Controls.Add(txtbPesquisa);
            Controls.Add(cbxStatus);
            Controls.Add(btnFecharOS);
            Controls.Add(dgvOSGeren);
            Controls.Add(lblCadastroDeCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConsultaOS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultaOS";
            ((System.ComponentModel.ISupportInitialize)dgvOSGeren).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadastroDeCliente;
        private DataGridView dgvOSGeren;
        private Button btnFecharOS;
        private ComboBox cbxStatus;
        private TextBox txtbPesquisa;
        private Label lblPesquisar;
        private Label lblStatus;
    }
}