using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreNat.Entities
{
    public class Background:BaseEntity
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
        public string VIH { get; set; }               //Absence   -   Family  - Personal
        public string Migraine { get; set; }          //Absence   -   Family  - Personal
        public string Enf_Tromboembólica { get; set; }//Absence   -   Family  - Personal
        public string IMC29 { get; set; }             //Absence   -   Family  - Personal
        public string IMC39 { get; set; }             //Absence   -   Family  - Personal
        public string Disc_Sang{ get; set; }          //Absence   -   Family  - Personal
        public string other_dises { get; set; }       //Absence   -   Family  - Personal
        public int PatientID { get; set; }


    }
}
