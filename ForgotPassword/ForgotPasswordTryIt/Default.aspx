<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ForgotPasswordTryIt._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h3>Mukthadir H Choudhury&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Assignmnet 3 Part 3</h3>
        <p>This page lets the user change his password incase he forgets it. For changing password, the user first needs to provide his valid name that he used during sign up, his contact number and one of the security question along with its answer.</p>
        <p> Name: <asp:TextBox ID="TextBox1" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101"></asp:TextBox> <br /><br />
            Phone Number: <asp:TextBox ID="TextBox2" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox> <br /><br />
            Security Question 1: <asp:TextBox ID="TextBox10" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox> <br /><br />
            Security Answer 1: <asp:TextBox ID="TextBox11" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox> <br /><br />
            Security Question 2: <asp:TextBox ID="TextBox12" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox>  <br /><br />
            Security Answer 2: <asp:TextBox ID="TextBox13" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox> <br /><br />
            New Password: <asp:TextBox ID="TextBox3" TextMode = "Password" runat="server" Height="30px" Width="500px" Wrap="True" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox>  <br /><br />
            Confirm New Password: <asp:TextBox ID="TextBox4"  TextMode = "Password" runat="server" Height="30px" Width="500px" Wrap="True" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox> <br /><br />
            
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update Password" style = "LEFT: 500px; POSITION: absolute;" />
        </p>

    </div>

    <div class ="jumbotron">
        <p> <asp:TextBox ID="TextBox5" TextMode = "Multiline" runat="server" Height="50px" Width="800px" Wrap="True" style = "LEFT: 400px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox>  <br /><br /> </p>
    </div>
</asp:Content>