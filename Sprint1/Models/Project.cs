using System.ComponentModel.DataAnnotations;

namespace Sprint1.Models
{
    public class Project
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public DateTime  StartDate { get; set; }
        [Required]
        public int CurVerNum { get; set; }
        [Required]
        public string? Url { get; set; }
      
        // Nav Properties
        public ICollection<Ticket> Tickets { get; set; }

    }
}
