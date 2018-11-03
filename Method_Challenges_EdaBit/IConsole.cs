﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Challenges_EdaBit
{
    public interface IConsole
    {
        void WriteLine(string s);
        void WriteLine(object o);
        void Write(string s);
        string ReadLine();
        void Clear();
        ConsoleKeyInfo ReadKey();
    }
}
