namespace WebSiteAboutMe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oskarprzybylski_oskarprzybylski.EntryType")]
    public partial class EntryType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EntryType()
        {
            Entry = new HashSet<Entry>();
            RoleAccess = new HashSet<RoleAccess>();
        }

        public int ID { get; set; }

        [StringLength(128)]
        public string Name { get; set; }

        public bool AllowHTMLEncode { get; set; }

        public int MaxLength { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entry> Entry { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoleAccess> RoleAccess { get; set; }
    }
}
