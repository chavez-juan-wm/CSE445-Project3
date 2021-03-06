﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryItChavez.aspx.cs" Inherits="GUI.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="~/Styles/bootstrap.css" />
    <link rel="stylesheet" href="~/Styles/Site.css" />
</head>
<body>
    <form id="form2" runat="server">
        <h1>Juan&#39;s Services:</h1>

        <h3>Top10Words Service</h3>
        <div class="row">
                <div class="col-md-4">          
                <p>
                    <b>Description:</b> Analyze the webpage at a given url and return the ten 
                    most-frequently occurred words in the webpage. Return the words in the descending 
                    order of their appearing frequencies.
                </p>

                    <p><b>Operation:</b> string[] Top10Words(string url)</p>

                    <p><b>Input:</b> A webpage url in string</p>

                    <p>
                        <b>Output:</b> An array of strings that contains the ten most-frequently occurred
                        words in descending order of their frequencies.
                    </p>
            </div>

            <div class="col-md-8">

                <asp:TextBox ID="UrlTextBox" placeholder="http://www.example.com/index.html" runat="server" Width="697px"></asp:TextBox>
                <asp:Button ID="submit" CssClass="btn btn-primary" runat="server" Text="Submit" OnClick="submit_Click" />
                <br /><br />
                <p>Result: </p><br />
                <asp:Label ID="Result" runat="server"></asp:Label>

            </div>
        </div>

        <h3>Stemming Service</h3>
        <div class="row">
            <div class="col-md-6">
                <p>
                    <b>Description:</b> Analyze a string containing a word or multiple words
                    and replace each of the inflected or derived words to their stem or root
                    word. For example, “information”, “informed”, “informs”, “informative”
                    will be replaced by the stem word “inform”. This service can help find 
                    useful keywords or index words in information processing and retrieval.
                </p>

                <p><b>Operation:</b> string Stemming(string str)</p>

                <p><b>Input:</b> A string type of a word or words</p>

                <p><b>Output:</b> The string of the inflected or derived words replaced by their stem words.</p>
            </div>
    
            <div class="col-md-6">
            
            </div>
        </div>
    </form>

    <script src="~/Scripts/jquery-3.4.1.js"></script>
    <script src="~/Scripts/bootstrap.js"></script>
    <script src="~/Scripts/myScripts.js"></script>
</body>
</html>