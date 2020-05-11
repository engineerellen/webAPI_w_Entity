using System;
using System.Collections.Generic;

namespace Aula12.Models
{
    public partial class Pontuacao
    {
        public int NumLanc { get; set; }
        public int CodFunc { get; set; }
        public DateTime DataPto { get; set; }
        public decimal PtoFunc { get; set; }

        public virtual Funcionario CodFuncNavigation { get; set; }
    }
}
