namespace Collection
{
    class Student
    {
        public int StudentId { get; set; }
        public string Fullname { get; set; }  

        public string PrintInfo(){
            return $"{StudentId}\t\t{Fullname}";
        }
    }
}