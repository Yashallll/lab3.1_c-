using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_3._1
{
    internal class SafePassword : Password
    {
        public string Safe()
        {
            string s = "";
            bool a;
            if (Pass.Contains('0') || Pass.Contains('1') || Pass.Contains('2') || Pass.Contains('3') || Pass.Contains('4') || Pass.Contains('5') || Pass.Contains('6') || Pass.Contains('7') || Pass.Contains('8') || Pass.Contains('9')) a = true;
            else a = false;
            bool b;
            if (Pass.Contains('!') || Pass.Contains('$') || Pass.Contains('#') || Pass.Contains('%')) b = true;
            else b = false;
            if (Pass.Length >= 8 && (Pass.ToLower() != Pass && Pass.ToUpper() != Pass) && a == true && b == true)
            {
                s = "Надёжный";
            }
            else if (Pass.Length >= 8 && ((Pass.ToLower() != Pass) && (Pass.ToUpper() != Pass)) && a == true)
            {
                s = "Хороший";
            }
            else if (Pass.Length >= 8 && ((Pass.ToLower() != Pass) && (Pass.ToUpper() != Pass)))
            {
                s = "Средний";
            }
            else if (Pass.Length >= 8)
            {
                s = "Слабый";
            }
            else if (Pass.Length < 8)
            {
                s = "Плохой";
            }

            return s;
        }
    }
}
