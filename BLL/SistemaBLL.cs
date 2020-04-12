using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SistemaBLL
    {
        public static int InserirClienteBLL(Cliente cliente)
        {
            return SistemaDAL.InserirClienteDAL(cliente);
        }
        public static List<Cliente> BuscarClienteDAL(string[] filtros)
        {
            return SistemaDAL.BuscarClienteDAL(filtros);
        }
        public static Cliente BuscarClienteBLL(int CodigoCliente)
        {
            return SistemaDAL.BuscarClienteDAL(CodigoCliente);
        }
        public static void AtualizarClienteBLL(Cliente cliente)
        {
            SistemaDAL.AtualizarClienteDAL(cliente);
        }
        public static void ExcluirClienteBLL(int CodigoCliente)
        {
            SistemaDAL.ExcluirClienteDAL(CodigoCliente);
        }

        public static List<Cliente> BuscarClienteTipo(string[] tipos)
        {
            return SistemaDAL.BuscarClienteTipo(tipos);
        }

        public static int InserirProdutoBLL(Produto produto)
        {
            return SistemaDAL.InserirProdutoDAL(produto);
        }
        public static List<Produto> BuscarProdutoDAL(string[] filtros)
        {
            return SistemaDAL.BuscarProdutoDAL(filtros);
        }
        public static Produto BuscarProdutoBLL(int CodigoProduto)
        {
            return SistemaDAL.BuscarProdutoDAL(CodigoProduto);
        }
        public static void AtualizarProdutoBLL(Produto produto)
        {
            SistemaDAL.AtualizarProdutoDAL(produto);
        }
        public static void ExcluirProdutoBLL(int CodigoProduto)
        {
            SistemaDAL.ExcluirProdutoDAL(CodigoProduto);
        }

        public static int InserirPedidoBLL(Pedido pedido)
        {
            return SistemaDAL.InserirPedidoDAL(pedido);
        }
        public static int InserirItemBLL(Item_Venda item)
        {
            return SistemaDAL.InserirItemDAL(item);
        }
    }
}
