<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NortHack._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">

        <h1>Douchbag recognizer</h1>
        <p>Victor Hugo</p>
        <br />
        <br />
        <br />
        <p>Picture here</p>
        <br />
        <br />
        <br />
        <h2 class="Icons"><span class="glyphicon glyphicon-thumbs-up"> 20</span> 
        <span class="glyphicon glyphicon-bookmark"> 10</span>
        <span class="glyphicon glyphicon-signal"> 2</span></h2>  

<%--        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Like &raquo;</a></p>--%>
        <h2>Pitch</h2>
            <p>
                This is where the pitch is gonna be displayd
            </p>

    </div>

    <footer><p><span class="glyphicon glyphicon-thumbs-up btn btn-primary"><br /> Like</span> 
        <span class="glyphicon glyphicon-bookmark btn btn-primary"><br /> Follow</span>
        <span class="glyphicon glyphicon-signal btn btn-primary"><br /> Team-up</span></p>  </footer>
<style>
p{
    font-size:7px;
    font-family: 'Times New Roman', Times, serif;
    margin-left: auto;
    margin-right:auto;
}
h1{
    font-size:20px;
}
h2{
    font-size:12px;
}
#footer {
   position:fixed;
   left:0px;
   bottom:0px;
   height:30px;
   width:100%;
   background:#999;
   margin-left:auto;
   margin-right:auto;
}
body{
    margin-bottom:50px;
}
div{
    text-align:center;
}
h2.Icons{
    background-color: darkgray;
    width:100%;
}

</style>


</asp:Content>
