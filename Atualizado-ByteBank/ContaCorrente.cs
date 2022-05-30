using Atualizado_ByteBank.Titular;

namespace Atualizado_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public string conta;
        public int numero_agencia;
        public string nome_agencia;
        private double saldo;

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

        //public void SetSando(double valor)
        //{
        //    if (valor < 0)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        saldo += valor;
        //    }
        //}

        public double Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    saldo += value;
                }
            }
        }


        public double GetSaldo()
        {
            return saldo;
        }
    }
}
// Quando o método vai manipular o ele é Set é e void
// Quando o método vai retornar um tipo ele é um Get