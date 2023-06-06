using System;
using System.Windows.Forms;

using System.Drawing;


namespace FormsCSHARP
{
    public partial class Form1 : Form

    {

        private TextBox textBoxNota1;
        private TextBox textBoxNota2;






        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcularMedia_Click(object sender, EventArgs e)
        {
            // Obter as notas digitadas pelo usuário
            double nota1 = Convert.ToDouble(textBoxNota1.Text);
            double nota2 = Convert.ToDouble(textBoxNota2.Text);

            // Calcular a média
            double media = (nota1 + nota2) / 2;

            // Exibir a média em uma caixa de mensagem
            MessageBox.Show("A média do aluno é: " + media.ToString("F2"));
        }
    }
}
