namespace Fantasy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// An NFL team.
    /// </summary>
    public class Team
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        // TODO: make this non-nullable
        public int? DivisionID { get; set; }

        public string FullName
        {
            get { return String.Format("{0} {1}", City, Name); }
        }

        [ForeignKey("DivisionID")]
        public virtual Division Division { get; set; }
    }
}