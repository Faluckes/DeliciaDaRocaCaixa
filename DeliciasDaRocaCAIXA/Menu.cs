using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliciasDaRocaCAIXA
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void Pagamentos_Click(object sender, EventArgs e)
        {
            DeliciasDaRoca delicia = new DeliciasDaRoca();
            this.Hide();
            delicia.ShowDialog();
        }

        private void listadeprodutos_Click(object sender, EventArgs e)
        {
            ListaProdutos listaproduto = new ListaProdutos();
            this.Hide();
            listaproduto.ShowDialog();
        }
    }
}
