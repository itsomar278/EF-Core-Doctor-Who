namespace DoctorWho.Db.Repositories
{
    public class DoctorRepository
    {
        public readonly DoctorWhoCoreDbContext _db;
        public DoctorRepository()
        {
            _db = new DoctorWhoCoreDbContext();
        }
        public void AddDoctor(Doctor doctor)
        {
            _db.Doctors.Add(doctor);
            _db.SaveChanges();
        }
        public void DeleteDoctor(Doctor doctor)
        {
                _db.Doctors.Remove(doctor);
                _db.SaveChanges();
        }
        public void UpdateDoctorInfo(Doctor doctor)
        {
            if (_db.Doctors.Find(doctor.DoctorId)!=null)
            {
                var doctorToEdit = _db.Doctors.Find(doctor.DoctorId);
                doctorToEdit.DoctorNumber = doctor.DoctorNumber;
                doctorToEdit.BirthDate = doctor.BirthDate;
                doctorToEdit.DoctorName = doctor.DoctorName;
                doctorToEdit.FirstEpisodeDate = doctor.FirstEpisodeDate;
                doctorToEdit.LastEpisodeDate = doctor.LastEpisodeDate;
                doctorToEdit.Episodes = doctor.Episodes;
                _db.SaveChanges();
            }
            else
            {
                throw new ArgumentException("there is no doctor with such id");
            }
            
        }
        public  ICollection<Doctor> GetAllDoctors()
        {
                return _db.Doctors.ToList();
        }
    }
}
