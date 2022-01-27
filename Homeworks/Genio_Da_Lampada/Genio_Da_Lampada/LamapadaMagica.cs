using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genio_Da_Lampada
{
    /*Funcionalidade da lâmpada mágica
    Uma lâmpada mágica liberta génios quando esfregada (método rub). Os génios podem ser bem ou malhumorados.
    O humor dos génios é determinado pelas condições da lâmpada: sempre que a lâmpada tiver
    sido esfregada um número par de vezes (sem contar a actual), o génio sai mal-humorado. A quantidade
    de génios disponíveis é determinada no momento de encantamento da lâmpada (criação). Depois de
    esgotados os génios disponíveis, já não adianta esfregar a lâmpada para obter um génio, bem ou malhumorado:
    nestas condições, a lâmpada cria um pequeno demónio que responde a pedidos de forma
    literal mas perversa. Devido a requisitos de sustentabilidade ambiental, as normas de produção exigem
    que as lâmpadas sejam recarregáveis. Assim, é possível voltar a obter génios quando se esfrega a
    lâmpada (em número igual ao inicial). O processo de recarregamento exige apenas que um demónio seja
    alimentado à lâmpada.
    Quando se cria uma nova lâmpada é necessário indicar a quantidade inicial de génios que é possível
    invocar. É possível saber quantos génios ainda estão disponíveis na lâmpada. É ainda possível saber
    quantas vezes a lâmpada já foi recarregada. Quando se esfrega a lâmpada, deve-se indicar quantos
    desejos se espera que o génio realize (independentemente de o génio os poder negar).
    Nota: a lâmpada liberta apenas um génio de cada vez.*/

    public class LampadaMagica
    {
        private int numberOfRubs { get; set; }
        private int numberOfWishes { get; set; }

        public int Rubs
        {
            get { return numberOfRubs; }
            set { numberOfRubs = value; }
        }

        public int Wishes
        {
            get { return numberOfWishes; }
            set { numberOfWishes = value; }
        }

        public LampadaMagica ()
        {
            Genios.GerarGenios();
        }

        public void Rub(int rubs)
        {
            this.numberOfRubs = rubs;
            Genios genios = new Genios();

            if (numberOfRubs % 2 == 0 )
            {
                Console.Clear();
                genios.GenioMau();
                numberOfRubs--;
            }
            else if (numberOfRubs % 2 != 0)
            {
                Console.Clear();
                genios.GenioBom();
                numberOfRubs--;
            }
            else if (genios.geniosBons == 0 && genios.geniosMaus == 0)
            {
                Console.Clear();
                genios.Demonio();
                numberOfRubs--;
            }
            else if (genios.geniosBons == 0 && genios.geniosMaus == 0 && genios.demonios == 0)
            {
                Console.WriteLine("Acabou o jogo!");
                Environment.Exit(0);
            }
        }
    }
}
