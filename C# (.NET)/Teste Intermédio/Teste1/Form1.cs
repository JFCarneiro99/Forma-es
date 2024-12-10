using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonSubmeter_Click(object sender, EventArgs e)
        {
            //Calcular a média das notas obtidas

            float escrita, oral, fisica;


            if (!float.TryParse(textBoxNPEscrita.Text, out escrita)||
                !float.TryParse(textBoxNAFisica.Text, out fisica)||
                !float.TryParse(textBoxNPOral.Text, out oral))
            {
                MessageBox.Show("Por favor introduza notas corretas");
                return;
            }

            float NFE = escrita;
            if (NFE < 0 || NFE > 20)
            {
                MessageBox.Show("Por favor introduza notas corretas");
                return;
            }

            float NFF = fisica;
            if (NFF < 0 || NFF > 20)
            {
                MessageBox.Show("Por favor introduza notas corretas");
                return;
            }

            float NFO = oral;
            if (NFO < 0 || NFO > 20)
            {
                MessageBox.Show("Por favor introduza notas corretas");
                return;
            }

            float NMedia = (NFE + NFO + NFF) / 3;

            // Numero de Linguas que o candidato fala

            int ingles, alemao, frances, mandarim, portugues, espanhol;
            if (checkBoxIngles.Checked)
            {
                ingles = 1;
            }
            else
            {
                ingles = 0;
            }

            if (checkBoxAlemao.Checked)
            {
                alemao = 1;
            }
            else
            {
                alemao = 0;
            }

            if (checkBoxMandarim.Checked)
            {
                mandarim = 1;
            }
            else
            {
                mandarim = 0;
            }

            if (checkBoxFrances.Checked)
            {
                frances = 1;
            }
            else
            {
                frances = 0;
            }

            if (checkBoxPortugues.Checked)
            {
                portugues = 1;
            }
            else
            {
                portugues = 0;
            }

            if (checkBoxEspanhol.Checked)
            {
                espanhol = 1;
            }
            else
            {
                espanhol = 0;
            }

            int numLinguas;

            numLinguas = ingles + alemao + frances + mandarim + portugues + espanhol;

            // Situação do candidato

            string situacao;

            if (NMedia > 10  && numLinguas >= 2)
            {
                situacao = "Admitido";
            }

            else
            {
                situacao = "Não Admitido";
            }

            // Preencher o DataGrid "Candidatos"
            int linhasID = Candidatos.Rows.Add(textBoxNome.Text, NMedia, numLinguas, situacao);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNome.Clear();
            textBoxNPOral.Clear();
            textBoxNAFisica.Clear();
            textBoxNPEscrita.Clear();
            checkBoxIngles.Checked = false;
            checkBoxAlemao.Checked = false;
            checkBoxEspanhol.Checked = false;
            checkBoxFrances.Checked = false;
            checkBoxMandarim.Checked = false;
            checkBoxPortugues.Checked = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
