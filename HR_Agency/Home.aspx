<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="HR_Agency._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">

         <%
        
             
                foreach (HR_Agency.Models.Client client in GetClients())
                {
        
                    Response.Write(String.Format(@"
                        <div style='border: 2px solid;
    padding-left: 15px; margin-bottom:10px;' class='item'>
                            <h3>{0}</h3>
                            {1}
                            <h4>{2:c}</h4>
                        </div>", 
                        client.companyName, client.descr, client.fioAgent));
                }
         %>

           </div>


</asp:Content>
