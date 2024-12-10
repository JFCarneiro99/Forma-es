using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ex43_Temperaturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //criar instância da classe e abrir o ficheiro
            XmlDocument FicheiroXML = new XmlDocument();
            FicheiroXML.Load("Temperaturas.xml");
            
            /*percorrer todos os nós elementos e escrever o nome da cidade
            no controlo combobox*/
            foreach (XmlNode no in FicheiroXML.SelectNodes ("//cidade"))
                 cbEstacao.Items.Add (no.Attributes[0].Value.ToString());
          }

        private void cboCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Criar uma instância da classe e abir o ficheiro
            XmlDocument FicheiroXML = new XmlDocument();
            FicheiroXML.Load("Temperaturas.xml");

            //Definição dos arrays para os valores do grafico
            int[] eixoX = new int[34];
            double[] eixoY = new double[34];
            
            //Percorrer todos os nó elementos
            foreach (XmlNode no in FicheiroXML.SelectNodes("//cidade"))
            {
               //Verificar se o nome da cidade corresponde ao atributo 
                if (no.Attributes[0].Value.ToString ()==cbEstacao.Text)
                {
                    //limpar o conteúdo do controlo DataGridView
                    dgvTemperaturas.Rows.Clear();
                    
                    /*Preencher os arrays com os valores e escrevê-los no controlo
                    DataGridView*/
                    for (int anos=0; anos<=no.ChildNodes.Count-1;anos ++)
                    {
                        int ano = int.Parse(no.ChildNodes[anos].Attributes[0].Value.ToString());
                        double temp = double.Parse (no.ChildNodes[anos].Attributes[1].Value.ToString());
                        dgvTemperaturas.Rows.Add(ano, temp);
                        eixoX[anos]=ano;
                        eixoY[anos]=temp;
                    }
                }
            }

            //formatação do gráfico
            Grafico.ChartAreas[0].AxisX.Minimum = 1980;
            Grafico.ChartAreas[0].AxisX.Maximum = 2013;
            Grafico.ChartAreas[0].AxisX.Interval = 2;
            Grafico.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            Grafico.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            //Definição da série do gráfico
            Series  SerieGrafico= new Series();
            
            SerieGrafico = Grafico.Series[0];
            SerieGrafico.ChartType = SeriesChartType.SplineArea;
            SerieGrafico.XValueType = ChartValueType.Int32;
            SerieGrafico.YValueType = ChartValueType.Int32;
  
            //Limpar o conteúdo do gráfico
            Grafico.Series[0].Points.Clear();
            
            //Desenhar gráfico
            for (int anos=1; anos<=34; anos ++)
            {
                SerieGrafico.Points.AddXY(eixoX[anos - 1], eixoY[anos - 1]);
            }
       

        }

       
    }
}
