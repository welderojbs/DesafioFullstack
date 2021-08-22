using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFull.Models
{
    public class Titulos
    {
        public int      Id              { get; set; }
        public int      NumeroTitulo    { get; set; }
        public string   Nome            { get; set; }
        public string   Cpf             { get; set; }
        public decimal  Juros           { get; set; }
        public decimal  Multa           { get; set; }
        public int      NParcela        { get; set; }
        public string   DataVencimento  { get; set; }
        public decimal  ValorParc       { get; set; }
        public Parcelas  Parcelas       { get; set; }

        public Titulos()
        {

        }

        public Titulos(int id, int numeroTitulo, string nome, string cpf, decimal juros, decimal multa, int nParcela, string dataVencimento, decimal valorParc, Parcelas parcelas)
        {
            Id = id;
            NumeroTitulo = numeroTitulo;
            Nome = nome;
            Cpf = cpf;
            Juros = juros;
            Multa = multa;
            NParcela = nParcela;
            DataVencimento = dataVencimento;
            ValorParc = valorParc;
            Parcelas = parcelas;
        }
    }
}
