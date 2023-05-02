using PreNat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreNat.ViewModels
{
    public class ObstetrichistoryListingViewModel
    {
        public List<Obstetrichistory> Obstetrichistory { get; set; }
        public string SearchTerm { get; set; }
    }
    public class ObstetrichistoryActionViewModel
    {
        public int ID { get; set; }
        public int Gestation { get; set; }
        public int NoOfPregnancy { get; set; }
        public int Delivery { get; set; }
        public int Term { get; set; }
        public int Preterm { get; set; }
        public int Vaginal { get; set; }
        public int Cesareas { get; set; }
        public int Abortions { get; set; }
        public int Gemerales { get; set; }
        public int Ectopic { get; set; }
        public int Obitus { get; set; }
        public int Molas { get; set; }
        public int Live_Births { get; set; }
        public int PatientID { get; set; }
    }
}