using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db
{
    public class Enemy
    {
        public  Enemy()
        {
            Episodes = new List<Episode>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int EnemyId { get; set; }
        public string EnemyName { get; set; }
        public string Describtion { get; set; }
        public List<Episode> Episodes { get; set; }
    }
}
