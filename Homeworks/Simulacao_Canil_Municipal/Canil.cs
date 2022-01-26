using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacao_Canil_Municipal
{
    public class Canil
    {
        public int _capacidadeMaxima;
        public int _lugaresOcupados;
        public string _nomeCanil;
        //public List<Animal> _animal = new List<Animal>();
        public Animal[] listaAnimals;

        public Canil (string nome, int capacidade)
        {
            this._nomeCanil = nome;
            this._capacidadeMaxima = capacidade;
            this.listaAnimals = new Animal[capacidade];
        }
        public Animal[] registarAnimal(Animal animal)
        {
            for (int i = 0; i < _capacidadeMaxima; i++)
            {
                if (listaAnimals[i] == null)
                {
                    listaAnimals[i] = animal;
                    _capacidadeMaxima--;
                    _lugaresOcupados++;
                    break;
                }
                else
                {
                    Console.WriteLine("nao tem lugares disponiveis para acolher animals!");
                }
            }
            return listaAnimals;
        }

        public void adotarAnimal (int chip)
        {
            for (int i = 0; i < listaAnimals.Length; i++)
            {
                if (listaAnimals[i].chip == chip)
                {
                    listaAnimals[i] = null;
                    _capacidadeMaxima++;
                    _lugaresOcupados--;
                    Console.WriteLine("O animal com chip {0} foi adotado", chip);
                }
            }
        }
    }

    public class Animal
    {
        private string _nome;
        private string _tipoAnimal;
        private string _porte;
        private int _chip;
        private double _peso;

        public Animal(string nome, string tipoAnimal, string porte, int chip, double peso)
        {
            _nome = nome;
            _tipoAnimal = tipoAnimal;
            _porte = porte;
            _chip = chip;
            _peso = peso;
        }

        public string Nome { get { return _nome;} set { _nome = value; } }
        public string tipoAnimal { get { return _tipoAnimal; } set { _tipoAnimal = value; } }
        public string porte { get { return _porte; } set { _porte = value; } }
        public int chip { get { return _chip; } set { _chip = value; } }
        public double peso { get { return _peso; } set { _peso = value; } }
    }
}
