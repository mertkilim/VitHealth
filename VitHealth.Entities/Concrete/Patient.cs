using VitHealth.Entities.Abstract;

namespace VitHealth.Entities.Concrete
{
    public class Patient : BaseEntity<int>
    {
        private DateTime _birthDate;
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
        public string IdentificationNumber { get; set; }
        public int Age { get; private set; }
        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                _birthDate = value;
                CalculateAge();
            }
        }
        public ICollection<Policlinic>? Policlinics { get; set; }
        public string PhoneNumber { get; set; }

        private string _Password;
        public string Password
        {
            get
            {
                return _Password;
            }
            private set
            {
                if (value.Length >= 8 && value.Contains("1234567890"))
                {
                    _Password = value;
                }
                else
                {

                }
            }
        }

        private void CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - _birthDate.Year;

            // Eğer henüz doğum günü geçmediyse yaş bir azalt
            if (_birthDate.Date > today.AddYears(-age))
                age--;

            Age = age;
        }

    }
}
