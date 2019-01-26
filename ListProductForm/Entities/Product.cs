using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProductForm.Entities
{
    [Table("tblProducts")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(maximumLength: 255)]
        public string Name { get; set; }
        [StringLength(maximumLength: 255)]
        public string Image { get; set; }
        [ForeignKey("CategoryOf")]
        public int CategoryId { get; set; }
        public virtual Category CategoryOf { get; set; }
    }
}
