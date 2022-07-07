using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prototype2WebApi.Models
{
    [Table("Schedule")]
    public class Schedule
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ScheduleId { get; set; }
        public int TaskName { get; set; }
        public int Description { get; set; }
        public int Completed { get; set; }
    }
}
