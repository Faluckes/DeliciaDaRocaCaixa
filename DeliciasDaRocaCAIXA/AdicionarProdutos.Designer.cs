namespace DeliciasDaRocaCAIXA
{
    partial class AdicionarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarProdutos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.produtos = new System.Windows.Forms.Label();
            this.idproduto = new System.Windows.Forms.Label();
            this.nomeproduto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidproduto = new System.Windows.Forms.TextBox();
            this.txtnomeproduto = new System.Windows.Forms.TextBox();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tipoproduto = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.boxtipoproduto = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.boxtipopeso = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(240, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // produtos
            // 
            this.produtos.AutoSize = true;
            this.produtos.BackColor = System.Drawing.Color.Transparent;
            this.produtos.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produtos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.produtos.Location = new System.Drawing.Point(338, 37);
            this.produtos.Name = "produtos";
            this.produtos.Size = new System.Drawing.Size(161, 38);
            this.produtos.TabIndex = 1;
            this.produtos.Text = "Produtos";
            this.produtos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // idproduto
            // 
            this.idproduto.AutoSize = true;
            this.idproduto.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idproduto.Location = new System.Drawing.Point(146, 165);
            this.idproduto.Name = "idproduto";
            this.idproduto.Size = new System.Drawing.Size(102, 15);
            this.idproduto.TabIndex = 2;
            this.idproduto.Text = "Id do Produto:";
            // 
            // nomeproduto
            // 
            this.nomeproduto.AutoSize = true;
            this.nomeproduto.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeproduto.Location = new System.Drawing.Point(373, 165);
            this.nomeproduto.Name = "nomeproduto";
            this.nomeproduto.Size = new System.Drawing.Size(126, 15);
            this.nomeproduto.TabIndex = 3;
            this.nomeproduto.Text = "Nome do Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Peso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preço Unitario:";
            // 
            // txtidproduto
            // 
            this.txtidproduto.Location = new System.Drawing.Point(254, 163);
            this.txtidproduto.MaxLength = 50;
            this.txtidproduto.Name = "txtidproduto";
            this.txtidproduto.Size = new System.Drawing.Size(100, 20);
            this.txtidproduto.TabIndex = 1;
            // 
            // txtnomeproduto
            // 
            this.txtnomeproduto.Location = new System.Drawing.Point(505, 163);
            this.txtnomeproduto.MaxLength = 100;
            this.txtnomeproduto.Name = "txtnomeproduto";
            this.txtnomeproduto.Size = new System.Drawing.Size(100, 20);
            this.txtnomeproduto.TabIndex = 2;
            // 
            // txtquantidade
            // 
            this.txtquantidade.Location = new System.Drawing.Point(254, 262);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(100, 20);
            this.txtquantidade.TabIndex = 6;
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(505, 210);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(47, 20);
            this.txtpeso.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(345, 366);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 95);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tipoproduto
            // 
            this.tipoproduto.AutoSize = true;
            this.tipoproduto.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoproduto.Location = new System.Drawing.Point(129, 215);
            this.tipoproduto.Name = "tipoproduto";
            this.tipoproduto.Size = new System.Drawing.Size(119, 15);
            this.tipoproduto.TabIndex = 13;
            this.tipoproduto.Text = "Tipo do Produto:";
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(505, 262);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(100, 20);
            this.txtpreco.TabIndex = 7;
            // 
            // boxtipoproduto
            // 
            this.boxtipoproduto.AutoCompleteCustomSource.AddRange(new string[] {
            "Carne",
            "Fruta",
            "Industrial",
            "Liquido",
            "Salgado",
            "Doce"});
            this.boxtipoproduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxtipoproduto.FormattingEnabled = true;
            this.boxtipoproduto.Items.AddRange(new object[] {
            "1 Carne",
            "2 Liquido",
            "3 Industrial",
            "4 Doce",
            "5 Salgado"});
            this.boxtipoproduto.Location = new System.Drawing.Point(254, 213);
            this.boxtipoproduto.Name = "boxtipoproduto";
            this.boxtipoproduto.Size = new System.Drawing.Size(99, 21);
            this.boxtipoproduto.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DarkViolet;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 477);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(763, 22);
            this.statusStrip1.TabIndex = 15;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel1.Text = "...";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExcluir.Location = new System.Drawing.Point(345, 366);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 95);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // boxtipopeso
            // 
            this.boxtipopeso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxtipopeso.FormattingEnabled = true;
            this.boxtipopeso.Items.AddRange(new object[] {
            "G",
            "Kg",
            "Ml",
            "Litro"});
            this.boxtipopeso.Location = new System.Drawing.Point(558, 210);
            this.boxtipopeso.Name = "boxtipopeso";
            this.boxtipopeso.Size = new System.Drawing.Size(47, 21);
            this.boxtipopeso.TabIndex = 5;
            // 
            // AdicionarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(763, 499);
            this.Controls.Add(this.boxtipopeso);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.boxtipoproduto);
            this.Controls.Add(this.tipoproduto);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.txtquantidade);
            this.Controls.Add(this.txtnomeproduto);
            this.Controls.Add(this.txtidproduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeproduto);
            this.Controls.Add(this.idproduto);
            this.Controls.Add(this.produtos);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdicionarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Produtos";
            this.Load += new System.EventHandler(this.AdicionarProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label produtos;
        private System.Windows.Forms.Label idproduto;
        private System.Windows.Forms.Label nomeproduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtidproduto;
        private System.Windows.Forms.TextBox txtnomeproduto;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label tipoproduto;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.ComboBox boxtipoproduto;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox boxtipopeso;
    }
}