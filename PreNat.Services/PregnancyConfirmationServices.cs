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
    public class PregnancyConfirmationServices
    {
        #region Singleton
        public static PregnancyConfirmationServices Instance
        {
            get
            {
                if (instance == null) instance = new PregnancyConfirmationServices();
                return instance;
            }
        }
        private static PregnancyConfirmationServices instance { get; set; }
        private PregnancyConfirmationServices()
        {
        }
        #endregion

        #region CRUD
        public List<PregnancyConfirmation> GetPregnancyConfirmations(string SearchTerm = "")
        {
            using (var context = new DSContext())
            {
                if (SearchTerm != "")
                {
                    return context.PregnancyConfirmations.Where(p => p.FUM != null && p.FUM.ToLower()
                                            .Contains(SearchTerm.ToLower()))
                                            .OrderBy(x => x.FUM)
                                            .ToList();
                }
                else
                {
                    return context.PregnancyConfirmations.ToList();
                }
            }
        }


        public List<PregnancyConfirmation> GetPregnancyConfirmations(string FUM, string SearchTerm = "")
        {
            using (var context = new DSContext())
            {
                if (SearchTerm != "")
                {
                    return context.PregnancyConfirmations.Where(p => p.FUM == FUM && p.FUM != null && p.FUM.ToLower()
                                            .Contains(SearchTerm.ToLower()))
                                            .OrderBy(x => x.FUM)
                                            .ToList();
                }
                else
                {
                    return context.PregnancyConfirmations.Where(x => x.FUM == FUM).ToList();
                }
            }
        }



        public PregnancyConfirmation GetPregnancyConfirmation(int ID)
        {
            using (var context = new DSContext())
            {

                return context.PregnancyConfirmations.Find(ID);

            }
        }








        public void SavePregnancyConfirmations(PregnancyConfirmation PregnancyConfirmation)
        {

            using (var context = new DSContext())
            {
                context.PregnancyConfirmations.Add(PregnancyConfirmation);
                context.SaveChanges();
            }
        }



        public void UpdatePregnancyConfirmations(PregnancyConfirmation PregnancyConfirmations)
        {
            using (var context = new DSContext())
            {
                context.Entry(PregnancyConfirmations).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeletePregnancyConfirmations(int ID)
        {
            using (var context = new DSContext())
            {

                var PregnancyConfirmations = context.PregnancyConfirmations.Find(ID);
                context.PregnancyConfirmations.Remove(PregnancyConfirmations);
                context.SaveChanges();
            }
        }

        #endregion
    }
}
