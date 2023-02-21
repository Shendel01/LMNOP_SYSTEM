<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="prueba.aspx.cs" Inherits="LMNOP_System01.Pages.prueba" %>


<!DOCTYPE html>

<html>
<head runat="server">
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.3.min.js" integrity="sha256-pvPw+upLPUjgMXY0G+8O0xUf+/Im1MZjXxxgOcBQBXU=" crossorigin="anonymous"></script>

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>

    </title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bulma@0.9.4/css/bulma.min.css">
    <link href="../Css/Css_general.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <nav class="navbar" role="navigation" aria-label="main navigation">
  <div class="navbar-brand">
    <a class="navbar-item" href="https://bulma.io">
        
      <img src="../Images/lmnop_logo.png" width="100" height="150">
    </a>

    <a role="button" class="navbar-burger" aria-label="menu" aria-expanded="false" data-target="navbarBasicExample">
      <span aria-hidden="true"></span>
      <span aria-hidden="true"></span>
      <span aria-hidden="true"></span>
    </a>
  </div>

  <div id="navbarBasicExample" class="navbar-menu">
    <div class="navbar-start">
      <a class="navbar-item">
        Home
      </a>

      <a class="navbar-item">
        NO SÉ 
      </a>

      <div class="navbar-item has-dropdown is-hoverable">
        <a class="navbar-link">
          NO SÉ x2
        </a>

        <div class="navbar-dropdown">
          <a class="navbar-item">
            Sub clas
          </a>
          <a class="navbar-item">
            sub clas x2
          </a>
          <a class="navbar-item">
            sub clas x3
          </a>
          <hr class="navbar-divider">
          <a class="navbar-item">
            sub clas x4
          </a>
        </div>
      </div>
    </div>

  </div>
</nav>
        </header>


             <div class="container box">

                 <div class="field">
  <label class="label">
            Número de maquila</label>

  <div class="form">
    <asp:TextBox runat="server" id="num_maquila" class="input" type="text" placeholder="Ingrese el número de la maquila"></asp:TextBox>
  </div>
</div>
       </div>                                    


    </form>






    <footer class="footer">
  <div class="content has-text-centered">
    <p>

      <strong>LMNOP</strong> by <a href="Centro_servicio.aspx">Centro_servicio.aspx</a>
    </p>
  </div>
</footer>
</body>
</html>
