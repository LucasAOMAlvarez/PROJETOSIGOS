namespace PROJETOSIGOS
{
    partial class CadastrandoServiço
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
            lblCadastrandoServ = new Label();
            lblNomeServ = new Label();
            lblPreco = new Label();
            txtbNomeServ = new TextBox();
            txtbPreco = new TextBox();
            btnAddServ = new Button();
            btnCancelarServ = new Button();
            SuspendLayout();
            // 
            // lblCadastrandoServ
            // 
            lblCadastrandoServ.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCadastrandoServ.AutoSize = true;
            lblCadastrandoServ.Font = new Font("Bahnschrift", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCadastrandoServ.ForeColor = SystemColors.ButtonFace;
            lblCadastrandoServ.ImageAlign = ContentAlignment.TopCenter;
            lblCadastrandoServ.Location = new Point(55, 30);
            lblCadastrandoServ.Margin = new Padding(0);
            lblCadastrandoServ.Name = "lblCadastrandoServ";
            lblCadastrandoServ.RightToLeft = RightToLeft.No;
            lblCadastrandoServ.Size = new Size(268, 33);
            lblCadastrandoServ.TabIndex = 3;
            lblCadastrandoServ.Text = "Cadastrando Serviço";
            lblCadastrandoServ.TextAlign = ContentAlignment.MiddleCenter;
            lblCadastrandoServ.Click += lblCadastrandoServ_Click;
            // 
            // lblNomeServ
            // 
            lblNomeServ.AutoSize = true;
            lblNomeServ.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeServ.ForeColor = SystemColors.ButtonFace;
            lblNomeServ.Location = new Point(43, 91);
            lblNomeServ.Margin = new Padding(0);
            lblNomeServ.Name = "lblNomeServ";
            lblNomeServ.RightToLeft = RightToLeft.No;
            lblNomeServ.Size = new Size(44, 16);
            lblNomeServ.TabIndex = 5;
            lblNomeServ.Text = "Nome:";
            lblNomeServ.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPreco.ForeColor = SystemColors.ButtonFace;
            lblPreco.Location = new Point(43, 121);
            lblPreco.Margin = new Padding(0);
            lblPreco.Name = "lblPreco";
            lblPreco.RightToLeft = RightToLeft.No;
            lblPreco.Size = new Size(44, 16);
            lblPreco.TabIndex = 6;
            lblPreco.Text = "Preço:";
            lblPreco.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbNomeServ
            // 
            txtbNomeServ.BackColor = SystemColors.WindowFrame;
            txtbNomeServ.BorderStyle = BorderStyle.None;
            txtbNomeServ.Cursor = Cursors.IBeam;
            txtbNomeServ.ForeColor = SystemColors.Window;
            txtbNomeServ.Location = new Point(90, 92);
            txtbNomeServ.MaxLength = 150;
            txtbNomeServ.Name = "txtbNomeServ";
            txtbNomeServ.Size = new Size(246, 16);
            txtbNomeServ.TabIndex = 7;
            // 
            // txtbPreco
            // 
            txtbPreco.BackColor = SystemColors.WindowFrame;
            txtbPreco.BorderStyle = BorderStyle.None;
            txtbPreco.Cursor = Cursors.IBeam;
            txtbPreco.ForeColor = SystemColors.Window;
            txtbPreco.Location = new Point(90, 122);
            txtbPreco.MaxLength = 150;
            txtbPreco.Name = "txtbPreco";
            txtbPreco.Size = new Size(93, 16);
            txtbPreco.TabIndex = 8;
            // 
            // btnAddServ
            // 
            btnAddServ.BackColor = Color.YellowGreen;
            btnAddServ.Cursor = Cursors.Hand;
            btnAddServ.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
            btnAddServ.FlatStyle = FlatStyle.Flat;
            btnAddServ.Font = new Font("Leelawadee UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddServ.ForeColor = SystemColors.ButtonFace;
            btnAddServ.ImageAlign = ContentAlignment.TopCenter;
            btnAddServ.Location = new Point(43, 169);
            btnAddServ.Margin = new Padding(0);
            btnAddServ.Name = "btnAddServ";
            btnAddServ.Size = new Size(132, 23);
            btnAddServ.TabIndex = 12;
            btnAddServ.Text = "Adicionar";
            btnAddServ.UseVisualStyleBackColor = false;
            btnAddServ.Click += btnAddServ_Click;
            // 
            // btnCancelarServ
            // 
            btnCancelarServ.BackColor = Color.FromArgb(255, 77, 81);
            btnCancelarServ.Cursor = Cursors.Hand;
            btnCancelarServ.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
            btnCancelarServ.FlatStyle = FlatStyle.Flat;
            btnCancelarServ.Font = new Font("Leelawadee UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarServ.ForeColor = SystemColors.ButtonFace;
            btnCancelarServ.ImageAlign = ContentAlignment.TopCenter;
            btnCancelarServ.Location = new Point(204, 169);
            btnCancelarServ.Margin = new Padding(0);
            btnCancelarServ.Name = "btnCancelarServ";
            btnCancelarServ.Size = new Size(132, 23);
            btnCancelarServ.TabIndex = 13;
            btnCancelarServ.Text = "Cancelar";
            btnCancelarServ.UseVisualStyleBackColor = false;
            btnCancelarServ.Click += btnCancelarServ_Click;
            // 
            // CadastrandoServiço
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(387, 226);
            Controls.Add(btnCancelarServ);
            Controls.Add(btnAddServ);
            Controls.Add(txtbPreco);
            Controls.Add(txtbNomeServ);
            Controls.Add(lblPreco);
            Controls.Add(lblNomeServ);
            Controls.Add(lblCadastrandoServ);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "CadastrandoServiço";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastrandoServiço";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadastrandoServ;
        private Label lblNomeServ;
        private Label lblPreco;
        private TextBox txtbNomeServ;
        private TextBox txtbPreco;
        private Button btnAddServ;
        private Button btnCancelarServ;
    }
}