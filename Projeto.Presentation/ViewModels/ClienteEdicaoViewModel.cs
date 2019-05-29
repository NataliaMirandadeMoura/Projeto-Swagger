using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.ViewModels
{
    public class ClienteEdicaoViewModel
    {
        [Required (ErrorMessage ="{0} é orbigatório")]
        public int IdCliente { get; set; }
        [MinLength(3, ErrorMessage ="{0} deve conter no mínimo {1} caracteres")]
        public string Nome { get; set; }
        [EmailAddress (ErrorMessage ="{0} deve ser um endereço de e-mail válido")]
        [Required(ErrorMessage ="{0} é obrigatório")]
        public string Email { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
