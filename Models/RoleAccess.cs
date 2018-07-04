namespace WebSiteAboutMe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oskarprzybylski_oskarprzybylski.RoleAccess")]
    public partial class RoleAccess
    {
        public int ID { get; set; }

        [Required]
        [StringLength(128)]
        public string RoleID { get; set; }

        public int EntryTypeID { get; set; }

        public bool ReadAny { get; set; }

        public bool EditAny { get; set; }

        public bool ReadSelf { get; set; }

        public bool EditSelf { get; set; }

        public virtual EntryType EntryType { get; set; }
    }
}
