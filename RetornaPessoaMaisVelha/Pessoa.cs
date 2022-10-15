using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetornaPessoaMaisVelha
{
    internal class Pessoa
    {
        public string Nome;
        public int Idade;

        public static string RetornarPessoaMaisVelha(Pessoa pessoa1, Pessoa pessoa2)
        {
            if (pessoa1.Idade > pessoa2.Idade)
                return $"Pessoa mais velha: {pessoa1.Nome}";
            else if (pessoa1.Idade == pessoa2.Idade)
                return "As duas pessoas possuem a mesma idade.";
            return $"Pessoa mais velha: {pessoa2.Nome}";
        }
    }
}
