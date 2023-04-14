using PreNat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreNat.ViewModels
{
    public class BackgroundListingViewModel
    {
        public List<Background> Backgrounds { get; set; }
        public string SearchTerm { get; set; }
    }
    public class BackgroundActionViewModel
    {
        public string Tbc { get; set; }
        public string Diabetes { get; set; }
        public string Hypertension { get; set; }
        public string Eclampsia { get; set; }
        public string Preeclampsia { get; set; }
        public string Surgery { get; set; }
        public string Infertility { get; set; }
        public string Cardiopathy { get; set; }
        public string Nephropathy { get; set; }
        public string Violence { get; set; }
        public string VIH { get; set; }
        public string Migraine { get; set; }
        public string Enf_Tromboembólica { get; set; }
        public string IMC29 { get; set; }
        public string IMC39 { get; set; }
        public string Disc_Sang { get; set; }
        public string other_dises { get; set; }
        public int ID { get; set; }
    }
}