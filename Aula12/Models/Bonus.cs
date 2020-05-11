using System;
using System.Collections.Generic;

namespace Aula12.Models
{
    public partial class Bonus
    {
        public int NumLanc { get; set; }
        public int CodFunc { get; set; }
        public DateTime DataBonus { get; set; }
        public decimal ValBonus { get; set; }

        public virtual Funcionario CodFuncNavigation { get; set; }
    }
}
