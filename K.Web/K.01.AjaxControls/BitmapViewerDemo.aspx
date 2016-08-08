<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BitmapViewerDemo.aspx.cs" Inherits="AjaxControls.BitmapViewerDemo" %>

<%@ Register Assembly="Aurigma.GraphicsMill.AjaxControls" Namespace="Aurigma.GraphicsMill.AjaxControls" TagPrefix="aur" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BitmapViewer Demo</title>
    <script type="text/javascript" src="//code.jquery.com/jquery-2.1.1.min.js"></script>
    <script type="text/javascript">
        $(window).load(function () {
            var bitmapViewer = $find('<%= BitmapViewer1.ClientID %>');
            var navigator = $find('<%= PanNavigator1.ClientID %>');

            $('#selectZoom').change(function () {
                var select = $('#selectZoom').get(0);
                var value = select.options[select.selectedIndex].value;

                if (GraphicsMill.ZoomMode.hasOwnProperty(value)) {
                    var mode = GraphicsMill.ZoomMode[value];
                    bitmapViewer.set_zoomMode(mode);
                }
                else if (Number.isInteger(+value)) {
                    bitmapViewer.set_zoom(+value / 100);
                }

                if (bitmapViewer.get_contentWidth() <= bitmapViewer.get_width() && bitmapViewer.get_contentHeight() <= bitmapViewer.get_height())
                    bitmapViewer.set_navigator("");
                else
                    bitmapViewer.set_navigator(navigator.get_id());
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding-top: 10px">
            Zoom:
        <select id="selectZoom">
            <option value="bestFit">Best Fit</option>
            <option value="fitToWidth">Fit To Width</option>
            <option value="fitToHeight">Fit To Height</option>
            <option value="10">10%</option>
            <option value="25" selected>25%</option>
            <option value="50">50%</option>
            <option value="75">75%</option>
            <option value="100">100%</option>
            <option value="150">150%</option>
            <option value="200">200%</option>
            <option value="300">300%</option>
            <option value="400">400%</option>
        </select>
        </div>
        <div style="padding-top: 10px">
            <aur:BitmapViewer ID="BitmapViewer1" ScrollBarsStyle="Auto" ViewportAlignment="CenterCenter" Zoom="0.25" Width="600" Height="400" runat="server" />
            <aur:PanNavigator ID="PanNavigator1" runat="server"></aur:PanNavigator>
            <asp:ScriptManager ID="ScriptManager1" runat="server" />
        </div>
    </form>
</body>
</html>