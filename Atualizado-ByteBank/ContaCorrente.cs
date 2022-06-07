using Atualizado_ByteBank.Titular;

namespace Atualizado_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        private string _conta;
        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Por favor, digite uma conta válida!! ");
                }
                else
                {
                    _conta = value;
                }
            }
        }
        private int _numero_agencia;
        public int Numero_Agencia 
        { get
            {
                return _numero_agencia;
            }
            set 
            {
                if (value <= 0)
                {
                    Console.WriteLine("Digite um número de agência válido! " );
                }
                else
                {
                    _numero_agencia = value;
                }
            }
        }
        public string Nome_Agencia { get; set; }
       
        private double _saldo;
        public double Saldo
        {
            get
            {
                return _saldo;
            }

            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    _saldo += value;
                }
            }
        }

        public static int TotalContasCriadas { get; protected set; }
        public ContaCorrente(int numero_agencia, string conta)
        {
            Numero_Agencia = numero_agencia;
            Conta = conta;

            TotalContasCriadas++;
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else if (valor < 0)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Tranferir(double valor, ContaCorrente destino)
        {
            if (_saldo < valor)
            {
                Console.WriteLine("Trasferência não executada, por falta de _saldo");
                return false;
            }
            else
            {
                _saldo -= valor;
                destino._saldo += valor;
                return true;
            }
        }
    }
}
// Quando o método vai manipular o ele é Set é e void
// Quando o método vai retornar um tipo ele é um Get