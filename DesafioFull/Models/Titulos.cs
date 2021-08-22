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
     
    }
}
