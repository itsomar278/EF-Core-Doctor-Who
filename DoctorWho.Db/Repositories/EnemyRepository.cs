namespace DoctorWho.Db.Repositories
{
    public class EnemyRepository
    {
        public readonly DoctorWhoCoreDbContext _db;
        public EnemyRepository()
        {
            _db = new DoctorWhoCoreDbContext();
        }
        public void AddEnemy(Enemy enemy)
        {
            _db.Enemies.Add(enemy);
            _db.SaveChanges();
        }
        public void DeleteEnemy(Enemy enemy)
        {
            _db.Enemies.Add(enemy);
            _db.SaveChanges();
        }
        public void UpdateEnemyName(Enemy Enemy)
        {
            if (_db.Enemies.Find(Enemy.EnemyId) != null)
            {
                var enemyToEdit = _db.Enemies.Find(Enemy.EnemyId);
                enemyToEdit.EnemyName = Enemy.EnemyName;
                enemyToEdit.Describtion = Enemy.Describtion;
                enemyToEdit.EnemyEpisodes = Enemy.EnemyEpisodes;
                _db.SaveChanges();
            }
            else
            {
                throw new ArgumentException("there is no enemy with such id");
            }
        }
        public Enemy GetEnemyById(int id)
        {
            var enemy = _db.Enemies.Find(id);
            if (enemy == null)
            {
                throw new ArgumentException("There is no enemy with such id ");
            }
            return enemy;
        }
    }
}
