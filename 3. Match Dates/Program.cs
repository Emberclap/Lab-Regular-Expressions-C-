﻿using System.Text.RegularExpressions;

namespace _3._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?<day>\d{2})([/.-])(?<month>[A-Z][a-z]{2})(\1)(?<year>\d{4})";
            string dateStrings = Console.ReadLine();
            var dates = Regex.Matches(dateStrings, regex);
            foreach (Match date in dates )
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;
                Console.WriteLine($" Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}