using System.ComponentModel.DataAnnotations;

namespace WebApplDay9.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        [Required]
        public string Author { get; set; }
        
        [Required]
        public float Price {  get; set; }

    }
}
