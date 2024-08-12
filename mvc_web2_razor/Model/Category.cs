using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace mvc_web2_razor.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        [MaxLength(50)]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(0, 100, ErrorMessage = "Display Order must be between 1-100")]
        public int DisPlayOrder { get; set; }
    }
}
