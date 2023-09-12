using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Aula1_aspnet.Models;

namespace Aula1_aspnet.Models
{
    public class ContatoModel
    {

        public int Id { get; set; }
        [Required (ErrorMessage = "Digite o nome do contato")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "Digite o e-mail do contato")]
        [EmailAddress(ErrorMessage = "E-mail invalido")]
        public string? Email { get; set;}
        [Required(ErrorMessage = "Digite o celular do contato")]
        public string? Celular { get; set;}
    }
}
