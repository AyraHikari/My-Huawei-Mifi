Public Class FloatingInfo
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub FloatingInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub TitleDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, NetType.MouseDown, PictureBox5.MouseDown, PictureBox4.MouseDown, PictureBox3.MouseDown, SignalImg.MouseDown, DownloadText.MouseDown, UploadText.MouseDown, BatteryLabel.MouseDown, UsersLabel.MouseDown, ProviderLabel.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub TitleMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, NetType.MouseMove, PictureBox5.MouseMove, PictureBox4.MouseMove, PictureBox3.MouseMove, ProviderLabel.MouseMove, SignalImg.MouseMove, UploadText.MouseMove, DownloadText.MouseMove, BatteryLabel.MouseMove, UsersLabel.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub TitleUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp, NetType.MouseUp, PictureBox5.MouseUp, PictureBox4.MouseUp, PictureBox3.MouseUp, ProviderLabel.MouseUp, SignalImg.MouseUp, UploadText.MouseUp, DownloadText.MouseUp, BatteryLabel.MouseUp, UsersLabel.MouseUp
        drag = False
    End Sub
End Class