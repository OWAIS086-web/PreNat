using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreNat.Entities
{
   public class ChronologyPregnancy : BaseEntity
    {
        public int ReliableFUM { get; set; }
        public int UltrasoundObstetrics  { get; set; }
        public int FPP { get; set; }
        public int FPC { get; set; }
        public int PatientID { get; set; }

    }
}
