using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {

            Registro registro = new Registro();
            registro.Show();
        }

        private void btnEstoques_Click(object sender, EventArgs e)
        {

            Estoque estoque = new Estoque();
            estoque.Show();
        }

        private void btnCadastros_MouseHover(object sender, EventArgs e)
        {
            btnCadastros.BackColor = Color.DimGray;
        }

        private void btnCadastros_MouseLeave(object sender, EventArgs e)
        {
            btnCadastros.BackColor = Color.Black;
        }

        private void btnEstoques_MouseHover(object sender, EventArgs e)
        {
            btnEstoques.BackColor = Color.DimGray;
        }

        private void btnEstoques_MouseLeave(object sender, EventArgs e)
        {
            btnEstoques.BackColor = Color.Black;
        }
    }
}
