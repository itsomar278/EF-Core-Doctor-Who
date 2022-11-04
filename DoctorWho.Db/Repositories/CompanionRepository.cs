namespace DoctorWho.Db.Repositories
{
    public class CompanionRepository
    {
        public readonly DoctorWhoCoreDbContext _db;
        public CompanionRepository()
        {
            _db = new DoctorWhoCoreDbContext();
        }
        public void AddCompanion(Companion companion)
        {
            _db.Companions.Add(companion);
            _db.SaveChanges();
        }
        public void DeleteCompanion(Companion companion)
        {
            _db.Companions.Remove(companion);
            _db.SaveChanges();
        }
        public void UpdateCompanionName(Companion companion)
        {
            if (_db.Companions.Find(companion.CompanionId) != null)
            {
                var companionToUpdate = _db.Companions.Find(companion.CompanionId);
                companionToUpdate.CompanionName = companion.CompanionName;
                companionToUpdate.WhoPayed = companion.WhoPayed;
                companionToUpdate.CompanionEpisodes = companion.CompanionEpisodes;
                _db.SaveChanges();

            }
            else
            {
                throw new ArgumentException("there is no companion with such id");
            }
        }
        public Companion GetCompanionById(int id)
        {
            var companion = _db.Companions.Find(id);
            if (companion == null)
            {
                throw new ArgumentException("There is no companion with such id ");
            }
            return companion;
        }
    }
}
