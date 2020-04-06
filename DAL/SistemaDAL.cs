using DTO;
using System;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SistemaDAL
    {
        public static int InserirClienteDAL(Cliente cliente)
        {
            MySqlConnection Conexao = new MySqlConnection();
            Conexao.ConnectionString = "server=35.193.155.168;user id=admin;password=1022890244Gui;persistsecurityinfo=True;database=dbpasswordsbook";

            MySqlCommand Comando = new MySqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "INSERT tbCliente (clienteTipoCadastro, clienteNome, clienteCPF, clienteLogin, clienteEmail, clienteSenha, clienteCartao, clienteTel, clienteTelCelular, clienteObs, clienteDN, clienteLogradouro, clienteNumero, clienteComplemento, clienteBairro, clienteCidade, clienteUF, clienteAtendente, clienteLinkSite) VALUES(@clienteTipoCadastro, @clienteNome, @clienteCPF, @clienteLogin, @clienteEmail, @clienteSenha, @clienteCartao, @clienteTel, @clienteTelCelular, @clienteObs, @clienteDN, @clienteLogradouro, @clienteNumero, @clienteComplemento, @clienteBairro, @clienteCidade, @clienteUF, @clienteAtendente, @clienteLinkSite)";

            Comando.Parameters.Add("clienteTipoCadastro", MySqlDbType.VarChar).Value = cliente.clienteTipoCadastro;
            Comando.Parameters.Add("clienteNome", MySqlDbType.VarChar).Value = cliente.clienteNome;
            Comando.Parameters.Add("clienteCPF", MySqlDbType.VarChar).Value = cliente.clienteCPF;
            Comando.Parameters.Add("clienteLogin", MySqlDbType.VarChar).Value = cliente.clienteLogin;
            Comando.Parameters.Add("clienteEmail", MySqlDbType.VarChar).Value = cliente.clienteEmail;
            Comando.Parameters.Add("clienteSenha", MySqlDbType.VarChar).Value = cliente.clienteSenha;
            Comando.Parameters.Add("clienteCartao", MySqlDbType.VarChar).Value = cliente.clienteCartao;
            Comando.Parameters.Add("clienteTel", MySqlDbType.VarChar).Value = cliente.clienteTel;
            Comando.Parameters.Add("clienteTelCelular", MySqlDbType.VarChar).Value = cliente.clienteTelCelular;
            Comando.Parameters.Add("clienteObs", MySqlDbType.VarChar).Value = cliente.clienteObs;
            Comando.Parameters.Add("clienteDN", MySqlDbType.VarChar).Value = cliente.clienteDN;
            Comando.Parameters.Add("clienteLogradouro", MySqlDbType.VarChar).Value = cliente.clienteLogradouro;
            Comando.Parameters.Add("clienteNumero", MySqlDbType.VarChar).Value = cliente.clienteNumero;
            Comando.Parameters.Add("clienteComplemento", MySqlDbType.VarChar).Value = cliente.clienteComplemento;
            Comando.Parameters.Add("clienteBairro", MySqlDbType.VarChar).Value = cliente.clienteBairro;
            Comando.Parameters.Add("clienteCidade", MySqlDbType.VarChar).Value = cliente.clienteCidade;
            Comando.Parameters.Add("clienteUF", MySqlDbType.VarChar).Value = cliente.clienteUF;
            Comando.Parameters.Add("clienteAtendente", MySqlDbType.VarChar).Value = cliente.clienteAtendente;
            Comando.Parameters.Add("clienteLinkSite", MySqlDbType.VarChar).Value = cliente.clienteLinkSite;

            Conexao.Open();
            Comando.ExecuteNonQuery();

            Comando.CommandText = "SELECT MAX(clienteId) FROM tbCliente";
            return int.Parse(Comando.ExecuteScalar().ToString());
        }
        public static List<Cliente> BuscarClienteDAL(string[] filtros)
        {
            MySqlConnection Conexao = new MySqlConnection();
            Conexao.ConnectionString = "server=35.193.155.168;user id=admin;password=1022890244Gui;persistsecurityinfo=True;database=dbpasswordsbook";

            MySqlCommand Comando = new MySqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "SELECT clienteId, clienteTipoCadastro, clienteNome, clienteCPF, clienteLogin, clienteEmail, clienteSenha, clienteCartao, clienteTel, clienteTelCelular, clienteObs, clienteDN, clienteLogradouro, clienteNumero, clienteComplemento, clienteBairro, clienteCidade, clienteUF, clienteAtendente, clienteLinkSite FROM tbCliente WHERE 1 = 1";

            if (filtros[0] != String.Empty)
            {
                Comando.CommandText += " AND clienteNome LIKE @Nome OR clienteCPF LIKE @Nome ";
                Comando.Parameters.AddWithValue("@Nome", "%" + filtros[0] + "%");
            }

            Conexao.Open();
            MySqlDataReader Dr = Comando.ExecuteReader();

            List<Cliente> Clientes = new List<Cliente>();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = Convert.ToInt32(Dr["clienteId"]);
                    cliente.clienteTipoCadastro = Convert.ToString(Dr["clienteTipoCadastro"]);
                    cliente.clienteNome = Convert.ToString(Dr["clienteNome"]);
                    cliente.clienteCPF = Convert.ToString(Dr["clienteCPF"]);
                    cliente.clienteLogin = Convert.ToString(Dr["clienteLogin"]);
                    cliente.clienteEmail = Convert.ToString(Dr["clienteEmail"]);
                    cliente.clienteSenha = Convert.ToString(Dr["clienteSenha"]);
                    cliente.clienteCartao = Convert.ToString(Dr["clienteCartao"]);
                    cliente.clienteTel = Convert.ToString(Dr["clienteTel"]);
                    cliente.clienteTelCelular = Convert.ToString(Dr["clienteTelCelular"]);
                    cliente.clienteObs = Convert.ToString(Dr["clienteObs"]);
                    cliente.clienteDN = Convert.ToString(Dr["clienteDN"]);
                    cliente.clienteLogradouro = Convert.ToString(Dr["clienteLogradouro"]);
                    cliente.clienteNumero = Convert.ToString(Dr["clienteNumero"]);
                    cliente.clienteComplemento = Convert.ToString(Dr["clienteComplemento"]);
                    cliente.clienteBairro = Convert.ToString(Dr["clienteBairro"]);
                    cliente.clienteCidade = Convert.ToString(Dr["clienteCidade"]);
                    cliente.clienteUF = Convert.ToString(Dr["clienteUF"]);
                    cliente.clienteAtendente = Convert.ToString(Dr["clienteAtendente"]);
                    cliente.clienteLinkSite = Convert.ToString(Dr["clienteLinkSite"]);

                    Clientes.Add(cliente);
                }
            }

            return Clientes;
        }
        public static void ExcluirClienteDAL(int IdCliente)
        {
            MySqlConnection Conexao = new MySqlConnection();
            Conexao.ConnectionString = "server=35.193.155.168;user id=admin;password=1022890244Gui;persistsecurityinfo=True;database=dbpasswordsbook";

            MySqlCommand Comando = new MySqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "DELETE FROM tbCliente WHERE clienteId = @IdCliente";
            Comando.Parameters.Add("IdCliente", MySqlDbType.Int32).Value = IdCliente;

            Conexao.Open();
            Comando.ExecuteNonQuery();
        }
        public static Cliente BuscarClienteDAL(int CodigoCliente)
        {
            MySqlConnection Conexao = new MySqlConnection();
            Conexao.ConnectionString = "server=35.193.155.168;user id=admin;password=1022890244Gui;persistsecurityinfo=True;database=dbpasswordsbook";

            MySqlCommand Comando = new MySqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT clienteId, clienteTipoCadastro, clienteNome, clienteCPF, clienteLogin, clienteEmail, clienteSenha, clienteCartao, clienteTel, clienteTelCelular, clienteObs, clienteDN, clienteLogradouro, clienteNumero, clienteComplemento, clienteBairro, clienteCidade, clienteUF, clienteAtendente, clienteLinkSite FROM tbCliente WHERE clienteId = @IdCliente";
            Comando.Parameters.Add("IdCliente", MySqlDbType.Int32).Value = CodigoCliente;

            Conexao.Open();
            MySqlDataReader Dr = Comando.ExecuteReader();

            Cliente cliente = new Cliente();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    cliente.Id = Convert.ToInt32(Dr["clienteId"]);
                    cliente.clienteTipoCadastro = Convert.ToString(Dr["clienteTipoCadastro"]);
                    cliente.clienteNome = Convert.ToString(Dr["clienteNome"]);
                    cliente.clienteCPF = Convert.ToString(Dr["clienteCPF"]);
                    cliente.clienteLogin = Convert.ToString(Dr["clienteLogin"]);
                    cliente.clienteEmail = Convert.ToString(Dr["clienteEmail"]);
                    cliente.clienteSenha = Convert.ToString(Dr["clienteSenha"]);
                    cliente.clienteCartao = Convert.ToString(Dr["clienteCartao"]);
                    cliente.clienteTel = Convert.ToString(Dr["clienteTel"]);
                    cliente.clienteTelCelular = Convert.ToString(Dr["clienteTelCelular"]);
                    cliente.clienteObs = Convert.ToString(Dr["clienteObs"]);
                    cliente.clienteDN = Convert.ToString(Dr["clienteDN"]);
                    cliente.clienteLogradouro = Convert.ToString(Dr["clienteLogradouro"]);
                    cliente.clienteNumero = Convert.ToString(Dr["clienteNumero"]);
                    cliente.clienteComplemento = Convert.ToString(Dr["clienteComplemento"]);
                    cliente.clienteBairro = Convert.ToString(Dr["clienteBairro"]);
                    cliente.clienteCidade = Convert.ToString(Dr["clienteCidade"]);
                    cliente.clienteUF = Convert.ToString(Dr["clienteUF"]);
                    cliente.clienteAtendente = Convert.ToString(Dr["clienteAtendente"]);
                    cliente.clienteLinkSite = Convert.ToString(Dr["clienteLinkSite"]);
                }
            }

            return cliente;
        }
        public static void AtualizarClienteDAL(Cliente cliente)
        {
            MySqlConnection Conexao = new MySqlConnection();
            Conexao.ConnectionString = "server=35.193.155.168;user id=admin;password=1022890244Gui;persistsecurityinfo=True;database=dbpasswordsbook";

            MySqlCommand Comando = new MySqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "UPDATE CLIENTE SET NM_CLIENTE = @clienteNome, NR_CPF_CLIENTE = @CPF, NR_TELEFONE = @Telefone, NR_CELULAR = @Celular, NR_TEL_ADICIONAL = @TelefoneAdicional, DS_ENDERECO = @Endereco, NR_ENDERECO = @Numero, DS_BAIRRO = @Bairro, DS_COMPLEMENTO = @Complemento, DS_CIDADE = @Cidade, DS_UF = @UF, NR_CEP = @CEP WHERE clienteId = @IdCliente";
            Comando.Parameters.Add("clienteTipoCadastro", MySqlDbType.VarChar).Value = cliente.clienteTipoCadastro;
            Comando.Parameters.Add("clienteNome", MySqlDbType.VarChar).Value = cliente.clienteNome;
            Comando.Parameters.Add("clienteCPF", MySqlDbType.VarChar).Value = cliente.clienteCPF;
            Comando.Parameters.Add("clienteLogin", MySqlDbType.VarChar).Value = cliente.clienteLogin;
            Comando.Parameters.Add("clienteEmail", MySqlDbType.VarChar).Value = cliente.clienteEmail;
            Comando.Parameters.Add("clienteSenha", MySqlDbType.VarChar).Value = cliente.clienteSenha;
            Comando.Parameters.Add("clienteCartao", MySqlDbType.VarChar).Value = cliente.clienteCartao;
            Comando.Parameters.Add("clienteTel", MySqlDbType.VarChar).Value = cliente.clienteTel;
            Comando.Parameters.Add("clienteTelCelular", MySqlDbType.VarChar).Value = cliente.clienteTelCelular;
            Comando.Parameters.Add("clienteObs", MySqlDbType.VarChar).Value = cliente.clienteObs;
            Comando.Parameters.Add("clienteDN", MySqlDbType.VarChar).Value = cliente.clienteDN;
            Comando.Parameters.Add("clienteLogradouro", MySqlDbType.VarChar).Value = cliente.clienteLogradouro;
            Comando.Parameters.Add("clienteNumero", MySqlDbType.VarChar).Value = cliente.clienteNumero;
            Comando.Parameters.Add("clienteComplemento", MySqlDbType.VarChar).Value = cliente.clienteComplemento;
            Comando.Parameters.Add("clienteBairro", MySqlDbType.VarChar).Value = cliente.clienteBairro;
            Comando.Parameters.Add("clienteCidade", MySqlDbType.VarChar).Value = cliente.clienteCidade;
            Comando.Parameters.Add("clienteUF", MySqlDbType.VarChar).Value = cliente.clienteUF;
            Comando.Parameters.Add("clienteAtendente", MySqlDbType.VarChar).Value = cliente.clienteAtendente;
            Comando.Parameters.Add("clienteLinkSite", MySqlDbType.VarChar).Value = cliente.clienteLinkSite;
            Comando.Parameters.Add("IdCliente", MySqlDbType.Int32).Value = cliente.Id;

            Conexao.Open();
            Comando.ExecuteNonQuery();
        }

        public static int InserirProdutoDAL(Produto produto)
        {
            MySqlConnection Conexao = new MySqlConnection();
            Conexao.ConnectionString = "server=35.193.155.168;user id=admin;password=1022890244Gui;persistsecurityinfo=True;database=dbpasswordsbook";

            MySqlCommand Comando = new MySqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "INSERT PRODUTOS (DS_PRODUTO, VR_VENDA, DS_CATEGORIA) VALUES (@DescricaoProduto, @Preco, @Categoria)";
            Comando.Parameters.Add("DescricaoProduto", MySqlDbType.VarChar).Value = produto.DescricaoProduto;
            Comando.Parameters.Add("Preco", MySqlDbType.VarChar).Value = produto.Preco;
            Comando.Parameters.Add("Categoria", MySqlDbType.VarChar).Value = produto.Categoria;

            Conexao.Open();
            Comando.ExecuteNonQuery();

            Comando.CommandText = "SELECT MAX(COD_PRODUTO) FROM PRODUTOS";
            return int.Parse(Comando.ExecuteScalar().ToString());
        }
        public static List<Produto> BuscarProdutoDAL(string[] filtros)
        {
            MySqlConnection Conexao = new MySqlConnection();
            Conexao.ConnectionString = "server=35.193.155.168;user id=admin;password=1022890244Gui;persistsecurityinfo=True;database=dbpasswordsbook";

            MySqlCommand Comando = new MySqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "SELECT COD_PRODUTO, DS_PRODUTO, VR_VENDA, DS_CATEGORIA FROM PRODUTOS WHERE 1 = 1";

            if (filtros[0] != String.Empty)
            {
                Comando.CommandText += " AND DS_PRODUTO LIKE '%' +@Descricao + '%' ";
                Comando.Parameters.Add("Descricao", MySqlDbType.VarChar).Value = filtros[0];
            }

            if (filtros[1] != String.Empty)
            {
                Comando.CommandText += " AND DS_CATEGORIA LIKE '%' +@Categoria + '%' ";
                Comando.Parameters.Add("Categoria", MySqlDbType.VarChar).Value = filtros[1];
            }

            Conexao.Open();
            MySqlDataReader Dr = Comando.ExecuteReader();

            List<Produto> Produtos = new List<Produto>();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    Produto produto = new Produto();
                    produto.CodProduto = Convert.ToInt32(Dr["COD_PRODUTO"]);
                    produto.DescricaoProduto = Convert.ToString(Dr["DS_PRODUTO"]);
                    produto.Preco = Convert.ToString(Dr["VR_VENDA"].ToString());
                    produto.Categoria = Convert.ToString(Dr["DS_CATEGORIA"]);


                    Produtos.Add(produto);
                }
            }

            return Produtos;
        }
        public static void AtualizarProdutoDAL(Produto produto)
        {
            MySqlConnection Conexao = new MySqlConnection();
            Conexao.ConnectionString = "server=35.193.155.168;user id=admin;password=1022890244Gui;persistsecurityinfo=True;database=dbpasswordsbook";

            MySqlCommand Comando = new MySqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "UPDATE PRODUTOS SET DS_PRODUTO = @Descricao, VR_VENDA = @Preco, DS_CATEGORIA = @Categoria WHERE COD_PRODUTO = @CodProduto";
            Comando.Parameters.Add("Descricao", MySqlDbType.VarChar).Value = produto.DescricaoProduto;
            Comando.Parameters.Add("Preco", MySqlDbType.VarChar).Value = produto.Preco;
            Comando.Parameters.Add("CodProduto", MySqlDbType.Int32).Value = produto.CodProduto;
            Comando.Parameters.Add("Categoria", MySqlDbType.VarChar).Value = produto.Categoria;

            Conexao.Open();
            Comando.ExecuteNonQuery();
        }
        public static void ExcluirProdutoDAL(int CodigoProduto)
        {
            MySqlConnection Conexao = new MySqlConnection();
            Conexao.ConnectionString = "server=35.193.155.168;user id=admin;password=1022890244Gui;persistsecurityinfo=True;database=dbpasswordsbook";

            MySqlCommand Comando = new MySqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "DELETE PRODUTOS WHERE COD_PRODUTO = @CodigoProduto";
            Comando.Parameters.Add("CodigoProduto", MySqlDbType.Int32).Value = CodigoProduto;

            Conexao.Open();
            Comando.ExecuteNonQuery();
        }
        public static Produto BuscarProdutoDAL(int CodigoProduto)
        {
            MySqlConnection Conexao = new MySqlConnection();
            Conexao.ConnectionString = "server=35.193.155.168;user id=admin;password=1022890244Gui;persistsecurityinfo=True;database=dbpasswordsbook";

            MySqlCommand Comando = new MySqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT COD_PRODUTO, DS_PRODUTO, VR_VENDA, DS_CATEGORIA FROM PRODUTOS WHERE COD_PRODUTO = @CODPRODUTO";
            Comando.Parameters.Add("CODPRODUTO", MySqlDbType.Int32).Value = CodigoProduto;

            Conexao.Open();
            MySqlDataReader Dr = Comando.ExecuteReader();

            Produto Produto = new Produto();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    Produto.CodProduto = Convert.ToInt32(Dr["COD_PRODUTO"]);
                    Produto.DescricaoProduto = Convert.ToString(Dr["DS_PRODUTO"]);
                    Produto.Preco = Convert.ToString(Dr["VR_VENDA"]);
                    Produto.Categoria = Convert.ToString(Dr["DS_CATEGORIA"]);

                }
            }

            return Produto;
        }

        public static int InserirPedidoDAL(Pedido pedido)
        {
            MySqlConnection Conexao = new MySqlConnection();
            Conexao.ConnectionString = "server=35.193.155.168;user id=admin;password=1022890244Gui;persistsecurityinfo=True;database=dbpasswordsbook";

            MySqlCommand Comando = new MySqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "INSERT PEDIDOS (COD_CLIENTE_PEDIDO, VR_TOTAL_PEDIDO, OBS_PEDIDO) VALUES (@CodCliente, @VR_TOTAL_PEDIDO, @OBS_PEDIDO)";
            Comando.Parameters.Add("CodCliente", MySqlDbType.VarChar).Value = pedido.CodCliente;
            Comando.Parameters.Add("VR_TOTAL_PEDIDO", MySqlDbType.Float).Value = pedido.ValorTotalPedido;
            Comando.Parameters.Add("OBS_PEDIDO", MySqlDbType.VarChar).Value = pedido.ObservacaoPedido;


            Conexao.Open();
            Comando.ExecuteNonQuery();

            Comando.CommandText = "SELECT MAX(COD_PEDIDO) FROM PEDIDOS";
            return int.Parse(Comando.ExecuteScalar().ToString());
        }

        public static int InserirItemDAL(Item_Venda item)
        {
            MySqlConnection Conexao = new MySqlConnection();
            Conexao.ConnectionString = "server=35.193.155.168;user id=admin;password=1022890244Gui;persistsecurityinfo=True;database=dbpasswordsbook";

            MySqlCommand Comando = new MySqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "INSERT ITENS_VENDAS (COD_PRODUTO) VALUES (@COD_PRODUTO)";
            Comando.Parameters.Add("COD_PRODUTO", MySqlDbType.VarChar).Value = item.CodProduto;

            Conexao.Open();
            Comando.ExecuteNonQuery();

            Comando.CommandText = "SELECT MAX(COD_PEDIDO) FROM ITENS_VENDAS";
            return int.Parse(Comando.ExecuteScalar().ToString());
        }
    }
}
