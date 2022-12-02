using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDLojaInterativa.Models
{
    [Table("Fabricante")]
    public class Fabricante
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Display(Name = "Categoria 1")]
        [Required]
        public string Categoria1 { get; set; }

        [Display(Name = "Categoria 2")]
        public string? Categoria2 { get; set; }

        [Display(Name = "Categoria 3")]
        public string? Categoria3 { get; set; }
    }
}
