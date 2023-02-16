﻿    <%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master.Master" AutoEventWireup="true" CodeBehind="Centro_servicio.aspx.cs" Inherits="LMNOP_System01.Pages.Centro_servicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Centro de servicio
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">

    <div class="container box">

        <div class="field">
  <label class="label">
            Número de OF</label>

  <div class="control">
    <asp:TextBox runat="server" id="num_of" class="input" type="text" placeholder="Ingrese el número de OF"></asp:TextBox>
  </div>
</div>

               <div class="field">
  <label class="label">Código de primera</label>
  <div class="control">
    <asp:TextBox runat="server" id="codigo_primera" class="input" type="text" placeholder="Ingrese el código de primera"></asp:TextBox>
  </div>
</div>

               <div class="field">
  <label class="label">Descripción</label>
  <div class="control">
    <asp:TextBox runat="server" id="descripcion" class="input" type="text" placeholder="Ingrese descripción"></asp:TextBox>
  </div>
</div>

             
                       <div class="field">
  <label class="label">Operadores</label>
  <div class="control">
    <asp:TextBox runat="server" id="operadores" class="input" type="text" placeholder="Ingrese los Operadores"></asp:TextBox>
  </div>
</div>
                       <div class="field">
  <label class="label">Turno</label>
  <div class="control">
    <asp:TextBox runat="server" id="turno" class="input" type="text" placeholder="Ingrese el turno"></asp:TextBox>
  </div>
</div>
                       <div class="field">
  <label class="label">Pedacería</label>
  <div class="control">
    <asp:TextBox runat="server" id="pedaceria" class="input" type="text" placeholder="Ingrese la pedacería"></asp:TextBox>
  </div>
</div>
                       <div class="field">
  <label class="label">Faltante</label>
  <div class="control">
    <asp:TextBox runat="server" id="faltante" class="input" type="text" placeholder="Ingrese el faltante"></asp:TextBox>
  </div>
</div>
                       <div class="field">
  <label class="label">Sobrante</label>
  <div class="control">
    <asp:TextBox runat="server" id="sobrante" class="input" type="text" placeholder="Ingrese el sobrante"></asp:TextBox>
  </div>
</div>
                       <div class="field">
  <label class="label">Rechazo</label>
  <div class="control">
    <asp:TextBox runat="server" id="rechazo" class="input" type="text" placeholder="Ingrese el rechazo"></asp:TextBox>
  </div>
</div>
                       <div class="field">
  <label class="label">Observaciones</label>
  <div class="control">
    <asp:TextBox runat="server" id="observaciones" class="input" type="text" placeholder="Ingrese las Observaciones"></asp:TextBox>
  </div>
</div>
                       <div class="field">
  <label class="label">Total</label>
  <div class="control">
    <asp:TextBox runat="server" id="total" class="input" type="text" placeholder="Total"></asp:TextBox>
  </div>
</div>


         <div class="field is-grouped">
            <div class="control">
                <asp:Button runat="server" ID="Enviar" CssClass="button is-success is-outlined is-rounded is-medium is-res" OnClick="Enviar_Click" Text="Enviar"/>
            </div>



    </div>


            <div class="table-container bg-color">
                   <asp:GridView ID="grilla" runat="server" Height="249px" CssClass="table is-selected">
            </asp:GridView>
           
             </div>
    </div>

</asp:Content>
