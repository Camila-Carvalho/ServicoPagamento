using System;

namespace Entidades
{
    class Parcela
    {
        public DateTime DataVencimento { get; set; }
        public double ValorParcela { get; set; }

        public Parcela(DateTime dataVencimento, double valorParcela)
        {
            DataVencimento = dataVencimento;
            ValorParcela = valorParcela;
        }

        //a parcela é a que é impressa no programa, por isso ela possui a função de impressão
        public override string ToString()
        {
            return $"{DataVencimento.ToString("dd/MM/yyyy")} - {ValorParcela.ToString("F2")}";
        }
    }
}
