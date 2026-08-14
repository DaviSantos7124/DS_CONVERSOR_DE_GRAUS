namespace DS_CONVERSOR_DE_GRAUS
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Titulo = new System.Windows.Forms.Label();
            this.nm_Temperatura = new System.Windows.Forms.Label();
            this.nm_Resultado = new System.Windows.Forms.Label();
            this.bt_Celsius = new System.Windows.Forms.Button();
            this.bt_Kelvin = new System.Windows.Forms.Button();
            this.bt_Fahrenheit = new System.Windows.Forms.Button();
            this.vl_temperatura = new System.Windows.Forms.TextBox();
            this.vl_resultado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(174, 34);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(516, 40);
            this.Titulo.TabIndex = 2;
            this.Titulo.Text = "TEMPERATURE CONVERTER";
            this.Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // nm_Temperatura
            // 
            this.nm_Temperatura.AutoSize = true;
            this.nm_Temperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_Temperatura.Location = new System.Drawing.Point(38, 131);
            this.nm_Temperatura.Name = "nm_Temperatura";
            this.nm_Temperatura.Size = new System.Drawing.Size(189, 31);
            this.nm_Temperatura.TabIndex = 3;
            this.nm_Temperatura.Text = "Temperatura:";
            // 
            // nm_Resultado
            // 
            this.nm_Resultado.AutoSize = true;
            this.nm_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_Resultado.Location = new System.Drawing.Point(38, 244);
            this.nm_Resultado.Name = "nm_Resultado";
            this.nm_Resultado.Size = new System.Drawing.Size(155, 31);
            this.nm_Resultado.TabIndex = 5;
            this.nm_Resultado.Text = "Resultado:";
            this.nm_Resultado.Click += new System.EventHandler(this.label4_Click);
            // 
            // bt_Celsius
            // 
            this.bt_Celsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Celsius.Location = new System.Drawing.Point(386, 366);
            this.bt_Celsius.Name = "bt_Celsius";
            this.bt_Celsius.Size = new System.Drawing.Size(99, 33);
            this.bt_Celsius.TabIndex = 7;
            this.bt_Celsius.Text = "Celsius";
            this.bt_Celsius.UseVisualStyleBackColor = true;
            this.bt_Celsius.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_Kelvin
            // 
            this.bt_Kelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Kelvin.Location = new System.Drawing.Point(665, 366);
            this.bt_Kelvin.Name = "bt_Kelvin";
            this.bt_Kelvin.Size = new System.Drawing.Size(99, 33);
            this.bt_Kelvin.TabIndex = 8;
            this.bt_Kelvin.Text = "Kelvin";
            this.bt_Kelvin.UseVisualStyleBackColor = true;
            // 
            // bt_Fahrenheit
            // 
            this.bt_Fahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Fahrenheit.Location = new System.Drawing.Point(64, 366);
            this.bt_Fahrenheit.Name = "bt_Fahrenheit";
            this.bt_Fahrenheit.Size = new System.Drawing.Size(150, 33);
            this.bt_Fahrenheit.TabIndex = 9;
            this.bt_Fahrenheit.Text = "Fahrenheit";
            this.bt_Fahrenheit.UseVisualStyleBackColor = true;
            this.bt_Fahrenheit.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // vl_temperatura
            // 
            this.vl_temperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vl_temperatura.Location = new System.Drawing.Point(243, 133);
            this.vl_temperatura.Multiline = true;
            this.vl_temperatura.Name = "vl_temperatura";
            this.vl_temperatura.Size = new System.Drawing.Size(551, 31);
            this.vl_temperatura.TabIndex = 10;
            this.vl_temperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vl_temperatura.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // vl_resultado
            // 
            this.vl_resultado.Enabled = false;
            this.vl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vl_resultado.Location = new System.Drawing.Point(243, 244);
            this.vl_resultado.Multiline = true;
            this.vl_resultado.Name = "vl_resultado";
            this.vl_resultado.Size = new System.Drawing.Size(551, 31);
            this.vl_resultado.TabIndex = 11;
            this.vl_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vl_resultado.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(847, 507);
            this.Controls.Add(this.vl_resultado);
            this.Controls.Add(this.vl_temperatura);
            this.Controls.Add(this.bt_Fahrenheit);
            this.Controls.Add(this.bt_Kelvin);
            this.Controls.Add(this.bt_Celsius);
            this.Controls.Add(this.nm_Resultado);
            this.Controls.Add(this.nm_Temperatura);
            this.Controls.Add(this.Titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label nm_Temperatura;
        private System.Windows.Forms.Label nm_Resultado;
        private System.Windows.Forms.Button bt_Celsius;
        private System.Windows.Forms.Button bt_Kelvin;
        private System.Windows.Forms.Button bt_Fahrenheit;
        private System.Windows.Forms.TextBox vl_temperatura;
        private System.Windows.Forms.TextBox vl_resultado;
    }
}

