using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db
{
    public class EnemyEpisode
    {
        public EnemyEpisode()
        {
        }
        public int EpisodeId { get; set; }
        Episode Episode { get; set; }
        public int EnemyId { get; set; }
        Enemy Enemy { get; set; }
    }
}
