using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pidev.Data
{
   public class waitingQueue
    {
        public int id { get; set; }
        public bool isConfirmed { get; set; }


        public virtual mission1 miss { get; set; }

        public virtual ICollection<missionrequest> mreq { get; set; }
    }
}
