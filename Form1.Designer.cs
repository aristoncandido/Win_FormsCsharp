namespace FormsCSHARP;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
   private void InitializeComponent()
{
    // Criação dos controles
    Label labelNota1 = new Label();
    TextBox textBoxNota1 = new TextBox();
    Label labelNota2 = new Label();
    TextBox textBoxNota2 = new TextBox();
    Button buttonCalcularMedia = new Button();

    // Configuração dos controles
    labelNota1.Text = "Nota 1:";
    textBoxNota1.Location = new Point(100, 50);
    labelNota2.Text = "Nota 2:";
    textBoxNota2.Location = new Point(100, 80);
    buttonCalcularMedia.Text = "Calcular Média";
    buttonCalcularMedia.Location = new Point(100, 110);
    buttonCalcularMedia.Click += buttonCalcularMedia_Click;

    // Adicionando os controles ao formulário
    Controls.Add(labelNota1);
    Controls.Add(textBoxNota1);
    Controls.Add(labelNota2);
    Controls.Add(textBoxNota2);
    Controls.Add(buttonCalcularMedia);

    // Resto do código gerado automaticamente
}

    #endregion
}
