using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtualizaEstoque
{
    internal class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            if (quantidade > Quantidade)
                Quantidade = 0;

            else
                Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"{_nome}, R${Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidade(s), Total: {ValorTotalEmEstoque().ToString("F2")}";
        }
    }
}
