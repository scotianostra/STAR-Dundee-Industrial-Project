﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Dundee_WPF
{
    class FileParser
    {

        public void readFile()
        {
            string fileName = "";

            string[] lineInFile = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lineInFile)
            {
                Console.WriteLine("\t" + line);
            }
        }

    }
}