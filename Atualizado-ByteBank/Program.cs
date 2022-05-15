using Atualizado_ByteBank;

Console.WriteLine("Boa Vindas, ao seu banco, ByteBank!");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "André Silva";
conta1.conta = "10123-x";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Banco Central";
conta1.saldo = 100;

Console.WriteLine("Titular: " + conta1.titular);
Console.WriteLine("Conta: " + conta1.conta);
Console.WriteLine("Número Agencia: " + conta1.numero_agencia);
Console.WriteLine("Nome da Agencia: " + conta1.nome_agencia);
Console.WriteLine("Saldo: " + conta1.saldo);

SistemaEstoque estoque = new SistemaEstoque();

Console.WriteLine(estoque.codigo_barras);