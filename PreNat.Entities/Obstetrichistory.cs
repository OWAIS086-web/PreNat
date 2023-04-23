using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreNat.Entities
{
    public class Obstetrichistory : BaseEntity
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
        public int PatientID { get; set; }


    }
}
