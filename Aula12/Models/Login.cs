using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aula12.Models
{
    public partial class Login
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O login deve ser inserido")]
        [MaxLength(10, ErrorMessage = "O nome deve conter no máximo 10 caracteres")]
        public string Login1 { get; set; }
        [Required(ErrorMessage = "A senha deve ser inserida")]
        public string Senha { get; set; }
        public int CodCli { get; set; }

        public virtual Cliente CodCliNavigation { get; set; }
    }
}
