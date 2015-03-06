<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadImageAjax.aspx.cs" Inherits="AjaxVectorObjects.UploadImageAjax" %>

<%@ Register Assembly="Aurigma.GraphicsMill.AjaxControls.VectorObjects" Namespace="Aurigma.GraphicsMill.AjaxControls" TagPrefix="aur" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Upload Image (AJAX)</title>
    <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.1/css/bootstrap.min.css" />
    <script type="text/javascript" src="//code.jquery.com/jquery-2.1.1.min.js"></script>
    <script type="text/javascript" src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.1/js/bootstrap.min.js"></script>

    <script type="text/javascript">
        $(window).load(function () {
            var avo = Aurigma.GraphicsMill.AjaxControls.VectorObjects
            var viewer = $find('<%= CanvasViewer1.ClientID %>');
            var canvas = viewer.get_canvas();

            var imageInput = $('#image');
            var uploadButton = $('#upload');

            imageInput.click(function () {
                this.val = null;
                uploadButton.attr('disabled', 'disabled');
            });

            imageInput.change(function () {
                uploadButton.removeAttr('disabled');
            });

            uploadButton.click(function () {
                var data = new FormData();
                var files = imageInput.get(0).files;

                if (files.length > 0) {
                    uploadButton.val("Uploading...");
                    uploadButton.attr('disabled', 'disabled');
                    
                    data.append('image', files[0]);

                    var onDone = function () {
                        uploadButton.val("Upload");
                        imageInput.val(null);
                    };

                    $.ajax({
                        type: 'post',
                        url: 'api/sample/uploadimage',
                        contentType: false,
                        processData: false,
                        data: data
                    }).done(function (id) {
                        var imageRectangle = new avo.Math.RectangleF(
                            canvas.get_workspaceWidth() * 0.5,
                            canvas.get_workspaceHeight() * 0.25,
                            canvas.get_workspaceWidth() * 0.5,
                            canvas.get_workspaceHeight() * 0.5
                        );

                        var image = new avo.ImageVObject(null, imageRectangle, { preserveAspectRatio: true });
                        image.set_sourceFileId(id);

                        canvas.get_layers().get_item(0).get_vObjects().add(image);

                        onDone();
                    }).fail(function (message) {
                        console.error(message);
                        onDone();
                    });
                }
                else
                    alert("No file selected");
            });
        });
    </script>
</head>
<body>
    <div class="form-group">
       <label for="image">Select image: </label><input id="image" type="file" accept="image/*" />
       <input id="upload" type="button" value="Upload" class="btn btn-default" disabled="disabled" />
    </div>

    <form id="form1" runat="server">
        <div>
            <aur:CanvasViewer ID="CanvasViewer1" ScrollBarsStyle="Auto" ViewportAlignment="CenterCenter" Width="600" Height="400" runat="server" />
            <asp:ScriptManager ID="ScriptManager1" runat="server" />
        </div>
    </form>
</body>
</html>
