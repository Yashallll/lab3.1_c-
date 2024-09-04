using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Лабораторная_работа_3._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void but1_Click(object sender, RoutedEventArgs e)
        {
            string path = "password.txt";
            Password password = new Password();
            password.pass = textbox1.Text;
            l1.Text = password.Draw_1();
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                await writer.WriteLineAsync(textbox1.Text);
            }
        }

        private void but2_Click(object sender, RoutedEventArgs e)
        {
            Password password = new Password();
            password.pass = textbox1.Text;
            l1.Text += password.Draw_2(textbox2.Text);
            l1.Text += password.Draw_3(textbox2.Text);
        }
    }
}
