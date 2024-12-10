using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoAutomovel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            /*
             * 
             * Elabore um programa que solicite ao utilizador a avaliação quantitativa de (0 a 5) dos argumentos design ,
             * conforto, motorizaçãp, consumo, extras e preço de um determinado veiculo automóvel.
                O programa deverá calcular a soma das avaliações e apresentar a avaliação qualitativa de acordo com os seguintes intervalos
                De 0 a 5 fraco
                6ª 10 insuficiente
                11 a 15 Suficiente
                16 a 20 bom
                21 a 25 muito bom
                26 a 30 excelente
             * 
             */





            if (comboBoxConforto.Text=="")
            {
                MessageBox.Show("tem que preencher a combobox Conforto");
            }else if (comboBoxConsumo.Text == "")
            {

                MessageBox.Show("tem que preencher a combobox Conforto");
            }
            //fazer para as restantes

            int somaPontos = 0;

            somaPontos += int.Parse(comboBoxDesign.Text);
            somaPontos += int.Parse(comboBoxConforto.Text);
            somaPontos += int.Parse(comboBoxMotorizacao.Text);
            somaPontos += int.Parse(comboBoxConsumo.Text);
            somaPontos += int.Parse(comboBoxExtras.Text);
            somaPontos += int.Parse(comboBoxPreco.Text);

            string avaliacao = "";
            /*
            switch (somaPontos) {
                case < 5:
                    avaliacao = "fraco";
                    break;
                case < 10:
                    avaliacao = "Insuficiente";
                    break;
                case < 15:
                    avaliacao = "Suficiente";
                    break;
                case < 20:
                    avaliacao = "Bom";
                    break;
                case < 25:
                    avaliacao = "Muito Bom";
                    break;
                case < 30:
                    avaliacao = "Excelente";
                    break;
                */
            if (somaPontos < 5)
             {
                        avaliacao = "fraco";
                    }
            else if (somaPontos < 10) { 
                        avaliacao = "Insuficiente";

            }
            else if (somaPontos < 15) {
                avaliacao = "Suficiente";

            }
             else if (somaPontos< 20) {
                avaliacao = "Bom";

            }
             else if (somaPontos< 25) {
                avaliacao = "Muito Bom";

            }
            else if (somaPontos < 30) {
                avaliacao = "Excelente";

            }

        dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, avaliacao);

       









           



        }
    }
}
