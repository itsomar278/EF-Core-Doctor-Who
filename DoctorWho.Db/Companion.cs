using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db
{
    public class Companion
    {
        public Companion()
        {
            Episodes = new List<Episode>();
        }
        public int CompanionId { get; set; }
        public string CompanionName { get; set; }
        public string WhoPayed { get; set; }
        public List<Episode> Episodes { get; set; } 
    }
}
