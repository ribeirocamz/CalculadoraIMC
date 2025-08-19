namespace CalculadoraIMC
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.btnClacular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblSaude = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblTitulo.Location = new System.Drawing.Point(122, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(255, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculadora de IMC";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(87, 161);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(46, 21);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(79, 215);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(54, 21);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Altura:";
            // 
            // txbPeso
            // 
            this.txbPeso.Location = new System.Drawing.Point(139, 163);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(108, 20);
            this.txbPeso.TabIndex = 3;
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(139, 215);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(108, 20);
            this.txbAltura.TabIndex = 4;
            this.txbAltura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbAltura_KeyDown);
            // 
            // btnClacular
            // 
            this.btnClacular.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnClacular.Location = new System.Drawing.Point(71, 251);
            this.btnClacular.Name = "btnClacular";
            this.btnClacular.Size = new System.Drawing.Size(176, 35);
            this.btnClacular.TabIndex = 5;
            this.btnClacular.Text = "Calcular";
            this.btnClacular.UseVisualStyleBackColor = false;
            this.btnClacular.Click += new System.EventHandler(this.btnClacular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(67, 307);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(40, 21);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "IMC:";
            // 
            // lblSaude
            // 
            this.lblSaude.AutoSize = true;
            this.lblSaude.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaude.Location = new System.Drawing.Point(67, 341);
            this.lblSaude.Name = "lblSaude";
            this.lblSaude.Size = new System.Drawing.Size(0, 21);
            this.lblSaude.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 424);
            this.Controls.Add(this.lblSaude);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnClacular);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.txbPeso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txbPeso;
        private System.Windows.Forms.TextBox txbAltura;
        private System.Windows.Forms.Button btnClacular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblSaude;
    }
}

