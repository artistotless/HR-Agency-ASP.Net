<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="HR_Agency.Pages.register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form_auth_block">
        <div class="form_auth_block_content">
            <p class="form_auth_block_head_text">Регистрация</p>
            

                <label>Введите Ваше ФИО</label><br />
                <input type="text" name="fio" placeholder="ФИО" required><br />
                <label>Введите Ваш логин</label><br />
                <input type="text" name="login" placeholder="Логин" required><br />
                <label>Введите Ваш пароль</label><br />
                <input type="password" name="pass" placeholder="Введите пароль" required><br />
                <label>Введите Ваш номер телефона</label><br />
                <input type="text" name="phone" placeholder="+7 ..." required><br />
                <label>Расскажите о себе</label><br />
                <textarea rows="5" cols="45" name="descr" required></textarea><br />

                <asp:Label ID="Label1"  runat="server" Text="Введите название компании (только для компаний)"></asp:Label><br />
                <asp:TextBox ID="CName"  runat="server"></asp:TextBox><br />

                <asp:Label ID="Label2" runat="server" Text="Укажите ссылку на портфолио"></asp:Label><br />
                <asp:TextBox ID="Portfolio"  runat="server"></asp:TextBox><br />


                <asp:Button ID="Button1" runat="server" Text="Зарегистрироваться" />

        
        </div>

        <li><a runat="server" href="~/Pages/auth">Авторизация</a></li>
    </div>


</asp:Content>
