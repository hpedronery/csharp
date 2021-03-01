using System.Globalization;

namespace Classe
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public double Quantidade;

        public double ValorTotal()
        {
            return Preco * Quantidade;
        }

        public double AdicionarProdutos(double quantidade)
        {
            return Quantidade += quantidade;
        }

        public double RemoverProdutos(double quantidade)
        {
            return Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
