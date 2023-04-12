using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreNat.Entities
{
    public class PregnancyConfirmation : BaseEntity
    {
        public string FUM { get; set; }
        public int FUM_Date { get; set; }
        public string Positive_HCG_presence { get; set; }
        public int Positive_HCG_presence_Date { get; set; }
        public string Upload_document1 {get; set;}
        public string Positive_TV_ultrasound { get; set; }
        public int Positive_TV_ultrasound_Date { get; set; }
        public string Upload_document2 { get; set; }
        public string PregnancyConfirm{ get; set; }

        public int PatientID { get; set; }
        //Continue with the Perinatal Medical History form. button 
        // urgent test button










    }
}
