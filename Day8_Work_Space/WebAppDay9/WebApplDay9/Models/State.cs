using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplDay9.Models
{
    public class State
    {
        public int StateId { get; set; }
        public string StateName { get; set; }

        [ForeignKey("Contry")]
        public int ContryId { get; set; }
        
        [NotMapped]
        public Contry Contry { get; set; }
    }
}
