using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreNat.Entities
{
    public class ObstetricGynecologyClinical : BaseEntity
    {
        public string PlannedPregnancy { get; set; }
        public string DesiredPregnancy { get; set; }
        public string PreconceptionCounseling { get; set; }
        public string ContraceptiveFailure { get; set; }
        public string DefinitiveMethod  { get; set; }
        public string Failure { get; set; }
        public int PatientID { get; set; }


    }
}
