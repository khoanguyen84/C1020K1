namespace InheritDemo
{
    class Student : Person
    {
        public string LastName {
            get => lastName;
            set => lastName = value;
        }
        public string Email { get; set; }
        public Student()
        {
            
        }

        public Student(string fn, string ln, string email) : base(fn, ln)
        {
            Email = email;
        }
        public string PrintInfo()
        {
            var str = ShowInfo();
            str += $"\t\t{Email}";
            return str;
        }

        // public new string ShowInfo(){
        //     return "";
        // }

        public override string ShowInfo(){
            // return $"{base.ShowInfo()}\t\t{Email}";
            return $"My email is: {Email}";
        }

        public override string ToString()
        {
            return $"{base.ToString()}\t\t{Email}";
        }

        public override int Sum(int number1, int number2)
        {
            int number3 = 10;
            int sum = base.Sum(number1, number2);
            return  sum + number3;
        }
    }
}