namespace PROJETOSIGOS
{
    partial class SIGOS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSigos = new Label();
            lblAassistenciaTtecnica = new Label();
            btnEntrar = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lblSigos
            // 
            lblSigos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSigos.AutoSize = true;
            lblSigos.Font = new Font("Impact", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSigos.ForeColor = SystemColors.ButtonFace;
            lblSigos.Location = new Point(256, 79);
            lblSigos.Margin = new Padding(0);
            lblSigos.Name = "lblSigos";
            lblSigos.RightToLeft = RightToLeft.No;
            lblSigos.Size = new Size(283, 117);
            lblSigos.TabIndex = 0;
            lblSigos.Text = "SIGOS";
            lblSigos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAassistenciaTtecnica
            // 
            lblAassistenciaTtecnica.AutoSize = true;
            lblAassistenciaTtecnica.Font = new Font("Bahnschrift", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAassistenciaTtecnica.ForeColor = SystemColors.ButtonFace;
            lblAassistenciaTtecnica.Location = new Point(273, 180);
            lblAassistenciaTtecnica.Margin = new Padding(0);
            lblAassistenciaTtecnica.Name = "lblAassistenciaTtecnica";
            lblAassistenciaTtecnica.RightToLeft = RightToLeft.No;
            lblAassistenciaTtecnica.Size = new Size(248, 33);
            lblAassistenciaTtecnica.TabIndex = 1;
            lblAassistenciaTtecnica.Text = "Assistência Técnica";
            lblAassistenciaTtecnica.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(105, 139, 239);
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = SystemColors.ButtonFace;
            btnEntrar.Location = new Point(295, 256);
            btnEntrar.Margin = new Padding(0);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(197, 30);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(255, 77, 81);
            btnSair.Cursor = Cursors.Hand;
            btnSair.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = SystemColors.ButtonFace;
            btnSair.Location = new Point(295, 296);
            btnSair.Margin = new Padding(0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(197, 30);
            btnSair.TabIndex = 3;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // SIGOS
            // 
            AccessibleName = "";
            AutoScaleMode = AutoScaleMode.None;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(780, 450);
            ControlBox = false;
            Controls.Add(btnSair);
            Controls.Add(btnEntrar);
            Controls.Add(lblAassistenciaTtecnica);
            Controls.Add(lblSigos);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            FormScreenCaptureMode = ScreenCaptureMode.HideContent;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "SIGOS";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIGOS";
            TransparencyKey = Color.Transparent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSigos;
        private Label lblAassistenciaTtecnica;
        private Button btnEntrar;
        private Button btnSair;
    }
}
