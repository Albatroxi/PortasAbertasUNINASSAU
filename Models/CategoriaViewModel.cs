using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PortasAbertasUNINASSAU.Models
{
    public class CategoriaViewModel
    {
        public Int32 CategoriaId { get; set; }
        [Required(ErrorMessage = "O nome da categoria é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome da Categoria")]
        public String CategoriaNome { get; set; }
    }
}