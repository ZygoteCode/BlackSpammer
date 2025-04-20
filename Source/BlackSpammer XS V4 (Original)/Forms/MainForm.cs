using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public partial class MainForm : Form
{
    [DllImport("user32.dll")]
    private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

    public MainForm()
    {
        InitializeComponent();
        CheckForIllegalCrossThreadCalls = false;
        guna2Button25.Enabled = true;
    }

    private void guna2CircleButton1_Click(object sender, EventArgs e)
    {
        Process.GetCurrentProcess().Kill();
    }

    private void guna2CircleButton3_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void guna2Button2_Click(object sender, EventArgs e)
    {
        if (guna2Button2.Checked)
        {
            guna2TabControl1.SelectedTab = tabPage2;
        }
    }

    private void guna2Button3_Click(object sender, EventArgs e)
    {
        if (guna2Button3.Checked)
        {
            guna2TabControl1.SelectedTab = tabPage3;
        }
    }

    private void guna2Button4_Click(object sender, EventArgs e)
    {
        if (guna2Button4.Checked)
        {
            guna2TabControl1.SelectedTab = tabPage4;
        }
    }

    private void guna2Button1_Click(object sender, EventArgs e)
    {
        if (guna2Button1.Checked)
        {
            guna2TabControl1.SelectedTab = tabPage1;
        }
    }

    private void guna2Button12_Click(object sender, EventArgs e)
    {
        if (FormManager.BlackSpammerLoggerForm != null)
        {
            FormManager.BlackSpammerLoggerForm.Close();
            FormManager.BlackSpammerLoggerForm = null;
        }

        if (FormManager.BlackSpammerTextGeneratorForm != null)
        {
            FormManager.BlackSpammerTextGeneratorForm.Close();
            FormManager.BlackSpammerTextGeneratorForm = null;
        }

        if (FormManager.BlackSpammerTextResultForm != null)
        {
            FormManager.BlackSpammerTextResultForm.Close();
            FormManager.BlackSpammerTextResultForm = null;
        }

        FormManager.BlackSpammerLoginForm.Show();
        Hide();
    }

    private void guna2Button11_Click(object sender, EventArgs e)
    {
        if (FormManager.BlackSpammerLoggerForm == null)
        {
            FormManager.BlackSpammerLoggerForm = new Logger();
        }

        FormManager.BlackSpammerLoggerForm.Show();
    }

    private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
    {
        guna2HtmlLabel25.Text = $"Delay: {guna2TrackBar1.Value}ms";
    }

    private void guna2TrackBar2_Scroll(object sender, ScrollEventArgs e)
    {
        guna2HtmlLabel36.Text = $"Delay: {guna2TrackBar2.Value}ms";
    }

    private void guna2Button13_Click(object sender, EventArgs e)
    {
        if (guna2Button13.Checked)
        {
            guna2TabControl1.SelectedTab = tabPage5;
        }
    }

    private void guna2Button19_Click(object sender, EventArgs e)
    {
        guna2TextBox10.Select();

        keybd_event(0x5B, 0, 0x0, UIntPtr.Zero);
        keybd_event(0xBE, 0, 0x0, UIntPtr.Zero);
        keybd_event(0xBE, 0, 0x2, UIntPtr.Zero);
        keybd_event(0x5B, 0, 0x2, UIntPtr.Zero);
    }

    private void guna2TrackBar3_Scroll(object sender, ScrollEventArgs e)
    {
        guna2HtmlLabel54.Text = $"Delay: {guna2TrackBar3.Value}ms";
    }

    private void guna2Button14_Click(object sender, EventArgs e)
    {
        if (guna2Button14.Checked)
        {
            guna2TabControl1.SelectedTab = tabPage6;
        }
    }

    private void guna2Button27_Click(object sender, EventArgs e)
    {
        if (FormManager.BlackSpammerTextGeneratorForm == null)
        {
            FormManager.BlackSpammerTextGeneratorForm = new TextGenerator();
        }

        FormManager.BlackSpammerTextGeneratorForm.Show();
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        FormManager.BlackSpammerMainForm = null;
    }
}