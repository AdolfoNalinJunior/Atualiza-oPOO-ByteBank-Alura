using Atualizado_ByteBank;

Console.WriteLine("Boa Vindas, ao seu banco, ByteBank!");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "André Silva";
conta1.conta = "10123-x";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Banco Central";
conta1.saldo = 100;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "Amanda Silva ";
//conta2.conta = "10106-x ";
//conta2.numero_agencia = 321;
//conta2.nome_agencia = "Banco Central ";
//conta2.saldo = 100;

//Console.WriteLine("Titular: " + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Número Agencia: " + conta1.numero_agencia);
//Console.WriteLine("Nome da Agencia: " + conta1.nome_agencia);
//Console.WriteLine("Saldo: " + conta1.saldo);

Console.WriteLine(conta1.caracter_especial);

double saldo = 100;
double saldo2 = conta1.saldo;
conta1.saldo = 200;

Console.WriteLine(saldo == conta1.saldo);
Console.WriteLine(saldo == saldo2);