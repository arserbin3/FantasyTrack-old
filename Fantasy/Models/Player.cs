// TODO: support a player changing teams (or coming from Free Agency)
namespace Fantasy.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// An NFL player.
    /// </summary>
    public class Player
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Name { get; set; }

        public int? TeamID { get; set; }

        [ForeignKey("TeamID")]
        public virtual Team Team { get; set; }

        // TODO: this should be a lookup
        public string Position { get; set; }
    }
}