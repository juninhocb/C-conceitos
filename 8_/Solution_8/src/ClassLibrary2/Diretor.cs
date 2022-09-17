using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Diretor : Pessoa
    {

        public double ProLabore { get; set; }

        public Diretor(string n, string s, double pl)
        {
            this.Nome = n;
            this.SobreNome = s;
            this.ProLabore = pl; 
        }

        public string VerificaStatus()
        {
            return "Hospital Ok!"; 
        }

        public string InfoDiretor()
        {

            return $"Diretor!\n {ApresentarNomeCustom()}" +
                $"Com seu grande ProLabore de R${ProLabore}" +
                $"\n Ação - {verificaAcao()}\n " +
                $"Defina uma ação![OK = DEMITIR]"; 
        }

        public string verificaAcao()
        {
            const string CAGADA_1 = "Sua recepecionista esqueceu de marcar a reunião";
            const string CAGADA_2 = "Sua recepcionista derrubou café no chão";
            const string BOA_1 = "Sua recpecionista tem se saído bem";
            Random random = new Random();
            int aleatorio = random.Next(1, 3);
            string[] acoes = new string[]
            {
                CAGADA_1,
                CAGADA_2,
                BOA_1
            };

            return $"{acoes[aleatorio]}"; 
        }

    }
}
