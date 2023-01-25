using System.ComponentModel.DataAnnotations;

namespace Sprint1.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public TicketStatus Status { get; set; }
        [Required]
        public DateTime OpenDate { get; set; }
        public DateTime? ModifiedDate { get; set; }


        // nav properties
        public int ProjectId { get; set; }
        public Project Project { get; set; }    
    
    }

}
