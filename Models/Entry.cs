namespace WebSiteAboutMe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oskarprzybylski_oskarprzybylski.Entry")]
    public partial class Entry
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Entry()
        {
            Entry1 = new HashSet<Entry>();
        }

        public int ID { get; set; }

        [StringLength(1024)]
        public string Title { get; set; }

        [StringLength(4000)]
        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(128)]
        public string UserID { get; set; }

        public int CategoryID { get; set; }

        public int? EntryID { get; set; }

        public int EntryTypeID { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entry> Entry1 { get; set; }

        public virtual Entry Entry2 { get; set; }

        public virtual EntryType EntryType { get; set; }
    }
}
