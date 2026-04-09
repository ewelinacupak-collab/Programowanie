namespace Programowanie.Entities
{
    public class Student
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public double MonthlyRate { get; set; } = 500.0;
        public double TotalToPay { get; set; } = 2500.0;

        public Address Address { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Tuition> Tuitions { get; set; } = new List<Tuition>();


        public Student(string name, int age, string phone)
        {
            FullName = name;
            Age = age;
            PhoneNumber = phone;
        }

        public void AddAddress(string city, string street, string nr)
        {
            Address = new Address {  City = city, Street = street, HomeNr = nr };
        }

        public void AddCourse(int id, string name)
        {
            Courses.Add(new Course { Id = id, Name = name });
        }

        public void AddGrade(int CourseId, int grade)
        {
            foreach (var c in Courses)
            {
                if (c.Id == CourseId) {  c.Grade = grade; }
            }
        }

        public void AddTuition(double amount)
        {
            Tuition fee = new Tuition();
            fee.Amount = amount;

            fee.PaymentDate = DateTime.Now.ToShortDateString();

            fee.Deadline = DateTime.Now.AddDays(14).ToShortDateString();

            fee.IsPaid = true;

            Tuitions.Add(fee);

            TotalToPay = TotalToPay - amount;
        }
    }
}
