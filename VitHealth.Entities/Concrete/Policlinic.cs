using VitHealth.Entities.Abstract;

namespace VitHealth.Entities.Concrete
{
    public class Policlinic : BaseEntity<int>
    {
        public string PoliclinicName { get; set; }
        public ICollection<Doctor>? Doctors { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Patient> Patients { get; set; }

    }
}
