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
    public class ImmunizationsServices
    {
        #region Singleton
        public static ImmunizationsServices Instance
        {
            get
            {
                if (instance == null) instance = new ImmunizationsServices();
                return instance;
            }
        }
        private static ImmunizationsServices instance { get; set; }
        private ImmunizationsServices()
        {
        }
        #endregion

        #region CRUD
        public List<Immunizations> GetImmunizationss(string SearchTerm = "")
        {
            using (var context = new DSContext())
            {
             
                    return context.Immunizationss.ToList();
                
            }
        }




        public Immunizations GetImmunizations(int ID)
        {
            using (var context = new DSContext())
            {

                return context.Immunizationss.Find(ID);

            }
        }








        public void SaveImmunizationss(Immunizations Immunizations)
        {

            using (var context = new DSContext())
            {
                context.Immunizationss.Add(Immunizations);
                context.SaveChanges();
            }
        }



        public void UpdateImmunizationss(Immunizations Immunizationss)
        {
            using (var context = new DSContext())
            {
                context.Entry(Immunizationss).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteImmunizationss(int ID)
        {
            using (var context = new DSContext())
            {

                var Immunizationss = context.Immunizationss.Find(ID);
                context.Immunizationss.Remove(Immunizationss);
                context.SaveChanges();
            }
        }

        #endregion
    }
}
