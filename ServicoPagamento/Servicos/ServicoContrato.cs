using System;
using Entidades;
using Servicos;

namespace Servicos
{
    class ServicoContrato
    {
        private IPagamentoOnlineParcelas _pagamento;

        public ServicoContrato(IPagamentoOnlineParcelas pagamento)
        {
            _pagamento = pagamento;
        }

        public void ProcessamentoContratos(Contrato contrato, int meses)
        {
            double valorBase = contrato.ValorTotal / meses;//para calcular o valor base
            for (int i = 1; i <= meses; i++)
            {
                DateTime data = contrato.Data.AddMonths(i);//aqui é para que todos os meses do campo data do contrato seja adicionado o valor de i
                double parcela = valorBase + _pagamento.Parcela(valorBase, i); //para calcular a parcela ele recebe o valor base(que já está dividido pelos meses) mais o i que indica a quantidade de meses
                double parcelaTaxa = parcela + _pagamento.PagamentoTaxa(parcela);

                contrato.AddParcela(new Parcela(data, parcelaTaxa));
            }
        }
    }
}
