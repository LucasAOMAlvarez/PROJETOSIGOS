namespace PROJETOSIGOS
{
    partial class CriandoCliente
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
            lblNome = new Label();
            txtbNome = new TextBox();
            lblCPF = new Label();
            lblTelCell = new Label();
            txtbTell = new TextBox();
            btnRegistrarCliente = new Button();
            btnCancelar = new Button();
            txtbCpf = new TextBox();
            SuspendLayout();
            // 
            // lblCadastroDeCliente
            // 
            lblCadastroDeCliente.AutoEllipsis = true;
            lblCadastroDeCliente.AutoSize = true;
            lblCadastroDeCliente.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCadastroDeCliente.ForeColor = SystemColors.ButtonFace;
            lblCadastroDeCliente.Location = new Point(188, 39);
            lblCadastroDeCliente.Margin = new Padding(0);
            lblCadastroDeCliente.Name = "lblCadastroDeCliente";
            lblCadastroDeCliente.RightToLeft = RightToLeft.No;
            lblCadastroDeCliente.Size = new Size(195, 25);
            lblCadastroDeCliente.TabIndex = 3;
            lblCadastroDeCliente.Text = "Cadastro de Cliente";
            lblCadastroDeCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.ForeColor = SystemColors.ButtonFace;
            lblNome.Location = new Point(55, 105);
            lblNome.Margin = new Padding(0);
            lblNome.Name = "lblNome";
            lblNome.RightToLeft = RightToLeft.No;
            lblNome.Size = new Size(44, 16);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome:";
            lblNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbNome
            // 
            txtbNome.BackColor = SystemColors.WindowFrame;
            txtbNome.BorderStyle = BorderStyle.None;
            txtbNome.Cursor = Cursors.IBeam;
            txtbNome.ForeColor = SystemColors.Window;
            txtbNome.Location = new Point(102, 106);
            txtbNome.MaxLength = 150;
            txtbNome.Name = "txtbNome";
            txtbNome.Size = new Size(422, 16);
            txtbNome.TabIndex = 5;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCPF.ForeColor = SystemColors.ButtonFace;
            lblCPF.Location = new Point(55, 141);
            lblCPF.Margin = new Padding(0);
            lblCPF.Name = "lblCPF";
            lblCPF.RightToLeft = RightToLeft.No;
            lblCPF.Size = new Size(70, 16);
            lblCPF.TabIndex = 6;
            lblCPF.Text = "CPF/CNPJ:";
            lblCPF.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTelCell
            // 
            lblTelCell.AutoSize = true;
            lblTelCell.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelCell.ForeColor = SystemColors.ButtonFace;
            lblTelCell.Location = new Point(55, 178);
            lblTelCell.Margin = new Padding(0);
            lblTelCell.Name = "lblTelCell";
            lblTelCell.RightToLeft = RightToLeft.No;
            lblTelCell.Size = new Size(106, 16);
            lblTelCell.TabIndex = 8;
            lblTelCell.Text = "Telefone/Celular:";
            lblTelCell.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbTell
            // 
            txtbTell.BackColor = SystemColors.WindowFrame;
            txtbTell.BorderStyle = BorderStyle.None;
            txtbTell.Cursor = Cursors.IBeam;
            txtbTell.ForeColor = SystemColors.Window;
            txtbTell.Location = new Point(164, 179);
            txtbTell.MaxLength = 15;
            txtbTell.Name = "txtbTell";
            txtbTell.Size = new Size(195, 16);
            txtbTell.TabIndex = 9;
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.BackColor = Color.YellowGreen;
            btnRegistrarCliente.Cursor = Cursors.Hand;
            btnRegistrarCliente.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
            btnRegistrarCliente.FlatStyle = FlatStyle.Flat;
            btnRegistrarCliente.Font = new Font("Leelawadee UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarCliente.ForeColor = SystemColors.ButtonFace;
            btnRegistrarCliente.ImageAlign = ContentAlignment.TopCenter;
            btnRegistrarCliente.Location = new Point(55, 248);
            btnRegistrarCliente.Margin = new Padding(0);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(469, 23);
            btnRegistrarCliente.TabIndex = 11;
            btnRegistrarCliente.Text = "Registrar Novo Cliente";
            btnRegistrarCliente.UseVisualStyleBackColor = false;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 77, 81);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Leelawadee UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonFace;
            btnCancelar.ImageAlign = ContentAlignment.TopCenter;
            btnCancelar.Location = new Point(55, 281);
            btnCancelar.Margin = new Padding(0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(469, 23);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtbCpf
            // 
            txtbCpf.BackColor = SystemColors.WindowFrame;
            txtbCpf.BorderStyle = BorderStyle.None;
            txtbCpf.Cursor = Cursors.IBeam;
            txtbCpf.ForeColor = SystemColors.Window;
            txtbCpf.Location = new Point(128, 142);
            txtbCpf.MaxLength = 18;
            txtbCpf.Name = "txtbCpf";
            txtbCpf.Size = new Size(195, 16);
            txtbCpf.TabIndex = 7;
            // 
            // CriandoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 44);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(584, 350);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrarCliente);
            Controls.Add(txtbTell);
            Controls.Add(lblTelCell);
            Controls.Add(txtbCpf);
            Controls.Add(lblCPF);
            Controls.Add(txtbNome);
            Controls.Add(lblNome);
            Controls.Add(lblCadastroDeCliente);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "CriandoCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CriandoCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadastroDeCliente;
        private Label lblNome;
        private TextBox txtbNome;
        private Label lblCPF;
        private Label lblTelCell;
        private TextBox txtbTell;
        private Button btnRegistrarCliente;
        private Button btnCancelar;
        private TextBox txtbCpf;
    }
}