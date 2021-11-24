using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Cadastro
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }

        //Limpa os campos do frm
        public void Clear()
        {
            tbCategoriaProduto.Text = tbNomeProduto.Text = tbFornProd.Text = string.Empty;
            mtbContatoFornecedor.ResetText(); 
            mtbDiaEntradaProd.ResetText(); 
            mtbIDEstoque.ResetText(); 
            mtbPrecoUnProduto.ResetText(); 
            mtbQuantidadeProduto.ResetText();
        }

        //Pesquisa com base no ID no BD
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Agendamento;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM EstoqueProduto WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", mtbIDEstoque);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvEstoque.DataSource = dt;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //Cadastra no BD
        private void btnCadastrarEstoque_Click(object sender, EventArgs e)
        {
            //Verifica os frm se não estão vazios
            if (tbNomeProduto.Text.Trim().Length < 1)
            {
                MessageBox.Show("Nome Produto está vazio");
                return;
            }
            if (mtbQuantidadeProduto.Text.Trim().Length < 1)
            {
                MessageBox.Show("Quantidade do Produto está vazio");
                return;
            }
            if (mtbPrecoUnProduto.Text.Trim().Length < 1)
            {
                MessageBox.Show("Preço Unitário do Produto está vazio");
                return;
            }
            if (tbCategoriaProduto.Text.Trim().Length < 1)
            {
                MessageBox.Show("Categoria do Produto está vazio");
                return;
            }
            if (tbFornProd.Text.Trim().Length < 1)
            {
                MessageBox.Show("Fornecedor está vazio");
                return;
            }
            if (mtbDiaEntradaProd.Text.Trim().Length < 1)
            {
                MessageBox.Show("Dia Entrada Produto está vazio");
                return;
            }
            if (mtbContatoFornecedor.Text.Trim().Length < 1)
            {
                MessageBox.Show("Contato Fornecedor está vazio");
                return;
            }

            //Insere no BD
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Agendamento;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO EstoqueProduto (nomeProduto, qtdProduto, precoProduto, categoriaProduto, fornecedorProduto, diaEntradaProduto, contatoFornecedor) VALUES (@nomeProduto, @qtdProduto, @precoProduto, @categoriaProduto, @fornecedorProduto, @diaEntradaProduto, @contatoFornecedor)", con);
            cmd.Parameters.AddWithValue("@nomeProduto", tbNomeProduto.Text);
            cmd.Parameters.AddWithValue("@qtdProduto", mtbQuantidadeProduto.Text);
            cmd.Parameters.AddWithValue("@precoProduto", mtbPrecoUnProduto.Text);
            cmd.Parameters.AddWithValue("@categoriaProduto", tbCategoriaProduto.Text);
            cmd.Parameters.AddWithValue("@fornecedorProduto", tbFornProd.Text);
            cmd.Parameters.AddWithValue("@diaEntradaProduto", mtbDiaEntradaProd.Text);
            cmd.Parameters.AddWithValue("@contatoFornecedor", mtbContatoFornecedor.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Cadastrado com sucesso!");
            Clear();

            SqlCommand cmdd = new SqlCommand("SELECT * FROM EstoqueProduto", con);
            SqlDataAdapter da = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvEstoque.DataSource = dt;
        }

        //Atualiza no BD
        private void btnAtualizarEstoque_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Agendamento;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();


            SqlCommand cmd = new SqlCommand("UPDATE EstoqueProduto SET nomeProduto=@nomeProduto, qtdProduto=@qtdProduto, precoProduto=@precoProduto, categoriaProduto=@categoriaProduto, fornecedorProduto=@fornecedorProduto, diaEntradaProduto=@diaEntradaProduto, contatoFornecedor=@contatoFornecedor WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", mtbIDEstoque.Text);
            cmd.Parameters.AddWithValue("@nomeProduto", tbNomeProduto.Text);
            cmd.Parameters.AddWithValue("@qtdProduto", mtbQuantidadeProduto.Text);
            cmd.Parameters.AddWithValue("@precoProduto", mtbPrecoUnProduto.Text);
            cmd.Parameters.AddWithValue("@categoriaProduto", tbCategoriaProduto.Text);
            cmd.Parameters.AddWithValue("@fornecedorProduto", tbFornProd.Text);
            cmd.Parameters.AddWithValue("@diaEntradaProduto", mtbDiaEntradaProd.Text);
            cmd.Parameters.AddWithValue("@contatoFornecedor", mtbContatoFornecedor.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Atualizado com sucesso!");
            Clear();
        }

        //Deleta no BD
        private void btnDeletarEstoque_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Agendamento;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();


            SqlCommand cmd = new SqlCommand("DELETE EstoqueProduto WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", mtbIDEstoque.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Deletado com sucesso!");
            Clear();


            SqlCommand cmdd = new SqlCommand("SELECT * FROM EstoqueProduto", con);
            SqlDataAdapter da = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvEstoque.DataSource = dt;
        }

        //Limpa o frm
        private void btnLimparEstoque_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //Pesquisa no BD
        private void btnPesquisarEstoque_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Agendamento;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM EstoqueProduto WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", mtbIDEstoque.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvEstoque.DataSource = dt;
        }

        //Pega as informações do dgv para colocar no frm
        private void dgvEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEstoque.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                mtbIDEstoque.Text = dgvEstoque.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                tbNomeProduto.Text = dgvEstoque.Rows[e.RowIndex].Cells["nomeProduto"].FormattedValue.ToString();
                mtbQuantidadeProduto.Text = dgvEstoque.Rows[e.RowIndex].Cells["qtdProduto"].FormattedValue.ToString();
                mtbPrecoUnProduto.Text = dgvEstoque.Rows[e.RowIndex].Cells["precoProduto"].FormattedValue.ToString();
                tbCategoriaProduto.Text = dgvEstoque.Rows[e.RowIndex].Cells["categoriaProduto"].FormattedValue.ToString();
                tbFornProd.Text = dgvEstoque.Rows[e.RowIndex].Cells["fornecedorProduto"].FormattedValue.ToString();
                mtbDiaEntradaProd.Text = dgvEstoque.Rows[e.RowIndex].Cells["diaEntradaProduto"].FormattedValue.ToString();
                mtbContatoFornecedor.Text = dgvEstoque.Rows[e.RowIndex].Cells["contatoFornecedor"].FormattedValue.ToString();

            }

        }
        //Carrega as informações no BD
        private void Estoque_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Agendamento;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM EstoqueProduto", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvEstoque.DataSource = dt;
        }
        //Vai para a tela registro
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            this.Close();
            Registro registro = new Registro();
            registro.Show();
        }

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Atualiza o dgv
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Agendamento;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            SqlCommand cmdd = new SqlCommand("SELECT * FROM EstoqueProduto", con);
            SqlDataAdapter da = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvEstoque.DataSource = dt;
        }
    }
}
