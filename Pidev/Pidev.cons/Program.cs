using Pidev.Data;
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
            ExpenseFormService ex = new ExpenseFormService();
            Tr aa = new Tr();
            aa.amount = "22";
            aa.date = "aaaaa";
            aa.description = "aaaaaaaaaaa";
            aa.justification = "aaaaaaaaaaaaaaa1";
            aa.state = true;
            ex.AddEform(aa);

/*            ProjService es = new ProjService();
            es.ConfirmMiss(1);
            es.Aff_antecedantM(1);

          //  es.affMreq(22);*/
             
        }
    }
}
