using System;
namespace Bai1
{

    public class Developer : Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public double Rank { get; set; }

        public int GetAge()
        {
            return DateTime.Now.Year - Birthday.Year;
        }
        public double GetSalary(double WorkHours)
        {
            return Rank * WorkHours;
        }
    }
}