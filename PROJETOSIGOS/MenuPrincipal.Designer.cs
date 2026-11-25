namespace PROJETOSIGOS
{
    partial class MenuPrincipal
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
            lblMenuPrincipal = new Label();
            btnCriarOS = new Button();
            btnConsultarOS = new Button();
            btnCliente = new Button();
            btnServicos = new Button();
            btnEncerrarSecao = new Button();
            SuspendLayout();
            // 
            // lblMenuPrincipal
            // 
            lblMenuPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMenuPrincipal.AutoSize = true;
            lblMenuPrincipal.Font = new Font("Bahnschrift", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMenuPrincipal.ForeColor = SystemColors.ButtonFace;
            lblMenuPrincipal.ImageAlign = ContentAlignment.TopCenter;
            lblMenuPrincipal.Location = new Point(308, 42);
            lblMenuPrincipal.Margin = new Padding(0);
            lblMenuPrincipal.Name = "lblMenuPrincipal";
            lblMenuPrincipal.RightToLeft = RightToLeft.No;
            lblMenuPrincipal.Size = new Size(194, 33);
            lblMenuPrincipal.TabIndex = 2;
            lblMenuPrincipal.Text = "Menu Principal";
            lblMenuPrincipal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCriarOS
            // 
            btnCriarOS.BackColor = Color.FromArgb(105, 139, 239);
            btnCriarOS.Cursor = Cursors.Hand;
            btnCriarOS.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
            btnCriarOS.FlatStyle = FlatStyle.Flat;
            btnCriarOS.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriarOS.ForeColor = SystemColors.ButtonFace;
            btnCriarOS.Location = new Point(306, 123);
            btnCriarOS.Margin = new Padding(0);
            btnCriarOS.Name = "btnCriarOS";
            btnCriarOS.Size = new Size(197, 30);
            btnCriarOS.TabIndex = 3;
            btnCriarOS.Text = "Criar O.S";
            btnCriarOS.UseVisualStyleBackColor = false;
            btnCriarOS.Click += btnCriarOS_Click;
            // 
            // btnConsultarOS
            // 
            btnConsultarOS.BackColor = Color.FromArgb(70, 70, 70);
            btnConsultarOS.Cursor = Cursors.Hand;
            btnConsultarOS.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
            btnConsultarOS.FlatStyle = FlatStyle.Flat;
            btnConsultarOS.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultarOS.ForeColor = SystemColors.ButtonFace;
            btnConsultarOS.Location = new Point(306, 169);
            btnConsultarOS.Margin = new Padding(0);
            btnConsultarOS.Name = "btnConsultarOS";
            btnConsultarOS.Size = new Size(197, 30);
            btnConsultarOS.TabIndex = 4;
            btnConsultarOS.Text = "Consultar O.S";
            btnConsultarOS.UseVisualStyleBackColor = false;
            btnConsultarOS.Click += btnConsultarOS_Click;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(70, 70, 70);
            btnCliente.Cursor = Cursors.Hand;
            btnCliente.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCliente.ForeColor = SystemColors.ButtonFace;
            btnCliente.Location = new Point(306, 216);
            btnCliente.Margin = new Padding(0);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(197, 30);
            btnCliente.TabIndex = 5;
            btnCliente.Text = "Registrar Cliente";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnServicos
            // 
            btnServicos.BackColor = Color.FromArgb(70, 70, 70);
            btnServicos.Cursor = Cursors.Hand;
            btnServicos.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
            btnServicos.FlatStyle = FlatStyle.Flat;
            btnServicos.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnServicos.ForeColor = SystemColors.ButtonFace;
            btnServicos.Location = new Point(306, 262);
            btnServicos.Margin = new Padding(0);
            btnServicos.Name = "btnServicos";
            btnServicos.Size = new Size(197, 30);
            btnServicos.TabIndex = 6;
            btnServicos.Text = "Serviços";
            btnServicos.UseVisualStyleBackColor = false;
            btnServicos.Click += btnServicos_Click;
            // 
            // btnEncerrarSecao
            // 
            btnEncerrarSecao.BackColor = Color.FromArgb(255, 77, 81);
            btnEncerrarSecao.Cursor = Cursors.Hand;
            btnEncerrarSecao.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
            btnEncerrarSecao.FlatStyle = FlatStyle.Flat;
            btnEncerrarSecao.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEncerrarSecao.ForeColor = SystemColors.ButtonFace;
            btnEncerrarSecao.Location = new Point(306, 308);
            btnEncerrarSecao.Margin = new Padding(0);
            btnEncerrarSecao.Name = "btnEncerrarSecao";
            btnEncerrarSecao.Size = new Size(197, 30);
            btnEncerrarSecao.TabIndex = 7;
            btnEncerrarSecao.Text = "Encerrar Seção";
            btnEncerrarSecao.UseVisualStyleBackColor = false;
            btnEncerrarSecao.Click += btnEncerrarSecao_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnEncerrarSecao);
            Controls.Add(btnServicos);
            Controls.Add(btnCliente);
            Controls.Add(btnConsultarOS);
            Controls.Add(btnCriarOS);
            Controls.Add(lblMenuPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "MenuPrincipal";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIGOS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMenuPrincipal;
        private Button btnCriarOS;
        private Button btnConsultarOS;
        private Button btnCliente;
        private Button btnServicos;
        private Button btnEncerrarSecao;
    }
}