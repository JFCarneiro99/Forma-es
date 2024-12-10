namespace Livro_de_Receitas
{
    partial class GestorDeReceitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorDeReceitas));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonLimpar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPesquisar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSair = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPreparacao = new System.Windows.Forms.TextBox();
            this.textBoxIngredientes = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxTempo = new System.Windows.Forms.TextBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.comboBoxPessoas = new System.Windows.Forms.ComboBox();
            this.comboBoxDificuldade = new System.Windows.Forms.ComboBox();
            this.dgvReceitas = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pessoas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dificuldade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preparacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceitas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNovo,
            this.toolStripSeparator1,
            this.toolStripButtonGuardar,
            this.toolStripSeparator2,
            this.toolStripButtonEditar,
            this.toolStripSeparator3,
            this.toolStripButtonEliminar,
            this.toolStripSeparator4,
            this.toolStripButtonLimpar,
            this.toolStripSeparator5,
            this.toolStripButtonPesquisar,
            this.toolStripSeparator6,
            this.toolStripButtonSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1199, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNovo
            // 
            this.toolStripButtonNovo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNovo.Image")));
            this.toolStripButtonNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNovo.Name = "toolStripButtonNovo";
            this.toolStripButtonNovo.Size = new System.Drawing.Size(56, 22);
            this.toolStripButtonNovo.Text = "Novo";
            this.toolStripButtonNovo.Click += new System.EventHandler(this.toolStripButtonNovo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonGuardar
            // 
            this.toolStripButtonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGuardar.Image")));
            this.toolStripButtonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGuardar.Name = "toolStripButtonGuardar";
            this.toolStripButtonGuardar.Size = new System.Drawing.Size(69, 22);
            this.toolStripButtonGuardar.Text = "Guardar";
            this.toolStripButtonGuardar.Click += new System.EventHandler(this.toolStripButtonGuardar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonEditar
            // 
            this.toolStripButtonEditar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditar.Image")));
            this.toolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditar.Name = "toolStripButtonEditar";
            this.toolStripButtonEditar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonEditar.Text = "Editar";
            this.toolStripButtonEditar.Click += new System.EventHandler(this.toolStripButtonEditar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonEliminar
            // 
            this.toolStripButtonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEliminar.Image")));
            this.toolStripButtonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEliminar.Name = "toolStripButtonEliminar";
            this.toolStripButtonEliminar.Size = new System.Drawing.Size(70, 22);
            this.toolStripButtonEliminar.Text = "Eliminar";
            this.toolStripButtonEliminar.Click += new System.EventHandler(this.toolStripButtonEliminar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonLimpar
            // 
            this.toolStripButtonLimpar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLimpar.Image")));
            this.toolStripButtonLimpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLimpar.Name = "toolStripButtonLimpar";
            this.toolStripButtonLimpar.Size = new System.Drawing.Size(64, 22);
            this.toolStripButtonLimpar.Text = "Limpar";
            this.toolStripButtonLimpar.Click += new System.EventHandler(this.toolStripButtonLimpar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonPesquisar
            // 
            this.toolStripButtonPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPesquisar.Image")));
            this.toolStripButtonPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPesquisar.Name = "toolStripButtonPesquisar";
            this.toolStripButtonPesquisar.Size = new System.Drawing.Size(72, 22);
            this.toolStripButtonPesquisar.Text = "Procurar";
            this.toolStripButtonPesquisar.Click += new System.EventHandler(this.toolStripButtonPesquisar_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSair
            // 
            this.toolStripButtonSair.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSair.Image")));
            this.toolStripButtonSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSair.Name = "toolStripButtonSair";
            this.toolStripButtonSair.Size = new System.Drawing.Size(46, 22);
            this.toolStripButtonSair.Text = "Sair";
            this.toolStripButtonSair.Click += new System.EventHandler(this.toolStripButtonSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tempo de Preparação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(329, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dificuldade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(329, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Número de Pessoas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ingredientes:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Preparação:";
            // 
            // textBoxPreparacao
            // 
            this.textBoxPreparacao.Location = new System.Drawing.Point(17, 278);
            this.textBoxPreparacao.Multiline = true;
            this.textBoxPreparacao.Name = "textBoxPreparacao";
            this.textBoxPreparacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPreparacao.Size = new System.Drawing.Size(460, 160);
            this.textBoxPreparacao.TabIndex = 8;
            // 
            // textBoxIngredientes
            // 
            this.textBoxIngredientes.Location = new System.Drawing.Point(17, 141);
            this.textBoxIngredientes.Multiline = true;
            this.textBoxIngredientes.Name = "textBoxIngredientes";
            this.textBoxIngredientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIngredientes.Size = new System.Drawing.Size(460, 111);
            this.textBoxIngredientes.TabIndex = 9;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(17, 48);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(291, 20);
            this.textBoxNome.TabIndex = 10;
            // 
            // textBoxTempo
            // 
            this.textBoxTempo.Location = new System.Drawing.Point(17, 90);
            this.textBoxTempo.Name = "textBoxTempo";
            this.textBoxTempo.Size = new System.Drawing.Size(158, 20);
            this.textBoxTempo.TabIndex = 11;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "Carne",
            "Peixe",
            "Marisco",
            "Entradas",
            "Sobremesa"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(187, 89);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategoria.TabIndex = 12;
            // 
            // comboBoxPessoas
            // 
            this.comboBoxPessoas.FormattingEnabled = true;
            this.comboBoxPessoas.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "6",
            "8",
            "10",
            "12",
            "14"});
            this.comboBoxPessoas.Location = new System.Drawing.Point(332, 47);
            this.comboBoxPessoas.Name = "comboBoxPessoas";
            this.comboBoxPessoas.Size = new System.Drawing.Size(145, 21);
            this.comboBoxPessoas.TabIndex = 13;
            // 
            // comboBoxDificuldade
            // 
            this.comboBoxDificuldade.FormattingEnabled = true;
            this.comboBoxDificuldade.Items.AddRange(new object[] {
            "Muito Fácil",
            "Fácil",
            "Intermédio",
            "Difícil",
            "Muito Difícil"});
            this.comboBoxDificuldade.Location = new System.Drawing.Point(332, 90);
            this.comboBoxDificuldade.Name = "comboBoxDificuldade";
            this.comboBoxDificuldade.Size = new System.Drawing.Size(145, 21);
            this.comboBoxDificuldade.TabIndex = 14;
            // 
            // dgvReceitas
            // 
            this.dgvReceitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.tempo,
            this.categoria,
            this.Pessoas,
            this.dificuldade,
            this.ingredientes,
            this.preparacao});
            this.dgvReceitas.Location = new System.Drawing.Point(483, 28);
            this.dgvReceitas.Name = "dgvReceitas";
            this.dgvReceitas.RowHeadersVisible = false;
            this.dgvReceitas.Size = new System.Drawing.Size(703, 410);
            this.dgvReceitas.TabIndex = 15;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // tempo
            // 
            this.tempo.HeaderText = "Tempo";
            this.tempo.Name = "tempo";
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            // 
            // Pessoas
            // 
            this.Pessoas.HeaderText = "Número de Pessoas";
            this.Pessoas.Name = "Pessoas";
            // 
            // dificuldade
            // 
            this.dificuldade.HeaderText = "Dificuldade";
            this.dificuldade.Name = "dificuldade";
            // 
            // ingredientes
            // 
            this.ingredientes.HeaderText = "Ingredientes";
            this.ingredientes.Name = "ingredientes";
            // 
            // preparacao
            // 
            this.preparacao.HeaderText = "Preparação";
            this.preparacao.Name = "preparacao";
            // 
            // GestorDeReceitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 450);
            this.Controls.Add(this.dgvReceitas);
            this.Controls.Add(this.comboBoxDificuldade);
            this.Controls.Add(this.comboBoxPessoas);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.textBoxTempo);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxIngredientes);
            this.Controls.Add(this.textBoxPreparacao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestorDeReceitas";
            this.Text = "Gestor de Receitas";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNovo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonLimpar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonSair;
        private System.Windows.Forms.ToolStripButton toolStripButtonPesquisar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPreparacao;
        private System.Windows.Forms.TextBox textBoxIngredientes;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxTempo;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.ComboBox comboBoxPessoas;
        private System.Windows.Forms.ComboBox comboBoxDificuldade;
        private System.Windows.Forms.DataGridView dgvReceitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pessoas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dificuldade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn preparacao;
    }
}

