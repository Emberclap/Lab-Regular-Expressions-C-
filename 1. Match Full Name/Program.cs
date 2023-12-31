﻿using System.Text.RegularExpressions;

namespace _1._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b([A-Z][a-z]{1,} [A-Z][a-z]{1,})\b";
            string names = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(names, regex);

            foreach (Match match in matchedNames)
            {
                Console.Write(match.Value + " ");
            }
        }
    }
}