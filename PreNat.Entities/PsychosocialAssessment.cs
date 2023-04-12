using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreNat.Entities
{
   public class PsychosocialAssessment : BaseEntity
    {
        public string SmokerActive { get; set; }
        public string PassiveSmoking { get; set; }
        public string ConsumeAlcohol { get; set; }
        public string ConsumeAlucinogenos { get; set; }
        public string  DomesticViolence  { get; set; }
        public int PatientID { get; set; }

    }
}
