namespace Pidev.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("piproject.expenseform")]
    public partial class expenseform
    {
        [Key]
        public int EF_Id { get; set; }

        [StringLength(255)]
        public string Collab { get; set; }

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
    }
}
