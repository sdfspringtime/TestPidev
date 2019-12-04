using Pidev.Data.EntityWS;
using Pidev.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pidev.cons
{
    class Program
    {

        static  void Main(string[] args)
        {

            ProjService es = new ProjService();
            es.Aff_antecedantM(1);
             
        }
    }
}
