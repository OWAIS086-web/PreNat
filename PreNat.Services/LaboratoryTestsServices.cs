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
    public class LaboratoryTestsServices
    {
        #region Singleton
        public static LaboratoryTestsServices Instance
        {
            get
            {
                if (instance == null) instance = new LaboratoryTestsServices();
                return instance;
            }
        }
        private static LaboratoryTestsServices instance { get; set; }
        private LaboratoryTestsServices()
        {
        }
        #endregion

        #region CRUD
        public List<LaboratoryTests> GetLaboratoryTestss(string SearchTerm = "")
        {
            using (var context = new DSContext())
            {
                if (SearchTerm != "")
                {
                    return context.LaboratoryTestss.Where(p => p.SanguineoGroup != null && p.SanguineoGroup.ToLower()
                                            .Contains(SearchTerm.ToLower()))
                                            .OrderBy(x => x.SanguineoGroup)
                                            .ToList();
                }
                else
                {
                    return context.LaboratoryTestss.ToList();
                }
            }
        }





        public LaboratoryTests GetLaboratoryTests(int ID)
        {
            using (var context = new DSContext())
            {

                return context.LaboratoryTestss.Find(ID);

            }
        }








        public void SaveLaboratoryTestss(LaboratoryTests LaboratoryTests)
        {

            using (var context = new DSContext())
            {
                context.LaboratoryTestss.Add(LaboratoryTests);
                context.SaveChanges();
            }
        }



        public void UpdateLaboratoryTestss(LaboratoryTests LaboratoryTestss)
        {
            using (var context = new DSContext())
            {
                context.Entry(LaboratoryTestss).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteLaboratoryTestss(int ID)
        {
            using (var context = new DSContext())
            {

                var LaboratoryTestss = context.LaboratoryTestss.Find(ID);
                context.LaboratoryTestss.Remove(LaboratoryTestss);
                context.SaveChanges();
            }
        }

        #endregion
    }
}
