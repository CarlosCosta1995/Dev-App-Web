// See https://aka.ms/new-console-template for more information
using CarlosCosta_2036114;

//public Conta(long numeroDeConta, string nomeTitular, string tipoConta, double saldoDaConta)
Conta carlos = new Conta(123456, "carlos", "poupanca", 150);

carlos.NomeTitularConta();
carlos.LevantarQuantia(50);
carlos.SaldoActual();
carlos.DepositarQuantia(50);

Conta Ana = new Conta(123456, "Ana", "poupanca", 150);

Ana.TransferirQuantia(Ana, carlos, 50);

Conta ContaSalario = new Conta(123456, "ContaSalario", "poupanca", 150);
ContaSalario.NomeTitularConta();
ContaSalario.Conta_v2();
ContaSalario.NomeTitularConta();

//public Costumer(string name)
Costumer customer = new Costumer("Carlos");
Console.WriteLine(customer.Name);

customer.MemberType = "Premium";
customer.Pagamento(40);

customer.MemberType = "Silver";
customer.Pagamento(40);

customer.MemberType = "Gold";
customer.Pagamento(40);

customer.MemberType = "Nada";
customer.Pagamento(40);