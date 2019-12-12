using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace CliffsGame
{
    class Program
    {
        [DllImport("kernel32.dll")]
        static extern bool SetConsoleOutputCP(uint wCodePageID);
        static void Main()
        {
            SetConsoleOutputCP(65001);
            Game game = new Game();
        }
    }
}
