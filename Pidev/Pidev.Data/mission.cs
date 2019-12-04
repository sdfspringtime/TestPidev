namespace Pidev.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("piproject.mission")]
    public partial class mission
    {
        public int id { get; set; }

        [StringLength(255)]
        public string emplacement { get; set; }

        [StringLength(255)]
        public string endDate { get; set; }

        public int idCollab { get; set; }

        [StringLength(255)]
        public string startDate { get; set; }

        [Column(TypeName = "bit")]
        public bool state { get; set; }
        


    }
}
