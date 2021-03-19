<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="alert.aspx.cs" Inherits="HR_Agency.Pages.alert" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 <%
        Response.Write(String.Format(@"
                        <div class='item'>
                           <h4>Ошибка</h4>
    <p>{0}</p>
                        </div>",
                    Request.QueryString["msg"]));

    %>
</asp:Content>
