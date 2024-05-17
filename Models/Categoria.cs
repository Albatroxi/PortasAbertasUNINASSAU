using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PortasAbertasUNINASSAU.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        public int CategoriaId { get; set; }
        [Display(Name = "Nome da Categoria")]
        public String CategoriaNome { get; set; }

        public List<Categoria> Categorias { get; set; }
    }
}