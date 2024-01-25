using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaOnline.ProductAPI.Model.Base
{
    public class BaseEntity 
    {
        [Key]
        [Column("id")]
        [Required]
        public long Id { get; set; }
    }
}
