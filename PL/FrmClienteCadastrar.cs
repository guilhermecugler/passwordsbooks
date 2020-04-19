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
    public partial class FrmClienteCadastrar : Form
    {
        //Função para preencher combobox com tipos de sites do banco
        void fillSites()
        {

            cbSites.Items.Clear();

            string[] sites = { };

            List<Site> Sites = SistemaBLL.BuscarSites(sites);

            foreach (var site in Sites)
            {
                cbSites.Items.Add(site.siteNome);

            }

        }

        public Cliente cliente = new Cliente();

        public FrmClienteCadastrar()
        {
            InitializeComponent();
            
            
        }
        public FrmClienteCadastrar(int CodigoCliente)
        {
            InitializeComponent();


            if (CodigoCliente != 0)
            {
                cliente = SistemaBLL.BuscarClienteBLL(CodigoCliente);

                mskClienteCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mskClienteTel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mskClienteTelCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mskAdicional.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                cbSites.Items.Insert(0, cliente.clienteSiteNome);
                cbSites.SelectedIndex = 0;
                txtClienteNome.Text = cliente.clienteNome;
                mskClienteCPF.Text = cliente.clienteCPF;
                txtClienteLogin.Text = cliente.clienteLogin;
                txtClienteEmail.Text = cliente.clienteEmail;
                txtClienteSenha.Text = cliente.clienteSenha;
                mskClienteCartao.Text = cliente.clienteCartao;
                mskClienteTel.Text = cliente.clienteTel;
                mskClienteTelCelular.Text = cliente.clienteTelCelular;
                txtClienteObs.Text = cliente.clienteObs;
                mskClienteDN.Text = cliente.clienteDN;
                txtClienteLogradouro.Text = cliente.clienteLogradouro;
                txtClienteNumero.Text = cliente.clienteNumero;
                txtClienteComplemento.Text = cliente.clienteComplemento;
                txtClienteBairro.Text = cliente.clienteBairro;
                txtClienteCidade.Text = cliente.clienteCidade;
                txtClienteUF.Text = cliente.clienteUF;
                txtClienteAtendente.Text = cliente.clienteAtendente;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string acao = null;

            if (cliente == null)
                cliente = new Cliente();
            //Removendo máscara para salvar no banco o atributo bruto
            mskClienteCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskClienteTel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskClienteTelCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskClienteDN.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskClienteCartao.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            cliente.clienteNome = txtClienteNome.Text.ToUpper();
            cliente.clienteCPF = mskClienteCPF.Text.ToUpper();
            cliente.clienteLogin = txtClienteLogin.Text;
            cliente.clienteEmail = txtClienteEmail.Text.ToLower();
            cliente.clienteSenha = txtClienteSenha.Text;
            cliente.clienteCartao = mskClienteCartao.Text.ToUpper();
            cliente.clienteTel = mskClienteTel.Text.ToUpper();
            cliente.clienteTelCelular = mskClienteTelCelular.Text.ToUpper();
            cliente.clienteObs = txtClienteObs.Text.ToUpper();
            cliente.clienteDN = mskClienteDN.Text.ToUpper();
            cliente.clienteLogradouro = txtClienteLogradouro.Text.ToUpper();
            cliente.clienteNumero = txtClienteNumero.Text.ToUpper();
            cliente.clienteComplemento = txtClienteComplemento.Text.ToUpper();
            cliente.clienteBairro = txtClienteBairro.Text.ToUpper();
            cliente.clienteCidade = txtClienteCidade.Text.ToUpper();
            cliente.clienteUF = txtClienteUF.Text.ToUpper();
            cliente.clienteAtendente = txtClienteAtendente.Text.ToUpper();
            cliente.clienteSiteIdFk = cbSites.Text;



            if (cliente.Id == 0)
            {
                cliente.Id = SistemaBLL.InserirClienteBLL(cliente);
                acao = "cadastrado";
            }
            else
            {
                SistemaBLL.AtualizarClienteBLL(cliente);
                acao = "atualizado";
            }

            MessageBox.Show("Cliente " + cliente.clienteNome.ToString() + " " + acao + " com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
        }

        private void btnNovoSite_Click(object sender, EventArgs e)
        {
            FrmClienteSitesCadastrar frmClienteSitesCadastrar = new FrmClienteSitesCadastrar();
            var resultSite = frmClienteSitesCadastrar.ShowDialog();

            if (resultSite == DialogResult.OK)
            {
                string[] cbSiteNovo = { frmClienteSitesCadastrar.site.siteNome };
                cbSites.Text = frmClienteSitesCadastrar.site.siteNome;
            }
        }

        private void cbSites_MouseEnter(object sender, EventArgs e)
        {
            fillSites();
        }
    }
}
