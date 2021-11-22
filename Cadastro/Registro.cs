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
using System.Globalization;
using NPOI.SS.Util;

namespace Cadastro
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        //Limpa os campos de registro
        public void Clear()
        {
            tbNomePet.Text = tbNomeCliente.Text = tbRacaPet.Text = tbServico.Text = mtbDia.Text = mtbHora.Text = string.Empty;
            mtbID.ResetText();
            mtbIdadePet.ResetText();
        }

        //Carrega as informções da Classe Cadastro no DataGridView
        private void Registro_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Agendamento;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM AgendamentoPets", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCadastros.DataSource = dt;

        }

        //Atualiza as informções da Classe Cadastro no DataGridView
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Agendamento;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
                     

            SqlCommand cmd = new SqlCommand("UPDATE AgendamentoPets SET nomePet=@nomePet, idadePet=@idadePet, racaPet=@racaPet, nomeCliente=@nomeCliente, diaAgendado=@diaAgendado, horaAgendada=@horaAgendada, servicoAgendado=@servicoAgendado WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", mtbID.Text);
            cmd.Parameters.AddWithValue("@nomePet", tbNomePet.Text);
            cmd.Parameters.AddWithValue("@idadePet", mtbIdadePet.Text);
            cmd.Parameters.AddWithValue("@racaPet", tbRacaPet.Text);
            cmd.Parameters.AddWithValue("@nomeCliente", tbNomeCliente.Text);
            cmd.Parameters.AddWithValue("@diaAgendado", mtbDia.Text);
            cmd.Parameters.AddWithValue("@horaAgendada", mtbHora.Text);
            cmd.Parameters.AddWithValue("@servicoAgendado", tbServico.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Atualizado com sucesso!");
            Clear();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Agendamento;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM AgendamentoPets WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", mtbID.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCadastros.DataSource = dt;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (tbNomePet.Text.Trim().Length < 1)
            {
                MessageBox.Show("Nome Pet está vazio");
                return;
            }
            if (mtbIdadePet.Text.Trim().Length < 1)
            {
                MessageBox.Show("Idade Pet está vazio");
                return;
            }
            if (tbRacaPet.Text.Trim().Length < 1)
            {
                MessageBox.Show("Raça Pet está vazio");
                return;
            }
            if (tbNomeCliente.Text.Trim().Length < 1)
            {
                MessageBox.Show("Nome Cliente está vazio");
                return;
            }
            if (mtbDia.Text.Trim().Length < 1)
            {
                MessageBox.Show("Dia está vazio");
                return;
            }
            if (mtbHora.Text.Trim().Length < 1)
            {
                MessageBox.Show("Hora está vazio");
                return;
            }
            if (tbServico.Text.Trim().Length < 1)
            {
                MessageBox.Show("Serviço está vazio");
                return;
            }

            string horario = mtbHora.Text;
            string horaMax = "17:01";
            string horaMin = "07:59";
            DateTime DateObject = Convert.ToDateTime(horario);
            DateTime dataMax = Convert.ToDateTime(horaMax);
            DateTime dataMin = Convert.ToDateTime(horaMin);

            if (DateObject >= dataMax || DateObject <= dataMin)
            {
                MessageBox.Show("Fora do horário de trabalho, 08:00 às 17:00");
            }
            else
            {

                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Agendamento;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO AgendamentoPets(nomePet, idadePet, racaPet, nomeCliente, diaAgendado, horaAgendada, servicoAgendado) VALUES (@nomePet, @idadePet, @racaPet, @nomeCliente, @diaAgendado, @horaAgendada, @servicoAgendado)", con);
                cmd.Parameters.AddWithValue("@nomePet", tbNomePet.Text);
                cmd.Parameters.AddWithValue("@idadePet", mtbIdadePet.Text);
                cmd.Parameters.AddWithValue("@racaPet", tbRacaPet.Text);
                cmd.Parameters.AddWithValue("@nomeCliente", tbNomeCliente.Text);
                cmd.Parameters.AddWithValue("@diaAgendado", mtbDia.Text);
                cmd.Parameters.AddWithValue("@horaAgendada", mtbHora.Text);
                cmd.Parameters.AddWithValue("@servicoAgendado", tbServico.Text);

                cmd.ExecuteNonQuery();


                MessageBox.Show("Cadastrado com sucesso!");
                Clear();

                SqlCommand cmdd = new SqlCommand("SELECT * FROM AgendamentoPets", con);
                SqlDataAdapter da = new SqlDataAdapter(cmdd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCadastros.DataSource = dt;
            }




        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Agendamento;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();


            SqlCommand cmd = new SqlCommand("DELETE AgendamentoPets WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", mtbID.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Deletado com sucesso!");
            Clear();


            SqlCommand cmdd = new SqlCommand("SELECT * FROM AgendamentoPets", con);
            SqlDataAdapter da = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCadastros.DataSource = dt;

        }

        private void dgvCadastros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCadastros.Rows [e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                mtbID.Text = dgvCadastros.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                tbNomePet.Text = dgvCadastros.Rows[e.RowIndex].Cells["nomePet"].FormattedValue.ToString();
                mtbIdadePet.Text = dgvCadastros.Rows[e.RowIndex].Cells["idadePet"].FormattedValue.ToString();
                tbRacaPet.Text = dgvCadastros.Rows[e.RowIndex].Cells["racaPet"].FormattedValue.ToString();
                tbNomeCliente.Text = dgvCadastros.Rows[e.RowIndex].Cells["nomeCliente"].FormattedValue.ToString();
                mtbDia.Text = dgvCadastros.Rows[e.RowIndex].Cells["diaAgendado"].FormattedValue.ToString();
                mtbHora.Text = dgvCadastros.Rows[e.RowIndex].Cells["horaAgendada"].FormattedValue.ToString();
                tbServico.Text = dgvCadastros.Rows[e.RowIndex].Cells["servicoAgendado"].FormattedValue.ToString();

            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Clear();
        }


        private void btnEstoque__Click(object sender, EventArgs e)
        {
            this.Close();
            Estoque estoque = new Estoque();
            estoque.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Agendamento;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            SqlCommand cmdd = new SqlCommand("SELECT * FROM AgendamentoPets", con);
            SqlDataAdapter da = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCadastros.DataSource = dt;
        }
    }
}
