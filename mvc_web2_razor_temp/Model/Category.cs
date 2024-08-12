using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Book_web2_razor_temp.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Category Name")]  
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1-100")]
        public int DisPlayOrder { get; set; }
    }
}
