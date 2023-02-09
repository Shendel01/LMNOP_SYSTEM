    <%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Master.Master" AutoEventWireup="true" CodeBehind="Centro_servicio.aspx.cs" Inherits="LMNOP_System01.Pages.Centro_servicio" %>
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
  <label class="label">Número de piezas</label>
  <div class="control">
    <asp:TextBox runat="server" id="num_piezas" class="input" type="text" placeholder="Ingrese número de piezas"></asp:TextBox>
  </div>
</div>
                       <div class="field">
  <label class="label">Kilogramos</label>
  <div class="control">
    <asp:TextBox runat="server" id="kg" class="input" type="text" placeholder="Ingrese KG"></asp:TextBox>
  </div>
</div>
                       <div class="field">
  <label class="label">Número de tarimas</label>
  <div class="control">
    <asp:TextBox runat="server" id="num_tarimas" class="input" type="text" placeholder="Ingrese número de tarimas"></asp:TextBox>
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

<%--<div class="field">
  <label class="label">Username</label>
  <div class="control has-icons-left has-icons-right">
    <input class="input is-success" type="text" placeholder="Text input" value="bulma">
    <span class="icon is-small is-left">
      <i class="fas fa-user"></i>
    </span>
    <span class="icon is-small is-right">
      <i class="fas fa-check"></i>
    </span>
  </div>
  <p class="help is-success">This username is available</p>
</div>

<div class="field">
  <label class="label">Email</label>
  <div class="control has-icons-left has-icons-right">
    <input class="input is-danger" type="email" placeholder="Email input" value="hello@">
    <span class="icon is-small is-left">
      <i class="fas fa-envelope"></i>
    </span>
    <span class="icon is-small is-right">
      <i class="fas fa-exclamation-triangle"></i>
    </span>
  </div>
  <p class="help is-danger">This email is invalid</p>
</div>

<div class="field">
  <label class="label">Subject</label>
  <div class="control">
    <div class="select">
      <select>
        <option>Select dropdown</option>
        <option>With options</option>
      </select>
    </div>
  </div>
</div>

<div class="field">
  <label class="label">Message</label>
  <div class="control">
    <textarea class="textarea" placeholder="Textarea"></textarea>
  </div>
</div>

<div class="field">
  <div class="control">
    <label class="checkbox">
      <input type="checkbox">
      I agree to the <a href="#">terms and conditions</a>
    </label>
  </div>
</div>

<div class="field">
  <div class="control">
    <label class="radio">
      <input type="radio" name="question">
      Yes
    </label>
    <label class="radio">
      <input type="radio" name="question">
      No
    </label>
  </div>
</div>

<div class="field is-grouped">
  <div class="control">
    <button class="button is-link">Submit</button>
  </div>
  <div class="control">
    <button class="button is-link is-light">Cancel</button>
  </div>--%><%--</div>--%>

    </div>
            <div class="table-container bg-color">
                   <asp:GridView ID="grilla" runat="server" Height="249px" CssClass="table is-selected">
            </asp:GridView>
           
             </div>
    </div>

</asp:Content>
