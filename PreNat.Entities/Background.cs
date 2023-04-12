using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreNat.Entities
{
    public class Background:BaseEntity
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
        public string Disc_Sang{ get; set; }
        public string other_dises { get; set; }
        public int PatientID { get; set; }


    }
}
