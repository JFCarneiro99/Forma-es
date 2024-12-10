using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomaVectores
{
    public partial class Form1 : Form
    {
        int [] val1= new int[10];
        int [] val2 = new int[10];
        int posVect1 = 0;
        int posVect2 = 0;
       
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = posVect1.ToString();
            textBox4.Text = posVect2.ToString();
            button6.Visible = false;
            textBox2.Focus();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int max = posVect1;
            if (posVect1< posVect2)
            {
                max = posVect2;
            }
            for (int i = 0; i < max; i++)
            {
                int soma = val1[i] + val2[i];
                listBox3.Items.Add(soma.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            string curItem = listBox1.SelectedIndex.ToString();
           // MessageBox.Show(curItem);
            textBox1.Text = curItem;
            string curItem2 = listBox1.SelectedItem.ToString();
            textBox2.Text = curItem2;
            button1.Visible = false;
            button6.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int pos1=int.Parse(textBox1.Text);
            val1[pos1] = int.Parse(textBox2.Text);
            textBox1.Text = posVect1.ToString();
            textBox2.ResetText();
            textBox2.Focus();
            button1.Visible = true;
            button6.Visible = false;
            button4_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            val1[posVect1] = int.Parse(textBox2.Text);
            posVect1++;
            textBox1.Text = posVect1.ToString();
            textBox2.ResetText();
            textBox2.Focus();
            if (posVect1 > 9)
            {
                button1.Enabled = false;
                textBox2.ReadOnly = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //limpar os valores da listbox1
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            
                for (int ctd = 0; ctd <= posVect1 - 1; ctd++)
                {
                    listBox1.Items.Add(val1[ctd].ToString());
                }
            
            
            for (int ctd2 = 0; ctd2 <= posVect2 - 1; ctd2++)
            {
                listBox2.Items.Add(val2[ctd2].ToString());
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                MessageBox.Show("Deu um enter vamos inserir os dados");
                val1[posVect1] = int.Parse(textBox2.Text);
                posVect1++;
                textBox1.Text = posVect1.ToString();
                textBox2.ResetText();
                if (posVect1 > 9)
                {
                    button1.Enabled = false;
                }
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) { 
            }
        }


        private void inserirDados()
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            val2[posVect2] = int.Parse(textBox3.Text);
            posVect2++;
            textBox4.Text = posVect2.ToString();
            textBox3.ResetText();
            textBox3.Focus();
            if (posVect2 > 9)
            {
                button2.Enabled = false;
                textBox3.ReadOnly = true;
            }
        }
    }
}
