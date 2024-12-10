using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contadores
{
    public partial class Form1 : Form
    {
        string caminho = "Contadores.txt";
        public Form1()
        {
            InitializeComponent();

            if (!File.Exists(caminho))
            {
                FileStream FSFicheiro=new FileStream(caminho,FileMode.Create,FileAccess.Write);
                FSFicheiro.Close();
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double gas, electricidade, agua;
            DateTime data = DateTime.Parse(dateTimePicker1.Text);

            gas = double.Parse(textBox_gas.Text);
            electricidade=double.Parse(textBox_electricidade.Text);
            agua = double.Parse(textBox_agua.Text);

            textBox_agua.ResetText();
            textBox_electricidade.ResetText();
            textBox_gas.ResetText();
            FileStream FS = new FileStream(caminho, FileMode.Append, FileAccess.Write);

            StreamWriter SR= new StreamWriter(FS);

            string escrita = data+";"+gas + ";" + electricidade + ";" + agua;

            SR.WriteLine(escrita);

            SR.Close();
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmListar formularioListar = new FrmListar();

            string gas, electricidade, agua, data;

            FileStream FS = new FileStream(caminho, FileMode.Open, FileAccess.Read);

            StreamReader SR = new StreamReader(FS);

            while (SR.Peek() != -1)
            {

                string linhas=SR.ReadLine();

                string[] dados = linhas.Split(';');

                data = dados[0];
                gas = dados[1];
                electricidade = dados[2];
                agua = dados[3];

                formularioListar.dataGridView1.Rows.Add(data, gas, electricidade, agua);



            }
            SR.Close();

            formularioListar.Show();



        }
    }
}
