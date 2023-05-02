using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreNat.Entities
{
    public class Obstetrichistory : BaseEntity
    {
        public int Gestation { get; set; }
        public int NoOfPregnancy { get; set; }
        public int Delivery { get; set; }
        public int Term { get; set; }
        public int Preterm { get; set; }
        public int Vaginal { get; set; }
        public int Cesareas { get; set; }
        public int Abortions { get; set; }
        public int Gemerales { get; set; }
        public int Ectopic { get; set; }
        public int Obitus { get; set; }
        public int Molas { get; set; }
        public int Live_Births { get; set; }
        public int PatientID { get; set; }


    }
}
