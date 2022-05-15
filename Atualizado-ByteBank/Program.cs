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

conta1 = conta2;

Console.WriteLine(conta1 == conta2);