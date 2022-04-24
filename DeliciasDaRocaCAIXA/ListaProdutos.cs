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
    public partial class ListaProdutos : Form
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();


        public ListaProdutos()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Conectando, Aguarde";
            statusStrip1.Refresh();

            try
            {

                conexao.conectar();


                var sqlQuery = cmd.CommandText = "SELECT * FROM tb_produto";
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, conexao.conectar()))
                {
                    using (DataTable data = new DataTable())
                    {
                        adapter.Fill(data);
                        dataGridView1.DataSource = data;
                    }
                }

            }
            catch (SqlException ex)
            {
                toolStripStatusLabel1.Text = "Falha ao se conectar no Banco de Dados";
                statusStrip1.Refresh();

            }
            toolStripStatusLabel1.Text = "Conectado ao Banco de Dados";
        }

        private void ListaProdutos_Load(object sender, EventArgs e)
        {

        }

        private void Conectar_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Conectando, Aguarde";
            statusStrip1.Refresh();

            try
            {

                conexao.conectar();


                var sqlQuery = cmd.CommandText = "SELECT * FROM tb_produto WHERE [Tipo Produto] like '%" + txtbuscarprodutos.Text + "%' Order by Nome ";
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, conexao.conectar()))
                {
                    using (DataTable data = new DataTable())
                    {
                        adapter.Fill(data);
                        dataGridView1.DataSource = data;
                    }
                }

            }
            catch (SqlException ex)
            {
                toolStripStatusLabel1.Text = "Falha ao se conectar no Banco de Dados";
                statusStrip1.Refresh();

            }
            toolStripStatusLabel1.Text = "Conectado ao Banco de Dados";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdicionarProdutos adicionarprodutos = new AdicionarProdutos(0);
            adicionarprodutos.ShowDialog();
            

        }

        private void btnAlterarClick(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            AdicionarProdutos adicionarprodutos = new AdicionarProdutos(id);
            adicionarprodutos.ShowDialog();
        }

        private void btnExcluirClick(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);

            AdicionarProdutos adicionar = new AdicionarProdutos(id, true);
            adicionar.ShowDialog();
        }
    }
}
