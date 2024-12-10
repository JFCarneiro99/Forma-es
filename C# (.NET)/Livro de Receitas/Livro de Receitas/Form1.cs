using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livro_de_Receitas
{
    public partial class GestorDeReceitas : Form
    {
        public GestorDeReceitas()
        {
            InitializeComponent();

            if (!File.Exists($@"C:\\Users\\PC\\Desktop\\Receitas"))
            {
                FileStream FSFicheiro = new FileStream($@"C:\\Users\\PC\\Desktop\\Receitas\\{nome}", FileMode.Create, FileAccess.Write); // criar no ambiente de trabalho uma pasta com o nome Receitas
                FSFicheiro.Close();
            }
        }

        private void toolStripButtonNovo_Click(object sender, EventArgs e)
        {
            Limpar();
            MessageBox.Show("Insira a nova Receita!");
        }

        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            string nome, ingredientes, categoria, dificuldade, preparacao, save;
            int tempo, pessoas;

            bool Historico = File.Exists($@"C:\\Users\\PC\\Desktop\\Receitas\\" + textBoxNome.Text + ".txt");

            if (Historico == true)
            {
                MessageBox.Show("Receita já existe, se pretende guardar utlize outro nome!");
            }
            else
            {
                nome = textBoxNome.Text;
                ingredientes = textBoxIngredientes.Text;
                categoria = comboBoxCategoria.Text;
                dificuldade = comboBoxDificuldade.Text;
                preparacao = textBoxPreparacao.Text;

                if (!int.TryParse(textBoxTempo.Text, out tempo) || !int.TryParse(comboBoxPessoas.Text, out pessoas) || nome == "" || ingredientes == ""
                    || categoria == "" || dificuldade == "" || preparacao == "")
                {
                    MessageBox.Show("Por favor, introduza os dados corretos!");
                    return;
                }

                FileStream FS = new FileStream($@"C:\\Users\\PC\\Desktop\\Receitas\\{nome}.txt", FileMode.Append, FileAccess.Write);

                StreamWriter SW = new StreamWriter(FS);

                save = nome+";"+tempo+";"+categoria+";"+dificuldade+";"+pessoas+";"+ingredientes+";"+preparacao+";";

                SW.WriteLine(save);
                SW.Close();
                AtualizardgvReceitas();
                Limpar();
            }
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            bool Historico = File.Exists($@"C:\\Users\\PC\\Desktop\\Receitas\\" + textBoxNome.Text + ".txt");

            if (Historico == true)
            {
                File.Delete($@"C:\\Users\\PC\\Desktop\\Receitas\\" + textBoxNome.Text + ".txt");
            }

            string nome, ingredientes, categoria, dificuldade, preparacao, save;
            int tempo, pessoas;

            nome = textBoxNome.Text;
            ingredientes = textBoxIngredientes.Text;
            categoria = comboBoxCategoria.Text;
            dificuldade = comboBoxDificuldade.Text;
            preparacao = textBoxPreparacao.Text;

            if (!int.TryParse(textBoxTempo.Text, out tempo) || !int.TryParse(comboBoxPessoas.Text, out pessoas) || nome == "" || ingredientes == ""
                || categoria == "" || dificuldade == "" || preparacao == "")
            {
                MessageBox.Show("Por favor, introduza os dados corretos!");
                return;
            }

            FileStream FS = new FileStream($@"C:\\Users\\PC\\Desktop\\Receitas\\{nome}.txt", FileMode.Append, FileAccess.Write);

            StreamWriter SW = new StreamWriter(FS);

            save = nome + ";" + tempo + ";" + categoria + ";" + dificuldade + ";" + pessoas + ";" + ingredientes + ";" + preparacao + ";";

            SW.WriteLine(save);
            SW.Close();
            AtualizardgvReceitas();
            Limpar();

        }

        private void toolStripButtonEliminar_Click(object sender, EventArgs e)
        {
            EliminarReceita();
        }

        private void toolStripButtonLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void toolStripButtonPesquisar_Click(object sender, EventArgs e)
        {
            string nome, ingredientes, categoria, dificuldade, preparacao, tempo, pessoas;

            bool Historico = File.Exists($@"C:\\Users\\PC\\Desktop\\Receitas\\" + textBoxNome.Text + ".txt");

            if (Historico == true)
            {
                FileStream FS = new FileStream($@"C:\\Users\\PC\\Desktop\\Receitas\\" + textBoxNome.Text + ".txt", FileMode.Open, FileAccess.Read);
                StreamReader SR = new StreamReader(FS);

                while (SR.Peek() != -1)
                {
                    string linha = SR.ReadLine();

                    string[] dados = linha.Split(';');

                    nome = dados[0];
                    tempo = dados[1];
                    categoria = dados[2];
                    pessoas = dados[4];
                    dificuldade = dados[3];
                    ingredientes = dados[5];
                    preparacao = dados[6];
                    textBoxIngredientes.Text = nome;
                    textBoxTempo.Text = tempo;
                    textBoxIngredientes.Text = ingredientes;
                    comboBoxDificuldade.Text = dificuldade;
                    comboBoxCategoria.Text = categoria;
                    textBoxPreparacao.Text = preparacao;
                    comboBoxPessoas.Text = pessoas;

                    dgvReceitas.Rows.Add(nome, tempo, categoria, pessoas, dificuldade, ingredientes, preparacao);
                }
                SR.Close();
            }

            else
            {
                MessageBox.Show("A receita não existe!");
            }
        }   
        private void toolStripButtonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AtualizardgvReceitas()
        {
            string nome, ingredientes, categoria, dificuldade, preparacao, tempo, pessoas;

            FileStream FS = new FileStream($@"C:\\Users\\PC\\Desktop\\Receitas\\" + textBoxNome.Text + ".txt", FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(FS);

            while (SR.Peek() != -1)
            {
                string linha = SR.ReadLine();

                string[] dados = linha.Split(';');

                nome = dados[0];
                tempo = dados[1];
                categoria = dados[2];
                pessoas = dados[3];
                dificuldade = dados[4];
                ingredientes = dados[5];
                preparacao = dados[6];

                dgvReceitas.Rows.Add(nome,tempo,categoria,dificuldade,pessoas,ingredientes,preparacao);
            }
            SR.Close();
        }

        private void Limpar()
        {
            textBoxNome.Clear();
            textBoxIngredientes.Clear();
            textBoxPreparacao.Clear();
            textBoxTempo.Clear();
            comboBoxCategoria.SelectedIndex = -1;
            comboBoxDificuldade.SelectedIndex = -1;
            comboBoxPessoas.SelectedIndex = -1;
            comboBoxCategoria.Text = "";
            comboBoxDificuldade.Text = "";
            comboBoxPessoas.Text = "";
        }       

        private void EliminarReceita()
        {
            bool Historico = File.Exists($@"C:\\Users\\PC\\Desktop\\Receitas\\" + textBoxNome.Text + ".txt");

            if (Historico == true)
            {
                File.Delete($@"C:\\Users\\PC\\Desktop\\Receitas\\" + textBoxNome.Text + ".txt");
                MessageBox.Show("Receita eliminada com sucesso");
                Limpar();
            }
            else
            {
                MessageBox.Show("A receita não existe!");
            }
        }
    }
}
