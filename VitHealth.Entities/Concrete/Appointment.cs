using VitHealth.Entities.Abstract;

namespace VitHealth.Entities.Concrete
{
    public class Appointment : BaseEntity<int>
    {
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public Policlinic Policlinic { get; set; }
        public TimeOnly Time { get; set; }

    }
}
