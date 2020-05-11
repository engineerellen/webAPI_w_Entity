using System;
using System.Collections.Generic;

namespace Aula12.Models
{
    public partial class Pais
    {
        public Pais()
        {
            Estado = new HashSet<Estado>();
        }

        public int CodPais { get; set; }
        public string NomePais { get; set; }

        public virtual ICollection<Estado> Estado { get; set; }
    }
}
