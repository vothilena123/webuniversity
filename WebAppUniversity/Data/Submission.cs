using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebAppUniversity.Data
{
    [Table("Submissions")]
    public class Submission
    {
        public int Id { get; set; }
        public string? Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime? ClosureDate { get; set; }
        public DateTime? FinalClosureTime { get; set; }
    }
}
