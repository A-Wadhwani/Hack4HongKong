<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Hack4HongKong.Important_Methods.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
  
    <form id="form1" runat="server">
        <div>
            <video id="video" width="640" height="480"  autoplay></video>
            <button id="snap" type="button">Snap Photo</button>
            <canvas id="canvas" width="640" height="480"></canvas>
            <img id="myimage" src="../TestImages/Google.jpg" runat="server"/>
            <script>
                // Put event listeners into place
                window.addEventListener("DOMContentLoaded", function () {
                    // Grab elements, create settings, etc.
                    var canvas = document.getElementById('canvas');
                    var context = canvas.getContext('2d');
                    var video = document.getElementById('video');
                    var constraints = {
                        video: {
                            facingMode: "environment",
                        }
                    };
                    //var img = document.getElementById("myimage");
                    var mediaConfig = { video: true };
                    var errBack = function (e) {
                        console.log('An error has occurred!', e)
                    };
                    // Put video listeners into place
                    if (navigator.mediaDevices && navigator.mediaDevices.getUserMedia) {
                        navigator.mediaDevices.getUserMedia(mediaConfig).then(function (stream) {
                            //video.src = window.URL.createObjectURL(stream);
                            video.srcObject = stream;
                            video.play();
                        });
                    }
                    // Trigger photo take
                    document.getElementById('snap').addEventListener('click', function () {
                        context.drawImage(video, 0, 0, 640, 480);
                        
                        var a = document.createElement('a');
                        a.style.display = 'block';
                        document.body.appendChild(a);
                        a.download = 'img.jpg';
                        a.click();
                        var canvas1 = document.getElementById("mycanvas");
                        var img1 = canvas.toDataURL("image/png");

                    });
                }, false);
            </script>
        </div>
    </form>
</body> 
</html>
