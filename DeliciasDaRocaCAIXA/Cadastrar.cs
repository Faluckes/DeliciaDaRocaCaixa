using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliciasDaRocaCAIXA
{
    public class Cadastrar
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string menssagem = "";


        public Cadastrar(string idproduto, string nome, string quantidade, string preco, string peso, string tipoproduto, string tipopeso, string precototal)
        {
            
            cmd.CommandText = "INSERT INTO [tb_produto] (IdProduto, Nome, Quantidade, Peso, TipoDePeso, Valor, TipoProduto, ValorTotal) values (@IdProduto, @Nome, @Quantidade, @Peso, @TipoDePeso, @Valor, @TipoProduto, @ValorTotal)";
            cmd.Parameters.AddWithValue("@IdProduto", idproduto);
            cmd.Parameters.AddWithValue("@Nome", nome);
            cmd.Parameters.AddWithValue("@Quantidade", quantidade);
            cmd.Parameters.AddWithValue("@Peso", peso);
            cmd.Parameters.AddWithValue("@TipoDePeso", tipopeso.Substring(0, 1));
            cmd.Parameters.AddWithValue("@Valor", preco);
            cmd.Parameters.AddWithValue("@TipoProduto", tipoproduto.Substring(0, 1));
            cmd.Parameters.AddWithValue("@ValorTotal", precototal);




            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.menssagem = "Cadastrado com Sucesso!";
            }
            catch (SqlException e)
            {
                this.menssagem = "Ocorreu um erro ao se conectar ao Banco de dados \n \n" + e;  
            }

        }


    }




}
