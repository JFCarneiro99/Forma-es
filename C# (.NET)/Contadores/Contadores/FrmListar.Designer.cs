namespace Contadores
{
    partial class FrmListar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Electricidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Gas,
            this.Electricidade,
            this.Agua});
            this.dataGridView1.Location = new System.Drawing.Point(5, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(798, 191);
            this.dataGridView1.TabIndex = 0;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.MinimumWidth = 8;
            this.Data.Name = "Data";
            this.Data.Width = 150;
            // 
            // Gas
            // 
            this.Gas.HeaderText = "Gas";
            this.Gas.MinimumWidth = 8;
            this.Gas.Name = "Gas";
            this.Gas.Width = 150;
            // 
            // Electricidade
            // 
            this.Electricidade.HeaderText = "Electricidade";
            this.Electricidade.MinimumWidth = 8;
            this.Electricidade.Name = "Electricidade";
            this.Electricidade.Width = 150;
            // 
            // Agua
            // 
            this.Agua.HeaderText = "Agua";
            this.Agua.MinimumWidth = 8;
            this.Agua.Name = "Agua";
            this.Agua.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmListar";
            this.Text = "FrmListar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridViewTextBoxColumn Data;
        public System.Windows.Forms.DataGridViewTextBoxColumn Gas;
        public System.Windows.Forms.DataGridViewTextBoxColumn Electricidade;
        public System.Windows.Forms.DataGridViewTextBoxColumn Agua;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}