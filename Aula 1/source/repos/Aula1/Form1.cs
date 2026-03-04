using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //formatar a identação: Ctrl + K + D
            string nome, sobrenome; //1º Declaração de variáveis

            nome = textBox1.Text; //Atribuição de valor a varável, pegando o valor digitado no textBox1
            sobrenome = textBox2.Text;

            label3.Text = nome+" "+sobrenome;//Exibe o conteúdo da variável no label3

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); // Clear limpa a textbox
            textBox2.Clear();
            label3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Fecha a aplicação
        }
    }
}
