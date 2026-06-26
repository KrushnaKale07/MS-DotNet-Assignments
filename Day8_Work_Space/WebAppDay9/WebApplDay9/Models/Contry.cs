using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplDay9.Models
{
    public class Contry
    {
        public int ContryId { get; set; }
        public string ContryName { get; set; }

        public ICollection<State>? States { get; set; }
    }
}
