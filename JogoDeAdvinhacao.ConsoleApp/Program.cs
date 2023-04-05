namespace JogoDeAdvinhacao.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogo jogo = new Jogo();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Bem-vindo ao Jogo de Adivinhar Números!");
                Console.Write("Informe um número entre 1 e 100: ");

                int palpite = int.Parse(Console.ReadLine());

                if (jogo.PalpiteCerto(palpite) || jogo.Acabou())
                {
                    ApresentarMensagem(jogo.MensagemFinal);
                    break;
                }

                ApresentarMensagem(jogo.MensagemDica);
            }
        }

        static void ApresentarMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.ReadLine();
        }
    }
}