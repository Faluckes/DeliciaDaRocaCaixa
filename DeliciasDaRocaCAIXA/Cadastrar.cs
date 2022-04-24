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


        public Cadastrar(string idproduto, string nome, string quantidade, string preco, string peso, string tipoproduto, string tipopeso)
        {
            double precototal = Convert.ToDouble(preco) * Convert.ToDouble(quantidade);
            cmd.CommandText = "INSERT INTO [tb_produto] (IdProduto, Nome, Quantidade, Peso, [Tipo Peso], Valor, [Tipo Produto], [Valor Total]) values (@IdProduto, @Nome, @Quantidade, @Peso, @[Tipo Peso], @Valor, @[Tipo Produto], @[Valor Total])";
            cmd.Parameters.AddWithValue("@IdProduto", idproduto);
            cmd.Parameters.AddWithValue("@Nome", nome);
            cmd.Parameters.AddWithValue("@Quantidade", quantidade);
            cmd.Parameters.AddWithValue("@Peso", peso);
            cmd.Parameters.AddWithValue("@[Tipo Peso]", tipopeso.Substring(0, 1));
            cmd.Parameters.AddWithValue("@[Tipo Produto]", tipoproduto.Substring(0, 4));
            cmd.Parameters.AddWithValue("@Valor", Convert.ToDouble(preco.Replace(',', '.')));
            cmd.Parameters.AddWithValue("@[Valor Total]", precototal);
            


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
