
namespace Cadastro
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEstoques = new System.Windows.Forms.Button();
            this.btnCadastros = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnEstoques);
            this.panel1.Controls.Add(this.btnCadastros);
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 369);
            this.panel1.TabIndex = 3;
            // 
            // btnEstoques
            // 
            this.btnEstoques.BackColor = System.Drawing.Color.Black;
            this.btnEstoques.FlatAppearance.BorderSize = 0;
            this.btnEstoques.Font = new System.Drawing.Font("Segoe UI Semibold", 19.75F, System.Drawing.FontStyle.Bold);
            this.btnEstoques.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEstoques.Location = new System.Drawing.Point(394, 70);
            this.btnEstoques.Name = "btnEstoques";
            this.btnEstoques.Size = new System.Drawing.Size(315, 243);
            this.btnEstoques.TabIndex = 16;
            this.btnEstoques.Text = "Estoques";
            this.btnEstoques.UseVisualStyleBackColor = false;
            this.btnEstoques.Click += new System.EventHandler(this.btnEstoques_Click);
            this.btnEstoques.MouseLeave += new System.EventHandler(this.btnEstoques_MouseLeave);
            this.btnEstoques.MouseHover += new System.EventHandler(this.btnEstoques_MouseHover);
            // 
            // btnCadastros
            // 
            this.btnCadastros.BackColor = System.Drawing.Color.Black;
            this.btnCadastros.FlatAppearance.BorderSize = 0;
            this.btnCadastros.Font = new System.Drawing.Font("Segoe UI Semibold", 19.75F, System.Drawing.FontStyle.Bold);
            this.btnCadastros.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastros.Location = new System.Drawing.Point(26, 70);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Size = new System.Drawing.Size(315, 243);
            this.btnCadastros.TabIndex = 15;
            this.btnCadastros.Text = "Cadastrar Pets";
            this.btnCadastros.UseVisualStyleBackColor = false;
            this.btnCadastros.Click += new System.EventHandler(this.btnCadastros_Click);
            this.btnCadastros.MouseLeave += new System.EventHandler(this.btnCadastros_MouseLeave);
            this.btnCadastros.MouseHover += new System.EventHandler(this.btnCadastros_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 51);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(262, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pet Shop Stories";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Cadastro.Properties.Resources.logo_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(-58, -51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 151);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCadastros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnEstoques;
    }
}