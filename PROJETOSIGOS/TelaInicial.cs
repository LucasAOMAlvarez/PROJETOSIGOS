namespace PROJETOSIGOS
{
    public partial class SIGOS : Form
    {
        public SIGOS()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Instanciando/Chamando próxima classe/tela (MenuPrincipal)
            MenuPrincipal MenuPrincipal = new MenuPrincipal();
            MenuPrincipal.Show();

            //Ocultando tela atual
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
