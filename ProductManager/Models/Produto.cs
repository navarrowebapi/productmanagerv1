using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManager.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }

        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }
        public string PrecoPt
        {
            get { return string.Format(new System.Globalization.CultureInfo("pt-BR"), "{0:C}", Preco); }
        }

    }
}
