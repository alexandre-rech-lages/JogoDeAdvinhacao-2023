using System.Collections;

namespace JogoDeAdvinhacao.ConsoleApp
{
    public class Jogo
    {
        private int numeroSecreto = new Random().Next(1, 100);
        
        private ArrayList palpites = new ArrayList();

        public string MensagemDica { get; private set; }
        public string MensagemFinal { get; private set; }

        public bool PalpiteCerto(int palpite)
        {            
            if (palpite < 1 || palpite > 100)
            {
                MensagemDica = "Esse número está fora da faixa estipulada, tente outro!";
                return false;
            }

            if (palpites.Contains(palpite))
            {
                MensagemDica = "Você já tentou esse número, tente outro!";
                return false;
            }

            if (palpite != numeroSecreto)
            {
                MensagemDica = palpite < numeroSecreto ?
                  "O número secreto é maior." : "O número secreto é menor.";
                
                palpites.Add(palpite);

                return false;
            }
            else
            {
                MensagemFinal = $"Parabéns, você acertou o número em {palpites.Count} tentativas!";
                return true;              
            }
        }

        public bool Acabou()
        {
            if (palpites.Count >= 10)
            {
                MensagemFinal = $"Você não acertou o número em 10 tentativas. O número secreto era {numeroSecreto}.";
                return true;
            }

            return false;
        }
    }
}
