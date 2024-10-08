﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db
{
    public class Episode
    {
        public Episode ()
        {
            CompanionEpisodes = new List<CompanionEpisode> ();
            EnemyEpisodes = new List<EnemyEpisode>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int EpisodeId { get; set; }
        public string Title { get; set; }
        public int SeriesNumber { get; set; }
        public int EpisodeNumber { get; set; }
        public DateTime EpisodeDate { get; set; }
        public string Notes { get; set; }
        public string EpisodeType { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public List<CompanionEpisode> CompanionEpisodes { get; set; }
        public List<EnemyEpisode> EnemyEpisodes { get; set; }
    }
}
