using System.ComponentModel.DataAnnotations;

namespace MeetingServices.Model
{
   
        public class Meeting
        {
            [Key]
            public int Id { get; set; }
            [Required]
            public string Title { get; set; }
            public string? Description { get; set; }
            [Required]
            public DateTime Date { get; set; }
        }
}
