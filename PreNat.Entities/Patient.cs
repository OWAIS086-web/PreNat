﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreNat.Entities
{
    public  class Patient: BaseEntity

    {
        public string Name { get; set; }
        public string Surnames { get; set; }
        public int Type_of_Identity { get; set; }
        public string Department_of_residence { get; set; }
        public string City_Municipality_of_residence { get; set; }
        public string Address_of_residence { get; set; }
        public int Telephones_Landline { get; set; }
        public int Cell_Phone { get; set; }
        public int Date_of_birth { get; set; }
        public int Age { get; set; }
        public string Race_DANE_Information { get; set; }
        public string Ethnicity_DANE_Information { get; set; }
        public string Level_of_Education { get; set; }
        public string Marital_status { get; set; }
        public string Affiliation_regime { get; set; } 
        public string EPS_IPS { get; set; }




    }
}
