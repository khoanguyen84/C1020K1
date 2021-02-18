namespace Bai1
{
    public class SeniorDeveloper : Developer
    {
        public double GetSalary(double workHours, double bonus){
            return workHours* Rank + bonus;
        }

        //overloading
        public new double GetSalary(double workHours){
            return workHours* Rank + workHours* Rank*0.1;
        }

        public new string ToString()
        {
            return "";
        }

        
    }
}