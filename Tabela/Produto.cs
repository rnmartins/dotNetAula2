using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetAula2.Tabela
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataDeValidade { get; set;}

        public decimal Valor { get; set; }
    }
}