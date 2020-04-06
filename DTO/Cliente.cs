using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Cliente
    {
        public int Id { get; set; }
        public string clienteTipoCadastro { get; set; }
        public string clienteNome { get; set; }
        public string clienteCPF { get; set; }
        public string clienteLogin { get; set; }
        public string clienteEmail { get; set; }
        public string clienteSenha { get; set; }
        public string clienteCartao { get; set; }
        public string clienteTel { get; set; }
        public string clienteTelCelular { get; set; }
        public string clienteObs { get; set; }
        public string clienteDN { get; set; }
        public string clienteLogradouro { get; set; }
        public string clienteNumero { get; set; }
        public string clienteComplemento { get; set; }
        public string clienteBairro { get; set; }
        public string clienteCidade { get; set; }
        public string clienteUF { get; set; }
        public string clienteAtendente { get; set; }
        public string clienteLinkSite { get; set; }
    }
}
