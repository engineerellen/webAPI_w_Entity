using System;
using System.Collections.Generic;

namespace Aula12.Models
{
    public partial class TipoProd
    {
        public TipoProd()
        {
            Produto = new HashSet<Produto>();
        }

        public int CodTipoProd { get; set; }
        public string NomeTipoProd { get; set; }

        public virtual ICollection<Produto> Produto { get; set; }
    }
}
