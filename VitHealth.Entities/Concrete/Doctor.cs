using VitHealth.Entities.Abstract;

namespace VitHealth.Entities.Concrete
{
    public class Doctor : BaseEntity<int>
    {
        public string DoctorName { get; set; }
        public string DoctorSurname { get; set; }
        public string IdentificationNumber { get; set; }
        public int PoliclinicId { get; set; }
        public Policlinic Policlinic { get; set; }
        public int TitleId { get; set; }
        public Title Title { get; set; }
        public List<TimeOnly> Hours { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Patient> Patients { get; set; }

    }
}
