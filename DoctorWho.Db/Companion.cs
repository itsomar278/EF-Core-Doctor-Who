using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CompanionId { get; set; }
        public string CompanionName { get; set; }
        public string WhoPayed { get; set; }
        public List<Episode> Episodes { get; set; } 
    }
}
