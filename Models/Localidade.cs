using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Livraria
{
    public class Localidade
    {
        public int localidadeId { get; set; }
        public string Local { get; set; }
    }
}
