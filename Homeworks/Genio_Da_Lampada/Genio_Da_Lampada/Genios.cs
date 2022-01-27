using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genio_Da_Lampada
{
    /*
    //Funcionalidade do génio bem-humorado
    O génio bem-humorado concede todos os desejos que lhe forem colocados, até ao limite com que foi
    chamado da lâmpada. Depois do limite já não são concedidos desejos. É possível saber quantos desejos
    já foram concedidos e quantos ainda existem disponíveis.
    Nota: o génio concede apenas um desejo de cada vez.

    //Funcionalidade do génio mal-humorado
    O génio mal-humorado concede apenas o primeiro desejo que lhe for colocado, independentemente do
    limite com que foi chamado da lâmpada. É possível saber se o desejo já foi realizado.

    //Funcionalidade do demónio reciclável
    O demónio concede todos os desejos que lhe forem colocados, independentemente do limite com que
    foi chamado da lâmpada. Se o demónio for recolocado na lâmpada (para a recarregar), já não pode realizar
    mais desejos. É possível saber quantos desejos já foram concedidos .
    Nota: o demónio concede apenas um desejo de cada vez.*/

    public class Genios : LampadaMagica
    {

        private static int _totalGenios { get; set; }
        private static int _geniosBons { get; set; }
        private static int _geniosMaus { get; set; }
        private static int _demonios { get; set; }

        private static int invocarGenioMau { get; set; }
        private static int LampRecarregar { get; set; }

        public int geniosBons
        {
            get { return _geniosBons; }
            set { _geniosBons = value; }
        }

        public int geniosMaus
        {
            get { return _geniosMaus; }
            set { _geniosMaus = value; }
        }

        public int demonios
        {
            get { return _demonios; }
            set { _demonios = value; }
        }

        public static void GerarGenios()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Gerando Génios!");
            for (int i = 0; i < 3; i++)
            {
                Random random = new Random();

                if (_geniosBons == 0)
                {
                    _geniosBons = random.Next(1,10);
                    Console.WriteLine("Genios Bons: " + _geniosBons);
                }
                else if (_geniosBons != 0 && _geniosMaus == 0)
                {
                    _geniosMaus = random.Next(1, 10);
                    Console.WriteLine("Genios Maus: " + _geniosMaus);
                }
                else if (_geniosBons != 0 && _geniosMaus != 0)
                {
                    _demonios = random.Next(1, 10);
                    Console.WriteLine("Demonios: " + _demonios);
                }
            }
            _totalGenios = _geniosBons + _geniosMaus + _demonios;
            Console.WriteLine("Total Genios: " + _totalGenios);
            Console.WriteLine("-------------------------");
        }

        private static void RecarregarLampada()
        {
            Random random2 = new Random();
            _geniosBons += random2.Next(1, 10);
            _geniosMaus += random2.Next(1, 10);
            _totalGenios = _geniosBons + _geniosMaus + _demonios;

            Console.WriteLine("-------------------------");
            Console.WriteLine("Recarregando Lampada");
            Console.WriteLine("Genios Bons gerados {0} e Genios Maus gerados {1}", _geniosBons, _geniosMaus);
            Console.WriteLine("Total Genios: " + _totalGenios);
            Console.WriteLine("-------------------------");
        }

        public void GenioBom()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Parabéns! Saiu-lhe Génio de Aladin, um génio bom!");
            Console.WriteLine("Génio de Aladin: Concedo-lhe UM dos seus muitos desejos. Boa sorte no futuro!");
            Console.WriteLine("-------------------------");

            _geniosBons--;
            _totalGenios = _geniosBons + _geniosMaus + _demonios;
            Console.WriteLine();
            Console.WriteLine("Genios Bons restantes: " + _geniosBons);
            Console.WriteLine("Total Genios restantes: " + _totalGenios);
        }

        public void GenioMau()
        {
            if (invocarGenioMau == 0)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Saiu-lhe o Génio Mau, Jafar!");
                Console.WriteLine("Jafar: Hoje estou bem disposto.\nVou conveder O desejo que queria!\nApenas desta vez....");
                Console.WriteLine("-------------------------");
                invocarGenioMau++;

                _geniosMaus--;
                _totalGenios = _geniosBons + _geniosMaus + _demonios;
                Console.WriteLine();
                Console.WriteLine("Genios Maus restantes: " + _geniosMaus);
                Console.WriteLine("Total Genios restantes: " + _totalGenios);
            }
            else if (invocarGenioMau > 0 && invocarGenioMau % 2 == 0)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("MUAHAHAH! Génio Jafar foi invocado!");
                Console.WriteLine("Jafar: TU OUTRA VEZ!?\nO teu desejo agora é MEU!");
                Console.WriteLine("-------------------------");
                invocarGenioMau++;

                _geniosMaus--;
                _totalGenios = _geniosBons + _geniosMaus + _demonios;
                Console.WriteLine();
                Console.WriteLine("Genios Maus restantes: " + _geniosMaus);
                Console.WriteLine("Total Genios restantes: " + _totalGenios);
            }
            else if (invocarGenioMau > 0 && invocarGenioMau % 2 != 0)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Génio Jafar!");
                Console.WriteLine("Jafar: POBRE CRIATURA!!\nVou acabar ficando com todos os teus desejos... MUHAHAHA!");
                Console.WriteLine("-------------------------");
                invocarGenioMau++;

                _geniosMaus--;
                _totalGenios = _geniosBons + _geniosMaus + _demonios;
                Console.WriteLine();
                Console.WriteLine("Genios Maus restantes: " + _geniosMaus);
                Console.WriteLine("Total Genios restantes: " + _totalGenios);
            }
        }

        public void Demonio()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Invocando demónio Pazuzu!\nO que vai fazer?");
            Console.WriteLine("Escreva 1 ou 2\n1.Pedir desejo...\n2.Recarregar lampada com o demónio!");
            int butao = int.Parse(Console.ReadLine());

            switch (butao)
            {
                case 1:
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Pazuzu: Desejo dado...");
                    Console.WriteLine("-------------------------");
                    _demonios--;
                    _totalGenios--;
                    Console.WriteLine();
                    Console.WriteLine("Demonios restantes: " + _demonios);
                    Console.WriteLine("Total Genios restantes: " + _totalGenios);
                    break;
               case 2:
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Recarregar lampada!");
                    Console.WriteLine("-------------------------");
                    _demonios--;
                    _totalGenios--;
                    Console.WriteLine();
                    RecarregarLampada();
                    break;
            }
        }
    }
}
