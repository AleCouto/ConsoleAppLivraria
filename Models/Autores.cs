using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria
{
    public partial class Autor
    {
        public int autorId { get; set; }
        public string nomeautor { get; set; }
        public string pais { get; set; }
        public string lingua { get; set; }

        public ICollection<Autoria> Autorias { get; set; }

    }
}

