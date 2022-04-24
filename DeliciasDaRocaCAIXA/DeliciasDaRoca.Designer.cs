namespace DeliciasDaRocaCAIXA
{
    partial class DeliciasDaRoca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliciasDaRoca));
            this.Codigo = new System.Windows.Forms.Label();
            this.CodigoBox = new System.Windows.Forms.TextBox();
            this.Quantidade = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.BackColor = System.Drawing.Color.Transparent;
            this.Codigo.Location = new System.Drawing.Point(60, 76);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(46, 13);
            this.Codigo.TabIndex = 0;
            this.Codigo.Text = "Código :";
            this.Codigo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // CodigoBox
            // 
            this.CodigoBox.Location = new System.Drawing.Point(63, 92);
            this.CodigoBox.Name = "CodigoBox";
            this.CodigoBox.Size = new System.Drawing.Size(178, 20);
            this.CodigoBox.TabIndex = 1;
            this.CodigoBox.TextChanged += new System.EventHandler(this.DeliciasDaRoca_Load);
            this.CodigoBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CodigoBox_KeyUp);
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSize = true;
            this.Quantidade.BackColor = System.Drawing.Color.Transparent;
            this.Quantidade.Location = new System.Drawing.Point(60, 142);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(68, 13);
            this.Quantidade.TabIndex = 2;
            this.Quantidade.Text = "Quantidade :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cadastrar Produto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Pagamento";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(369, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 371);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DeliciasDaRoca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(846, 496);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Quantidade);
            this.Controls.Add(this.CodigoBox);
            this.Controls.Add(this.Codigo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DeliciasDaRoca";
            this.Text = "Delicias Da Roça";
            this.Load += new System.EventHandler(this.DeliciasDaRoca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.TextBox CodigoBox;
        private System.Windows.Forms.Label Quantidade;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

