<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GameStore.Pages.Admin.Login" %>




<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="SingleParagraph" CssClass="error" />

    <div class="loginContainer">
        <div>
            <label for="name">Imie:</label>
            <input name="name" />
        </div>
        <div>
            <label for="password">Hasło:</label>
            <input type="password" name="password" />
        </div>
        <button type="submit">Wejście</button>
    </div>
</asp:Content>