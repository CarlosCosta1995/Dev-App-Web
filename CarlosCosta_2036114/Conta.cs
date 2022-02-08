using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosCosta_2036114
{
    public class Conta
    {
        public double _numeroDaConta;
        public string _nomeTitular;
        public string _tipoConta;
        public double _saldoDaConta;

        public Conta(long numeroDeConta, string nomeTitular, string tipoConta, double saldoDaConta)
        { 
            this._numeroDaConta = numeroDeConta;
            this._nomeTitular = nomeTitular; 
            this._tipoConta = tipoConta;
            this._saldoDaConta = saldoDaConta;
        }
        
        //Falta fazeruma verificação com if's
        public double LevantarQuantia(double quantiaLevantar)
        {
            _saldoDaConta -= quantiaLevantar;
            Console.WriteLine("Valor levantado {0} e saldo actual {1}", quantiaLevantar, _saldoDaConta);
            return quantiaLevantar;
        }
        
        
        public double DepositarQuantia(double quantiaDepositar)
        {
            _saldoDaConta += quantiaDepositar;
            Console.WriteLine("Valor depositado {0} e saldo actual {1}", quantiaDepositar, _saldoDaConta);
            return quantiaDepositar;
        }
        
        //pode ser atraves das propriedades (get e set)
        public void NomeTitularConta()
        {
            Console.WriteLine("O titular da conta, cujo o número da conta {0}, é {1}", _nomeTitular, _numeroDaConta);
        }
        
        //Deveria returnar um valor
        public void SaldoActual()
        {
            Console.WriteLine("O seu saldo actual é de: {0}", _saldoDaConta);
        }
        
        //Falta fazer verificação com if's
        public void TransferirQuantia(Conta transferir, Conta recebeTransferencia, double valorTransferir)
        {
            transferir._saldoDaConta -= valorTransferir;
            recebeTransferencia._saldoDaConta += valorTransferir;
            Console.WriteLine("O valor transferido foi de {0}, da conta {1} para a conta {2}", valorTransferir, transferir._numeroDaConta, recebeTransferencia._numeroDaConta);
        }
        
        //Falta fazer o return, criar uma variavel que va somando o total levantado diariamente.
        public void LevantarQuantiaLimite(double quantia)
        {
            if (quantia <= 300)
            {
                Console.WriteLine("Levantamento Aceite!");
                LevantarQuantia(quantia);
            }
            else
            {
                Console.WriteLine("Quantia Limite atingida! Quantia máxima diária é de 300 euros.");
            }
        }

        public void Conta_v2()
        {
            Console.WriteLine("Qual o tipo de conta que deseja?");
            Console.WriteLine("Escola das seguintes opções: Conta Corrente(1), Conta Poupança(2), Conta Salário(3), Conta Depósito Fixo(4) e Conta Deposito Recorrente(6),");

            int numeroEscolha = int.Parse(Console.ReadLine());
            switch (numeroEscolha)
            { 
                case 1:
                    Console.WriteLine("Sua conta foi definida como Conta Corrente.");
                    _tipoConta = "Conta Corrente";
                    break;
                case 2:
                    Console.WriteLine("Sua conta foi definida como Conta Poupança.");
                    _tipoConta = "Conta Poupança";
                    break;
                case 3:
                    Console.WriteLine("Sua conta foi definida como Conta Salário.");
                    _tipoConta = "Conta Salário";
                    break;
                case 4:
                    Console.WriteLine("Sua conta foi definida como Conta Depósito Fixo.");
                    _tipoConta = "Conta Depósito Fixo";
                    break;
                case 5:
                    Console.WriteLine("Sua conta foi definida como Conta Deposito Recorrente.");
                    _tipoConta = "Conta Deposito Recorrente";
                    break;
                default:
                    Console.WriteLine("Escolha invalida.");
                    break;
            }    
        }

    }
}
