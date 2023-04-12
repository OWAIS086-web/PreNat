using PreNat.Database;
using PreNat.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreNat.Services
{
    public class ChronologyPregnancyServices
    {
        #region Singleton
        public static ChronologyPregnancyServices Instance
        {
            get
            {
                if (instance == null) instance = new ChronologyPregnancyServices();
                return instance;
            }
        }
        private static ChronologyPregnancyServices instance { get; set; }
        private ChronologyPregnancyServices()
        {
        }
        #endregion

        #region CRUD
        public List<ChronologyPregnancy> GetChronologyPregnancys(string SearchTerm = "")
        {
            using (var context = new DSContext())
            {
                if (SearchTerm != "")
                {
                    return context.ChronologyPregnancys.Where(p => p.ReliableFUM != null && p.ReliableFUM.ToLower()
                                            .Contains(SearchTerm.ToLower()))
                                            .OrderBy(x => x.ReliableFUM)
                                            .ToList();
                }
                else
                {
                    return context.ChronologyPregnancys.ToList();
                }
            }
        }


        public List<ChronologyPregnancy> GetChronologyPregnancys(int ReliableFUM, string SearchTerm = "")
        {
            using (var context = new DSContext())
            {
                if (SearchTerm != "")
                {
                    return context.ChronologyPregnancys.Where(p => p.ReliableFUM == ReliableFUM && p.ReliableFUM != null && p.ReliableFUM.ToLower()
                                            .Contains(SearchTerm.ToLower()))
                                            .OrderBy(x => x.ReliableFUM)
                                            .ToList();
                }
                else
                {
                    return context.ChronologyPregnancys.Where(x => x.ReliableFUM == ReliableFUM).ToList();
                }
            }
        }



        public ChronologyPregnancy GetChronologyPregnancy(int ID)
        {
            using (var context = new DSContext())
            {

                return context.ChronologyPregnancys.Find(ID);

            }
        }








        public void SaveChronologyPregnancys(ChronologyPregnancy ChronologyPregnancy)
        {

            using (var context = new DSContext())
            {
                context.ChronologyPregnancys.Add(ChronologyPregnancy);
                context.SaveChanges();
            }
        }



        public void UpdateChronologyPregnancys(ChronologyPregnancy ChronologyPregnancys)
        {
            using (var context = new DSContext())
            {
                context.Entry(ChronologyPregnancys).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteChronologyPregnancys(int ID)
        {
            using (var context = new DSContext())
            {

                var ChronologyPregnancys = context.ChronologyPregnancys.Find(ID);
                context.ChronologyPregnancys.Remove(ChronologyPregnancys);
                context.SaveChanges();
            }
        }

        #endregion
    }
}
