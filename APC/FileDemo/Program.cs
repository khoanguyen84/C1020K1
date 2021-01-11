using System;
using System.Collections.Generic;
using System.IO;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\CodeGym\Class\C1020K1\APC\FileDemo\Data";
            string filename = "data.txt";
            string fnResult = "result.txt";
            string logfile = $"Log_{DateTime.Now.ToString("ddMMyyyyhhmm")}.txt";
            //Directory.CreateDirectory(path);
            // Directory.Delete(path);
            //Directory.Delete(path, true);
            using(StreamWriter sw = new StreamWriter($@"{path}\{filename}")){
                sw.WriteLine("CodeGym");
                sw.Write("C1020K1");
                sw.WriteLine("NET CORE");
            }

            List<string> data = new List<string>();
            using(StreamReader sr = new StreamReader($@"{path}\{filename}")){
                // Console.WriteLine(sr.ReadToEnd());
                string line;
                int count =0;
                while((line = sr.ReadLine()) != null){
                    // Console.WriteLine($"Line {++count}. {line.ToUpper()}");
                    data.Add($"Line {++count}. {line.ToUpper()}");
                }
            }

            using(StreamWriter sw = new StreamWriter($@"{path}\{fnResult}")){
                foreach(var item in data){
                    sw.WriteLine(item);
                }
            }
            try
            {
                int a = 5;
                int b= 0;
                int c = a/b;
            }
            catch (System.Exception ex)
            {
                WriteLog($@"{path}\{logfile}", ex.Message);
            }

        }

        public static void WriteLog(string path, string message){
            using(StreamWriter sw = new StreamWriter(path, true)){
                sw.WriteLine(message);
            }
        }
    }
}
