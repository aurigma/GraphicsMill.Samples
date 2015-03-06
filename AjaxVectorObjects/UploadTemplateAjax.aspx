<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadTemplateAjax.aspx.cs" Inherits="AjaxVectorObjects.UploadTemplateAjax" %>

<%@ Register Assembly="Aurigma.GraphicsMill.AjaxControls.VectorObjects" Namespace="Aurigma.GraphicsMill.AjaxControls" TagPrefix="aur" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Upload Template (AJAX)</title>
    <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.1/css/bootstrap.min.css" />
    <script type="text/javascript" src="//code.jquery.com/jquery-2.1.1.min.js"></script>
    <script type="text/javascript" src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.1/js/bootstrap.min.js"></script>

    <script type="text/javascript">
        $(window).load(function () {
            var avo = Aurigma.GraphicsMill.AjaxControls.VectorObjects
            var viewer = $find('<%= CanvasViewer1.ClientID %>');
            var canvas = viewer.get_canvas();

            var templateInput = $('#template');
            var uploadButton = $('#upload');

            templateInput.click(function () {
                this.val = null;
                uploadButton.attr('disabled', 'disabled');
            });

            templateInput.change(function () {
                uploadButton.removeAttr('disabled');
            });

            uploadButton.click(function () {
                var data = new FormData();
                var files = templateInput.get(0).files;

                if (files.length > 0) {
                    uploadButton.val("Uploading...");
                    uploadButton.attr('disabled', 'disabled');
                    
                    data.append('template', files[0]);
                    data.append('canvas', canvas.get_data());

                    var onDone = function () {
                        uploadButton.val("Upload");
                        templateInput.val(null);
                    };

                    $.ajax({
                        type: 'post',
                        url: 'api/sample/uploadtemplate',
                        contentType: false,
                        processData: false,
                        data: data
                    }).done(function (data) {
                        canvas.set_data(data);
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
       <label for="template">Select template: </label><input id="template" type="file" accept=".psd" />
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
