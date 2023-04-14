using PreNat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreNat.ViewModels
{
    public class PsychosocialAssessmentListingViewModel
    {
        public List<PsychosocialAssessment> PsychosocialAssessments { get; set; }
        public string SearchTerm { get; set; }
    }

    public class PsychosocialAssessmentActionViewModel
    {
        public string SmokerActive { get; set; }
        public int ID { get; set; }
        public string PassiveSmoking { get; set; }
        public string ConsumeAlcohol { get; set; }
        public string ConsumeAlucinogenos { get; set; }
        public string DomesticViolence { get; set; }
    }
}