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
        public string TetanusDiphtheria { get; set; }
        public int TetanusDiphtheria_Date { get; set; }
        public int TetanusDiphtheria_Quantity { get; set; }
        public string TDAP { get; set; }
        public int TDAP_Date { get; set; }
        public int TDAP_Quantity { get; set; }
        public string Influenza { get; set; }
        public int Influenza_Date { get; set; }
        public int Influenza_Quantity { get; set; }
        public string Rubella { get; set; }
        public int Rubella_Date { get; set; }
        public int Rubella_Quantity { get; set; }
        public string Hepatitis_B { get; set; }
        public int Hepatitis_B_Date { get; set; }
        public int Hepatitis_B_Quantity { get; set; }
        public string Hepatitis_A { get; set; }
        public int Hepatitis_A_Date { get; set; }
        public int Hepatitis_A_Quantity { get; set; }
        public int ID { get; set; }
    }
}
