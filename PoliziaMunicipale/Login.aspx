<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PoliziaMunicipale.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../StyleSheet1.css" rel="stylesheet" />
    <script src="https://kit.fontawesome.com/e275ee0ca7.js" crossorigin="anonymous"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid bg-primary text-center p-2">
            <h1 class="text-light">Login</h1>
             <hr style="color:white" />
        </div>

        <nav class="navbar navbar-expand-lg navbar-light bg-primary">
            <a class="text-light navbar-brand mx-3" href="ReportViolazioni.aspx">Polizia Stradale</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
                <div class="navbar-nav">
                    <a class="text-light nav-item nav-link active mx-3" href="Login.aspx"><i class="far fa-caret-square-right"></i>  Archivio Trasgressori </a>
                    <a class="text-light nav-item nav-link mx-3" href="Login.aspx"><i class="far fa-caret-square-right"></i>  Archivio Violazioni</a>
                    <a class="text-light nav-item nav-link mx-3" href="Login.aspx"><i class="far fa-caret-square-right"></i>  Report Violazione</a>
                </div>
            </div>
        </nav>
        
        <div class="container text-center">
            <div class="central rounded m-5 p-5" style="height:40%; width:50%; float:right">
                <div>
                    <h3 class="text-light" >Credenziali Accesso</h3>
                    <asp:TextBox CssClass="mt-3 btn btn-light btn-outline-primary" ID="TextUser" runat="server" placeholder="Username" ></asp:TextBox><br />
                    <asp:TextBox CssClass="mt-3 btn btn-light btn-outline-primary" ID="TextPass" runat="server" placeholder="Password"></asp:TextBox><br />
                    <asp:Button CssClass="btn btn-primary mt-3" ID="Loginbtn" runat="server" Text="Login" OnClick="Loginbtn_Click" /><br />
                    <asp:Label ID="LabelNonAutorizzato" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
        <footer class="container-fluid col-12 bg-primary text-center text-light mt-2 p-4">
            <h5>Per assistenza/info chiamare il numero verde 800.500.600 oppure scrivere all'indirizzo poliziastradale@comune.it</h5>
        </footer>
    </form>
</body>
</html>
