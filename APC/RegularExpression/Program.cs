using System;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "Copyright (C) Microsoft Corporation. All rights reserved.";
            string regex = @"ri";

            MatchCollection result = Regex.Matches(pattern, regex);
            // Match result2 = Regex.Match(pattern, regex);
            // bool result3 = Regex.IsMatch(pattern, regex);

            // Console.WriteLine(result2.Success);
            foreach(var item in result){
                Console.WriteLine(item);
            }
                
        }
    }
}
