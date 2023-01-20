namespace Projeto19jan2023
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
            this.textBoxresultado = new System.Windows.Forms.TextBox();
            this.labeloperacao = new System.Windows.Forms.Label();
            this.botao7 = new System.Windows.Forms.Button();
            this.botao8 = new System.Windows.Forms.Button();
            this.botao9 = new System.Windows.Forms.Button();
            this.mais = new System.Windows.Forms.Button();
            this.buttoncancelar = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.menos = new System.Windows.Forms.Button();
            this.botao6 = new System.Windows.Forms.Button();
            this.botao5 = new System.Windows.Forms.Button();
            this.botao4 = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.botao2 = new System.Windows.Forms.Button();
            this.botao1 = new System.Windows.Forms.Button();
            this.botao3 = new System.Windows.Forms.Button();
            this.botao0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxresultado
            // 
            this.textBoxresultado.Location = new System.Drawing.Point(12, 12);
            this.textBoxresultado.Multiline = true;
            this.textBoxresultado.Name = "textBoxresultado";
            this.textBoxresultado.Size = new System.Drawing.Size(498, 57);
            this.textBoxresultado.TabIndex = 0;
            this.textBoxresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxresultado.TextChanged += new System.EventHandler(this.textBoxresultado_TextChanged);
            // 
            // labeloperacao
            // 
            this.labeloperacao.AutoSize = true;
            this.labeloperacao.BackColor = System.Drawing.Color.White;
            this.labeloperacao.Location = new System.Drawing.Point(12, 15);
            this.labeloperacao.Name = "labeloperacao";
            this.labeloperacao.Size = new System.Drawing.Size(54, 13);
            this.labeloperacao.TabIndex = 1;
            this.labeloperacao.Text = "Operação";
            this.labeloperacao.Click += new System.EventHandler(this.labeloperacao_Click);
            // 
            // botao7
            // 
            this.botao7.BackColor = System.Drawing.Color.Gainsboro;
            this.botao7.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao7.ForeColor = System.Drawing.Color.Purple;
            this.botao7.Location = new System.Drawing.Point(15, 75);
            this.botao7.Name = "botao7";
            this.botao7.Size = new System.Drawing.Size(95, 82);
            this.botao7.TabIndex = 2;
            this.botao7.Text = "7";
            this.botao7.UseVisualStyleBackColor = false;
            this.botao7.Click += new System.EventHandler(this.botao7_Click);
            // 
            // botao8
            // 
            this.botao8.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao8.ForeColor = System.Drawing.Color.Purple;
            this.botao8.Location = new System.Drawing.Point(116, 75);
            this.botao8.Name = "botao8";
            this.botao8.Size = new System.Drawing.Size(95, 82);
            this.botao8.TabIndex = 3;
            this.botao8.Text = "8";
            this.botao8.UseVisualStyleBackColor = true;
            this.botao8.Click += new System.EventHandler(this.botao8_Click);
            // 
            // botao9
            // 
            this.botao9.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao9.ForeColor = System.Drawing.Color.Purple;
            this.botao9.Location = new System.Drawing.Point(217, 75);
            this.botao9.Name = "botao9";
            this.botao9.Size = new System.Drawing.Size(95, 82);
            this.botao9.TabIndex = 4;
            this.botao9.Text = "9";
            this.botao9.UseVisualStyleBackColor = true;
            this.botao9.Click += new System.EventHandler(this.botao9_Click);
            // 
            // mais
            // 
            this.mais.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mais.Location = new System.Drawing.Point(318, 75);
            this.mais.Name = "mais";
            this.mais.Size = new System.Drawing.Size(95, 82);
            this.mais.TabIndex = 5;
            this.mais.Text = "+";
            this.mais.UseVisualStyleBackColor = true;
            this.mais.Click += new System.EventHandler(this.mais_Click);
            // 
            // buttoncancelar
            // 
            this.buttoncancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncancelar.Location = new System.Drawing.Point(419, 75);
            this.buttoncancelar.Name = "buttoncancelar";
            this.buttoncancelar.Size = new System.Drawing.Size(95, 82);
            this.buttoncancelar.TabIndex = 6;
            this.buttoncancelar.Text = "C E";
            this.buttoncancelar.UseVisualStyleBackColor = true;
            this.buttoncancelar.Click += new System.EventHandler(this.buttoncancelar_Click);
            // 
            // apagar
            // 
            this.apagar.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apagar.Location = new System.Drawing.Point(419, 163);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(95, 82);
            this.apagar.TabIndex = 7;
            this.apagar.Text = "C";
            this.apagar.UseVisualStyleBackColor = true;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // igual
            // 
            this.igual.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.Location = new System.Drawing.Point(419, 251);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(95, 176);
            this.igual.TabIndex = 8;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // menos
            // 
            this.menos.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menos.Location = new System.Drawing.Point(318, 163);
            this.menos.Name = "menos";
            this.menos.Size = new System.Drawing.Size(95, 82);
            this.menos.TabIndex = 9;
            this.menos.Text = "-";
            this.menos.UseVisualStyleBackColor = true;
            this.menos.Click += new System.EventHandler(this.menos_Click);
            // 
            // botao6
            // 
            this.botao6.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao6.ForeColor = System.Drawing.Color.Purple;
            this.botao6.Location = new System.Drawing.Point(217, 163);
            this.botao6.Name = "botao6";
            this.botao6.Size = new System.Drawing.Size(95, 82);
            this.botao6.TabIndex = 10;
            this.botao6.Text = "6";
            this.botao6.UseVisualStyleBackColor = true;
            this.botao6.Click += new System.EventHandler(this.botao6_Click);
            // 
            // botao5
            // 
            this.botao5.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao5.ForeColor = System.Drawing.Color.Purple;
            this.botao5.Location = new System.Drawing.Point(116, 163);
            this.botao5.Name = "botao5";
            this.botao5.Size = new System.Drawing.Size(95, 82);
            this.botao5.TabIndex = 11;
            this.botao5.Text = "5";
            this.botao5.UseVisualStyleBackColor = true;
            this.botao5.Click += new System.EventHandler(this.botao5_Click);
            // 
            // botao4
            // 
            this.botao4.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao4.ForeColor = System.Drawing.Color.Purple;
            this.botao4.Location = new System.Drawing.Point(15, 163);
            this.botao4.Name = "botao4";
            this.botao4.Size = new System.Drawing.Size(95, 82);
            this.botao4.TabIndex = 12;
            this.botao4.Text = "4";
            this.botao4.UseVisualStyleBackColor = true;
            this.botao4.Click += new System.EventHandler(this.botao4_Click);
            // 
            // mult
            // 
            this.mult.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult.Location = new System.Drawing.Point(318, 251);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(95, 82);
            this.mult.TabIndex = 13;
            this.mult.Text = "x";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // dividir
            // 
            this.dividir.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividir.Location = new System.Drawing.Point(318, 345);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(95, 82);
            this.dividir.TabIndex = 14;
            this.dividir.Text = "/";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // botao2
            // 
            this.botao2.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao2.ForeColor = System.Drawing.Color.Purple;
            this.botao2.Location = new System.Drawing.Point(116, 251);
            this.botao2.Name = "botao2";
            this.botao2.Size = new System.Drawing.Size(95, 82);
            this.botao2.TabIndex = 17;
            this.botao2.Text = "2";
            this.botao2.UseVisualStyleBackColor = true;
            this.botao2.Click += new System.EventHandler(this.botao2_Click);
            // 
            // botao1
            // 
            this.botao1.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao1.ForeColor = System.Drawing.Color.Purple;
            this.botao1.Location = new System.Drawing.Point(217, 251);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(95, 82);
            this.botao1.TabIndex = 18;
            this.botao1.Text = "1";
            this.botao1.UseVisualStyleBackColor = true;
            this.botao1.Click += new System.EventHandler(this.botao1_Click);
            // 
            // botao3
            // 
            this.botao3.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao3.ForeColor = System.Drawing.Color.Purple;
            this.botao3.Location = new System.Drawing.Point(15, 251);
            this.botao3.Name = "botao3";
            this.botao3.Size = new System.Drawing.Size(95, 82);
            this.botao3.TabIndex = 19;
            this.botao3.Text = "3";
            this.botao3.UseVisualStyleBackColor = true;
            this.botao3.Click += new System.EventHandler(this.botao3_Click);
            // 
            // botao0
            // 
            this.botao0.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao0.ForeColor = System.Drawing.Color.Purple;
            this.botao0.Location = new System.Drawing.Point(15, 345);
            this.botao0.Name = "botao0";
            this.botao0.Size = new System.Drawing.Size(284, 82);
            this.botao0.TabIndex = 20;
            this.botao0.Text = "0";
            this.botao0.UseVisualStyleBackColor = true;
            this.botao0.Click += new System.EventHandler(this.botao0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(537, 465);
            this.Controls.Add(this.botao0);
            this.Controls.Add(this.botao3);
            this.Controls.Add(this.botao1);
            this.Controls.Add(this.botao2);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.botao4);
            this.Controls.Add(this.botao5);
            this.Controls.Add(this.botao6);
            this.Controls.Add(this.menos);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.buttoncancelar);
            this.Controls.Add(this.mais);
            this.Controls.Add(this.botao9);
            this.Controls.Add(this.botao8);
            this.Controls.Add(this.botao7);
            this.Controls.Add(this.labeloperacao);
            this.Controls.Add(this.textBoxresultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxresultado;
        private System.Windows.Forms.Label labeloperacao;
        private System.Windows.Forms.Button botao7;
        private System.Windows.Forms.Button botao8;
        private System.Windows.Forms.Button botao9;
        private System.Windows.Forms.Button mais;
        private System.Windows.Forms.Button buttoncancelar;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button menos;
        private System.Windows.Forms.Button botao6;
        private System.Windows.Forms.Button botao5;
        private System.Windows.Forms.Button botao4;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button botao2;
        private System.Windows.Forms.Button botao1;
        private System.Windows.Forms.Button botao3;
        private System.Windows.Forms.Button botao0;
    }
}

