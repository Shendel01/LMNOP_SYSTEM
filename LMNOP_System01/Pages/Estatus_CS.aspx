﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master.Master" AutoEventWireup="true" CodeBehind="Estatus_CS.aspx.cs" Inherits="LMNOP_System01.Pages.Estatus_CS" %>
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
    <asp:TextBox runat="server" id="maquila" class="input" type="text" placeholder="Ingrese el número de maquila"></asp:TextBox>
  </div>
        </div>


          <div class="field">
             <label class="label">
            Estatus de maquila</label>
  <div class="control">
    <asp:TextBox runat="server" id="estatus" class="input" type="text" placeholder="Ingrese el estatus de la maquila"></asp:TextBox>
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

         <div>
                 <div>
             <asp:Button runat="server" ID="tarimas" CssClass="button is-info is-rounded is-medium is-res" OnClick="tarimas_Click" Text="Tarimas"/>
             <asp:Button runat="server" ID="segundas" CssClass="button is-info is-rounded is-medium is-res" OnClick="segundas_Click" Text="Segundas"/>
                     <asp:Button runat="server" ID="ofe" CssClass="button is-info is-rounded is-medium is-res" OnClick="ofe_Click" Text="Llenado de OFE"/>
             <asp:Button runat="server" ID="back" CssClass="button is-danger is-outlined is-rounded is-medium is-res" OnClick="back_Click" Text="Regresar"/> <%--Index--%>
                     </div>
            </div>
    </div>
</asp:Content>
