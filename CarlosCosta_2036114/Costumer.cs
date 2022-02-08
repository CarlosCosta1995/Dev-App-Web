using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosCosta_2036114
{
    public class Costumer
    {
        private string _name;
        //Member deveria ser bool
        private string _member;
        private string _memberType;

        public Costumer(string name)
        {
            this._name = name;
        }

        public string Name { get { return _name; } }

        public string MemberType
        { get { return _memberType; } 
           set { _memberType = value; }
        }
         
        //Falta a verificação de ser membro if's (se é ou nao)
        public string isMember()
        {
            return _memberType;
        }
        
        //Deveria ser um bool
        public void setMember(string x)
        {
            this._member = x;
        }
        
        //Mudar o tipo de returno para double, acrescentar customer como parametro (tambem),
        //Verificar o tipo de membro (default == Silver)
        public void Pagamento (double valorPagar)
        {
            if (_memberType == "Premium")
            {
                valorPagar *= 0.80;
                Console.WriteLine("Valor a pagar é de {0}", valorPagar);
            }
            else if (_memberType == "Silver")
            {
                valorPagar *= 0.85;
                Console.WriteLine("Valor a pagar é de {0}", valorPagar);
            }
            else if (_memberType == "Gold")
            {
                valorPagar *= 0.90;
                Console.WriteLine("Valor a pagar é de {0}", valorPagar);
            }
            else 
            {
                Console.WriteLine("Valor a pagar é de {0}", valorPagar);
            }
        }

    }
}
