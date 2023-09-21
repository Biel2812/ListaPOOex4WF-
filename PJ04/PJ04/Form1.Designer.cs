namespace PJ04
{
    partial class frmQuadrado
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
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(655, 90);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 0;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(655, 150);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(601, 93);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(31, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Base";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(601, 157);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(34, 13);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Altura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(652, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Resultado";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(733, 241);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "0";
            this.lblResultado.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(668, 201);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.Calcular);
            // 
            // frmQuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 641);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBase);
            this.Name = "frmQuadrado";
            this.Text = "Quadrado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
    }
}

