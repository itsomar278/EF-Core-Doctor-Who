namespace DoctorWho.Db.Repositories
{
    public class AuthorRepository
    {
        public readonly DoctorWhoCoreDbContext _db;
        public AuthorRepository()
        {
            _db = new DoctorWhoCoreDbContext();
        }
        public void AddAuthor(Author author)
        {
            _db.Authors.Add(author);
            _db.SaveChanges();
        }
        public void DeleteAuthor(Author author)
        {
            _db.Authors.Remove(author);
            _db.SaveChanges();
        }
        public void UpdateAuthorInfo(Author author)
        {
            if (_db.Authors.Find(author.AuthorId) != null)
            {
                var authorToEdit = _db.Authors.Find(author.AuthorId);
                authorToEdit.AuthorName = author.AuthorName;
                authorToEdit.Episodes = author.Episodes;
                _db.SaveChanges();
            }
            else
            {
                throw new ArgumentException("there is no author with such id");
            }
        }
    }
}
