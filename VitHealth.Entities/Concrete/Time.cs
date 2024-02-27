using VitHealth.Entities.Abstract;

namespace VitHealth.Entities.Concrete
{
    public class Time : BaseEntity<int>
    {
        public DateOnly Date { get; set; }
        public List<TimeOnly> Hours { get; set; }
    }
}
