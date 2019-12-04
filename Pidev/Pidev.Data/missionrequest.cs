namespace Pidev.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("piproject.missionrequest")]
    public partial class missionrequest
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idCollab { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idMission { get; set; }

        public int? man_id { get; set; }

        public int id { get; set; }

        [StringLength(255)]
        public string date { get; set; }

        [StringLength(255)]
        public string firstname { get; set; }

        public int idCollabo { get; set; }

        [StringLength(255)]
        public string lastname { get; set; }

        public virtual collaborator collaborator { get; set; }

        public virtual collaborator collaborator1 { get; set; }

        public virtual manager manager { get; set; }

        public virtual mission1 mission1 { get; set; }
        public bool isconfirmed { get; set; }
        [ForeignKey("wq")]
        public int? wqId { get; set; }
        public virtual waitingQueue wq { get; set; }
    }
}
