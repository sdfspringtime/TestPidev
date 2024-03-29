﻿using Pidev.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pidev.Service
{
    public class ProjService
    {
        private static Context _context;

        public ProjService()
        {
            init();
            _context = new Context();
            _context.Database.Initialize(force: false);
        }
        public static void init()
        {
            _context = new Context();
        }
        public int Aff_antecedantM(int idcollab)
        {
            int req = _context.missionrequests
                .Include("collaborator")
                .Include("mission1")
                .Where(x => x.collaborator.id == idcollab).Count();
            return req;
        }
        public missionrequest affMreq(int mreqId)
        {
           var req= _context.missionrequests
                .Include("collaborator")
                .Include("mission1")
                .Where(x => x.id == mreqId).FirstOrDefault();
            return req; }
        public void createEf(expform e)
        {
             _context.expforms
                
                 .Add(e);
        }
        public void createMissionRequest(missionrequest e)
        {
            _context.missionrequests

                .Add(e);
        }
        public void updateMissionRequest(missionrequest e)
        {
            
            _context.SaveChanges();

                
        }


        public void InjectInQueue(missionrequest e) 

        {
           // var res = _context.waitingQueues
            //    .Include("mission1").Include("missionrequest").Where((e.collaborator.notea > 10 && this.Aff_antecedantM(e.collaborator.id) < 10));
            
                if (e.collaborator.notea > 10 && this.Aff_antecedantM(e.collaborator.id) < 10)
            {

                
               this.affMreq(e.id).isconfirmed = true;
                _context.SaveChanges();
                waitingQueue b = new waitingQueue();
                b.miss = e.mission1;
                //b.idmission = e.idMission;
                b.mreq.Add(e);
                //b.mreq = e;
                _context.waitingQueues.Add(b);
               
            }
        
        }
        public void ConfirmMiss(int e)
        {
            var t = _context.waitingQueues.First<waitingQueue>();
                
               //.Where(x => x.miss.id == e).FirstOrDefault();
/*
            int p = m.get.Count();
            while (p<5)
            {

            }
           if (e.isConfirmed)
            {

            }
            else
            {
                if (e.isConfirmed==false)
                    //on doit mettre le boolean a null par defaut!!!!!!!!!!!!!!!!!!!
                {
                    _context.waitingQueues.Remove(e);
                }
            }*/
        }
        public void deleteEf(expform e)
        {
            _context.expforms

                .Remove(e);
        }
    }


}
