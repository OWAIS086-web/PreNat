using PreNat.Database;
using PreNat.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PreNat.Services
{
    public class PatientMasterServices
    {
        #region Singleton
        public static PatientMasterServices Instance
        {
            get
            {
                if (instance == null) instance = new PatientMasterServices();
                return instance;
            }
        }
        private static PatientMasterServices instance { get; set; }
        private PatientMasterServices()
        {
        }
        #endregion

        #region CRUD
        public List<PatientMaster> GetPatientMasters(string SearchTerm = "")
        {
            using (var context = new DSContext())
            {
                if (SearchTerm != "")
                {
                    return context.PatientMasters.Where(p => p.Name != null && p.Tbc.ToLower()
                                            .Contains(SearchTerm.ToLower()))
                                            .OrderBy(x => x.Name)
                                            .ToList();
                }
                else
                {
                    return context.PatientMasters.OrderBy(x => x.Name).ToList();
                }
            }
        }


        public List<PatientMaster> GetPatientMasters(string CreatedBy, string SearchTerm = "")
        {
            using (var context = new DSContext())
            {
                if (SearchTerm != "")
                {
                    return context.PatientMasters.Where(p => p.CreatedBy == CreatedBy && p.Name != null && p.Tbc.ToLower()
                                            .Contains(SearchTerm.ToLower()))
                                            .OrderBy(x => x.Name)
                                            .ToList();
                }
                else
                {
                    return context.PatientMasters.Where(x => x.CreatedBy == CreatedBy).OrderBy(x => x.Name).ToList();
                }
            }
        }




        public PatientMaster GetPatientMaster(int ID)
        {
            using (var context = new DSContext())
            {

                return context.PatientMasters.Find(ID);

            }
        }








        public void SavePatientMasters(PatientMaster PatientMaster)
        {

            using (var context = new DSContext())
            {
                context.PatientMasters.Add(PatientMaster);
                context.SaveChanges();
            }
        }



        public void UpdatePatientMasters(PatientMaster PatientMasters)
        {
            using (var context = new DSContext())
            {
                context.Entry(PatientMasters).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeletePatientMasters(int ID)
        {
            using (var context = new DSContext())
            {

                var PatientMasters = context.PatientMasters.Find(ID);
                context.PatientMasters.Remove(PatientMasters);
                context.SaveChanges();
            }
        }

        #endregion
    }
}
