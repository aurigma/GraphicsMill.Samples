<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VectorObjectsEditor.aspx.cs" Inherits="AjaxVectorObjects.VectorObjectsEditor" %>

<%@ Register Assembly="Aurigma.GraphicsMill.AjaxControls.VectorObjects" Namespace="Aurigma.GraphicsMill.AjaxControls" TagPrefix="aur" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Vector Objects Editor</title>
    <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.1/css/bootstrap.min.css" />
    <script type="text/javascript" src="//code.jquery.com/jquery-2.1.1.min.js"></script>
    <script type="text/javascript" src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.1/js/bootstrap.min.js"></script>

    <script type="text/javascript">
        $(window).load(function () {
            var avo = Aurigma.GraphicsMill.AjaxControls.VectorObjects
            var canvas = $find('<%= CanvasViewer1.ClientID %>').get_canvas();

            canvas.set_workspaceWidth(800);
            canvas.set_workspaceHeight(600);

            var layer = new avo.Layer();
            canvas.get_layers().add(layer);

            $('#add_rectangle').click(function () {
                var rectangle = new avo.RectangleVObject(30, 20, 150, 100);
                rectangle.set_fillColor('white');
                rectangle.set_borderColor('#0169c9');
                rectangle.set_borderWidth(4);

                layer.get_vObjects().add(rectangle);
            });

            $('#add_ellipse').click(function () {
                var ellipse = new avo.EllipseVObject(240, 20, 150, 100);
                ellipse.set_fillColor('#ccff99');
                ellipse.set_borderColor('#015a01');

                layer.get_vObjects().add(ellipse);
            });

            $('#add_image').click(function () {
                var url = window.location.href.replace(window.location.href.split('/').slice(-1)[0], 'image.jpg')
                var image = new avo.ImageVObject(url, new avo.Math.RectangleF(240, 170, 150, 100), { downloadToCache: true });

                layer.get_vObjects().add(image);
            });

            $('#add_text').click(function () {
                var text = new avo.PlainTextVObject('Hello World', new avo.Math.PointF(40, 200), avo.TextAlignment.Left, 'Tahoma', 26);

                layer.get_vObjects().add(text);
            });

            canvas.add_currentVObjectChanged(function () {
                if (canvas.get_currentVObject() == null)
                    $('#delete').hide();
                else
                    $('#delete').show();
            });

            $('#delete').click(function () {
                canvas.deleteSelectedVObjects(true);
            });
        });
	</script>
</head>
<body>
    <div class="btn-toolbar">
        <div class="btn-group">
            <input class="btn btn-default" type="button" id="add_rectangle" value="Rectangle" />
            <input class="btn btn-default" type="button" id="add_ellipse" value="Ellipse" />
            <input class="btn btn-default" type="button" id="add_text" value="Text" />
            <input class="btn btn-default" type="button" id="add_image" value="Image" />
        </div>
        <div class="btn-group">
            <input class="btn btn-danger right" type="button" id="delete" value="Delete" style="display: none;" />
        </div>
    </div>

    <form id="form1" runat="server">
        <div>
            <aur:CanvasViewer ID="CanvasViewer1" ScrollBarsStyle="Auto" Width="600" Height="400" runat="server" />
            <asp:ScriptManager ID="ScriptManager1" runat="server" />
        </div>
    </form>
</body>
</html>
