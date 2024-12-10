using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App37
{
    public partial class Form1 : Form
    {

        struct Dados
        {
            public DateTime data;
            public string modelo;
            public string avaria;
        }
        Queue <Dados> avarias=new Queue<Dados>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dados registo;

            if(textBox1.Text!=""&& textBox3.Text!="")
            {
                registo.data = DateTime.Parse(dateTimePicker1.Text);
                registo.modelo = textBox1.Text;
                registo.avaria = textBox3.Text;

                avarias.Enqueue(registo);

                AtualizarGrelhas();

                dateTimePicker1.Value = DateTime.Today;
                textBox1.ResetText();
                textBox3.ResetText();
            }
            else
            {
                MessageBox.Show("todos os campos são obrigatórios");
            }

        }

        private void AtualizarGrelhas()
        {
            dataGridView1.Rows.Clear();

            foreach(Dados registo in avarias)
            {
                dataGridView1.Rows.Add(registo.data, registo.modelo, registo.avaria);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (avarias.Count > 0)
            {
                avarias.Dequeue();
                AtualizarGrelhas();
            }
            else
            {
                MessageBox.Show("Não existem elementos inseridos");
            }
        }
    }
}
