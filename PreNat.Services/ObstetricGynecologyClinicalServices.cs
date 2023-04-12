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
    public class ObstetricGynecologyClinicalServices
    {
        #region Singleton
        public static ObstetricGynecologyClinicalServices Instance
        {
            get
            {
                if (instance == null) instance = new ObstetricGynecologyClinicalServices();
                return instance;
            }
        }
        private static ObstetricGynecologyClinicalServices instance { get; set; }
        private ObstetricGynecologyClinicalServices()
        {
        }
        #endregion

        #region CRUD
        public List<ObstetricGynecologyClinical> GetObstetricGynecologyClinicals(string SearchTerm = "")
        {
            using (var context = new DSContext())
            {
                if (SearchTerm != "")
                {
                    return context.ObstetricGynecologyClinicals.Where(p => p.PlannedPregnancy != null && p.PlannedPregnancy.ToLower()
                                            .Contains(SearchTerm.ToLower()))
                                            .OrderBy(x => x.PlannedPregnancy)
                                            .ToList();
                }
                else
                {
                    return context.ObstetricGynecologyClinicals.ToList();
                }
            }
        }


        public List<ObstetricGynecologyClinical> GetObstetricGynecologyClinicals(string PlannedPregnancy, string SearchTerm = "")
        {
            using (var context = new DSContext())
            {
                if (SearchTerm != "")
                {
                    return context.ObstetricGynecologyClinicals.Where(p => p.PlannedPregnancy == PlannedPregnancy && p.PlannedPregnancy != null && p.PlannedPregnancy.ToLower()
                                            .Contains(SearchTerm.ToLower()))
                                            .OrderBy(x => x.PlannedPregnancy)
                                            .ToList();
                }
                else
                {
                    return context.ObstetricGynecologyClinicals.Where(x => x.PlannedPregnancy == PlannedPregnancy).ToList();
                }
            }
        }



        public ObstetricGynecologyClinical GetObstetricGynecologyClinical(int ID)
        {
            using (var context = new DSContext())
            {

                return context.ObstetricGynecologyClinicals.Find(ID);

            }
        }








        public void SaveObstetricGynecologyClinicals(ObstetricGynecologyClinical ObstetricGynecologyClinical)
        {

            using (var context = new DSContext())
            {
                context.ObstetricGynecologyClinicals.Add(ObstetricGynecologyClinical);
                context.SaveChanges();
            }
        }



        public void UpdateObstetricGynecologyClinicals(ObstetricGynecologyClinical ObstetricGynecologyClinicals)
        {
            using (var context = new DSContext())
            {
                context.Entry(ObstetricGynecologyClinicals).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteObstetricGynecologyClinicals(int ID)
        {
            using (var context = new DSContext())
            {

                var ObstetricGynecologyClinicals = context.ObstetricGynecologyClinicals.Find(ID);
                context.ObstetricGynecologyClinicals.Remove(ObstetricGynecologyClinicals);
                context.SaveChanges();
            }
        }

        #endregion
    }
}
