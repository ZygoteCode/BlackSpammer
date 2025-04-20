using System.Windows.Forms;

public partial class TextResult : Form
{
    public TextResult()
    {
        InitializeComponent();
    }

    private void guna2CircleButton1_Click(object sender, System.EventArgs e)
    {
        Close();
    }

    private void TextResult_FormClosing(object sender, FormClosingEventArgs e)
    {
        FormManager.BlackSpammerTextResultForm = null;
    }

    private void TextResult_Load(object sender, System.EventArgs e)
    {
        string result = "";

        for (int i = 0; i < FormManager.BlackSpammerTextGeneratorCount; i++)
        {
            if (FormManager.BlackSpammerTextGenerator_MTAG)
            {
                if (result == "")
                {
                    result = "[mtag]";
                }
                else
                {
                    result += "[mtag]";
                }
            }

            if (FormManager.BlackSpammerTextGenerator_COUNT)
            {
                if (result == "")
                {
                    result = "[count]";
                }
                else
                {
                    result += "[count]";
                }
            }

            if (FormManager.BlackSpammerTextGenerator_RAND)
            {
                if (result == "")
                {
                    result = "[rand]";
                }
                else
                {
                    result += "[rand]";
                }
            }
        }

        guna2TextBox12.Text = result;
    }
}