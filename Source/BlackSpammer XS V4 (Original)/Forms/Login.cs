using System;
using System.Diagnostics;
using System.Windows.Forms;

public partial class Login : Form
{
    public Login()
    {
        InitializeComponent();
        CheckForIllegalCrossThreadCalls = false;
    }

    private void guna2Button1_Click(object sender, EventArgs e)
    {
        if (FormManager.BlackSpammerMainForm == null)
        {
            FormManager.BlackSpammerMainForm = new MainForm();
        }

        Hide();
        FormManager.BlackSpammerMainForm.Show();
    }

    private void guna2CircleButton1_Click(object sender, EventArgs e)
    {
        Process.GetCurrentProcess().Kill();
    }

    private void guna2CircleButton3_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void Login_FormClosing(object sender, FormClosingEventArgs e)
    {
        FormManager.BlackSpammerLoginForm = null;
    }
}