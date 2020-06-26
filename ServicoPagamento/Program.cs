using System;
using Entidades;
using Servicos;

namespace ServicoPagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados do contrato: ");
            Console.Write("Número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write("Valor do contrato: ");
            double valorContrato = double.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numero, data, valorContrato);

            Console.WriteLine();
            Console.Write("Informe o número de parcelas: ");
            int numMeses = int.Parse(Console.ReadLine());
            /* como fiz
            ServicoContrato servicoContrato = new ServicoContrato(contrato, numMeses, new ServicoParcela());
            */
            //como é para ser feito
            ServicoContrato servicoContrato = new ServicoContrato(new ServicoParcela());
            servicoContrato.ProcessamentoContratos(contrato, numMeses);

            Console.WriteLine("Parcelas:");
            foreach(Parcela parcela in contrato.Parcelas)//forench para passar por todas as parcelas
            {
                Console.WriteLine(parcela);
            }
        }
    }
}
