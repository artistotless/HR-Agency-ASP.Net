<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="vacancies.aspx.cs" Inherits="HR_Agency.Pages.vacancies" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">

        <%

            foreach (HR_Agency.Models.Vacancy vc in GetVacancies())
            {

                Response.Write(String.Format(@"
                        <div style='border: 2px solid;
    padding-left: 15px; margin-bottom:10px;' class='item'>
                            <h3>{0}</h3>
                            {1}
                            <h4>{2}</h4>
                        </div>",
                    vc.title, vc.descr, vc.status));
            }
        %>
    </div>

</asp:Content>
