﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master.Master" AutoEventWireup="true" CodeBehind="Atencion_sucursales.aspx.cs" Inherits="LMNOP_System01.Pages.Atencion_sucursales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">

    <div class="container box">

         <div class="field">
  <label class="label">
            Número de maquila</label>

  <div class="control">
    <asp:TextBox runat="server" id="num_maquila" class="input" type="text" placeholder="aaaaa"></asp:TextBox>
  </div>
</div>

             <div class="field">
  <label class="label">
            Documento</label>

  <div class="control">
    <asp:TextBox runat="server" id="documento" class="input" type="text" placeholder="aaaaa"></asp:TextBox>
  </div>
</div>

             <div class="field">
  <label class="label">
            División</label>

  <div class="control">
    <asp:TextBox runat="server" id="division" class="input" type="text" placeholder="aaaaa"></asp:TextBox>
  </div>
</div>

        <div class="field is-grouped">
            <div class="control">
                <asp:Button runat="server" ID="Enviar" CssClass="button is-success is-outlined is-rounded is-medium is-res" OnClick="Enviar_Click" Text="Enviar"/>
            </div>
        </div>


         <div class="table-container">
                   <asp:GridView ID="gridview" runat="server" Height="249px" CssClass="table is-selected">
            </asp:GridView>
           
             </div>


    </div>
</asp:Content>
