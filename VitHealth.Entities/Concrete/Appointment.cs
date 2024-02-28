using VitHealth.Entities.Abstract;

namespace VitHealth.Entities.Concrete
{
    public class Appointment : BaseEntity<int>
    {
        public int? PatientId { get; set; }
        public Patient Patient { get; set; }
        public int? DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int? PoliclinicId { get; set; }
        public Policlinic Policlinic { get; set; }
        public DateTime Time { get; set; }
    }
}
