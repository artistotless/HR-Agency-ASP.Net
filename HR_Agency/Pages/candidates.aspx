<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="candidates.aspx.cs" Inherits="HR_Agency.Pages.candidates" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

       <div class="jumbotron">
             <%
        
             
                foreach (HR_Agency.Models.Candidate cd in GetCandidates())
                {
        
                    Response.Write(String.Format(@"
                        <div style='border: 2px solid;
    padding-left: 15px; margin-bottom:10px;' class='item'>
                            <h3>{0}</h3>
                            <p>{1}</p>
                            <p>{2}</p>
                            <p>{3}</p>

                        </div>", 
                        cd.fio, cd.descr, cd.phone,cd.portfolio));
                }
         %>
     
    </div>

</asp:Content>
