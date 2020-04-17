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
    public partial class FrmClienteSelecionar : Form
    {
        public FrmClienteSelecionar(Acao acao)
        {
            InitializeComponent();
            fillTipos();

        }

        void fillTipos()
        {

            cbTipo.Items.Clear();

            string[] tipos = {};

            List<Cliente> Tipos = SistemaBLL.BuscarClienteTipo(tipos);

            foreach (var tipo in Tipos)
            {
                cbTipo.Items.Add(tipo.clienteTipoCadastro);

            }

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FrmClienteCadastrar frmClienteCadastrar = new FrmClienteCadastrar(0);
            var result = frmClienteCadastrar.ShowDialog();

            if (result == DialogResult.OK)
            {
                string[] linhaCliente = { frmClienteCadastrar.cliente.Id.ToString(), frmClienteCadastrar.cliente.clienteTipoCadastro, frmClienteCadastrar.cliente.clienteNome, frmClienteCadastrar.cliente.clienteCPF, frmClienteCadastrar.cliente.clienteLogin, frmClienteCadastrar.cliente.clienteEmail, frmClienteCadastrar.cliente.clienteSenha, frmClienteCadastrar.cliente.clienteCartao, frmClienteCadastrar.cliente.clienteTel, frmClienteCadastrar.cliente.clienteTelCelular, frmClienteCadastrar.cliente.clienteObs, frmClienteCadastrar.cliente.clienteDN, frmClienteCadastrar.cliente.clienteLogradouro, frmClienteCadastrar.cliente.clienteNumero, frmClienteCadastrar.cliente.clienteComplemento, frmClienteCadastrar.cliente.clienteBairro, frmClienteCadastrar.cliente.clienteCidade, frmClienteCadastrar.cliente.clienteUF, frmClienteCadastrar.cliente.clienteAtendente, frmClienteCadastrar.cliente.clienteLinkSite };
                Grid.Rows.Add(linhaCliente);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Grid.Rows.Clear();

            string[] filtros = { txtPesquisar.Text, cbTipo.Text };

            List<Cliente> Clientes = SistemaBLL.BuscarClienteDAL(filtros);

            foreach (var cliente in Clientes)
            {
                string[] linhaCliente = { cliente.Id.ToString(), cliente.clienteTipoCadastro, cliente.clienteNome, cliente.clienteCPF, cliente.clienteLogin, cliente.clienteEmail, cliente.clienteSenha, cliente.clienteCartao, cliente.clienteTel, cliente.clienteTelCelular, cliente.clienteObs, cliente.clienteDN, cliente.clienteLogradouro, cliente.clienteNumero, cliente.clienteComplemento, cliente.clienteBairro, cliente.clienteCidade, cliente.clienteUF, cliente.clienteAtendente, cliente.clienteLinkSite };
                Grid.Rows.Add(linhaCliente);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int CodigoClienteLinhaSelecionada = int.Parse(Grid.CurrentRow.Cells["ColumnID"].Value.ToString());

            FrmClienteCadastrar frmClienteCadastrar = new FrmClienteCadastrar(CodigoClienteLinhaSelecionada);
            var result = frmClienteCadastrar.ShowDialog();

            if (result == DialogResult.OK)
            {
                Grid.Rows.Clear();
                string[] linhaCliente = { frmClienteCadastrar.cliente.Id.ToString(), frmClienteCadastrar.cliente.clienteTipoCadastro, frmClienteCadastrar.cliente.clienteNome, frmClienteCadastrar.cliente.clienteCPF, frmClienteCadastrar.cliente.clienteLogin, frmClienteCadastrar.cliente.clienteEmail, frmClienteCadastrar.cliente.clienteSenha, frmClienteCadastrar.cliente.clienteCartao, frmClienteCadastrar.cliente.clienteTel, frmClienteCadastrar.cliente.clienteTelCelular, frmClienteCadastrar.cliente.clienteObs, frmClienteCadastrar.cliente.clienteDN, frmClienteCadastrar.cliente.clienteLogradouro, frmClienteCadastrar.cliente.clienteNumero, frmClienteCadastrar.cliente.clienteComplemento, frmClienteCadastrar.cliente.clienteBairro, frmClienteCadastrar.cliente.clienteCidade, frmClienteCadastrar.cliente.clienteUF, frmClienteCadastrar.cliente.clienteAtendente, frmClienteCadastrar.cliente.clienteLinkSite };
                Grid.Rows.Add(linhaCliente);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o cliente " + Grid.CurrentRow.Cells["ColumnNome"].Value.ToString() + "?", "Excluir Ciente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int CodigoClienteLinhaSelecionada = int.Parse(Grid.CurrentRow.Cells["ColumnID"].Value.ToString());

                SistemaBLL.ExcluirClienteBLL(CodigoClienteLinhaSelecionada);

                Grid.Rows.RemoveAt(Grid.CurrentRow.Index);
            }
        }

        private void Grid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewCell cellLink = (DataGridViewCell)Grid.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cellLink.ColumnIndex == this.Grid.Columns["ColumnSite"].Index)
            {
                Process.Start(Grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                return;
            }
            btnAlterar_Click(null, null);
        }

    }
}