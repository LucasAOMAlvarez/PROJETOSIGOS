namespace PROJETOSIGOS
{
    partial class ControleServiços
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
            lblSevicosCadastrados = new Label();
            ltbServicos = new ListBox();
            btnCriarServico = new Button();
            btnCancelar = new Button();
            lblAtualizar = new Label();
            SuspendLayout();
            // 
            // lblCadastroDeCliente
            // 
            lblCadastroDeCliente.AutoEllipsis = true;
            lblCadastroDeCliente.AutoSize = true;
            lblCadastroDeCliente.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCadastroDeCliente.ForeColor = SystemColors.ButtonFace;
            lblCadastroDeCliente.Location = new Point(202, 26);
            lblCadastroDeCliente.Margin = new Padding(0);
            lblCadastroDeCliente.Name = "lblCadastroDeCliente";
            lblCadastroDeCliente.RightToLeft = RightToLeft.No;
            lblCadastroDeCliente.Size = new Size(93, 25);
            lblCadastroDeCliente.TabIndex = 4;
            lblCadastroDeCliente.Text = "Serviços";
            lblCadastroDeCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSevicosCadastrados
            // 
            lblSevicosCadastrados.AutoSize = true;
            lblSevicosCadastrados.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSevicosCadastrados.ForeColor = SystemColors.ButtonFace;
            lblSevicosCadastrados.Location = new Point(69, 79);
            lblSevicosCadastrados.Margin = new Padding(0);
            lblSevicosCadastrados.Name = "lblSevicosCadastrados";
            lblSevicosCadastrados.RightToLeft = RightToLeft.No;
            lblSevicosCadastrados.Size = new Size(135, 16);
            lblSevicosCadastrados.TabIndex = 18;
            lblSevicosCadastrados.Text = "Serviços Cadastrados";
            lblSevicosCadastrados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ltbServicos
            // 
            ltbServicos.BackColor = SystemColors.WindowFrame;
            ltbServicos.BorderStyle = BorderStyle.None;
            ltbServicos.ForeColor = SystemColors.Window;
            ltbServicos.FormattingEnabled = true;
            ltbServicos.Location = new Point(69, 109);
            ltbServicos.Margin = new Padding(9);
            ltbServicos.Name = "ltbServicos";
            ltbServicos.Size = new Size(363, 165);
            ltbServicos.TabIndex = 19;
            // 
            // btnCriarServico
            // 
            btnCriarServico.BackColor = Color.FromArgb(105, 139, 239);
            btnCriarServico.Cursor = Cursors.Hand;
            btnCriarServico.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
            btnCriarServico.FlatStyle = FlatStyle.Flat;
            btnCriarServico.Font = new Font("Leelawadee UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriarServico.ForeColor = SystemColors.ButtonFace;
            btnCriarServico.ImageAlign = ContentAlignment.TopCenter;
            btnCriarServico.Location = new Point(69, 293);
            btnCriarServico.Margin = new Padding(0);
            btnCriarServico.Name = "btnCriarServico";
            btnCriarServico.Size = new Size(139, 23);
            btnCriarServico.TabIndex = 20;
            btnCriarServico.Text = "Criar Serviço";
            btnCriarServico.UseVisualStyleBackColor = false;
            btnCriarServico.Click += btnCriarServico_Click;
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
            btnCancelar.Location = new Point(293, 293);
            btnCancelar.Margin = new Padding(0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(139, 23);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblAtualizar
            // 
            lblAtualizar.AutoSize = true;
            lblAtualizar.Cursor = Cursors.Hand;
            lblAtualizar.Font = new Font("Bahnschrift", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAtualizar.ForeColor = Color.Cyan;
            lblAtualizar.Location = new Point(380, 82);
            lblAtualizar.Margin = new Padding(0);
            lblAtualizar.Name = "lblAtualizar";
            lblAtualizar.RightToLeft = RightToLeft.No;
            lblAtualizar.Size = new Size(52, 13);
            lblAtualizar.TabIndex = 25;
            lblAtualizar.Text = "Atualizar";
            lblAtualizar.TextAlign = ContentAlignment.MiddleCenter;
            lblAtualizar.Click += lblAtualizar_Click;
            // 
            // ControleServiços
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(515, 365);
            ControlBox = false;
            Controls.Add(lblAtualizar);
            Controls.Add(btnCancelar);
            Controls.Add(btnCriarServico);
            Controls.Add(ltbServicos);
            Controls.Add(lblSevicosCadastrados);
            Controls.Add(lblCadastroDeCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ControleServiços";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ControleServiços";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadastroDeCliente;
        private Label lblSevicosCadastrados;
        private ListBox ltbServicos;
        private Button btnCriarServico;
        private Button btnCancelar;
        private Label lblAtualizar;
    }
}