using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace JsonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\CodeGym\Class\C1020K1\APC\JsonDemo\JsonDemo\JsonDemo\Data\";
            string inputFile = "matrix.json";
            string outputFile = "matrix-output.json";
            string students = "students.json";
            string data;
            using (StreamReader sr = File.OpenText($@"{path}{inputFile}"))
            {
                data = sr.ReadToEnd();
            }
            Matrix result = JsonConvert.DeserializeObject<Matrix>(data);
            foreach(List<int> arr in result.matrix)
            {
                foreach(int value in arr)
                {
                    Console.Write($"{value} ");
                }
                Console.WriteLine();
            }
            for(int i=0; i< result.matrix.Count; i++)
            {
                for(int j=0; j< result.matrix[i].Count; j++)
                {
                    result.matrix[i][j] *= 2;
                }
            }

            using (StreamWriter sw = File.CreateText($@"{path}{outputFile}")){
                sw.Write(JsonConvert.SerializeObject(result.matrix));
            }

            //using (StreamWriter sw = File.CreateText($@"{path}{students}"))
            //{
            //    sw.Write(JsonConvert.SerializeObject(result.students));
            //}
            List<ResStudent> resStudents = new List<ResStudent>();
            foreach(Student std in result.students)
            {
                var item = new ResStudent()
                {
                    studentId = std.studentId,
                    dob = std.dob,
                    fullname = std.fullname,
                    scores = std.scores
                };
                resStudents.Add(item);
            }
            using (StreamWriter sw = File.CreateText($@"{path}{students}"))
            {
                sw.Write(JsonConvert.SerializeObject(resStudents));
            }
        }

    }


    class Matrix
    {
        public List<List<int>> matrix { get; set; }
        public List<Student> students { get; set; }
    }
    class Student
    {
        public int studentId { get; set; }
        public string fullname { get; set; }
        public DateTime dob { get; set; }
        public List<Score> scores { get; set; }
        //public double avescore => CalculatorAveScore();
        //private double CalculatorAveScore()
        //{
        //    double sum = 0.0;
        //    foreach(Score s in scores)
        //    {
        //        sum += s.score;
        //    }
        //    return sum / scores.Count;
        //}
    }
    class Score
    {
        public string scorename { get; set; }
        public double score { get; set; }
    }

    class ResStudent : Student
    {
        public double avescore => CalculatorAveScore();
        private double CalculatorAveScore()
        {
            double sum = 0.0;
            foreach (Score s in scores)
            {
                sum += s.score;
            }
            return sum / scores.Count;
        }
    }
}
