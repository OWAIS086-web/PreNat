using Microsoft.AspNet.Identity.EntityFramework;
using PreNat.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreNat.Database
{
    public class DSContext :IdentityDbContext<User>,IDisposable
    {
        public DSContext() : base("PreNatConnectionStrings")
        {

        }

        public static DSContext Create()
        {
            return new DSContext();
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<PsychosocialAssessment> PsychosocialAssessments { get; set; }
        public DbSet<PregnancyConfirmation> PregnancyConfirmations { get; set; }
        public DbSet<Obstetrichistory> Obstetrichistorys { get; set; }
        public DbSet<ObstetricGynecologyClinical> ObstetricGynecologyClinicals { get; set; }
        public DbSet<LaboratoryTests> LaboratoryTestss { get; set; }
        public DbSet<Immunizations> Immunizationss { get; set; }
        public DbSet<ChronologyPregnancy> ChronologyPregnancys { get; set; }
        public DbSet<Background> Backgrounds { get; set; }
        


    }
}
