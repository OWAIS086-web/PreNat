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
    public class PatientServices
    {
        #region Singleton
        public static PatientServices Instance
        {
            get
            {
                if (instance == null) instance = new PatientServices();
                return instance;
            }
        }
        private static PatientServices instance { get; set; }
        private PatientServices()
        {
        }
        #endregion

        #region CRUD
        public List<Patient> GetPatients(string SearchTerm = "")
        {
            using (var context = new DSContext())
            {
                if (SearchTerm != "")
                {
                    return context.Patients.Where(p => p.Name != null && p.Name.ToLower()
                                            .Contains(SearchTerm.ToLower()))
                                            .OrderBy(x => x.Name)
                                            .ToList();
                }
                else
                {
                    return context.Patients.ToList();
                }
            }
        }


        public List<Patient> GetPatients(string Name, string SearchTerm = "")
        {
            using (var context = new DSContext())
            {
                if (SearchTerm != "")
                {
                    return context.Patients.Where(p => p.Name == Name && p.Name != null && p.Name.ToLower()
                                            .Contains(SearchTerm.ToLower()))
                                            .OrderBy(x => x.Name)
                                            .ToList();
                }
                else
                {
                    return context.Patients.Where(x => x.Name == Name).ToList();
                }
            }
        }



        public Patient GetPatient(int ID)
        {
            using (var context = new DSContext())
            {

                return context.Patients.Find(ID);

            }
        }








        public void SavePatients(Patient Patient)
        {

            using (var context = new DSContext())
            {
                context.Patients.Add(Patient);
                context.SaveChanges();
            }
        }



        public void UpdatePatients(Patient Patients)
        {
            using (var context = new DSContext())
            {
                context.Entry(Patients).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeletePatients(int ID)
        {
            using (var context = new DSContext())
            {

                var Patients = context.Patients.Find(ID);
                context.Patients.Remove(Patients);
                context.SaveChanges();
            }
        }

        #endregion
    }
}
