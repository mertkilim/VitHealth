using VitHealth.Entities.Abstract;

namespace VitHealth.Entities.Concrete
{
    public class Policlinic : BaseEntity<int>
    {
        public string PoliclinicName { get; set; }
        public ICollection<Doctor>? Doctors { get; set; }

    }
}
