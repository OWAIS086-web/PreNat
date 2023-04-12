using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreNat.Entities
{
    public class LaboratoryTests : BaseEntity
    {
        public string Group { get; set; }
        public string SanguineoGroup { get; set; }
        public string Laboratory_Tests { get; set; }
        public string VDRL { get; set; }
        public string Syphilis { get; set; }
        public string VIH { get; set; }
        public int PatientID { get; set; }
    }
}
