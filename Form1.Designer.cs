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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblimc = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.Label();
            this.txtaltura = new System.Windows.Forms.Label();
            this.txbpeso = new System.Windows.Forms.TextBox();
            this.txbaltura = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.lblclass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblimc
            // 
            this.lblimc.AutoSize = true;
            this.lblimc.Font = new System.Drawing.Font("Franklin Gothic Book", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimc.Location = new System.Drawing.Point(70, 9);
            this.lblimc.Name = "lblimc";
            this.lblimc.Size = new System.Drawing.Size(234, 37);
            this.lblimc.TabIndex = 0;
            this.lblimc.Text = "Calcule seu IMC";
            // 
            // txtpeso
            // 
            this.txtpeso.AutoSize = true;
            this.txtpeso.Location = new System.Drawing.Point(73, 67);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(42, 21);
            this.txtpeso.TabIndex = 1;
            this.txtpeso.Text = "Peso";
            // 
            // txtaltura
            // 
            this.txtaltura.AutoSize = true;
            this.txtaltura.Location = new System.Drawing.Point(73, 108);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(50, 21);
            this.txtaltura.TabIndex = 2;
            this.txtaltura.Text = "Altura";
            // 
            // txbpeso
            // 
            this.txbpeso.Location = new System.Drawing.Point(178, 62);
            this.txbpeso.Name = "txbpeso";
            this.txbpeso.Size = new System.Drawing.Size(126, 26);
            this.txbpeso.TabIndex = 3;
            // 
            // txbaltura
            // 
            this.txbaltura.Location = new System.Drawing.Point(178, 103);
            this.txbaltura.Name = "txbaltura";
            this.txbaltura.Size = new System.Drawing.Size(126, 26);
            this.txbaltura.TabIndex = 4;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(77, 146);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(227, 37);
            this.BtnCalcular.TabIndex = 5;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(73, 204);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(36, 21);
            this.lblresultado.TabIndex = 6;
            this.lblresultado.Text = "IMC";
            // 
            // txbResultado
            // 
            this.txbResultado.Location = new System.Drawing.Point(178, 199);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.ReadOnly = true;
            this.txbResultado.Size = new System.Drawing.Size(126, 26);
            this.txbResultado.TabIndex = 7;
            // 
            // lblclass
            // 
            this.lblclass.AutoSize = true;
            this.lblclass.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblclass.Location = new System.Drawing.Point(73, 246);
            this.lblclass.Name = "lblclass";
            this.lblclass.Size = new System.Drawing.Size(14, 21);
            this.lblclass.TabIndex = 8;
            this.lblclass.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 304);
            this.Controls.Add(this.lblclass);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.txbaltura);
            this.Controls.Add(this.txbpeso);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.lblimc);
            this.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Calculadora IMC ::";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblimc;
        private System.Windows.Forms.Label txtpeso;
        private System.Windows.Forms.Label txtaltura;
        private System.Windows.Forms.TextBox txbpeso;
        private System.Windows.Forms.TextBox txbaltura;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txbResultado;
        private System.Windows.Forms.Label lblclass;
    }
}

