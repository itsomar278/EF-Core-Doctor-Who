namespace DoctorWho.Db.Repositories
{
    public class EnemyEpisodeRepository
    {
        public readonly DoctorWhoCoreDbContext _db;
        public EnemyEpisodeRepository()
        {
            _db = new DoctorWhoCoreDbContext();
        }
        public void AddEnemyToEpisode(Enemy enemy, Episode episode)
        {
            if (!_db.Episodes.Contains(episode))
                throw new ArgumentException("this episode dosent exist");
            if (!_db.Enemies.Contains(enemy))
                throw new ArgumentException("this enemy dosent exist");
            EnemyEpisode enemyEpisode = new EnemyEpisode
            {
                EnemyId = enemy.EnemyId,
                EpisodeId = episode.EpisodeId
            };
            _db.EnemyEpisodes.Add(enemyEpisode);
            _db.SaveChanges();
        }
    }
}
