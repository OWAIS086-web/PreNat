using Microsoft.AspNet.Identity.EntityFramework;
using PreNat.Entities;
using System;
using System.Data.Entity;

namespace PreNat.Database
{
    public class DSContext : IdentityDbContext<User>, IDisposable
    {
        public DSContext() : base("PreNatConnectionStrings")
        {

        }

        public static DSContext Create()
        {
            return new DSContext();
        }


        public DbSet<PatientMaster> PatientMasters { get; set; }



    }
}
