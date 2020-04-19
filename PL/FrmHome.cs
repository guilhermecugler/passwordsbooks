using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
            customizedDesign();
        }

        private void customizedDesign()
        {
            //customizando menus
            panelSubMenuCadastros.Visible = false;
            panelSubMenuConsultas.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMenuCadastros.Visible == true)
                panelSubMenuCadastros.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #region Cadastros
        private void btnCadastros_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuCadastros);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //chamar form de clientes
            openChildForm(new FrmClienteSelecionar(Acao.Pesquisar));
            hideSubMenu();
        }

        private void btnSites_Click(object sender, EventArgs e)
        {
            //chamar form de sites
            openChildForm(new FrmClienteSitesSelecionar());
            hideSubMenu();
        }
        #endregion
        private void btnMenuSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair do sistema?", "Sair do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuConsultas);
        }

        private void btnConsultaCPF_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCPFConsultar());
            hideSubMenu();
        }
    }
}
