using Data.Infrastructure;
using Pidev.Data;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pidev.Service
{
     public class MissionRequestService : Service<missionrequest>, IMissionRequestService
    {
        static IDataBaseFactory factory = new DataBaseFactory();
        static IUnitOfWork UTK = new UnitOfWork(factory);
        public MissionRequestService():base(UTK)
        {

        }


    }
}
