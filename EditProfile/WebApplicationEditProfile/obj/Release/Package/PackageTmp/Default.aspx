<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationEditProfile._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="jumbotron">
        
        <a href ="http:\\webstrar13.fulton.asu.edu" style = "left: 1000px; position: ABSOLUTE;"> Go to HomePage </a>
        <br /><br />
        
        
        <h3>Mukthadir H Choudhury&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Assignmnet 3 Part 3</h3>
        <p>This service modifies the existing user&#39;s details whenever the user wants to modify them. Also, this page lets the user delete his account in case he no longer wants to use this service.</p>
        <p>Enter all the fields you want to change: (min - zero fields, max - All fields)</p>
        <p>Name: <asp:TextBox ID="TextBox1" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101"></asp:TextBox> <br /><br />
        Phone Number: <asp:TextBox ID="TextBox2" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox> <br /><br />
        Email ID: <asp:TextBox ID="TextBox3" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox>  <br /><br />
        Address: <asp:TextBox ID="TextBox4" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox> <br /><br />
        SSN: <asp:TextBox ID="TextBox5" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox> <br /><br />
        Emergency Contact Name: <asp:TextBox ID="TextBox6" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox>  <br /><br />
        Emergency Contact Phone Number: <asp:TextBox ID="TextBox7" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox> <br /><br />
        Emergency Contact Email ID: <asp:TextBox ID="TextBox8" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox> <br /><br />
        Emergency Contact Relation: <asp:TextBox ID="TextBox9" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox>  <br /><br />
        Security Question 1: <asp:TextBox ID="TextBox10" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox> <br /><br />
        Security Answer 1: <asp:TextBox ID="TextBox11" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox> <br /><br />
        Security Question 2: <asp:TextBox ID="TextBox12" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox>  <br /><br />
        Security Answer 2: <asp:TextBox ID="TextBox13" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox> <br /> </p><br />
        <p><asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Save User Details" style = "LEFT: 300px; POSITION: absolute;" />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit New Details" style = "LEFT: 700px; POSITION: absolute;" />
            <br />
        </p>
        
    </div>

    <div class="jumbotron">
        <p><asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete User Account" /> <asp:TextBox ID="TextBox15" runat="server" Height="30px" Width="250px" Wrap="True" TextMode="MultiLine" style = "LEFT: 450px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox> <br /> </p>
    </div>

        <div class="jumbotron">
            <p><asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="View User Details" /> <asp:TextBox ID="TextBox16" runat="server" Height="30px" Width="250px" Wrap="True" TextMode="MultiLine" style = "LEFT: 450px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox> <br /> </p>
            Output: <asp:TextBox ID="TextBox14" runat="server" Height="270px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 350px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox>    
        <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
        
        
        </div>




    
        <div class="jumbotron">
        <div> <p> Second Elective Sercvice </p> </div>
        <p>This service lets the user change his password incase he forgets it. For changing password, the user first needs to provide his valid name that he used during sign up, his contact number and one of the security question along with its answer.</p>
        <p> Name: <asp:TextBox ID="TextBox17" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101"></asp:TextBox> <br /><br />
            Phone Number: <asp:TextBox ID="TextBox18" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox> <br /><br />
            Security Question 1: <asp:TextBox ID="TextBox19" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox> <br /><br />
            Security Answer 1: <asp:TextBox ID="TextBox20" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox> <br /><br />
            Security Question 2: <asp:TextBox ID="TextBox21" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox>  <br /><br />
            Security Answer 2: <asp:TextBox ID="TextBox22" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox> <br /><br />
            New Password: <asp:TextBox ID="TextBox23" TextMode = "Password" runat="server" Height="30px" Width="500px" Wrap="True" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox>  <br /><br />
            Confirm New Password: <asp:TextBox ID="TextBox24"  TextMode = "Password" runat="server" Height="30px" Width="500px" Wrap="True" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox> <br /><br />
            
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Update Password" style = "LEFT: 400px; POSITION: absolute;"/>
        </p>
    </div>

    <div class ="jumbotron">
        <p> <asp:TextBox ID="TextBox25" TextMode = "Multiline" runat="server" Height="50px" Width="800px" Wrap="True" style = "LEFT: 400px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="1"></asp:TextBox>  <br /><br /> </p>
    </div>







    <div class="jumbotron">
        <h3>Third Elective service</h3>
        <p>This service lets the user enter the destination he wants to go to. Then it prints out all the users including himself that are going to the same destination.</p>
        <p> Name: <asp:TextBox ID="TextBox26" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101"></asp:TextBox> <br /><br /> </p>
        <p> Destination: <asp:TextBox ID="TextBox27" runat="server" Height="30px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 550px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101"></asp:TextBox> <br /><br /> </p>

        
        <p> 
            <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="Submit" style = "LEFT: 500px; POSITION: absolute;"/>
        </p>
    </div>

    <div class="jumbotron">
        <p> Users Travelling To your destination: <asp:TextBox ID="TextBox28" runat="server" Height="50px" Width="500px" Wrap="True" TextMode="MultiLine" style = "LEFT: 750px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101"></asp:TextBox> <br /><br /> </p>
    
    <br /><br /><br /><br />
    
    </div>





    
    <div class="jumbotron">
<h3>Mukthadir H Choudhury&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Assignmnet 3 Part 2</h3>
        
            <h4>Description - Top 10 Words&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h4>
            <p>
                This WebService analyzes a given Web Page and returns the top ten most- frequently occured words in the web page. The words that are returned are arranged in the decreasing order of their appearing frequencies. In case two words appearing frequencies are exactly the same, then the word that appears first in the web page is placed higher.</p>
            <p>
                Method Name - Top10Words()&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Parameter type - String&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Return type - String[]</p>
        
       <br />   <br /> <br />

        <h4>Description - Top 10 Content Words&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  </h4>
            <p>
                This WebService analyzes a given Web Page and returns the top ten most- frequently occured Content words in the web page. This web service removes all the non-content words i.e the STOP words before counting the appearance of rest of the words. The words that are returned are arranged in the decreasing order of their appearing frequencies. In case two words appearing frequencies are exactly the same, then the word that appears first in the web page is placed higher.
            </p>
            <p />
                Method Name - Top10ContentWords()&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Parameter type - String&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Return type - String[]<p>

                </p>






            <p>
                Please enter the URL here:
                <asp:TextBox ID="TextBox29" runat="server" Height="30px" Width="424px"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="GetTop10Words" style ="LEFT: 350px; POSITION: absolute"/> 
                <asp:Button ID="Button6" runat="server" Text="GetTop10ContentWords" OnClick="Button6_Click" style ="LEFT: 800px; POSITION: absolute" /> <br /><br />
           

                 <asp:TextBox ID="TextBox30" runat="server" Height="150px" Width="300px" TextMode="MultiLine" style = "LEFT: 300px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="10"></asp:TextBox>
                
                <asp:TextBox ID="TextBox32" runat="server" Height="150px" Width="300px" TextMode="MultiLine" style = "LEFT: 770px; POSITION: absolute; OVERFLOW: hidden; Z-INDEX: 101" Rows ="10"></asp:TextBox>
               
             <br /><br /> <br /><br /> <br /><br /> <br /><br /> <br /><br />
            
            </p>
        
    </div>
</asp:Content>
