using PreNat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreNat.ViewModels
{
    public class PregnancyConfirmationListingViewModel
    {
        public List<PregnancyConfirmation> PregnancyConfirmations { get; set; }
        public string SearchTerm { get; set; }

    }
    public class PregnancyConfirmationActionViewModel
    {
        public string FUM { get; set; }
        public int ID { get; set; }
        public int FUM_Date { get; set; }
        public string Positive_HCG_presence { get; set; }
        public int Positive_HCG_presence_Date { get; set; }
        public string Upload_document1 { get; set; }
        public string Positive_TV_ultrasound { get; set; }
        public int Positive_TV_ultrasound_Date { get; set; }
        public string Upload_document2 { get; set; }
        public string PregnancyConfirm { get; set; }
    }
}