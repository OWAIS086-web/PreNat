using PreNat.Database;
using PreNat.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreNat.Services
{
    public class BackgroundServices
    {
        #region Singleton
        public static BackgroundServices Instance
        {
            get
            {
                if (instance == null) instance = new BackgroundServices();
                return instance;
            }
        }
        private static BackgroundServices instance { get; set; }
        private BackgroundServices()
        {
        }
        #endregion

        #region CRUD
        public List<Background> GetBackgrounds(string SearchTerm = "")
        {
            using (var context = new DSContext())
            {
                if (SearchTerm != "")
                {
                    return context.Backgrounds.Where(p => p.Tbc != null && p.Tbc.ToLower()
                                            .Contains(SearchTerm.ToLower()))
                                            .OrderBy(x => x.Tbc)
                                            .ToList();
                }
                else
                {
                    return context.Backgrounds.ToList();
                }
            }
        }


        public List<Background> GetBackgrounds(string Tbc, string SearchTerm = "")
        {
            using (var context = new DSContext())
            {
                if (SearchTerm != "")
                {
                    return context.Backgrounds.Where(p => p.Tbc == Tbc && p.Tbc != null && p.Tbc.ToLower()
                                            .Contains(SearchTerm.ToLower()))
                                            .OrderBy(x => x.Tbc)
                                            .ToList();
                }
                else
                {
                    return context.Backgrounds.Where(x => x.Tbc == Tbc).ToList();
                }
            }
        }



        public Background GetBackground(int ID)
        {
            using (var context = new DSContext())
            {

                return context.Backgrounds.Find(ID);

            }
        }








        public void SaveBackgrounds(Background Background)
        {

            using (var context = new DSContext())
            {
                context.Backgrounds.Add(Background);
                context.SaveChanges();
            }
        }



        public void UpdateBackgrounds(Background Backgrounds)
        {
            using (var context = new DSContext())
            {
                context.Entry(Backgrounds).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteBackgrounds(int ID)
        {
            using (var context = new DSContext())
            {

                var Backgrounds = context.Backgrounds.Find(ID);
                context.Backgrounds.Remove(Backgrounds);
                context.SaveChanges();
            }
        }

        #endregion
    }
}