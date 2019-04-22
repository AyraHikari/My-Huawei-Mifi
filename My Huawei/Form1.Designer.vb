<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Provider = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MessageInfo = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.GetMsg = New System.Windows.Forms.Timer(Me.components)
        Me.msgpic = New System.Windows.Forms.PictureBox()
        Me.SignalBox = New System.Windows.Forms.PictureBox()
        Me.NetwkTypeLabel = New System.Windows.Forms.Label()
        Me.NetUsageLabel = New System.Windows.Forms.Label()
        Me.BatteryBar = New System.Windows.Forms.ProgressBar()
        Me.BatteryLabel = New System.Windows.Forms.Label()
        Me.UserConnected = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.msgpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignalBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Loading..."
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(149, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(148, 22)
        Me.ToolStripMenuItem1.Text = "Open Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(275, 30)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 222)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(275, 30)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Hide"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Provider
        '
        Me.Provider.AutoSize = True
        Me.Provider.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Provider.Location = New System.Drawing.Point(12, 13)
        Me.Provider.Name = "Provider"
        Me.Provider.Size = New System.Drawing.Size(84, 19)
        Me.Provider.TabIndex = 2
        Me.Provider.Text = "Loading..."
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 186)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(275, 30)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Open WebUi"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(77, 159)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(129, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "192.168.8.1"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(212, 157)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Connect"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "IP Address"
        '
        'MessageInfo
        '
        Me.MessageInfo.BalloonTipText = "You got message!"
        Me.MessageInfo.BalloonTipTitle = "Click here to read message"
        Me.MessageInfo.Icon = CType(resources.GetObject("MessageInfo.Icon"), System.Drawing.Icon)
        Me.MessageInfo.Text = "Message"
        '
        'GetMsg
        '
        Me.GetMsg.Interval = 5000
        '
        'msgpic
        '
        Me.msgpic.Image = Global.My_Huawei.My.Resources.Resources.sms_received_icon
        Me.msgpic.Location = New System.Drawing.Point(268, 12)
        Me.msgpic.Name = "msgpic"
        Me.msgpic.Size = New System.Drawing.Size(20, 20)
        Me.msgpic.TabIndex = 7
        Me.msgpic.TabStop = False
        Me.msgpic.Visible = False
        '
        'SignalBox
        '
        Me.SignalBox.Image = CType(resources.GetObject("SignalBox.Image"), System.Drawing.Image)
        Me.SignalBox.Location = New System.Drawing.Point(12, 76)
        Me.SignalBox.Name = "SignalBox"
        Me.SignalBox.Size = New System.Drawing.Size(80, 80)
        Me.SignalBox.TabIndex = 8
        Me.SignalBox.TabStop = False
        '
        'NetwkTypeLabel
        '
        Me.NetwkTypeLabel.AutoSize = True
        Me.NetwkTypeLabel.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetwkTypeLabel.Location = New System.Drawing.Point(12, 76)
        Me.NetwkTypeLabel.Name = "NetwkTypeLabel"
        Me.NetwkTypeLabel.Size = New System.Drawing.Size(32, 26)
        Me.NetwkTypeLabel.TabIndex = 9
        Me.NetwkTypeLabel.Text = "??"
        '
        'NetUsageLabel
        '
        Me.NetUsageLabel.AutoSize = True
        Me.NetUsageLabel.Location = New System.Drawing.Point(98, 110)
        Me.NetUsageLabel.Name = "NetUsageLabel"
        Me.NetUsageLabel.Size = New System.Drawing.Size(86, 13)
        Me.NetUsageLabel.TabIndex = 10
        Me.NetUsageLabel.Text = "Loading usage..."
        '
        'BatteryBar
        '
        Me.BatteryBar.Location = New System.Drawing.Point(98, 128)
        Me.BatteryBar.Name = "BatteryBar"
        Me.BatteryBar.Size = New System.Drawing.Size(189, 23)
        Me.BatteryBar.TabIndex = 11
        '
        'BatteryLabel
        '
        Me.BatteryLabel.AutoSize = True
        Me.BatteryLabel.BackColor = System.Drawing.Color.Transparent
        Me.BatteryLabel.Location = New System.Drawing.Point(174, 133)
        Me.BatteryLabel.Name = "BatteryLabel"
        Me.BatteryLabel.Size = New System.Drawing.Size(33, 13)
        Me.BatteryLabel.TabIndex = 12
        Me.BatteryLabel.Text = "100%"
        Me.BatteryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserConnected
        '
        Me.UserConnected.AutoSize = True
        Me.UserConnected.Location = New System.Drawing.Point(98, 87)
        Me.UserConnected.Name = "UserConnected"
        Me.UserConnected.Size = New System.Drawing.Size(70, 13)
        Me.UserConnected.TabIndex = 13
        Me.UserConnected.Text = "Connecting..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 300)
        Me.Controls.Add(Me.UserConnected)
        Me.Controls.Add(Me.BatteryLabel)
        Me.Controls.Add(Me.BatteryBar)
        Me.Controls.Add(Me.NetUsageLabel)
        Me.Controls.Add(Me.NetwkTypeLabel)
        Me.Controls.Add(Me.SignalBox)
        Me.Controls.Add(Me.msgpic)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Provider)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Huawei"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.msgpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignalBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Provider As Label
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MessageInfo As NotifyIcon
    Friend WithEvents GetMsg As Timer
    Friend WithEvents msgpic As PictureBox
    Friend WithEvents SignalBox As PictureBox
    Friend WithEvents NetwkTypeLabel As Label
    Friend WithEvents NetUsageLabel As Label
    Friend WithEvents BatteryBar As ProgressBar
    Friend WithEvents BatteryLabel As Label
    Friend WithEvents UserConnected As Label
End Class
