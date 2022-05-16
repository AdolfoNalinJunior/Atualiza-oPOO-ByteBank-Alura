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
            if (valor <= 0)
            {
                Console.WriteLine("Adicione um valor que seja maior que 0 ");
            }

            else
            {
                saldo += valor;
            }
        }

        public void Tranferir(double valor)
        {
            if (saldo < valor)
            {
                Console.WriteLine("Trasferência não executada, por falta de saldo");
            }
            else
            {
                saldo -= valor;
            }
        }

    }
}