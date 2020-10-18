using System;

namespace GUI
{
    public partial class Default : System.Web.UI.Page
    {
     

        protected void submit_Click(object sender, EventArgs e)
        {
            Result.Text = "";
            if (UrlTextBox.Text == "")
                Result.Text = "Please enter a url";
            else
            {
                Top10WordsServiceRef.Top10WordsClient client = new Top10WordsServiceRef.Top10WordsClient();
                string[] top10 = client.Top10Words(UrlTextBox.Text);

                for (int i = 0; i < 9; i++)
                {
                    Result.Text += (top10[i] + ", ");
                }
                Result.Text += top10[9];

                client.Close();
            }

        }
    }
}
