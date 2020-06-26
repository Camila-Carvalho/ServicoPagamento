namespace Servicos
{
    interface IPagamentoOnlineParcelas
    {
        double PagamentoTaxa(double valor);
        double Parcela(double valor, int meses);
    }
}
