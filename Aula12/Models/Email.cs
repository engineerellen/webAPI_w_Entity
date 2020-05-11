using System;
using System.Collections.Generic;

namespace Aula12.Models
{
    public partial class Email
    {
        public int NumLanc { get; set; }
        public int CodCli { get; set; }
        public string EmailCli { get; set; }

        public virtual Cliente CodCliNavigation { get; set; }
    }
}
