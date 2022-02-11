<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportViolazioni.aspx.cs" Inherits="PoliziaMunicipale.ReportViolazioni" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../StyleSheet1.css" rel="stylesheet" />
    <script src="https://kit.fontawesome.com/e275ee0ca7.js" crossorigin="anonymous"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid bg-primary text-center p-2">
            <h1 class="text-light">Report Violazioni</h1>
            <hr style="color: white" />
        </div>
        <nav class="navbar navbar-expand-lg navbar-light bg-primary">
            <a class="text-light navbar-brand" href="ReportViolazioni.aspx">Polizia Stradale</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
                <div class="navbar-nav">
                    <a class="text-light nav-item nav-link active mx-3" href="ArchivioTrasgressori.aspx"><i class="far fa-caret-square-right"></i>Archivio Trasgressori </a>
                    <a class="text-light nav-item nav-link mx-3" href="ArchivioViolazioni.aspx"><i class="far fa-caret-square-right"></i>Archivio Violazioni</a>
                    <a class="text-light nav-item nav-link mx-3" href="CompilazioneViolazione.aspx"><i class="far fa-caret-square-right"></i>Compila Violazione</a>
                    <asp:LinkButton CssClass="text-light logout log" ID="LinkButton1" runat="server" OnClick="LinkSignOut_Click"><i class="fas fa-sign-out-alt"></i>  Logout</asp:LinkButton>
                </div>
            </div>
        </nav>
        <div class="container">
            <div class="central rounded m-5" style="height: 40%">
                <asp:DropDownList ID="ScegliSelect" CssClass="btn btn-primary btn-outline-light dropdown-toggle m-5" runat="server" OnSelectedIndexChanged="ScegliSelect_SelectedIndexChanged" AutoPostBack="true">
                    <asp:ListItem Value="0" Text="Criterio Ricerca"></asp:ListItem>
                    <asp:ListItem Value="1" Text="Conteggio Totale Multe"></asp:ListItem>
                    <asp:ListItem Value="2" Text="Tot Multe per Trasgressore"></asp:ListItem>
                    <asp:ListItem Value="3" Text="Punti Decurtati per Trasgressore"></asp:ListItem>
                    <asp:ListItem Value="4" Text="Multe Trasgressore per Citta"></asp:ListItem>
                    <asp:ListItem Value="5" Text="Multe > 5 pti Decurtati"></asp:ListItem>
                    <asp:ListItem Value="6" Text="Multe > 400€"></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox CssClass="btn btn-primary btn-outline-light m-5 btn-outline-light" ID="Citta" runat="server" placeholder="Città"></asp:TextBox>
                <asp:Button CssClass="btn btn-primary btn-outline-light m-5" ID="Cittabtn" runat="server" Text="Conferma Città" OnClick="Button1_Click" />
                <asp:GridView ID="GridView1" CssClass="table table-dark text-dark text-center table-hover rounded" runat="server">
                    <Columns>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
        <footer class="container-fluid col-12 bg-primary text-center text-light mt-2 p-4">
            <h5>Per assistenza/info chiamare il numero verde 800.500.600 oppure scrivere all'indirizzo poliziastradale@comune.it</h5>
        </footer>
    </form>
</body>
</html>
