<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryIt.aspx.cs" Inherits="GUI.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="~/Styles/bootstrap.css" />
    <link rel="stylesheet" href="~/Styles/Site.css" />
</head>
<body>
    <form id="form1" runat="server">
        <h1>Isaiah&#39;s Services:</h1>

        <h3>Word Filter Service</h3>
        <div class ="row">
            <div class="col-md-6">
                <p>
                    <b>Description:</b> Analyze a string of words and filter out 
                    the function words such as "a", "an", "in", "on", "the", "is", 
                    "are", "am", and any words that are not meaningful to be counted 
                    at the top words in search.
                </p>
                <p><b>Operation:</b> string WordFilter(string str)</p>
                <p><b>Input:</b> A string.</p>
                <p><b>Output:</b> A string with the stop words removed.<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </p>
                <p>
                    <asp:FileUpload ID="FileUpload1" runat="server" Width="398px" />
                    <asp:Button ID="FileUploadSubmit" runat="server" OnClick="FileUploadSubmit_Click1" Text="Upload" />
                    <asp:Label ID="UploadStatusLabel" runat="server"></asp:Label>
                </p>
                
            </div>
        </div>

        <h3>Storage Service</h3>
        <div class ="row">
            <div class="col-md-6">
                <p>
                    <b>Description:</b> Create a service that can load a
                    local file and storethe file into the server. A URL
                    will be returned.The returned URL can be used for retreiving
                    the file from the server.
                </p>
                <p><b>Operation:</b> string Storefile(string fileName)</p>
                <p><b>Input:</b> file name with local path</p>
                <p><b>Output:</b> URL of the file in the server.</p>
                <p>
                    <asp:TextBox ID="WordFilterTxtBox" runat="server" Width="178px"></asp:TextBox>
                    <asp:Button ID="WordFilterBtn" runat="server" Height="22px" Text="Filter" Width="51px" OnClick="WordFilterBtn_Click" />
                </p>
                <p>
                    <asp:Label ID ="WordFilterLabel" runat="server"></asp:Label>
                </p>
                
            </div>
        </div>
    </form>

    <script src="~/Scripts/jquery-3.4.1.js"></script>
    <script src="~/Scripts/bootstrap.js"></script>
    <script src="~/Scripts/myScripts.js"></script>
</body>
</html>

