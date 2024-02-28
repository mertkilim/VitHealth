using VitHealth.Entities.Abstract;

namespace VitHealth.Entities.Concrete
{
    public class Title : BaseEntity<int>
    {
        public string TitleName { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}
