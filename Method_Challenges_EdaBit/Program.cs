﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Challenges_EdaBit
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramUI program = new ProgramUI(new RealConsole());
            program.Run();
        }
    }
}
