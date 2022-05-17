namespace Atualizado_ByteBank
{
    public class ContaCorrente
    {
        public string titular;
        public string conta;
        public int numero_agencia;
        public string nome_agencia;
        public double saldo;

        public bool Sacar(double valor)
        {
            if(saldo < valor)
            {
                return false;
            }
            else if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Tranferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                Console.WriteLine("Trasferência não executada, por falta de saldo");
                return false;
            }
            else
            {
                saldo -= valor;
                destino.saldo += valor;
                return true;
            }
        }

        public void GetInformaçõesConta()
        {
            Console.WriteLine("Titular: " + this.titular);
            Console.WriteLine("Conta: " + this.conta);
            Console.WriteLine("Número Agência: " + this.numero_agencia);
            Console.WriteLine("Nome Agência: " + this.nome_agencia);
            Console.WriteLine("Saldo " + this.saldo);
        }
    }
}