using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PL
{
    public partial class FrmClienteSitesSelecionar : Form
    {
        public FrmClienteSitesSelecionar()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FrmClienteSitesCadastrar frmClienteSitesCadastrar = new FrmClienteSitesCadastrar();
            var result = frmClienteSitesCadastrar.ShowDialog();

            if (result == DialogResult.OK)
            {
                string[] linhaSite = { frmClienteSitesCadastrar.site.Id.ToString(), frmClienteSitesCadastrar.site.siteNome, frmClienteSitesCadastrar.site.siteLink };
                Grid.Rows.Add(linhaSite);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Grid.Rows.Clear();

            string[] filtros = { txtPesquisar.Text };

            List<Site> Sites = SistemaBLL.BuscarSiteDAL(filtros);

            foreach (var site in Sites)
            {
                string[] linhaSite = { site.Id.ToString(), site.siteNome, site.siteLink};
                Grid.Rows.Add(linhaSite);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewCell cellLink = Grid.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cellLink.ColumnIndex == this.Grid.Columns["ColumnSite"].Index)
            {
                Process.Start(Grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                return;
            }
            //btnAlterar_Click(null, null);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int CodigoSiteLinhaSelecionada = int.Parse(Grid.CurrentRow.Cells["ColumnID"].Value.ToString());

            FrmClienteSitesCadastrar frmClienteSiteCadastrar = new FrmClienteSitesCadastrar(CodigoSiteLinhaSelecionada);
            var result = frmClienteSiteCadastrar.ShowDialog();

            if (result == DialogResult.OK)
            {
                Grid.Rows.Clear();
                string[] linhaSite = { frmClienteSiteCadastrar.site.Id.ToString(), frmClienteSiteCadastrar.site.siteNome, frmClienteSiteCadastrar.site.siteLink };
                Grid.Rows.Add(linhaSite);
            }
        }
    }
}
