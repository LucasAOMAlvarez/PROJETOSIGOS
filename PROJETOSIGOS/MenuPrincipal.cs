using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROJETOSIGOS
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        //Botão para sair do sistema
        private void btnEncerrarSecao_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Botão para criação das OS's
        private void btnCriarOS_Click(object sender, EventArgs e)
        {
            CriandoOS criandoOS = new CriandoOS();
            criandoOS.Show();

        }

        //Boatão para consultar OS's já criadas
        private void btnConsultarOS_Click(object sender, EventArgs e)
        {
            ConsultaOS consultaOS = new ConsultaOS();
            consultaOS.Show();

        }

        //Botão para consulta/registro de clientes
        private void btnCliente_Click(object sender, EventArgs e)
        {
            CriandoCliente criandoClient = new CriandoCliente();
            criandoClient.Show();
        }

        //Botão para consulta e/ou criação de novos serviços
        private void btnServicos_Click(object sender, EventArgs e)
        {
            ControleServiços controlServ = new ControleServiços();
            controlServ.Show();
        }


    }
}
