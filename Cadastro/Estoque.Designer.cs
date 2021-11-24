
namespace Cadastro
{
    partial class Estoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbFornProd = new System.Windows.Forms.TextBox();
            this.btnLimparEstoque = new System.Windows.Forms.Button();
            this.mtbIDEstoque = new System.Windows.Forms.MaskedTextBox();
            this.mtbQuantidadeProduto = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisarEstoque = new System.Windows.Forms.Button();
            this.btnDeletarEstoque = new System.Windows.Forms.Button();
            this.btnAtualizarEstoque = new System.Windows.Forms.Button();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCadastrarEstoque = new System.Windows.Forms.Button();
            this.mtbContatoFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.mtbDiaEntradaProd = new System.Windows.Forms.MaskedTextBox();
            this.tbCategoriaProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbPrecoUnProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNomeProduto = new System.Windows.Forms.TextBox();
            this.lblNomePet = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnRegistro);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblRegistro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 124);
            this.panel1.TabIndex = 1;
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.Color.Black;
            this.btnRegistro.Location = new System.Drawing.Point(851, 76);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(82, 45);
            this.btnRegistro.TabIndex = 16;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cadastro.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(936, -92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblRegistro
            // 
            this.lblRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblRegistro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRegistro.Location = new System.Drawing.Point(12, 34);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(128, 41);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "Estoque";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.tbFornProd);
            this.panel2.Controls.Add(this.btnLimparEstoque);
            this.panel2.Controls.Add(this.mtbIDEstoque);
            this.panel2.Controls.Add(this.mtbQuantidadeProduto);
            this.panel2.Controls.Add(this.btnPesquisarEstoque);
            this.panel2.Controls.Add(this.btnDeletarEstoque);
            this.panel2.Controls.Add(this.btnAtualizarEstoque);
            this.panel2.Controls.Add(this.dgvEstoque);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnCadastrarEstoque);
            this.panel2.Controls.Add(this.mtbContatoFornecedor);
            this.panel2.Controls.Add(this.mtbDiaEntradaProd);
            this.panel2.Controls.Add(this.tbCategoriaProduto);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.mtbPrecoUnProduto);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbNomeProduto);
            this.panel2.Controls.Add(this.lblNomePet);
            this.panel2.Location = new System.Drawing.Point(12, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1240, 534);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefresh.Location = new System.Drawing.Point(782, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 45);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tbFornProd
            // 
            this.tbFornProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFornProd.Location = new System.Drawing.Point(933, 299);
            this.tbFornProd.Name = "tbFornProd";
            this.tbFornProd.Size = new System.Drawing.Size(261, 23);
            this.tbFornProd.TabIndex = 4;
            // 
            // btnLimparEstoque
            // 
            this.btnLimparEstoque.BackColor = System.Drawing.Color.Black;
            this.btnLimparEstoque.FlatAppearance.BorderSize = 0;
            this.btnLimparEstoque.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparEstoque.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimparEstoque.Location = new System.Drawing.Point(933, 481);
            this.btnLimparEstoque.Name = "btnLimparEstoque";
            this.btnLimparEstoque.Size = new System.Drawing.Size(261, 33);
            this.btnLimparEstoque.TabIndex = 10;
            this.btnLimparEstoque.Text = "Limpar Campos";
            this.btnLimparEstoque.UseVisualStyleBackColor = false;
            this.btnLimparEstoque.Click += new System.EventHandler(this.btnLimparEstoque_Click);
            // 
            // mtbIDEstoque
            // 
            this.mtbIDEstoque.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbIDEstoque.Location = new System.Drawing.Point(49, 23);
            this.mtbIDEstoque.Mask = "0000000000";
            this.mtbIDEstoque.Name = "mtbIDEstoque";
            this.mtbIDEstoque.Size = new System.Drawing.Size(125, 23);
            this.mtbIDEstoque.TabIndex = 11;
            this.mtbIDEstoque.ValidatingType = typeof(int);
            // 
            // mtbQuantidadeProduto
            // 
            this.mtbQuantidadeProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbQuantidadeProduto.Location = new System.Drawing.Point(933, 169);
            this.mtbQuantidadeProduto.Mask = "000";
            this.mtbQuantidadeProduto.Name = "mtbQuantidadeProduto";
            this.mtbQuantidadeProduto.Size = new System.Drawing.Size(87, 23);
            this.mtbQuantidadeProduto.TabIndex = 1;
            this.mtbQuantidadeProduto.ValidatingType = typeof(int);
            // 
            // btnPesquisarEstoque
            // 
            this.btnPesquisarEstoque.BackColor = System.Drawing.Color.Black;
            this.btnPesquisarEstoque.FlatAppearance.BorderSize = 0;
            this.btnPesquisarEstoque.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarEstoque.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisarEstoque.Location = new System.Drawing.Point(192, 10);
            this.btnPesquisarEstoque.Name = "btnPesquisarEstoque";
            this.btnPesquisarEstoque.Size = new System.Drawing.Size(82, 45);
            this.btnPesquisarEstoque.TabIndex = 12;
            this.btnPesquisarEstoque.Text = "Pesquisar";
            this.btnPesquisarEstoque.UseVisualStyleBackColor = false;
            this.btnPesquisarEstoque.Click += new System.EventHandler(this.btnPesquisarEstoque_Click);
            // 
            // btnDeletarEstoque
            // 
            this.btnDeletarEstoque.BackColor = System.Drawing.Color.Black;
            this.btnDeletarEstoque.FlatAppearance.BorderSize = 0;
            this.btnDeletarEstoque.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarEstoque.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeletarEstoque.Location = new System.Drawing.Point(1112, 418);
            this.btnDeletarEstoque.Name = "btnDeletarEstoque";
            this.btnDeletarEstoque.Size = new System.Drawing.Size(82, 45);
            this.btnDeletarEstoque.TabIndex = 9;
            this.btnDeletarEstoque.Text = "Deletar";
            this.btnDeletarEstoque.UseVisualStyleBackColor = false;
            this.btnDeletarEstoque.Click += new System.EventHandler(this.btnDeletarEstoque_Click);
            // 
            // btnAtualizarEstoque
            // 
            this.btnAtualizarEstoque.BackColor = System.Drawing.Color.Black;
            this.btnAtualizarEstoque.FlatAppearance.BorderSize = 0;
            this.btnAtualizarEstoque.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarEstoque.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAtualizarEstoque.Location = new System.Drawing.Point(1023, 418);
            this.btnAtualizarEstoque.Name = "btnAtualizarEstoque";
            this.btnAtualizarEstoque.Size = new System.Drawing.Size(82, 45);
            this.btnAtualizarEstoque.TabIndex = 8;
            this.btnAtualizarEstoque.Text = "Atualizar";
            this.btnAtualizarEstoque.UseVisualStyleBackColor = false;
            this.btnAtualizarEstoque.Click += new System.EventHandler(this.btnAtualizarEstoque_Click);
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Location = new System.Drawing.Point(12, 73);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.Size = new System.Drawing.Size(852, 441);
            this.dgvEstoque.TabIndex = 12;
            this.dgvEstoque.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstoque_CellClick);
            this.dgvEstoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstoque_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID";
            // 
            // btnCadastrarEstoque
            // 
            this.btnCadastrarEstoque.BackColor = System.Drawing.Color.Black;
            this.btnCadastrarEstoque.FlatAppearance.BorderSize = 0;
            this.btnCadastrarEstoque.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarEstoque.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarEstoque.Location = new System.Drawing.Point(933, 418);
            this.btnCadastrarEstoque.Name = "btnCadastrarEstoque";
            this.btnCadastrarEstoque.Size = new System.Drawing.Size(82, 45);
            this.btnCadastrarEstoque.TabIndex = 7;
            this.btnCadastrarEstoque.Text = "Cadastrar";
            this.btnCadastrarEstoque.UseVisualStyleBackColor = false;
            this.btnCadastrarEstoque.Click += new System.EventHandler(this.btnCadastrarEstoque_Click);
            // 
            // mtbContatoFornecedor
            // 
            this.mtbContatoFornecedor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbContatoFornecedor.Location = new System.Drawing.Point(1048, 365);
            this.mtbContatoFornecedor.Mask = "(99) 00000-0000";
            this.mtbContatoFornecedor.Name = "mtbContatoFornecedor";
            this.mtbContatoFornecedor.Size = new System.Drawing.Size(146, 23);
            this.mtbContatoFornecedor.TabIndex = 6;
            // 
            // mtbDiaEntradaProd
            // 
            this.mtbDiaEntradaProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDiaEntradaProd.Location = new System.Drawing.Point(933, 365);
            this.mtbDiaEntradaProd.Mask = "00/00/0000";
            this.mtbDiaEntradaProd.Name = "mtbDiaEntradaProd";
            this.mtbDiaEntradaProd.Size = new System.Drawing.Size(87, 23);
            this.mtbDiaEntradaProd.TabIndex = 5;
            this.mtbDiaEntradaProd.ValidatingType = typeof(System.DateTime);
            // 
            // tbCategoriaProduto
            // 
            this.tbCategoriaProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCategoriaProduto.Location = new System.Drawing.Point(933, 233);
            this.tbCategoriaProduto.Name = "tbCategoriaProduto";
            this.tbCategoriaProduto.Size = new System.Drawing.Size(261, 23);
            this.tbCategoriaProduto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(930, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1045, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Contato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(930, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dia Entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(930, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fornecedor";
            // 
            // mtbPrecoUnProduto
            // 
            this.mtbPrecoUnProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPrecoUnProduto.Location = new System.Drawing.Point(1048, 169);
            this.mtbPrecoUnProduto.Name = "mtbPrecoUnProduto";
            this.mtbPrecoUnProduto.Size = new System.Drawing.Size(146, 23);
            this.mtbPrecoUnProduto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1045, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Preço Unitário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(930, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade";
            // 
            // tbNomeProduto
            // 
            this.tbNomeProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeProduto.Location = new System.Drawing.Point(933, 105);
            this.tbNomeProduto.Name = "tbNomeProduto";
            this.tbNomeProduto.Size = new System.Drawing.Size(261, 23);
            this.tbNomeProduto.TabIndex = 0;
            // 
            // lblNomePet
            // 
            this.lblNomePet.AutoSize = true;
            this.lblNomePet.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePet.Location = new System.Drawing.Point(930, 73);
            this.lblNomePet.Name = "lblNomePet";
            this.lblNomePet.Size = new System.Drawing.Size(58, 17);
            this.lblNomePet.TabIndex = 0;
            this.lblNomePet.Text = "Produto";
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Estoque_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLimparEstoque;
        private System.Windows.Forms.MaskedTextBox mtbIDEstoque;
        private System.Windows.Forms.MaskedTextBox mtbQuantidadeProduto;
        private System.Windows.Forms.Button btnPesquisarEstoque;
        private System.Windows.Forms.Button btnDeletarEstoque;
        private System.Windows.Forms.Button btnAtualizarEstoque;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCadastrarEstoque;
        private System.Windows.Forms.MaskedTextBox mtbContatoFornecedor;
        private System.Windows.Forms.MaskedTextBox mtbDiaEntradaProd;
        private System.Windows.Forms.TextBox tbCategoriaProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNomeProduto;
        private System.Windows.Forms.Label lblNomePet;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.TextBox tbFornProd;
        private System.Windows.Forms.TextBox mtbPrecoUnProduto;
        private System.Windows.Forms.Button btnRefresh;
    }
}