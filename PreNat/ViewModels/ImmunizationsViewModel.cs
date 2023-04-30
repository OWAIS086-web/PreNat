using PreNat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreNat.ViewModels
{
    public class ImmunizationsListingViewModel
    {
        public List<Immunizations> Immunizationss { get; set; }
        public string SearchTerm { get; set; }
    }
    public class ImmunizationsActionViewModel
    {
        public string TetanusDiphtheriaNo { get; set; }
        public string TetanusDiphtheriaYesPrevPreg { get; set; }
        public string TetanusDiphtheriaYesDuringPreg { get; set; }

        public DateTime TetanusDiphtheria_Date { get; set; }
        public int TetanusDiphtheria_Dozes { get; set; }



        public string TdapNo { get; set; }
        public string TdapYesPrevPreg { get; set; }
        public string TdapYesDuringPreg { get; set; }
        public DateTime Tdap_Date { get; set; }
        public int Tdap_Dozes { get; set; }

        public string InfluenzaNo { get; set; }
        public string InfluenzaYesPrevPreg { get; set; }
        public string InfluenzaYesDuringPreg { get; set; }
        public DateTime Influenza_Date { get; set; }
        public int Influenza_Dozes { get; set; }

        public string RubellaNo { get; set; }
        public string RubellaYesPrevPreg { get; set; }
        public string RubellaYesDuringPreg { get; set; }
        public DateTime Rubella_Date { get; set; }
        public int Rubella_Dozes { get; set; }

        public string Hepatitis_ANo { get; set; }
        public string Hepatitis_AYesPrevPreg { get; set; }
        public string Hepatitis_AYesDuringPreg { get; set; }
        public DateTime Hepatitis_A_Date { get; set; }
        public int Hepatitis_A_Dozes { get; set; }

        public string Hepatitis_BNo { get; set; }
        public string Hepatitis_BYesPrevPreg { get; set; }
        public string Hepatitis_BYesDuringPreg { get; set; }
        public DateTime Hepatitis_B_Date { get; set; }
        public int Hepatitis_B_Dozes { get; set; }

        public int ID { get; set; }
    }
}
