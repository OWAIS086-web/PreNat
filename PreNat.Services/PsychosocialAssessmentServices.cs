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
    public class PsychosocialAssessmentServices
    {
        #region Singleton
        public static PsychosocialAssessmentServices Instance
        {
            get
            {
                if (instance == null) instance = new PsychosocialAssessmentServices();
                return instance;
            }
        }
        private static PsychosocialAssessmentServices instance { get; set; }
        private PsychosocialAssessmentServices()
        {
        }
        #endregion

        #region CRUD
        public List<PsychosocialAssessment> GetPsychosocialAssessments(string SearchTerm = "")
        {
            using (var context = new DSContext())
            {
                if (SearchTerm != "")
                {
                    return context.PsychosocialAssessments.Where(p => p.SmokerActive != null && p.SmokerActive.ToLower()
                                            .Contains(SearchTerm.ToLower()))
                                            .OrderBy(x => x.SmokerActive)
                                            .ToList();
                }
                else
                {
                    return context.PsychosocialAssessments.ToList();
                }
            }
        }


        public List<PsychosocialAssessment> GetPsychosocialAssessments(string SmokerActive, string SearchTerm = "")
        {
            using (var context = new DSContext())
            {
                if (SearchTerm != "")
                {
                    return context.PsychosocialAssessments.Where(p => p.SmokerActive == SmokerActive && p.SmokerActive != null && p.SmokerActive.ToLower()
                                            .Contains(SearchTerm.ToLower()))
                                            .OrderBy(x => x.SmokerActive)
                                            .ToList();
                }
                else
                {
                    return context.PsychosocialAssessments.Where(x => x.SmokerActive == SmokerActive).ToList();
                }
            }
        }



        public PsychosocialAssessment GetPsychosocialAssessment(int ID)
        {
            using (var context = new DSContext())
            {

                return context.PsychosocialAssessments.Find(ID);

            }
        }








        public void SavePsychosocialAssessments(PsychosocialAssessment PsychosocialAssessment)
        {

            using (var context = new DSContext())
            {
                context.PsychosocialAssessments.Add(PsychosocialAssessment);
                context.SaveChanges();
            }
        }



        public void UpdatePsychosocialAssessments(PsychosocialAssessment PsychosocialAssessments)
        {
            using (var context = new DSContext())
            {
                context.Entry(PsychosocialAssessments).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeletePsychosocialAssessments(int ID)
        {
            using (var context = new DSContext())
            {

                var PsychosocialAssessments = context.PsychosocialAssessments.Find(ID);
                context.PsychosocialAssessments.Remove(PsychosocialAssessments);
                context.SaveChanges();
            }
        }

        #endregion
    }
}
