<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PhotoCropDemo.aspx.cs" Inherits="AjaxControls.PhotoCropDemo" %>
<%@ Register Assembly="Aurigma.GraphicsMill.AjaxControls" Namespace="Aurigma.GraphicsMill.AjaxControls" TagPrefix="aur" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Photo Crop Demo</title>
    <script type="text/javascript" src="//code.jquery.com/jquery-2.1.1.min.js"></script>

    <script type="text/javascript">
        $(window).load(function () {
            var bitmapViewer = $find('<%= BitmapViewer1.ClientID %>');
            var rubberband = $find('<%= RectangleRubberband1.ClientID %>');

            var updateRubbeband = function(orientationChanged) {
                var rectangle = rubberband.get_rectangle();

                var imageWidth = bitmapViewer.get_bitmap().get_width();
                var imageHeight = bitmapViewer.get_bitmap().get_height();

                if (rectangle.width === -1 && rectangle.height === -1) {
                    rectangle.width = imageWidth;
                    rectangle.height = imageHeight;
                }

                if (orientationChanged) {
                    var tmp = rectangle.width;
                    rectangle.width = rectangle.height;
                    rectangle.height = tmp;
                }

                var select = $('#selectFormat').get(0);
                var format = select.options[select.selectedIndex].value.split(",");
                var isLandscape = !$('#portraitRadio').get(0).checked;

                var ratio = isLandscape ? format[1] / format[0] : format[0] / format[1];
                rubberband.set_ratio(ratio);

                if (ratio < 1)
                    rectangle.height = Math.floor(rectangle.width * ratio);
                else
                    rectangle.width = Math.floor(rectangle.height / ratio);

                if (rectangle.y + rectangle.height > imageHeight) {
                    rectangle.height = imageHeight - rectangle.y;
                    rectangle.width = Math.floor(rectangle.height / ratio);
                }

                if (rectangle.x + rectangle.width > imageWidth) {
                    rectangle.width = imageWidth - rectangle.x;
                    rectangle.height = Math.floor(rectangle.width * ratio);
                }

                rectangle.x = (imageWidth - rectangle.width) / 2;
                rectangle.y = (imageHeight - rectangle.height) / 2;

                rubberband.set_rectangle(rectangle);
            };

            $('#selectFormat').change(function() { updateRubbeband(false); });
            $(":radio").change(function() { updateRubbeband(true); });

            updateRubbeband(false);
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <select id="selectFormat">
		    <option value="6,4" selected>4 x 6"</option>
		    <option value="7,5">5 x 7"</option>
		    <option value="10,8">8 x 10"</option>
        </select>
     </div>
     <div>
        <label for="portraitRadio"><input id="portraitRadio" type="radio" name="Orientation">&nbsp;Portrait</label>
	    <br />
		<label for="landscapeRadio"><input id="landscapeRadio" type="radio" name="Orientation" checked>&nbsp;Landscape</label>
	</div>
    <div>
        <asp:Button ID="Button1" OnClick="Button1_Click" Text="Crop" runat="server"/>
     </div>
     <div>
        <aur:BitmapViewer ID="BitmapViewer1" ScrollBarsStyle="Auto" ViewportAlignment="CenterCenter" ZoomMode="BestFit" Width="600" Height="400" Rubberband="RectangleRubberband1" runat="server" />
        <aur:RectangleRubberband ID="RectangleRubberband1" ResizeMode="Proportional" GripsVisible="True" MaskVisible="True" runat="server"></aur:RectangleRubberband>
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
     </div>
     
    </form>
</body>
</html>
