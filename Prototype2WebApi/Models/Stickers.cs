using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prototype2WebApi.Models
{
    public class Stickers
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StickerId { get; set; }
        public string StickerName { get; set; } = string.Empty;
    }
}
