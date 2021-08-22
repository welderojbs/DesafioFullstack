using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioFull.Models
{
    public class Parcelas
    {
        public int     id                   { get; set; }
        public int     PcNumTitulo          { get; set; }
        public int     NumeroParcela        { get; set; }
        public DateTime VencimentoParcela   { get; set; }
        public decimal ValorParcela         { get; set; }
        public decimal ValorTotal           { get; set; }
        public ICollection<Titulos> Dividas { get; set; } = new List<Titulos>();

        public Parcelas()
        {

        }

        public Parcelas(int id, int pcnumeroTitulo, int numeroParcela, DateTime vencimentoParcela, decimal valorParcela, decimal valorTotal)
        {
            this.id = id;
            PcNumTitulo = pcnumeroTitulo;
            NumeroParcela = numeroParcela;
            VencimentoParcela = vencimentoParcela;
            ValorParcela = valorParcela;
            ValorTotal = valorTotal;
        }

        public void AddDivida (Titulos tit)
        {
            Dividas.Add(tit);
        }

        public void RemoveDivida(Titulos tit)
        {
            Dividas.Remove(tit);
        }


        /*
        public decimal TotalDivida(DateTime inicial)
        {
            return Dividas.Sum(tit => tit.TotalDivida( tit.ValorParc * (tit.Juros / 100) + (tit.Multa /100)));
        }*/


    }
}
