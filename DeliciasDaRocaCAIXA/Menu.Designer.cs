namespace DeliciasDaRocaCAIXA
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Pagamentos = new System.Windows.Forms.Button();
            this.listadeprodutos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pagamentos
            // 
            this.Pagamentos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pagamentos.BackgroundImage")));
            this.Pagamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pagamentos.Location = new System.Drawing.Point(558, 60);
            this.Pagamentos.Name = "Pagamentos";
            this.Pagamentos.Size = new System.Drawing.Size(168, 120);
            this.Pagamentos.TabIndex = 1;
            this.Pagamentos.UseVisualStyleBackColor = true;
            this.Pagamentos.Click += new System.EventHandler(this.Pagamentos_Click);
            // 
            // listadeprodutos
            // 
            this.listadeprodutos.AutoSize = true;
            this.listadeprodutos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listadeprodutos.BackgroundImage")));
            this.listadeprodutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listadeprodutos.Location = new System.Drawing.Point(79, 60);
            this.listadeprodutos.Name = "listadeprodutos";
            this.listadeprodutos.Size = new System.Drawing.Size(168, 120);
            this.listadeprodutos.TabIndex = 2;
            this.listadeprodutos.UseVisualStyleBackColor = true;
            this.listadeprodutos.Click += new System.EventHandler(this.listadeprodutos_Click);
            // 
            // Menu
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 434);
            this.Controls.Add(this.listadeprodutos);
            this.Controls.Add(this.Pagamentos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Pagamentos;
        private System.Windows.Forms.Button listadeprodutos;
    }
}