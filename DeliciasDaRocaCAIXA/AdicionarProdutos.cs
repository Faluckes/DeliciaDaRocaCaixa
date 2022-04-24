using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliciasDaRocaCAIXA
{
    public partial class AdicionarProdutos : Form
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        

        int id = 0;
        public AdicionarProdutos(int IdProduto)
        {
            InitializeComponent();
            btnExcluir.Visible = false;
            toolStripStatusLabel1.Text = "Esperando...";
            statusStrip1.Refresh();
            this.id = IdProduto;
            if (this.id > 0)
            {
                GetProduto(id);
                btnSalvar.Visible = true;
                btnExcluir.Visible = false;
            }

        }
        public AdicionarProdutos(int idproduto, bool excluir)
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Esperando...";
            statusStrip1.Refresh();
            this.id = idproduto;
            if (excluir)
                if (this.id > 0)
                {
                    GetProduto(id);
                    TravarControles();
                    btnSalvar.Visible = false;
                    btnExcluir.Visible = true;
                }
                else
                    this.Close();
        }

        private void TravarControles()
        {
            txtidproduto.Enabled = false;
            txtnomeproduto.Enabled = false;
            txtquantidade.Enabled = false;
            txtpeso.Enabled = false;
            txtpreco.Enabled = false;
            boxtipoproduto.Enabled = false;
        }


        private void GetProduto(int id)
        {
            conexao.conectar();

            var Sql = cmd.CommandText = "SELECT * from tb_produto WHERE IdProduto=" + id;

            using (cmd = new SqlCommand(Sql, conexao.conectar()))
            {
                toolStripStatusLabel1.Text = "Buscando produto!";
                statusStrip1.Refresh();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            txtidproduto.Text = reader["IdProduto"].ToString();
                            txtnomeproduto.Text = reader["Nome"].ToString();
                            txtquantidade.Text = reader["Quantidade"].ToString();
                            txtpeso.Text = reader["Peso"].ToString();
                            txtpreco.Text = reader["Valor"].ToString();


                            switch (Convert.ToInt32(reader["[Tipo Produto]"]))
                            {
                                case 1:
                                    boxtipoproduto.Text = "1 Carne";
                                    break;
                                case 2:
                                    boxtipoproduto.Text = "2 Liquido";
                                    break;
                                case 3:
                                    boxtipoproduto.Text = "3 Industrial";
                                    break;
                                case 4:
                                    boxtipoproduto.Text = "4 Doce";
                                    break;
                                case 5:
                                    boxtipoproduto.Text = "5 Salgado";
                                    break;

                            }
                            switch (Convert.ToInt32(reader["Tipo de Peso"]))
                            {
                                case 1:
                                    boxtipopeso.Text = "G";
                                    break;
                                case 2:
                                    boxtipopeso.Text = "Kg";
                                    break;
                                case 3:
                                    boxtipopeso.Text = "Ml";
                                    break;
                                case 4:
                                    boxtipopeso.Text = "Litro";
                                    break;
                            }

                        }
                    }
                }
            }


        }

        private void AdicionarProdutos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sql = "";
            if (this.id == 0)
            {


                Cadastrar cadastrar = new Cadastrar(txtidproduto.Text, txtnomeproduto.Text, txtquantidade.Text, txtpreco.Text, txtpeso.Text, boxtipoproduto.Text, boxtipopeso.Text);
                if (txtidproduto.Text == string.Empty)
                {
                    MessageBox.Show(cadastrar.menssagem);
                }
                MessageBox.Show(cadastrar.menssagem);
                toolStripStatusLabel1.Text = "Erro '-'";
                statusStrip1.Refresh();
            }
            else
            {
                sql = "UPDATE tb_produto SET IdProduto=@IdProduto, Nome=@Nome, Quantidade=@Quantidade, Peso=@Peso, [Tipo Peso]=@[Tipo Peso], Valor=@Valor, [Tipo Produto]=@[Tipo Produto] WHERE IdProduto=" + this.id;

                MessageBox.Show("Alterado com sucesso!!");
                this.Hide();

                using (SqlCommand cmd = new SqlCommand(sql, conexao.conectar()))
                {
                    toolStripStatusLabel1.Text = "Salvando produto";
                    statusStrip1.Refresh();
                    double ValorTotal = Convert.ToDouble(txtpreco) * Convert.ToDouble(txtquantidade);
                    

                    cmd.Parameters.AddWithValue("@IdProduto", txtidproduto.Text);
                    cmd.Parameters.AddWithValue("@Nome", txtnomeproduto.Text);
                    cmd.Parameters.AddWithValue("@Quantidade", txtquantidade.Text);
                    cmd.Parameters.AddWithValue("@Peso", txtpeso.Text);
                    cmd.Parameters.AddWithValue("@Valor", txtpreco.Text.Replace(',', '.'));
                    cmd.Parameters.AddWithValue("@[Tipo Produto]", boxtipoproduto.Text.Substring(0, 1));
                    cmd.Parameters.AddWithValue("@[Tipo Peso]", boxtipopeso.Text.Substring(0, 4));
                    cmd.Parameters.AddWithValue("@[Valor Total]", ValorTotal);
                    cmd.ExecuteNonQuery();
                }
            }

        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja excluir:", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                ExcluirProduto();
                this.Close();
            }
        }

        private void ExcluirProduto()
        {
            toolStripStatusLabel1.Text = "Conectando...";
            statusStrip1.Refresh();

            try
            {
                conexao.conectar();
                var sql = "DELETE FROM tb_produto WHERE IdProduto=" + id;
                using (SqlCommand cmd = new SqlCommand(sql, conexao.conectar()))
                {
                    toolStripStatusLabel1.Text = "Excluindo Produto";
                    statusStrip1.Refresh();
                    cmd.ExecuteNonQuery();
                }
                toolStripStatusLabel1.Text = "Pronto";
                statusStrip1.Refresh();
            }
            catch(Exception ex)
            {
                toolStripStatusLabel1.Text = "Falha ao Excluir";
                statusStrip1.Refresh();
                MessageBox.Show("Falha ao excluir o Produto \n \n" + ex.Message);



            }
        }
    }
}
