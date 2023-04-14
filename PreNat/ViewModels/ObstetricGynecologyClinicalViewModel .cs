using PreNat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreNat.ViewModels
{
    public class ObstetricGynecologyClinicalListingViewModel
    {
        public List<ObstetricGynecologyClinical> ObstetricGynecologyClinicals { get; set; }
        public string SearchTerm { get; set; }
    }

    public class ObstetricGynecologyClinicalActionViewModel
    {
        public int ID { get; set; }
        public string PlannedPregnancy { get; set; }
        public string DesiredPregnancy { get; set; }
        public string PreconceptionCounseling { get; set; }
        public string ContraceptiveFailure { get; set; }
        public string DefinitiveMethod { get; set; }
        public string Failure { get; set; }
    }
}