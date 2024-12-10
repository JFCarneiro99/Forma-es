namespace AvaliacaoAutomovel
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avaliacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDesign = new System.Windows.Forms.ComboBox();
            this.comboBoxConforto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMotorizacao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxConsumo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxExtras = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxPreco = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(73, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pontuar Veiculo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Marca,
            this.Modelo,
            this.Avaliacao});
            this.dataGridView1.Location = new System.Drawing.Point(193, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(328, 243);
            this.dataGridView1.TabIndex = 5;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // Avaliacao
            // 
            this.Avaliacao.HeaderText = "Avaliação";
            this.Avaliacao.Name = "Avaliacao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Design";
            // 
            // comboBoxDesign
            // 
            this.comboBoxDesign.FormattingEnabled = true;
            this.comboBoxDesign.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxDesign.Location = new System.Drawing.Point(73, 93);
            this.comboBoxDesign.Name = "comboBoxDesign";
            this.comboBoxDesign.Size = new System.Drawing.Size(100, 21);
            this.comboBoxDesign.TabIndex = 7;
            // 
            // comboBoxConforto
            // 
            this.comboBoxConforto.FormattingEnabled = true;
            this.comboBoxConforto.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxConforto.Location = new System.Drawing.Point(73, 127);
            this.comboBoxConforto.Name = "comboBoxConforto";
            this.comboBoxConforto.Size = new System.Drawing.Size(100, 21);
            this.comboBoxConforto.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Conforto";
            // 
            // comboBoxMotorizacao
            // 
            this.comboBoxMotorizacao.FormattingEnabled = true;
            this.comboBoxMotorizacao.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxMotorizacao.Location = new System.Drawing.Point(73, 163);
            this.comboBoxMotorizacao.Name = "comboBoxMotorizacao";
            this.comboBoxMotorizacao.Size = new System.Drawing.Size(100, 21);
            this.comboBoxMotorizacao.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Motorização";
            // 
            // comboBoxConsumo
            // 
            this.comboBoxConsumo.FormattingEnabled = true;
            this.comboBoxConsumo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxConsumo.Location = new System.Drawing.Point(73, 196);
            this.comboBoxConsumo.Name = "comboBoxConsumo";
            this.comboBoxConsumo.Size = new System.Drawing.Size(100, 21);
            this.comboBoxConsumo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Consumo";
            // 
            // comboBoxExtras
            // 
            this.comboBoxExtras.FormattingEnabled = true;
            this.comboBoxExtras.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxExtras.Location = new System.Drawing.Point(73, 231);
            this.comboBoxExtras.Name = "comboBoxExtras";
            this.comboBoxExtras.Size = new System.Drawing.Size(100, 21);
            this.comboBoxExtras.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Extras";
            // 
            // comboBoxPreco
            // 
            this.comboBoxPreco.FormattingEnabled = true;
            this.comboBoxPreco.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxPreco.Location = new System.Drawing.Point(73, 260);
            this.comboBoxPreco.Name = "comboBoxPreco";
            this.comboBoxPreco.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPreco.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Preço";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 408);
            this.Controls.Add(this.comboBoxPreco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxExtras);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxConsumo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxMotorizacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxConforto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxDesign);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avaliacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDesign;
        private System.Windows.Forms.ComboBox comboBoxConforto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMotorizacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxConsumo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxExtras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxPreco;
        private System.Windows.Forms.Label label8;
    }
}

