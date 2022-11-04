using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class CompanionEpisodeRepository
    {
        public readonly DoctorWhoCoreDbContext _db; 
        public CompanionEpisodeRepository()
        {
            _db = new DoctorWhoCoreDbContext();
        }
        public void AddCompanionToEpisode(Episode episode, Companion companion)
        {
                if (!_db.Episodes.Contains(episode))
                    throw new ArgumentException("this episode dosent exist");
                if (_db.Companions.Contains(companion))
                    throw new ArgumentException("this companion dosent exist");
                CompanionEpisode companionEpisode = new CompanionEpisode
                {
                    CompanionId = companion.CompanionId,
                    EpisodeId = episode.EpisodeId
                };
                _db.CompanionsEpisodes.Add(companionEpisode);
                _db.SaveChanges();
        }
    }
}
