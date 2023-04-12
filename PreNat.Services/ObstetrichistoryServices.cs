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
    public class ObstetrichistoryServices
    {
        #region Singleton
        public static ObstetrichistoryServices Instance
        {
            get
            {
                if (instance == null) instance = new ObstetrichistoryServices();
                return instance;
            }
        }
        private static ObstetrichistoryServices instance { get; set; }
        private ObstetrichistoryServices()
        {
        }
        #endregion

        #region CRUD
        public List<Obstetrichistory> GetObstetrichistorys(string SearchTerm = "")
        {
            using (var context = new DSContext())
            {
              
                    return context.Obstetrichistorys.ToList();
                
            }
        }


      

        public Obstetrichistory GetObstetrichistory(int ID)
        {
            using (var context = new DSContext())
            {

                return context.Obstetrichistorys.Find(ID);

            }
        }








        public void SaveObstetrichistorys(Obstetrichistory Obstetrichistory)
        {

            using (var context = new DSContext())
            {
                context.Obstetrichistorys.Add(Obstetrichistory);
                context.SaveChanges();
            }
        }



        public void UpdateObstetrichistorys(Obstetrichistory Obstetrichistorys)
        {
            using (var context = new DSContext())
            {
                context.Entry(Obstetrichistorys).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteObstetrichistorys(int ID)
        {
            using (var context = new DSContext())
            {

                var Obstetrichistorys = context.Obstetrichistorys.Find(ID);
                context.Obstetrichistorys.Remove(Obstetrichistorys);
                context.SaveChanges();
            }
        }

        #endregion
    }
}
