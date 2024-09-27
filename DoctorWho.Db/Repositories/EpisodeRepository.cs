namespace DoctorWho.Db.Repositories
{
    public class EpisodeRepository
    {
        public readonly DoctorWhoCoreDbContext _db;
        public EpisodeRepository()
        {
            _db = new DoctorWhoCoreDbContext();
        }
        public void AddEpisode(Episode episode)
        {
            _db.Episodes.Add(episode);
            _db.SaveChanges();
        }
        public void DeleteEpisode(Episode episode)
        {

            _db.Episodes.Remove(episode);
            _db.SaveChanges();

        }
        public void UpdateEpisodeTitle(Episode episode)
        {
            if (_db.Episodes.Find(episode.EpisodeId) != null)
            {
                var episodeToUpdate = _db.Episodes.Find(episode.EpisodeId);
                episodeToUpdate.EpisodeDate = episode.EpisodeDate;
                episodeToUpdate.Title = episode.Title;
                episodeToUpdate.SeriesNumber = episode.SeriesNumber;
                episodeToUpdate.EpisodeNumber = episode.EpisodeNumber;
                episodeToUpdate.Notes = episode.Notes;
                episodeToUpdate.EpisodeType = episode.EpisodeType;
                if (_db.Authors.Find(episode.AuthorId) != null)
                {
                    episodeToUpdate.AuthorId = episode.AuthorId;
                }
                else
                {
                    throw new ArgumentException("there is no author with such id");
                }
                if (_db.Authors.Find(episode.DoctorId) != null)
                {
                    episodeToUpdate.DoctorId = episode.DoctorId;
                }
                else
                {
                    throw new ArgumentException("there is no doctor with such id");

                }
                _db.SaveChanges();
            }
            else
            {
                throw new ArgumentException("there is no episode with such id");
            }
        }

    }
}
