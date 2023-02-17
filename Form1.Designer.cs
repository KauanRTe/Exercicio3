
namespace Exercicio3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDataNascimento = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txbDataNascimento = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(79, 62);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(217, 20);
            this.txbNome.TabIndex = 4;
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(79, 224);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(217, 20);
            this.txbCPF.TabIndex = 9;
            // 
            // lbNome
            // 
            this.lbNome.FormattingEnabled = true;
            this.lbNome.Location = new System.Drawing.Point(402, 44);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(132, 277);
            this.lbNome.TabIndex = 10;
            this.lbNome.SelectedIndexChanged += new System.EventHandler(this.lbNome_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(441, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nome";
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.FormattingEnabled = true;
            this.lbDataNascimento.Location = new System.Drawing.Point(592, 44);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(150, 277);
            this.lbDataNascimento.TabIndex = 12;
            this.lbDataNascimento.SelectedIndexChanged += new System.EventHandler(this.lbDataNascimento_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(588, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Data de Nascimento";
            // 
            // lbCPF
            // 
            this.lbCPF.FormattingEnabled = true;
            this.lbCPF.Location = new System.Drawing.Point(799, 44);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(150, 277);
            this.lbCPF.TabIndex = 14;
            this.lbCPF.SelectedIndexChanged += new System.EventHandler(this.lbCPF_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(849, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "CPF";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(35, 294);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(80, 27);
            this.btnAdicionar.TabIndex = 18;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(243, 294);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(80, 27);
            this.btnRemover.TabIndex = 19;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // txbDataNascimento
            // 
            this.txbDataNascimento.Location = new System.Drawing.Point(79, 145);
            this.txbDataNascimento.Name = "txbDataNascimento";
            this.txbDataNascimento.Size = new System.Drawing.Size(217, 20);
            this.txbDataNascimento.TabIndex = 20;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(140, 294);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 27);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 538);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txbDataNascimento);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbDataNascimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.ListBox lbNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbDataNascimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbCPF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox txbDataNascimento;
        private System.Windows.Forms.Button btnEditar;
    }
}

