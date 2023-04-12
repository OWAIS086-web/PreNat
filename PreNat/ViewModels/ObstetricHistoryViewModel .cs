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
        public int Gestationes_Pregnancies { get; set; }
        public int Delivery { get; set; }
        public int Term { get; set; }
        public int Premature { get; set; }
        public int Vaginal { get; set; }
        public int Cesareas { get; set; }
        public int Abortions { get; set; }
        public int Gemerales { get; set; }
        public int Ectopicos { get; set; }
        public int Obitos { get; set; }
        public int Springs { get; set; }
        public int Live_Births { get; set; }
    }
}