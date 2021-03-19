<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="auth.aspx.cs" Inherits="HR_Agency.Pages.auth" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form_auth_block">
        <div class="form_auth_block_content">
            <p class="form_auth_block_head_text">Авторизация</p>
            <form class="form_auth_style" action="#" method="post">
                <label>Введите Ваш имейл</label><br />
                <input type="email" name="auth_email" placeholder="Введите Ваш имейл" required><br /><br />
                <label>Введите Ваш пароль</label><br />
                <input type="password" name="auth_pass" placeholder="Введите пароль" required><br /><br />
                <button class="form_auth_button" type="submit" name="form_auth_submit">Войти</button><br />
            </form>
        </div>
        <li><a runat="server" href="~/Pages/register">Регистрация</a></li>
    </div>

</asp:Content>
