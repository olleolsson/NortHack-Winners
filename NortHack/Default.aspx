<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NortHack._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">

        <h1><%= Name %></h1>
        <p><%= Owner %></p>
        <br />
        <br />
        <br />
        <p><img src="<%=PictureUrl%>" alt="some_text" style="width:auto;height:auto;"> <asp:Button id="buttonNext" OnClick="GetIdea" runat="server" Text="Next"/></p>
        
        <br />
        <br />
        <h2 class="Icons"><span class="glyphicon glyphicon-thumbs-up"> <%= Likes %></span> 
        <span class="glyphicon glyphicon-bookmark"> <%=Followers %></span>
        <span class="glyphicon glyphicon-signal"> <%= Contributors %></span></h2>  

<%--        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Like &raquo;</a></p>--%>
        <h2>Pitch</h2>
            <p>
                <%= Description %>
            </p>

    </div>

    <footer><p>
        <asp:LinkButton ID="btnLike" 
            runat="server" 
            CssClass="btn btn-primary"    
            OnClick="Like">
        <span aria-hidden="true" class="glyphicon glyphicon-thumbs-up"> Like</span>
        </asp:LinkButton> 
        <asp:LinkButton ID="btnFollow" 
            runat="server" 
            CssClass="btn btn-primary"    
            OnClick="Follow">
        <span aria-hidden="true" class="glyphicon glyphicon-bookmark"> Follow</span>
        </asp:LinkButton> 
        <asp:LinkButton ID="btnContribute" 
            runat="server" 
            CssClass="btn btn-primary"    
            OnClick="Contribute">
        <span aria-hidden="true" class="glyphicon glyphicon-signal"> Team-up</span>
        </asp:LinkButton> 
        </p>
        </footer>
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
