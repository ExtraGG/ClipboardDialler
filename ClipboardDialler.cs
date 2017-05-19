using System.Diagnostics;
using System.Windows.Forms;
using System;
using System.Windows.Controls;

class ClipboardDialler
{
    [STAThread]
    public static void Main()
    {
        string number = Clipboard.GetText();
        Call(number);
    }
    public static void Call(string number)
    {
        Process.Start("callto:" + number);
    }
}


