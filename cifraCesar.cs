namespace CifraDeCesar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }

        private void encriptar_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Empty;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                int txtUsuario = (int)textBox1.Text[i];
                int txtCifrado = txtUsuario +3;
                textBox2.Text += char.ConvertFromUtf32(txtCifrado);
            }
        }

        private void decriptar_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Empty;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                int txtCifrado = (int)textBox2.Text[i];
                int txtOriginal = txtCifrado - 3;
                textBox2.Text += char.ConvertFromUtf32(txtOriginal);
            }
        }
    }
}