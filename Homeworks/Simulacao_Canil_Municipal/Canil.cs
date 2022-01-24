using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacao_Canil_Municipal
{
    public class Animals
    {
        public List<Dog> DogList  = new List<Dog>(3);
        public List<Cat> CatList = new List<Cat>(2);
    }

    //Dogs section
    public class Dog
    {
        public string DogName { get; set; }

        public void AddDog(string dogName)
        {
            Animals dog = new Animals();
            Dog dog1 = new Dog();
            dog1.DogName = dogName;
            dog.DogList.Add(dog1);

            Console.WriteLine("Seu cao foi adicionado ao canil com o nome de {0}", dog1.DogName);
        }

        public void AdoptDog(Dog nomeCao)
        {
            Animals dog = new Animals();
            bool dogListed = dog.DogList.Contains(nomeCao);
            if (dogListed == true)
            {
                Console.WriteLine("Adoção do cao previamente chamado de {0}", nomeCao.DogName);
                dog.DogList.RemoveAt(dog.DogList.IndexOf(nomeCao));
            }
            else
            {
                Console.WriteLine("Cão nao encontrado! Chamado de {0}", nomeCao.DogName);
            }
        }
    }

    //Cat section
    public class Cat
    {
        private string[] cat = new string[2];

        public Array addCat(string dogName)
        {
            if (cat.Length <= 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    cat[i] = dogName;
                }
            }
            else
            {
                Console.WriteLine("Canil dos gatos cheio!");
            }
            return cat;
        }

        public Array AdoptDog(int escolherCao)
        {
            Console.WriteLine("Adoção do gato previamente chamado de {0}", cat[escolherCao].ToString());
            cat[escolherCao] = "";
            return cat;
        }
    }
}
