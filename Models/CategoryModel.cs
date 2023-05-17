using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class CategoryModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage = "Display Order out of range! Enter value between 1-100!!")]
        public int DisplayOrder { get; set; }

        [DisplayName("Created At")]
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
