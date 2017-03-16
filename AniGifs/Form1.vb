Imports System.IO 
Public Class Form1 
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Gif
        Try
            Gif = Image.FromFile(My.Application.CommandLineArgs(0))
        Catch
            Gif = My.Resources.GifNotFound
        End Try
        Dim h As Integer = Gif.Height
        Dim w As Integer = Gif.Width
        If h < 534 And w < 512 Then
            Me.Size = New Size(534 - (534 - w) + 16, 512 - (512 - h) + 32)
        Else
            Me.Size = New Size(534 - (534 - w) + 16, 512 - (512 - h) + 32)
        End If

        PictureBox1.Image = Gif
    End Sub
End Class
