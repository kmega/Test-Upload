﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexTasks
{
    class FileSupporter
    {
        //
        public string fullstringsfromfile;

        public string Read_File(string path)
        {
            //string path = "..\\..\\..\\..\\..\\cybermagic\\karty-postaci\\1807-fryderyk-komciur.md";

            //Read the stream to a string, and write the string to the console.

            fullstringsfromfile = File.ReadAllText(path);


            return fullstringsfromfile;
        }

        public void SaveToFIle(string TextToSave, string TaskResultNumber,bool append)
        {
            using (StreamWriter file = new StreamWriter(@"..\\..\\results\\"+TaskResultNumber+".txt", append))
            {
                file.WriteLine(TextToSave);
            }
        }
    }
}