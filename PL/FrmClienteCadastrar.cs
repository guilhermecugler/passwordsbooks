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

                txtClienteTipoCadastro.Text = cliente.clienteTipoCadastro;
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
                txtClienteLinkSite.Text = cliente.clienteLinkSite;
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cliente == null)
                cliente = new Cliente();
            //Removendo máscara para salvar no banco o atributo bruto
            mskClienteCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskClienteTel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskClienteTelCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskClienteDN.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskClienteCartao.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            cliente.clienteTipoCadastro = txtClienteTipoCadastro.Text;
            cliente.clienteNome = txtClienteNome.Text;
            cliente.clienteCPF = mskClienteCPF.Text;
            cliente.clienteLogin = txtClienteLogin.Text;
            cliente.clienteEmail = txtClienteEmail.Text;
            cliente.clienteSenha = txtClienteSenha.Text;
            cliente.clienteCartao = mskClienteCartao.Text;
            cliente.clienteTel = mskClienteTel.Text;
            cliente.clienteTelCelular = mskClienteTelCelular.Text;
            cliente.clienteObs = txtClienteObs.Text;
            cliente.clienteDN = mskClienteDN.Text;
            cliente.clienteLogradouro = txtClienteLogradouro.Text;
            cliente.clienteNumero = txtClienteNumero.Text;
            cliente.clienteComplemento = txtClienteComplemento.Text;
            cliente.clienteBairro = txtClienteBairro.Text;
            cliente.clienteCidade = txtClienteCidade.Text;
            cliente.clienteUF = txtClienteUF.Text;
            cliente.clienteAtendente = txtClienteAtendente.Text;
            cliente.clienteLinkSite = txtClienteLinkSite.Text;


            if (cliente.Id == 0)
                cliente.Id = SistemaBLL.InserirClienteBLL(cliente);
            else
                SistemaBLL.AtualizarClienteBLL(cliente);

            MessageBox.Show("Cliente Cadastrado com Sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
        }

    }
}
