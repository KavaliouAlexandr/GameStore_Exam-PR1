<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CartSummary.ascx.cs" 
   Inherits="GameStore.Controls.CartSummary" %>

<div id="cartSummary">
    <span class="caption">
        <b>W koszyku:</b>
        <span id="csQuantity" runat="server"></span> towary,
        <span id="csTotal" runat="server"></span>
    </span>
    <a id="csLink" runat="server">Koszyk</a>
</div>
