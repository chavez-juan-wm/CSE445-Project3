using GUI.StorageServiceRef;
using GUI.WordFilterServiceRef;
using System;
using System.Reflection.Emit;
using System.Web.UI.WebControls;

namespace GUI
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void FileUploadSubmit_Click1(object sender, EventArgs e)
        {
            StorageServiceRef.StorageServiceClient storageService = new StorageServiceRef.StorageServiceClient();
            if (FileUpload1.HasFile)
            {

                string retstring = storageService.Storefile(FileUpload1.PostedFile.ToString());
                FileUpload1.SaveAs(retstring);
                UploadStatusLabel.Text = retstring;
            }
            else
            {
                UploadStatusLabel.Text = "You did not specify a file to upload.";
            }
        }

        protected void WordFilterBtn_Click(object sender, EventArgs e)
        {
            WordFilterServiceRef.WordFilterServiceClient wordFilter = new WordFilterServiceRef.WordFilterServiceClient();
            WordFilterLabel.Text = wordFilter.WordFilter(WordFilterTxtBox.Text);
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            Result.Text = "";
            if (UrlTextBox.Text == "")
                Result.Text = "Please enter a url";
            else
            {
                Top10WordsService.Top10WordsClient client = new Top10WordsService.Top10WordsClient();
                string[] top10 = client.Top10Words(UrlTextBox.Text);

                for(int i = 0; i < 9; i++)
                {
                    Result.Text += (top10[i] + ", ");
                }
                Result.Text += top10[9];

                client.Close();
            }
                
        }
    }
}