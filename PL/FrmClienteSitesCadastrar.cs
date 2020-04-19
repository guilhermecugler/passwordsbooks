using DTO;
using BLL;
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
    public partial class FrmClienteSitesCadastrar : Form
    {
        public Site site = new Site();

        public FrmClienteSitesCadastrar()
        {
            InitializeComponent();
        }


        public FrmClienteSitesCadastrar(int CodigoSite)
        {
            InitializeComponent();
         //   fillTipos();

            if (CodigoSite != 0)
            {
                site = SistemaBLL.BuscarSiteBLL(CodigoSite);

                txtSiteNome.Text = site.siteNome;
                txtSiteLink.Text = site.siteLink;

            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string acao = null;

            if (site == null)
                site = new Site();

            site.siteNome = txtSiteNome.Text.ToUpper();
            site.siteLink = txtSiteLink.Text;


            if (site.Id == 0)
            {
                site.Id = SistemaBLL.InserirSiteBLL(site);
                acao = "cadastrado";
            }
            else
            {
                SistemaBLL.AtualizarSiteBLL(site);
                acao = "atualizado";
            }



            MessageBox.Show("Site " + site.siteNome.ToString() + " " + acao + " com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
        }
    }
}
