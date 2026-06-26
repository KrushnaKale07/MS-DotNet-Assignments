using System.ComponentModel.DataAnnotations;

namespace WebAppDay8.Models
{
    public class Product : IValidatableObject
    {
        [Required(ErrorMessage = "Id is required field")]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Name is required field")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Name can only have alphabets")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price is required field")]
        [Range(10.0, 10000.0, ErrorMessage = "Price must be in between 10 to 10K")]
        public float? Price { get; set; }

        [Required(ErrorMessage = "Description is required field")]
        [StringLength(500, ErrorMessage = "Description can't exceed 500 characters")]
        public string Description { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Price > 5000 && !Description.Contains("Premium"))
            {
                yield return new ValidationResult("For Prudcts more 5000, description must contain Premium keyword", new[] { nameof(Description) });
            }
        }
    }
}
