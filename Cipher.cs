using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_3._1
{
    internal class Cipher : Password
    {
        public const string upalf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public const string lowalf = "abcdefghijklmnopqrstuvwxyz";

        public int k;

        public int K
        {
            get => k;
            set => k = value;
        }

        private string CodeEncode(string pass, int k)
        {
            var retVal = "";
            for (int i = 0; i < pass.Length; i++)
            {
                var c = pass[i];
                if (pass[i].ToString() == pass[i].ToString().ToLower())
                {
                    var index = lowalf.IndexOf(c);
                    if (index < 0)
                    {
                        //если символ не найден, то добавляем его в неизменном виде
                        retVal += c.ToString();
                    }
                    else
                    {
                        var letterQty1 = lowalf.Length;
                        var codeIndex1 = (letterQty1 + index + k%26) % (letterQty1);
                        retVal += lowalf[codeIndex1];
                    }
                }
                if (pass[i].ToString() != pass[i].ToString().ToLower())
                {
                    var index = upalf.IndexOf(c);
                    if (index < 0)
                    {
                        //если символ не найден, то добавляем его в неизменном виде
                        retVal += c.ToString();
                    }
                    else
                    {
                        var letter2 = upalf.Length;
                        var codeIndex2 = (letter2 + index + k%26) % letter2;
                        retVal += upalf[codeIndex2];
                    }
                }
            }

            return retVal;
        }

        //шифрование текста
        public string Encrypt(string s, int k)
        => CodeEncode(s, k);

        //дешифрование текста
        public string Decrypt(string s, int k)
        => CodeEncode(s, -k);
    }
}
