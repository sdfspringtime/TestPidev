namespace Pidev.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("piproject.mission1")]
    public partial class mission1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mission1()
        {
            expforms = new HashSet<expform>();
            fixedfees = new HashSet<fixedfee>();
            missionrequests = new HashSet<missionrequest>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string emplacement { get; set; }

        [StringLength(255)]
        public string endDate { get; set; }

        [StringLength(255)]
        public string startDate { get; set; }

        [Column(TypeName = "bit")]
        public bool state { get; set; }
        public int maxcollab { get; set; }

        public int? ffee_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<expform> expforms { get; set; }

        public virtual fixedfee fixedfee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fixedfee> fixedfees { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<missionrequest> missionrequests { get; set; }
    }
}
