using PreNat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreNat.ViewModels
{
    public class ChronologyPregnancyListingViewModel
    {
        public List<ChronologyPregnancy> ChronologyPregnancys { get; set; }
        public string SearchTerm { get; set; }
    }

    public class ChronologyPregnancyActionViewModel
    {
        public int ReliableFUM { get; set; }
        public int UltrasoundObstetrics { get; set; }
        public int FPP { get; set; }
        public int FPC { get; set; }
        public DateTime ProbableDateOfDelivery { get; set; }
        public DateTime ProbableDateOfConception { get; set; }
        public int ID { get; set; }

    }
}