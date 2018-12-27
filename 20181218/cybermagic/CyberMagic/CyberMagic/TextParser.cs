﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace VivaRegex
{
    public class TextParser
    {
        public string ExtractTimeToCreate(string text)
        {
            return SafelyExtractSingleElement(
                @"\((\d\d) min.*\)", text);
        }

        public string ExtractCommandNumbers(string text)
        {
            return SafelyExtractSingleElement(
                @"\d+", text);
        }
        public string ExtractProfileName(string text)
        {
            return SafelyExtractSingleElement(
                @"title: ""(\w+ \w+)""", text);
        }

        public string ExtractStuffWithMagda(string text)
        {
            return SafelyExtractSingleElement(
                @"# Zas.ugi.*?(Magda Patiril.*?)\*.*?#", text);
        }

        public string ExtractMerit(string text)
        {
            return SafelyExtractSingleElement(
                @"# Zas.ugi\s+(.+?)# ", text);
        }
        public string ExtractCharacterFromMerit(string text)
        {
            return SafelyExtractManyElement(
                @"^\* (\w+ \w+):", text);
        }

        public string ExtrakctTitle(string text)
        {
            return SafelyExtractSingleElement(
                @"title: +""([\w\s]+)""", text);
        }

        private string SafelyExtractSingleElement(string pattern, string text)
        {
            MatchCollection matches = new Regex(pattern, RegexOptions.Multiline | RegexOptions.Singleline)
                .Matches(text);

            List<string> allResults = new List<string>();
            foreach (Match match in matches)
            {
                allResults.Add(match.Groups[1].Value);
            }

            if (allResults.Count > 0) return allResults.First();
            else return string.Empty;
        }

        private string SafelyExtractManyElement(string pattern, string text)
        {
            MatchCollection matches = new Regex(pattern, RegexOptions.Multiline | RegexOptions.Singleline)
                .Matches(text);

            List<string> allResults = new List<string>();
            foreach (Match match in matches)
            {
                allResults.Add(match.Groups[1].Value);
            }

            if (allResults.Count > 0) return String.Join(",", allResults);
            else return string.Empty;
        }
    }
}

