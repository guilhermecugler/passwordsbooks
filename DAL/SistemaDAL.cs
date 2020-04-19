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

            Comando.CommandText = "INSERT tbCliente (clienteNome, clienteCPF, clienteLogin, clienteEmail, clienteSenha, clienteCartao, clienteTel, clienteTelCelular, clienteObs, clienteDN, clienteLogradouro, clienteNumero, clienteComplemento, clienteBairro, clienteCidade, clienteUF, clienteAtendente, clienteSiteIdFk) VALUES(@clienteNome, @clienteCPF, @clienteLogin, @clienteEmail, @clienteSenha, @clienteCartao, @clienteTel, @clienteTelCelular, @clienteObs, @clienteDN, @clienteLogradouro, @clienteNumero, @clienteComplemento, @clienteBairro, @clienteCidade, @clienteUF, @clienteAtendente, (SELECT siteId FROM tbSite WHERE siteNome =@Site))";

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
            Comando.Parameters.Add("Site", MySqlDbType.VarChar).Value = cliente.clienteSiteIdFk;

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

            Comando.CommandText = "SELECT c.clienteId, c.clienteNome, s.siteNome, c.clienteCPF, c.clienteLogin, c.clienteEmail, c.clienteSenha, c.clienteCartao, c.clienteTel, c.clienteTelCelular, c.clienteObs, c.clienteDN, c.clienteLogradouro, c.clienteNumero, c.clienteComplemento, c.clienteBairro, c.clienteCidade, c.clienteUF, c.clienteAtendente, s.siteLink FROM tbCliente AS c INNER JOIN tbSite AS s ON (c.clienteSiteIdFk=s.siteId) WHERE 1 = 1";

            if (filtros[0] != String.Empty)
            {
                    Comando.CommandText += " AND (clienteNome LIKE @Nome OR clienteCPF LIKE @Nome)";
                    Comando.Parameters.AddWithValue("@Nome", "%" + filtros[0] + "%");
            }
            if(filtros[1] != String.Empty)
            {
                Comando.CommandText += " AND s.siteNome LIKE @Site";;
                Comando.Parameters.AddWithValue("@Site", "%" + filtros[1] + "%");
            }

            Console.WriteLine(Comando.CommandText);

            Conexao.Open();
            MySqlDataReader Dr = Comando.ExecuteReader();

            List<Cliente> Clientes = new List<Cliente>();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = Convert.ToInt32(Dr["clienteId"]);
                    cliente.clienteSiteNome = Convert.ToString(Dr["siteNome"]);
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
                    cliente.clienteSiteLink = Convert.ToString(Dr["siteLink"]);


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
            Comando.CommandText = "SELECT c.clienteId, c.clienteNome, c.clienteCPF, c.clienteLogin, c.clienteEmail, c.clienteSenha, c.clienteCartao, c.clienteTel, c.clienteTelCelular, c.clienteObs, c.clienteDN, c.clienteLogradouro, c.clienteNumero, c.clienteComplemento, c.clienteBairro, c.clienteCidade, c.clienteUF, c.clienteAtendente, s.siteNome FROM tbCliente AS c INNER JOIN tbSite AS s ON (c.clienteSiteIdFk=s.siteId) WHERE clienteId = @IdCliente";
            Comando.Parameters.Add("IdCliente", MySqlDbType.Int32).Value = CodigoCliente;

            Conexao.Open();
            MySqlDataReader Dr = Comando.ExecuteReader();

            Cliente cliente = new Cliente();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    cliente.Id = Convert.ToInt32(Dr["clienteId"]);
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
                    cliente.clienteSiteNome = Convert.ToString(Dr["siteNome"]);
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
            Comando.CommandText = "UPDATE tbCliente SET clienteNome = @clienteNome, clienteCPF = @clienteCPF, clienteLogin = @clienteLogin, clienteEmail = @clienteEmail, clienteSenha = @clienteSenha, clienteCartao = @clienteCartao, clienteTel = @clienteTel, clienteTelCelular = @clienteTelCelular, clienteObs = @clienteObs, clienteDN = @clienteDN, clienteLogradouro = @clienteLogradouro, clienteNumero = @clienteNumero, clienteComplemento = @clienteComplemento, clienteBairro = @clienteBairro, clienteCidade = @clienteCidade, clienteUF = @clienteUF, clienteAtendente = @clienteAtendente WHERE clienteId = @IdCliente";
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
            Comando.Parameters.Add("IdCliente", MySqlDbType.Int32).Value = cliente.Id;

            Conexao.Open();
            Comando.ExecuteNonQuery();
        }

        public static List<Site> BuscarSites(string[] sites)
        {
            MySqlConnection Conexao = new MySqlConnection();
            Conexao.ConnectionString = "server=35.193.155.168;user id=admin;password=1022890244Gui;persistsecurityinfo=True;database=dbpasswordsbook";

            MySqlCommand Comando = new MySqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "SELECT DISTINCT siteNome FROM tbSite ORDER BY siteNome";

            Conexao.Open();
            MySqlDataReader Dr = Comando.ExecuteReader();

            List<Site> Sites = new List<Site>();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    Site site = new Site();
                    site.siteNome = Convert.ToString(Dr["siteNome"]);

                    Sites.Add(site);
                }
            }

            return Sites;
        }

        public static Site BuscarSiteDAL(int CodigoSite)
        {
            MySqlConnection Conexao = new MySqlConnection();
            Conexao.ConnectionString = "server=35.193.155.168;user id=admin;password=1022890244Gui;persistsecurityinfo=True;database=dbpasswordsbook";

            MySqlCommand Comando = new MySqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT siteId, siteNome, siteLink FROM tbSite WHERE siteId = @siteId";
            Comando.Parameters.Add("siteId", MySqlDbType.Int32).Value = CodigoSite;

            Conexao.Open();
            MySqlDataReader Dr = Comando.ExecuteReader();

            Site site = new Site();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    site.Id = Convert.ToInt32(Dr["siteId"]);
                    site.siteNome = Convert.ToString(Dr["siteNome"]);
                    site.siteLink = Convert.ToString(Dr["siteLink"]);
                }
            }

            return site;
        }
        public static void AtualizarSiteDAL(Site site)
        {
            MySqlConnection Conexao = new MySqlConnection();
            Conexao.ConnectionString = "server=35.193.155.168;user id=admin;password=1022890244Gui;persistsecurityinfo=True;database=dbpasswordsbook";

            MySqlCommand Comando = new MySqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "UPDATE tbSite SET siteNome = @siteNome, siteLink = @siteLink WHERE siteId= @siteId";
            Comando.Parameters.Add("siteNome", MySqlDbType.VarChar).Value = site.siteNome;
            Comando.Parameters.Add("siteLink", MySqlDbType.VarChar).Value = site.siteLink;
            Comando.Parameters.Add("siteId", MySqlDbType.Int32).Value = site.Id;

            Conexao.Open();
            Comando.ExecuteNonQuery();
        }

        public static int InserirSiteDAL(Site site)
        {
            MySqlConnection Conexao = new MySqlConnection();
            Conexao.ConnectionString = "server=35.193.155.168;user id=admin;password=1022890244Gui;persistsecurityinfo=True;database=dbpasswordsbook";

            MySqlCommand Comando = new MySqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "INSERT tbSite (siteNome, siteLink) VALUES(@siteNome, @siteLink)";

            Comando.Parameters.Add("siteNome", MySqlDbType.VarChar).Value = site.siteNome;
            Comando.Parameters.Add("siteLink", MySqlDbType.VarChar).Value = site.siteLink;
  
            Conexao.Open();
            Comando.ExecuteNonQuery();

            Comando.CommandText = "SELECT MAX(siteId) FROM tbSite";
            return int.Parse(Comando.ExecuteScalar().ToString());
        }

        public static List<Site> BuscarSiteDAL(string[] filtros)
        {
            MySqlConnection Conexao = new MySqlConnection();
            Conexao.ConnectionString = "server=35.193.155.168;user id=admin;password=1022890244Gui;persistsecurityinfo=True;database=dbpasswordsbook";

            MySqlCommand Comando = new MySqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "SELECT siteId, siteNome, siteLink FROM tbSite WHERE 1 = 1";

            if (filtros[0] != String.Empty)
            {
                Comando.CommandText += " AND (siteNome LIKE @Site OR siteLink LIKE @Site)";
                Comando.Parameters.AddWithValue("@Site", "%" + filtros[0] + "%");
            }

            Console.WriteLine(Comando.CommandText);

            Conexao.Open();
            MySqlDataReader Dr = Comando.ExecuteReader();

            List<Site> Sites = new List<Site>();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    Site site = new Site();
                    site.Id = Convert.ToInt32(Dr["siteId"]);
                    site.siteNome = Convert.ToString(Dr["siteNome"]);
                    site.siteLink = Convert.ToString(Dr["siteLink"]);

                    Sites.Add(site);
                }
            }

            return Sites;
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
