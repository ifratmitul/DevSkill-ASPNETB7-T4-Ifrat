﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class FileUtility
    {
        public void WriteLine(string text)
        {
            var writer = new StringBuilder();
            writer.Append(text);
            File.WriteAllText(@"./Data.txt", writer.ToString());
        }
    }
}
