<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master.Master" AutoEventWireup="true" CodeBehind="C_Detenida.aspx.cs" Inherits="LMNOP_System01.Pages.C_Detenida" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">

    <div class="container box">

              <div class="field">
  <label class="label">
            Defecto</label>

  <div class="control">
    <asp:TextBox runat="server" id="defecto" class="input" type="text" placeholder="Ingrese el defecto"></asp:TextBox>
  </div>
</div>

               <div class="field">
  <label class="label">
            Seguimiento</label>

  <div class="control">
    <asp:TextBox runat="server" id="seguimiento" class="input" type="text" placeholder="Ingrese el seguimiento"></asp:TextBox>
  </div>
</div>

               <div class="field">
  <label class="label">
            Comentario</label>

  <div class="control">
    <asp:TextBox runat="server" id="comentario" class="input" type="text" placeholder="Ingrese el comentario"></asp:TextBox>
  </div>
</div>

               <div class="field">
  <label class="label">
            Nombre de la persona que detiene</label>

  <div class="control">
    <asp:TextBox runat="server" id="nombre_detenido" class="input" type="text" placeholder="Ingrese su nombre"></asp:TextBox>
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
