using Atualizado_ByteBank;

Console.WriteLine("Boa Vindas, ao seu banco, ByteBank!");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "André Silva ";
conta1.conta = "10123-x";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Banco Central";
conta1.saldo = 100;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "André silva ";
conta2.conta = "10123-x";
conta2.numero_agencia = 23;
conta2.nome_agencia = "Banco Central";
conta2.saldo = 100;

Console.WriteLine("Saldo da conta do André " + conta1.saldo);
Console.WriteLine("Saldo da conta da Amanada " + conta2.saldo);

bool transferencia = conta1.Tranferir(50, conta2);

Console.WriteLine("Saldo da conta do André " + conta1.saldo);
Console.WriteLine("Saldo da conta da Amanada " + conta2.saldo);

Console.WriteLine("Transferência foi realizada? " + transferencia);

conta1.GetInformaçõesConta();