﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using VivaRegex;

namespace RegEx
{
    class Program
    {            
        static void Main(string[] args)
        {
            string timeKomciur;
            string nameKomciur;
            string timeWszyscy;
            int allTime = 0;
            string pathFKomciur = @"C:\Code\primary\20181218\cybermagic\karty-postaci\1807-fryderyk-komciur.md";
            string pathWszyscy = @"C:\Code\primary\20181218\cybermagic\karty-postaci";
            string result1 = @"C:\Code\primary\20181218\RegEx\RegEx\result1.txt";
            string result2 = @"C:\Code\primary\20181218\RegEx\RegEx\result2.txt";
            StreamWriter result2File = new StreamWriter(result2);

            //task 1
            string fKomciur = File.ReadAllText(pathFKomciur);
            TextParser tp = new TextParser();
            
            timeKomciur = tp.ExtractTimeToCreate(fKomciur);
            nameKomciur = tp.ExtractProfileName(fKomciur);
            File.WriteAllText(result1, nameKomciur + " byl budowany " + timeKomciur + " minuty");

            //task 2
            foreach(var element in Directory.EnumerateFiles(pathWszyscy, "*.md"))
            {
                string wszyscy = File.ReadAllText(element);
                TextParser tp2 = new TextParser();                
                timeWszyscy = tp2.ExtractTimeToCreate(wszyscy);

                if(timeWszyscy != "")
                {
                    allTime += Int32.Parse(timeWszyscy);
                }
            }
            result2File.WriteLine("Czas tworzenia wszystkich bahaterów to: {0} minuty", allTime);
            result2File.Close();
        }
    }
}
