using System;
using System.Windows.Forms;

public partial class TextGenerator : Form
{
    public TextGenerator()
    {
        InitializeComponent();
        CheckForIllegalCrossThreadCalls = false;
    }

    private void guna2CircleButton1_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void guna2Button11_Click(object sender, EventArgs e)
    {
        string str = guna2TextBox12.Text;
        ushort result = 0;
        bool canParse = ushort.TryParse(str, out result);

        if (!canParse)
        {
            MessageBox.Show("Please, insert a valid number", "BlackSpammer XS V4", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        FormManager.BlackSpammerTextGeneratorCount = result;

        if (FormManager.BlackSpammerTextResultForm == null)
        {
            FormManager.BlackSpammerTextResultForm = new TextResult();
        }

        FormManager.BlackSpammerTextResultForm.Show();
    }

    private void TextGenerator_FormClosing(object sender, FormClosingEventArgs e)
    {
        FormManager.BlackSpammerTextGeneratorForm = null;
    }

    private void guna2CustomCheckBox13_Click(object sender, EventArgs e)
    {
        FormManager.BlackSpammerTextGenerator_MTAG = guna2CustomCheckBox13.Checked;
    }

    private void guna2CustomCheckBox2_Click(object sender, EventArgs e)
    {
        FormManager.BlackSpammerTextGenerator_RAND = guna2CustomCheckBox2.Checked;
    }

    private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
    {
        FormManager.BlackSpammerTextGenerator_COUNT = guna2CustomCheckBox1.Checked;
    }

    private void guna2TextBox12_TextChanged(object sender, EventArgs e)
    {
        FormManager.BlackSpammerTextGenerator_TEXT = guna2TextBox12.Text;
    }

    private void TextGenerator_Load(object sender, EventArgs e)
    {
        if (FormManager.BlackSpammerTextGenerator_TEXT != null)
        {
            guna2TextBox12.Text = FormManager.BlackSpammerTextGenerator_TEXT;
        }

        guna2CustomCheckBox13.Checked = FormManager.BlackSpammerTextGenerator_MTAG;
        guna2CustomCheckBox2.Checked = FormManager.BlackSpammerTextGenerator_RAND;
        guna2CustomCheckBox1.Checked = FormManager.BlackSpammerTextGenerator_COUNT;
    }
}