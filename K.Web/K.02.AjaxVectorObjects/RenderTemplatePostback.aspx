<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RenderTemplatePostback.aspx.cs" Inherits="AjaxVectorObjects.RenderTemplatePostback" %>

<%@ Register Assembly="Aurigma.GraphicsMill.AjaxControls.VectorObjects" Namespace="Aurigma.GraphicsMill.AjaxControls" TagPrefix="aur" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.1/css/bootstrap.min.css" />
    <script type="text/javascript" src="//code.jquery.com/jquery-2.1.1.min.js"></script>
    <script type="text/javascript" src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.1/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" OnClick="Button1_Click" Text="Render" runat="server"/>
            <asp:HyperLink ID="Link1" runat="server" Visible="false" EnableViewState="false" />
            <aur:CanvasViewer ID="CanvasViewer1" ScrollBarsStyle="Auto" ViewportAlignment="CenterCenter" Width="600" Height="400" runat="server" />
            <asp:ScriptManager ID="ScriptManager1" runat="server" />
        </div>
    </form>
</body>
</html>
