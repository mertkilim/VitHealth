using VitHealth.Entities.Abstract;

namespace VitHealth.Entities.Concrete
{
    public class Doctor : BaseEntity<int>
    {
        public string DoctorName { get; set; }
        public string DoctorSurname { get; set; }
        public int PoliclinicId { get; set; }
        public Policlinic Policlinic { get; set; }
        public Title Title { get; set; }
        public List<TimeOnly> Hours { get; set; }

    }
}
