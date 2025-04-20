using System;
using System.Windows.Forms;
using System.Diagnostics;

public static class Program
{
    [STAThread]
    static void Main()
    {
        Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.RealTime;

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        FormManager.BlackSpammerMainForm = new MainForm();
        FormManager.BlackSpammerLoginForm = new Login();
        FormManager.BlackSpammerLoggerForm = new Logger();

        Application.Run(FormManager.BlackSpammerLoginForm);
    }
}