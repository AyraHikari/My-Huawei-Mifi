<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FloatingInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.DownloadText = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.UploadText = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BatteryLabel = New System.Windows.Forms.Label()
        Me.UsersLabel = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.NetType = New System.Windows.Forms.Label()
        Me.ProviderLabel = New System.Windows.Forms.Label()
        Me.SignalImg = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignalImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.My_Huawei.My.Resources.Resources.sms_received_icon
        Me.PictureBox5.Location = New System.Drawing.Point(57, 25)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox5.TabIndex = 21
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'DownloadText
        '
        Me.DownloadText.AutoSize = True
        Me.DownloadText.BackColor = System.Drawing.Color.Transparent
        Me.DownloadText.Location = New System.Drawing.Point(180, 29)
        Me.DownloadText.Name = "DownloadText"
        Me.DownloadText.Size = New System.Drawing.Size(66, 13)
        Me.DownloadText.TabIndex = 20
        Me.DownloadText.Text = "0 MB - 0 MB"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.My_Huawei.My.Resources.Resources.upload
        Me.PictureBox4.Location = New System.Drawing.Point(158, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox4.TabIndex = 19
        Me.PictureBox4.TabStop = False
        '
        'UploadText
        '
        Me.UploadText.AutoSize = True
        Me.UploadText.BackColor = System.Drawing.Color.Transparent
        Me.UploadText.Location = New System.Drawing.Point(180, 7)
        Me.UploadText.Name = "UploadText"
        Me.UploadText.Size = New System.Drawing.Size(66, 13)
        Me.UploadText.TabIndex = 18
        Me.UploadText.Text = "0 MB - 0 MB"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.My_Huawei.My.Resources.Resources.download
        Me.PictureBox3.Location = New System.Drawing.Point(158, 26)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'BatteryLabel
        '
        Me.BatteryLabel.AutoSize = True
        Me.BatteryLabel.BackColor = System.Drawing.Color.Transparent
        Me.BatteryLabel.Location = New System.Drawing.Point(83, 29)
        Me.BatteryLabel.Name = "BatteryLabel"
        Me.BatteryLabel.Size = New System.Drawing.Size(69, 13)
        Me.BatteryLabel.TabIndex = 16
        Me.BatteryLabel.Text = "Battery 100%"
        Me.BatteryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UsersLabel
        '
        Me.UsersLabel.AutoSize = True
        Me.UsersLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsersLabel.Location = New System.Drawing.Point(108, 7)
        Me.UsersLabel.Name = "UsersLabel"
        Me.UsersLabel.Size = New System.Drawing.Size(40, 13)
        Me.UsersLabel.TabIndex = 15
        Me.UsersLabel.Text = "x users"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.My_Huawei.My.Resources.Resources.devices
        Me.PictureBox2.Location = New System.Drawing.Point(86, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'NetType
        '
        Me.NetType.AutoSize = True
        Me.NetType.BackColor = System.Drawing.Color.Transparent
        Me.NetType.Location = New System.Drawing.Point(30, 28)
        Me.NetType.Name = "NetType"
        Me.NetType.Size = New System.Drawing.Size(14, 13)
        Me.NetType.TabIndex = 13
        Me.NetType.Text = "X"
        '
        'ProviderLabel
        '
        Me.ProviderLabel.AutoSize = True
        Me.ProviderLabel.BackColor = System.Drawing.Color.Transparent
        Me.ProviderLabel.Location = New System.Drawing.Point(3, 7)
        Me.ProviderLabel.Name = "ProviderLabel"
        Me.ProviderLabel.Size = New System.Drawing.Size(54, 13)
        Me.ProviderLabel.TabIndex = 12
        Me.ProviderLabel.Text = "Loading..."
        '
        'SignalImg
        '
        Me.SignalImg.BackColor = System.Drawing.Color.Transparent
        Me.SignalImg.Image = Global.My_Huawei.My.Resources.Resources.loading1
        Me.SignalImg.Location = New System.Drawing.Point(6, 26)
        Me.SignalImg.Name = "SignalImg"
        Me.SignalImg.Size = New System.Drawing.Size(16, 16)
        Me.SignalImg.TabIndex = 11
        Me.SignalImg.TabStop = False
        '
        'FloatingInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(300, 50)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.DownloadText)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.UploadText)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.BatteryLabel)
        Me.Controls.Add(Me.UsersLabel)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.NetType)
        Me.Controls.Add(Me.ProviderLabel)
        Me.Controls.Add(Me.SignalImg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FloatingInfo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "FloatingInfo"
        Me.TopMost = True
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignalImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents DownloadText As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents UploadText As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BatteryLabel As Label
    Friend WithEvents UsersLabel As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents NetType As Label
    Friend WithEvents ProviderLabel As Label
    Friend WithEvents SignalImg As PictureBox
End Class
