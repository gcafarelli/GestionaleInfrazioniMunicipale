<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArchivioViolazioni.aspx.cs" Inherits="PoliziaMunicipale.ArchivioViolazioni" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../StyleSheet1.css" rel="stylesheet" />
    <script src="https://kit.fontawesome.com/e275ee0ca7.js" crossorigin="anonymous"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid bg-primary text-center p-2">
            <h1 class="text-light">Archivio Violazioni</h1>
             <hr style="color:white" />
        </div>

        <nav class="navbar navbar-expand-lg navbar-light bg-primary">
            <a class="text-light navbar-brand" href="ReportViolazioni.aspx">Polizia Stradale</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
                <div class="navbar-nav">
                    <a class="text-light nav-item nav-link active mx-3" href="ArchivioTrasgressori.aspx"><i class="far fa-caret-square-right"></i>Archivio Trasgressori </a>
                    <a class="text-light nav-item nav-link mx-3" href="CompilazioneViolazione.aspx"><i class="far fa-caret-square-right"></i>Compila Violazione</a>
                    <a class="text-light nav-item nav-link mx-3" href="ReportViolazioni.aspx"><i class="far fa-caret-square-right"></i>Report Violazione</a>
                    <asp:LinkButton CssClass="text-light logout log" ID="LinkButton1" runat="server" OnClick="LinkSignOut_Click"><i class="fas fa-sign-out-alt"></i>  Logout</asp:LinkButton>
                </div>
            </div>
        </nav>

        <div class="container text-center">
            <div class="central rounded m-5">
                <h3 class="text-light">Infrazione</h3>
                <asp:TextBox CssClass="btn btn-light btn-outline-primary m-3" Style="width: 400px;" ID="Descrizione" runat="server" placeholder="Descrizione Violazione"></asp:TextBox><br />
                <asp:Button CssClass="btn btn-primary m-3" ID="AggiungiViolazione" runat="server" Text="AggiungiViolazione" OnClick="AggiungiViolazione_Click" />
           
            <asp:GridView CssClass="table table-dark text-light opacity-75 text-center table-hover rounded" ID="GridView1" runat="server"></asp:GridView>
                 </div>
        </div>
        <footer class="container-fluid col-12 bg-primary text-center text-light mt-2 p-4">
            <h5>Per assistenza/info chiamare il numero verde 800.500.600 oppure scrivere all'indirizzo poliziastradale@comune.it</h5>
        </footer>
    </form>
</body>
</html>
