﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace regex
{
    public class TextOperation
    {
        public string ExtractTimeToCreate(string text)
        {

            return SafelyExtractSingleElement(
                @"\((\d\d) min.*\)", text);
        }
        public string ExtractProfileName(string text)
        {

            return SafelyExtractSingleElement(
                @"title: ""(\w+ \w+)""", text);
        }
        public string SafelyExtractSingleElement(string pattern, string text)
        {
            MatchCollection matches = new Regex(pattern).Matches(text);

            List<string> allResults = new List<string>();
            foreach (Match match in matches)
            {
                allResults.Add(match.Groups[1].Value);
            }

            if (allResults.Count > 0) return allResults.First();
            else return string.Empty;

        }
    }
}
