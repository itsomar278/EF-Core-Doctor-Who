using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db
{
    public class CompanionEpisode
    {
        public int CompanionId { get; set; }
        public Companion companion { get; set; } 
        public int EpisodeId { get; set; } 
        public Episode episode { get; set; }
    }
}
