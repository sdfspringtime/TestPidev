namespace Pidev.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("piproject.fixedfee")]
    public partial class fixedfee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fixedfee()
        {
            mission1 = new HashSet<mission1>();
        }

        public int id { get; set; }

        public float daily_fee { get; set; }

        public int daily_spendings { get; set; }

        public int? man_id { get; set; }

        public int? miss_id { get; set; }

        public virtual collaborator collaborator { get; set; }

        public virtual manager manager { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mission1> mission1 { get; set; }

        public virtual mission1 mission11 { get; set; }
    }
}
