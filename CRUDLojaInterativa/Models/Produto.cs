using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDLojaInterativa.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public int FabricanteId { get; set; }

        [Required]
        [Range(1, 3)]
        public Categoria Categoria { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
        public decimal Preco { get; set; }
    }

    public enum Categoria : int
    {
        Categoria1 = 1,
        Categoria2 = 2,
        Categoria3 = 3
    };
}
