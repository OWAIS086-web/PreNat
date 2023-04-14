using PreNat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreNat.ViewModels
{
    public class LaboratoryTestsListingViewModel
    {
        public List<LaboratoryTests> LaboratoryTestss { get; set; }
        public string SearchTerm { get; set; }
    }

    public class LaboratoryTestsActionViewModel
    {
        public string Group { get; set; }
        public string SanguineoGroup { get; set; }
        public string Laboratory_Tests { get; set; }
        public string VDRL { get; set; }
        public string Syphilis { get; set; }
        public int ID { get; set; }
        public string VIH_L { get; set; }
    }
}