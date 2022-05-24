using Atualizado_ByteBank;
using Atualizado_ByteBank.Titular;

Console.WriteLine("Boa Vindas, ao seu banco, ByteBank!");

//ContaCorrente conta1 = new ContaCorrente();
//conta1.titular = "André Silva ";
//conta1.conta = "10123-x";
//conta1.numero_agencia = 23;
//conta1.nome_agencia = "Banco Central";
//conta1.saldo = 100;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "André silva ";
//conta2.conta = "10123-x";
//conta2.numero_agencia = 23;
//conta2.nome_agencia = "Banco Central";
//conta2.saldo = 100;

//Console.WriteLine("Saldo da conta do André " + conta1.saldo);
//Console.WriteLine("Saldo da conta da Amanada " + conta2.saldo);

//bool transferencia = conta1.Tranferir(50, conta2);

//Console.WriteLine("Saldo da conta do André " + conta1.saldo);
//Console.WriteLine("Saldo da conta da Amanada " + conta2.saldo);

//Console.WriteLine("Transferência foi realizada? " + transferencia);

//conta1.GetInformaçõesConta();

//Cliente cliente = new Cliente();
//cliente.nome = "Adolfo Nalin Junior ";
//cliente.cpf = "12344566778 ";
//cliente.profissao = "Programador ";

ContaCorrente conta3 = new ContaCorrente();
conta3.titular = new Cliente();
conta3.titular.nome = "Adolfo Nalin Junior ";
conta3.titular.cpf = "12344566778 ";
conta3.titular.profissao = "Programador ";
conta3.conta = "251325-X";
conta3.numero_agencia = 35;
conta3.nome_agencia = "Agencia Central ";

Console.WriteLine(conta3.titular.nome);
if(conta3.titular == null)
{
    Console.WriteLine("O campo titular está nulo ");
}  