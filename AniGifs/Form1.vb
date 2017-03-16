Imports System.IO 

Public Class Form1 
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Gif
        Try
            Gif = Image.FromFile(My.Application.CommandLineArgs(0))
        Catch
            Gif = My.Resources.GifNotFound
        End Try
        Me.Size = New Size(534 - (534 - Gif.Width) + 16, 512 - (512 - Gif.Height) + 32)
        PictureBox1.Image = Gif
    End Sub
End Class
