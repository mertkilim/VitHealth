using VitHealth.Entities.Abstract;

namespace VitHealth.Entities.Concrete
{
    public class Patient : BaseEntity<int>
    {
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
        public string IdentificationNumber { get; set; }

        private DateTime _BirthDate;
        public DateTime BirthDate
        {
            get
            {
                return _BirthDate;
            }
            set
            {
                _BirthDate = value;
                CalculateAge();
            }
        }
        public int Age { get; private set; }
        public string PhoneNumber { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
        public ICollection<Policlinic> Policlinics { get; set; }
        public ICollection<Appointment> Appointments { get; set; }

        private void CalculateAge()
        {
            int age = (DateTime.Today.Year) - (_BirthDate.Year);

            if (_BirthDate.Date > DateTime.Today.AddYears(-age))
                age--;

            Age = age;
        }
    }
}
