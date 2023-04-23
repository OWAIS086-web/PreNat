using PreNat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreNat.ViewModels
{
    public class PatientListingViewModel
    {
        public List<Patient> Patients { get; set; }
        public string SearchTerm { get; set; }
    }

    public class PatientActionViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surnames { get; set; }
        public string Type_of_Identity { get; set; }  //Dropdown
                                                      //Cedula de Ciudadanía - Cédula de Extranjería - Tarjeta de Identidad 
        public string Department_of_residence { get; set; }
        public string City_Municipality_of_residence { get; set; }
        public string Address_of_residence { get; set; }
        public string Telephones_Landline { get; set; }
        public string Cell_Phone { get; set; }
        public DateTime Date_of_birth { get; set; }
        public int Age { get; set; }
        public string Race_DANE_Information { get; set; }  //Black (Afro-descendant) - Mestizo - White - Indigenous
                                                           //Dropdown
        public string Ethnicity_DANE_Information { get; set; }  //Palenquera   -   Raizal  - Indigenous  -  Gypsy
                                                                //Dropdown
        public string Level_of_Education { get; set; } //Primary - Bachelor - Technical - Professional 
        public string Marital_status { get; set; } //Married - Single - Separated - Free - Union - Divorced - Widowed

        public string Affiliation_regime { get; set; } //Subsidized - contributory
        public string EPS_IPS { get; set; }


        //Paste Patient Columns
    }
}