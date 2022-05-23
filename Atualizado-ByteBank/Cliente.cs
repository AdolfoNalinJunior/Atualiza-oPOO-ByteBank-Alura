using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atualizado_ByteBank.Titular
{
    public class Cliente
    {
        public string nome;
        public string cpf;
        public string profissao;

        public void GetInformacoesCliente()
        {
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("CPF: " + this.cpf);
            Console.WriteLine("Profissão: " + this.profissao);
        }
    }
}
