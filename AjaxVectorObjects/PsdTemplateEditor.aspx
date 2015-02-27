<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PsdTemplateEditor.aspx.cs" Inherits="AjaxVectorObjects.PsdTemplateEditor" %>

<%@ Register Assembly="Aurigma.GraphicsMill.AjaxControls.VectorObjects" Namespace="Aurigma.GraphicsMill.AjaxControls" TagPrefix="aur" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PSD Template Editor</title>
    <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.1/css/bootstrap.min.css" />
    <script type="text/javascript" src="//code.jquery.com/jquery-2.1.1.min.js"></script>
    <script type="text/javascript" src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.1/js/bootstrap.min.js"></script>

    <style type="text/css">
        #textarea {
            resize: none;
            position: absolute;
            z-index: 999;
        }
    </style>

    <script type="text/javascript">
        $(window).load(function () {
            var avo = Aurigma.GraphicsMill.AjaxControls.VectorObjects
            var canvas =  $find('<%= CanvasViewer1.ClientID %>').get_canvas();

            var textarea = $('#textarea');

            canvas.add_currentVObjectChanged(function () {
                var vObject = canvas.get_currentVObject();

                if (vObject != null && avo.BaseTextVObject.isInstanceOfType(vObject)) {
                    textarea.val(vObject.get_text());

                    var bounds = vObject.get_bounds();
                    var x = bounds.Left;
                    var y = bounds.Top + bounds.Height;
                    var point = canvas.workspaceToControl(new avo.Math.PointF(x, y));

                    var offset = $(canvas.get_bottomCanvas()).offset();

                    textarea.show();
                    textarea.offset({ left: offset.left + point.X, top: offset.top + point.Y + 5 });
                }
                else {
                    textarea.hide();
                }
            });

            textarea.click(function (e) {
                e.stopPropagation();
            });

            textarea.keydown(function (e) {
                e.stopPropagation();
            });

            textarea.keyup(function (e) {
                var vObject = canvas.get_currentVObject();

                if (vObject != null && avo.BaseTextVObject.isInstanceOfType(vObject))
                    vObject.set_text(textarea.val());

                e.stopPropagation();
            });
        });
	</script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <aur:CanvasViewer ID="CanvasViewer1" ScrollBarsStyle="Auto" ViewportAlignment="CenterCenter" Width="600" Height="400" runat="server" />
            <asp:ScriptManager ID="ScriptManager1" runat="server" />
        </div>
    </form>
    <textarea id="textarea" rows="2" style="display: none;"></textarea>
</body>
</html>
