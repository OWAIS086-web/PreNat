using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using PreNat.Database;

namespace PreNat.Services
{
    public class AMRolesManager : RoleManager<IdentityRole>
    {
        public AMRolesManager(IRoleStore<IdentityRole, string> roleStore) : base(roleStore)
        {

        }
        public static AMRolesManager Create(IdentityFactoryOptions<AMRolesManager> options, IOwinContext context)
        {
            return new AMRolesManager(new RoleStore<IdentityRole>(context.Get<DSContext>()));
        }
    }
}
