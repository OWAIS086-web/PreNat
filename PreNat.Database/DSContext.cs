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

      
        public DbSet<PatientMaster> PatientMasters { get; set; }



    }
}
