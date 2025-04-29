using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Project
{

    public class CalculatorApp
    {
        public static void AnimateLoading()
        {
            string[] loadingChars = { "|", "/", "-", "\\" };
            for (int i = 0; i < 20; i++)
            {
                Console.Write(loadingChars[i % loadingChars.Length]);
                Thread.Sleep(100);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
        }
    }

}
