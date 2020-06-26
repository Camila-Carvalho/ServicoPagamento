using Servicos;
namespace Servicos
{
    class ServicoParcela : IPagamentoOnlineParcelas
    {
        public double Parcela(double valor, int meses)
        {
            return valor * 0.01 * meses;
        }
        public double PagamentoTaxa(double valor)
        {
            return valor * 0.02;
        }
    }
}
