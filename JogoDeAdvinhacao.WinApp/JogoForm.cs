using JogoDeAdvinhacao.ConsoleApp;

namespace JogoDeAdvinhacao.WinApp
{
    public partial class JogoForm : Form
    {
        Jogo jogo = new Jogo();

        public JogoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int palpite = int.Parse(txtPalpite.Text);

            if (jogo.PalpiteCerto(palpite) || jogo.Acabou())
            {
                MessageBox.Show(jogo.MensagemFinal);
                Close();
            }

            labelDica.Text = jogo.MensagemDica;
        }
    }
}