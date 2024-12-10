namespace Teste1
{
    partial class Form1
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
            this.Candidatos = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linguas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSubmeter = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.checkBoxMandarim = new System.Windows.Forms.CheckBox();
            this.checkBoxAlemao = new System.Windows.Forms.CheckBox();
            this.checkBoxEspanhol = new System.Windows.Forms.CheckBox();
            this.checkBoxFrances = new System.Windows.Forms.CheckBox();
            this.checkBoxPortugues = new System.Windows.Forms.CheckBox();
            this.labelLinguas = new System.Windows.Forms.Label();
            this.labelPEscrita = new System.Windows.Forms.Label();
            this.labelPOral = new System.Windows.Forms.Label();
            this.labelAFisica = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNPEscrita = new System.Windows.Forms.TextBox();
            this.textBoxNPOral = new System.Windows.Forms.TextBox();
            this.textBoxNAFisica = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.checkBoxIngles = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Candidatos)).BeginInit();
            this.SuspendLayout();
            // 
            // Candidatos
            // 
            this.Candidatos.AllowUserToAddRows = false;
            this.Candidatos.AllowUserToDeleteRows = false;
            this.Candidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Candidatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.NotaFinal,
            this.Linguas,
            this.Situacao});
            this.Candidatos.Location = new System.Drawing.Point(418, 36);
            this.Candidatos.Name = "Candidatos";
            this.Candidatos.ReadOnly = true;
            this.Candidatos.Size = new System.Drawing.Size(445, 337);
            this.Candidatos.TabIndex = 40;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // NotaFinal
            // 
            this.NotaFinal.HeaderText = "Nota Final";
            this.NotaFinal.Name = "NotaFinal";
            this.NotaFinal.ReadOnly = true;
            // 
            // Linguas
            // 
            this.Linguas.HeaderText = "Línguas Faladas";
            this.Linguas.Name = "Linguas";
            this.Linguas.ReadOnly = true;
            // 
            // Situacao
            // 
            this.Situacao.HeaderText = "Situação";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            // 
            // buttonSubmeter
            // 
            this.buttonSubmeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmeter.Location = new System.Drawing.Point(36, 326);
            this.buttonSubmeter.Name = "buttonSubmeter";
            this.buttonSubmeter.Size = new System.Drawing.Size(84, 47);
            this.buttonSubmeter.TabIndex = 39;
            this.buttonSubmeter.Text = "Submeter";
            this.buttonSubmeter.UseVisualStyleBackColor = true;
            this.buttonSubmeter.Click += new System.EventHandler(this.buttonSubmeter_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(316, 326);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 47);
            this.buttonExit.TabIndex = 38;
            this.buttonExit.Text = "Sair";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(235, 326);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 47);
            this.buttonClear.TabIndex = 37;
            this.buttonClear.Text = "Limpar";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // checkBoxMandarim
            // 
            this.checkBoxMandarim.AutoSize = true;
            this.checkBoxMandarim.Location = new System.Drawing.Point(204, 282);
            this.checkBoxMandarim.Name = "checkBoxMandarim";
            this.checkBoxMandarim.Size = new System.Drawing.Size(72, 17);
            this.checkBoxMandarim.TabIndex = 36;
            this.checkBoxMandarim.Text = "Mandarim";
            this.checkBoxMandarim.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlemao
            // 
            this.checkBoxAlemao.AutoSize = true;
            this.checkBoxAlemao.Location = new System.Drawing.Point(204, 259);
            this.checkBoxAlemao.Name = "checkBoxAlemao";
            this.checkBoxAlemao.Size = new System.Drawing.Size(61, 17);
            this.checkBoxAlemao.TabIndex = 35;
            this.checkBoxAlemao.Text = "Alemão";
            this.checkBoxAlemao.UseVisualStyleBackColor = true;
            // 
            // checkBoxEspanhol
            // 
            this.checkBoxEspanhol.AutoSize = true;
            this.checkBoxEspanhol.Location = new System.Drawing.Point(204, 236);
            this.checkBoxEspanhol.Name = "checkBoxEspanhol";
            this.checkBoxEspanhol.Size = new System.Drawing.Size(70, 17);
            this.checkBoxEspanhol.TabIndex = 34;
            this.checkBoxEspanhol.Text = "Espanhol";
            this.checkBoxEspanhol.UseVisualStyleBackColor = true;
            // 
            // checkBoxFrances
            // 
            this.checkBoxFrances.AutoSize = true;
            this.checkBoxFrances.Location = new System.Drawing.Point(204, 213);
            this.checkBoxFrances.Name = "checkBoxFrances";
            this.checkBoxFrances.Size = new System.Drawing.Size(64, 17);
            this.checkBoxFrances.TabIndex = 33;
            this.checkBoxFrances.Text = "Francês";
            this.checkBoxFrances.UseVisualStyleBackColor = true;
            // 
            // checkBoxPortugues
            // 
            this.checkBoxPortugues.AutoSize = true;
            this.checkBoxPortugues.Location = new System.Drawing.Point(204, 190);
            this.checkBoxPortugues.Name = "checkBoxPortugues";
            this.checkBoxPortugues.Size = new System.Drawing.Size(74, 17);
            this.checkBoxPortugues.TabIndex = 32;
            this.checkBoxPortugues.Text = "Português";
            this.checkBoxPortugues.UseVisualStyleBackColor = true;
            // 
            // labelLinguas
            // 
            this.labelLinguas.AutoSize = true;
            this.labelLinguas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLinguas.Location = new System.Drawing.Point(57, 163);
            this.labelLinguas.Name = "labelLinguas";
            this.labelLinguas.Size = new System.Drawing.Size(141, 20);
            this.labelLinguas.TabIndex = 31;
            this.labelLinguas.Text = "Línguas Faladas";
            // 
            // labelPEscrita
            // 
            this.labelPEscrita.AutoSize = true;
            this.labelPEscrita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPEscrita.Location = new System.Drawing.Point(40, 114);
            this.labelPEscrita.Name = "labelPEscrita";
            this.labelPEscrita.Size = new System.Drawing.Size(158, 20);
            this.labelPEscrita.TabIndex = 30;
            this.labelPEscrita.Text = "Nota Prova Escrita";
            // 
            // labelPOral
            // 
            this.labelPOral.AutoSize = true;
            this.labelPOral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPOral.Location = new System.Drawing.Point(63, 86);
            this.labelPOral.Name = "labelPOral";
            this.labelPOral.Size = new System.Drawing.Size(135, 20);
            this.labelPOral.TabIndex = 29;
            this.labelPOral.Text = "Nota Prova Oral";
            // 
            // labelAFisica
            // 
            this.labelAFisica.AutoSize = true;
            this.labelAFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAFisica.Location = new System.Drawing.Point(32, 60);
            this.labelAFisica.Name = "labelAFisica";
            this.labelAFisica.Size = new System.Drawing.Size(166, 20);
            this.labelAFisica.TabIndex = 28;
            this.labelAFisica.Text = "Nota Aptidão Física";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(143, 36);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(55, 20);
            this.labelNome.TabIndex = 27;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNPEscrita
            // 
            this.textBoxNPEscrita.Location = new System.Drawing.Point(204, 114);
            this.textBoxNPEscrita.Name = "textBoxNPEscrita";
            this.textBoxNPEscrita.Size = new System.Drawing.Size(208, 20);
            this.textBoxNPEscrita.TabIndex = 26;
            // 
            // textBoxNPOral
            // 
            this.textBoxNPOral.Location = new System.Drawing.Point(204, 86);
            this.textBoxNPOral.Name = "textBoxNPOral";
            this.textBoxNPOral.Size = new System.Drawing.Size(208, 20);
            this.textBoxNPOral.TabIndex = 25;
            // 
            // textBoxNAFisica
            // 
            this.textBoxNAFisica.Location = new System.Drawing.Point(204, 60);
            this.textBoxNAFisica.Name = "textBoxNAFisica";
            this.textBoxNAFisica.Size = new System.Drawing.Size(208, 20);
            this.textBoxNAFisica.TabIndex = 24;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(204, 36);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(208, 20);
            this.textBoxNome.TabIndex = 23;
            // 
            // checkBoxIngles
            // 
            this.checkBoxIngles.AutoSize = true;
            this.checkBoxIngles.Location = new System.Drawing.Point(204, 167);
            this.checkBoxIngles.Name = "checkBoxIngles";
            this.checkBoxIngles.Size = new System.Drawing.Size(54, 17);
            this.checkBoxIngles.TabIndex = 22;
            this.checkBoxIngles.Text = "Inglês";
            this.checkBoxIngles.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 419);
            this.Controls.Add(this.Candidatos);
            this.Controls.Add(this.buttonSubmeter);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.checkBoxMandarim);
            this.Controls.Add(this.checkBoxAlemao);
            this.Controls.Add(this.checkBoxEspanhol);
            this.Controls.Add(this.checkBoxFrances);
            this.Controls.Add(this.checkBoxPortugues);
            this.Controls.Add(this.labelLinguas);
            this.Controls.Add(this.labelPEscrita);
            this.Controls.Add(this.labelPOral);
            this.Controls.Add(this.labelAFisica);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNPEscrita);
            this.Controls.Add(this.textBoxNPOral);
            this.Controls.Add(this.textBoxNAFisica);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.checkBoxIngles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Candidatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Candidatos;
        private System.Windows.Forms.Button buttonSubmeter;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.CheckBox checkBoxMandarim;
        private System.Windows.Forms.CheckBox checkBoxAlemao;
        private System.Windows.Forms.CheckBox checkBoxEspanhol;
        private System.Windows.Forms.CheckBox checkBoxFrances;
        private System.Windows.Forms.CheckBox checkBoxPortugues;
        private System.Windows.Forms.Label labelLinguas;
        private System.Windows.Forms.Label labelPEscrita;
        private System.Windows.Forms.Label labelPOral;
        private System.Windows.Forms.Label labelAFisica;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNPEscrita;
        private System.Windows.Forms.TextBox textBoxNPOral;
        private System.Windows.Forms.TextBox textBoxNAFisica;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.CheckBox checkBoxIngles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linguas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
    }
}

