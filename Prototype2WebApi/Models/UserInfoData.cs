using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prototype2WebApi.Models
{
    [Table("UserInfoData")]
    public class UserInfoData
    {
        /// <summary>
        /// Sample Data. This can still propbably be used for the final
        /// app.
        /// </summary>

        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public string CellNumber { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
