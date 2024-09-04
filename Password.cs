using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using System.IO;
using System.Windows.Shapes;
using System.Runtime.Remoting.Messaging;

namespace Лабораторная_работа_3._1
{
    internal class Password
    {
        public string pass;
        public string pas = "Qwerty123!";
        public string Pass
        {
            get => pass;
            set => pass = value;
        }

        public string Draw_1()
        {
            string a;
            SafePassword safe = new SafePassword();
            safe.pass = Pass;
            if (pas != Pass) a = "Пароли не совпадают! ";
            else a = "Пароли совпадают! ";
            a += $"Надёжность пароля: {safe.Safe()} ";
            return a;
        }

        public string Draw_2(string i)
        {
            string a;
            string path = "password.txt";
            Cipher cipher = new Cipher();
            cipher.pass = File.ReadAllText(path);
            cipher.k = int.Parse(i);
            string Enc = cipher.Encrypt(Pass, cipher.k);
            a = $"Зашифрованный пароль: {Enc} ";
            return a;
        }

        public string Draw_3(string i)
        {
            string b;
            string path = "password.txt";
            Cipher cipher = new Cipher();
            cipher.pass = File.ReadAllText(path);
            cipher.k = int.Parse(i);
            string Enc = cipher.Encrypt(Pass, cipher.k);
            b = $"Расшифрованный пароль: {cipher.Decrypt(Enc, cipher.k)}";
            return b;
        }
    }
}
