using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacao_Canil_Municipal
{
    //Dogs section
    public class Dog
    {
        private string[] dog  = new string[5];

        public string[] Doge 
        { 
            get { return dog; }
            set { dog = value; }
        } 

        public Array AddDog(string dogName)
        {
            dog = new string[] { dogName };
            return dog;
        }

        public Array AdoptDog(int escolherCao)
        {
            Console.WriteLine("Adoção do cao previamente chamado de {0}", dog[escolherCao].ToString());
            dog[escolherCao] = "";
            return dog;
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
