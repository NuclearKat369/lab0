using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class Program102
{
    static void Main(string[] args)
    {
        string txt = Interaction.InputBox("Ваше число", "Ввведите число:");
        int a, b, c;
        a = Int32.Parse(txt);
        b = a - 1;
        c = a + 1;
        MessageBox.Show(b + ", " + a + ", " + c);
    }
}