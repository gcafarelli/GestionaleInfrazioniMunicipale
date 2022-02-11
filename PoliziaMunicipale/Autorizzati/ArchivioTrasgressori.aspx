<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArchivioTrasgressori.aspx.cs" Inherits="PoliziaMunicipale.ArchivioTrasgressori" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link href="../StyleSheet1.css" rel="stylesheet" />
    <script src="https://kit.fontawesome.com/e275ee0ca7.js" crossorigin="anonymous"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid bg-primary text-center p-2">
            <h1 class="text-light">Archivio Trasgressori</h1>
             <hr style="color:white" />
        </div>

        <nav class="navbar navbar-expand-lg navbar-light bg-primary">
            <a class="text-light navbar-brand" href="ReportViolazioni.aspx">Polizia Stradale</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
                <div class="navbar-nav">
                    <a class="text-light nav-item nav-link active mx-3" href="CompilazioneViolazione.aspx"><i class="far fa-caret-square-right"></i>  Compila Violazione </a>
                    <a class="text-light nav-item nav-link mx-3" href="ArchivioViolazioni.aspx"><i class="far fa-caret-square-right"></i>  Archivio Violazioni</a>
                    <a class="text-light nav-item nav-link mx-3" href="ReportViolazioni.aspx"><i class="far fa-caret-square-right"></i>  Report Violazione</a>
                    <asp:LinkButton CssClass="text-light logout log" ID="LinkButton1" runat="server" OnClick="LinkSignOut_Click"><i class="fas fa-sign-out-alt"></i>  Logout</asp:LinkButton>
                </div>
            </div>
        </nav>
        
        <div class="container text-center">
            <div class="central rounded m-5" style="height:40%">
            <h3 class="text-light">Informazioni Generali</h3>
            <asp:TextBox CssClass="m-3 btn btn-light btn-outline-primary" ID="Cognome" runat="server" placeholder="Cognome"></asp:TextBox>
            <asp:TextBox CssClass="m-3 btn btn-light btn-outline-primary"  ID="Nome" runat="server" placeholder="Nome"></asp:TextBox>
            <asp:TextBox CssClass="m-3 btn btn-light btn-outline-primary" ID="Indirizzo" runat="server" placeholder="Indirizzo"></asp:TextBox><br />
            <asp:TextBox CssClass="m-3 btn btn-light btn-outline-primary" ID="Citta" runat="server" placeholder="Citta"></asp:TextBox>
            <asp:TextBox CssClass="m-3 btn btn-light btn-outline-primary" ID="CAP" runat="server" placeholder="CAP"></asp:TextBox>
            <asp:TextBox CssClass="m-3 btn btn-light btn-outline-primary" ID="CodiceFiscale" runat="server" placeholder="CodiceFiscale"></asp:TextBox><br />
            <asp:TextBox CssClass="m-3 btn btn-primary" ID="NomeTrasgressore" runat="server" placeHolder="Cerca Nome"></asp:TextBox>
            <asp:TextBox CssClass="m-3 btn btn-primary" ID="CognomeTrasgressore" runat="server" placeHolder="Cerca Cognome"></asp:TextBox>
            <asp:Button CssClass="m-3 btn btn-primary" style="width:200px" ID="CercaTrasgressorebtn" runat="server" Text="Cerca" OnClick="CercaTrasgressorebtn_Click"/>
            <asp:Button CssClass="m-3 btn btn-primary" ID="ConfermaTrasgressore" runat="server" Text="Nuovo Trasgressore" OnClick="ConfermaTrasgressore_Click" />
                <asp:GridView CssClass="table table-dark text-light opacity-75 text-center table-hover rounded" ID="GridView1" runat="server"></asp:GridView>
        </div>
        </div>
        <footer class="container-fluid col-12 bg-primary text-center text-light mt-2 p-4">
            <h5>Per assistenza/info chiamare il numero verde 800.500.600 oppure scrivere all'indirizzo poliziastradale@comune.it</h5>
        </footer>
    </form>
</body>
</html>
