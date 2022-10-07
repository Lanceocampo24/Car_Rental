Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO

Public Class Camera
    Dim CAMERA As VideoCaptureDevice
    Dim bmp As Bitmap

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If cameras.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CAMERA = cameras.VideoDevice
            AddHandler CAMERA.NewFrame, New NewFrameEventHandler(AddressOf cap)
            CAMERA.Start()
        End If
    End Sub

    Private Sub cap(sender As Object, eventargs As NewFrameEventArgs)
        bmp = DirectCast(eventargs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(eventargs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox2.Image = PictureBox1.Image
        Rent.PicturePictureBox.Image = PictureBox2.Image
        CAMERA.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SaveFileDialog1.DefaultExt = ".Jpg"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox2.Image.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Jpeg)
            Me.Hide()
        End If
    End Sub
End Class
