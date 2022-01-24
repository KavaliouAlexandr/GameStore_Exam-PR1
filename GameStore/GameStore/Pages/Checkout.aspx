<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="GameStore.Pages.Checkout" 
 MasterPageFile="~/Pages/Store.Master" %>


<asp:Content ID="Content1" ContentPlaceHolderID="bodyContent" runat="server">
    <div id="content">

        <div id="checkoutForm" class="checkout" runat="server">
            <h2>Złożyć zamówienie</h2>
            Podaj swoje dane, a my wyślemy twoje zamówinie już teraz!

        <div id="errors" data-valmsg-summary="true">
            <ul>
                <li style="display:none"></li>
            </ul>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        </div>

            <h3>Klient</h3>
            <div>
                <label for="name">Imie:</label>
                <SX:VInput Property="Name" runat="server" />
            </div>

            <h3>Adres</h3>
            <div>
                <label for="line1">Adres 1:</label>
                <SX:VInput Property="Line1" runat="server" />
            </div>
            <div>
                <label for="line2">Adres 2:</label>
                <SX:VInput Property="Line2" runat="server" />
            </div>
            <div>
                <label for="line3">Adres 3:</label>
                <SX:VInput Property="Line3" runat="server" />
            </div>
            <div>
                <label for="city">Miasto:</label>
                <SX:VInput Property="City" runat="server" />
            </div>

            <h3>Szczegóły zamówienia</h3>
            <input type="checkbox" id="giftwrap" name="giftwrap" value="true" />
           Skorzystać z szybkiej dostawy (+5,99 zł)?
        
        <p class="actionButtons">
            <button class="actionButtons" type="submit">Zamówić</button>
        </p>
        </div>
        <div id="checkoutMessage" runat="server">
            <h2>Dziękijemy!</h2>
            Dziękujemy za wybranie naszego sklepu! Postaramy się jak najszybciej wysłać Twoje zamówienie.
        </div>
    </div>
</asp:Content>