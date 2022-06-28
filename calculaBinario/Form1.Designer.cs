namespace calculaBinario
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
            this.calcBinario = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Label();
            this.decimalVar = new System.Windows.Forms.TextBox();
            this.binarioVar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calcBinario
            // 
            this.calcBinario.Location = new System.Drawing.Point(170, 59);
            this.calcBinario.Name = "calcBinario";
            this.calcBinario.Size = new System.Drawing.Size(75, 23);
            this.calcBinario.TabIndex = 0;
            this.calcBinario.Text = "Calcular";
            this.calcBinario.UseVisualStyleBackColor = true;
            this.calcBinario.Click += new System.EventHandler(this.calcBinario_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(23, 36);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(116, 13);
            this.text.TabIndex = 1;
            this.text.Text = "Digite um valor decimal";
            // 
            // decimalVar
            // 
            this.decimalVar.Location = new System.Drawing.Point(145, 33);
            this.decimalVar.Name = "decimalVar";
            this.decimalVar.Size = new System.Drawing.Size(100, 20);
            this.decimalVar.TabIndex = 2;
            // 
            // binarioVar
            // 
            this.binarioVar.Location = new System.Drawing.Point(26, 117);
            this.binarioVar.Multiline = true;
            this.binarioVar.Name = "binarioVar";
            this.binarioVar.Size = new System.Drawing.Size(219, 78);
            this.binarioVar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor decimal em binario é";
            // 
            // limpar
            // 
            this.limpar.Location = new System.Drawing.Point(170, 88);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(75, 23);
            this.limpar.TabIndex = 5;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 218);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.binarioVar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decimalVar);
            this.Controls.Add(this.text);
            this.Controls.Add(this.calcBinario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcBinario;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox decimalVar;
        private System.Windows.Forms.TextBox binarioVar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button limpar;
    }
}

