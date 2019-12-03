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
        
        static void Main(string[] args)
        {

            ExpenseFormService es = new ExpenseFormService();
           es.AddEform();
        }
    }
}
