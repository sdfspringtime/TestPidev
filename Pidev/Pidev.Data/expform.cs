namespace Pidev.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("piproject.expform")]
    public partial class expform
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public expform()
        {
            collaborators = new HashSet<collaborator>();
        }

        [Key]
        public int EF_Id { get; set; }

        [StringLength(255)]
        public string Justification { get; set; }

        [StringLength(255)]
        public string amount { get; set; }

        [StringLength(255)]
        public string date { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [Column(TypeName = "bit")]
        public bool state { get; set; }

        public int? collab_id { get; set; }

        public int? man_id { get; set; }

        public int? miss_id { get; set; }

        public virtual collaborator collaborator { get; set; }

        public virtual collaborator collaborator1 { get; set; }

        public virtual manager manager { get; set; }

        public virtual mission1 mission1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<collaborator> collaborators { get; set; }
    }
}
