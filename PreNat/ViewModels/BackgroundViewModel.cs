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
        public string Tbc { get; set; }               //Absence   -   Family  - Personal
        public string Diabetes { get; set; }          //Absence   -   Family  - Personal
        public string Hypertension { get; set; }      //Absence   -   Family  - Personal
        public string Eclampsia { get; set; }         //Absence   -   Family  - Personal
        public string Preeclampsia { get; set; }      //Absence   -   Family  - Personal
        public string Surgery { get; set; }           //Absence   -   Family  - Personal
        public string Infertility { get; set; }       //Absence   -   Family  - Personal
        public string Cardiopathy { get; set; }       //Absence   -   Family  - Personal
        public string Nephropathy { get; set; }       //Absence   -   Family  - Personal
        public string Violence { get; set; }          //Absence   -   Family  - Personal
        public string HIV { get; set; }               //Absence   -   Family  - Personal
        public string Migraine { get; set; }          //Absence   -   Family  - Personal
        public string Thromboembolic { get; set; }//Absence   -   Family  - Personal
        public string BMI_29 { get; set; }             //Absence   -   Family  - Personal
        public string BMI_39 { get; set; }             //Absence   -   Family  - Personal
        public string Disc_Sang { get; set; }          //Absence   -   Family  - Personal
        public string Other { get; set; }       //Absence   -   Family  - Personal
        public int ID { get; set; }
    }
}