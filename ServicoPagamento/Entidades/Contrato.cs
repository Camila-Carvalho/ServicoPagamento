using System;
using System.Collections.Generic;
namespace Entidades
{
    class Contrato
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }
        public List<Parcela> Parcelas { get; set; }

        public Contrato(int numero, DateTime data, double valorTotal)
        {
            Numero = numero;
            Data = data;
            ValorTotal = valorTotal;
            Parcelas = new List<Parcela>(); //necessário instanciar a parcela
        }

        //função para adicionar um contrato
        public void AddParcela (Parcela parcela)
        {
            Parcelas.Add(parcela);
        }
    }
}
