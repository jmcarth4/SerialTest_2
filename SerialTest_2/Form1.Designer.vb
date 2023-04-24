<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.RedTrackBar = New System.Windows.Forms.TrackBar()
        Me.LabelR = New System.Windows.Forms.Label()
        Me.GreenTrackBar = New System.Windows.Forms.TrackBar()
        Me.LabelG = New System.Windows.Forms.Label()
        Me.BlueTrackBar = New System.Windows.Forms.TrackBar()
        Me.BLabel = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.HScrollBar2 = New System.Windows.Forms.HScrollBar()
        Me.HScrollBar3 = New System.Windows.Forms.HScrollBar()
        Me.HScrollBar4 = New System.Windows.Forms.HScrollBar()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.RedTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GreenTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlueTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RedTrackBar
        '
        Me.RedTrackBar.Location = New System.Drawing.Point(373, 361)
        Me.RedTrackBar.Maximum = 255
        Me.RedTrackBar.Name = "RedTrackBar"
        Me.RedTrackBar.Size = New System.Drawing.Size(151, 69)
        Me.RedTrackBar.TabIndex = 53
        Me.RedTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'LabelR
        '
        Me.LabelR.AutoSize = True
        Me.LabelR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelR.Location = New System.Drawing.Point(414, 447)
        Me.LabelR.Name = "LabelR"
        Me.LabelR.Size = New System.Drawing.Size(21, 20)
        Me.LabelR.TabIndex = 59
        Me.LabelR.Text = "R"
        '
        'GreenTrackBar
        '
        Me.GreenTrackBar.Location = New System.Drawing.Point(562, 361)
        Me.GreenTrackBar.Maximum = 255
        Me.GreenTrackBar.Name = "GreenTrackBar"
        Me.GreenTrackBar.Size = New System.Drawing.Size(195, 69)
        Me.GreenTrackBar.TabIndex = 60
        Me.GreenTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'LabelG
        '
        Me.LabelG.AutoSize = True
        Me.LabelG.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelG.Location = New System.Drawing.Point(637, 433)
        Me.LabelG.Name = "LabelG"
        Me.LabelG.Size = New System.Drawing.Size(22, 20)
        Me.LabelG.TabIndex = 61
        Me.LabelG.Text = "G"
        '
        'BlueTrackBar
        '
        Me.BlueTrackBar.Location = New System.Drawing.Point(804, 361)
        Me.BlueTrackBar.Maximum = 255
        Me.BlueTrackBar.Name = "BlueTrackBar"
        Me.BlueTrackBar.Size = New System.Drawing.Size(155, 69)
        Me.BlueTrackBar.TabIndex = 62
        Me.BlueTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'BLabel
        '
        Me.BLabel.AutoSize = True
        Me.BLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BLabel.Location = New System.Drawing.Point(877, 433)
        Me.BLabel.Name = "BLabel"
        Me.BLabel.Size = New System.Drawing.Size(20, 20)
        Me.BLabel.TabIndex = 63
        Me.BLabel.Text = "B"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(594, 492)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 64
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.ForeColor = System.Drawing.Color.Black
        Me.ClearButton.Location = New System.Drawing.Point(1014, 361)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(93, 45)
        Me.ClearButton.TabIndex = 65
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(342, 94)
        Me.HScrollBar1.Maximum = 255
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(153, 45)
        Me.HScrollBar1.TabIndex = 66
        Me.HScrollBar1.TabStop = True
        '
        'TrackBar1
        '
        Me.TrackBar1.LargeChange = 10
        Me.TrackBar1.Location = New System.Drawing.Point(541, 94)
        Me.TrackBar1.Maximum = 255
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(153, 69)
        Me.TrackBar1.TabIndex = 67
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'HScrollBar2
        '
        Me.HScrollBar2.Location = New System.Drawing.Point(717, 94)
        Me.HScrollBar2.Maximum = 255
        Me.HScrollBar2.Name = "HScrollBar2"
        Me.HScrollBar2.Size = New System.Drawing.Size(153, 45)
        Me.HScrollBar2.TabIndex = 68
        Me.HScrollBar2.TabStop = True
        '
        'HScrollBar3
        '
        Me.HScrollBar3.Location = New System.Drawing.Point(418, 197)
        Me.HScrollBar3.Maximum = 255
        Me.HScrollBar3.Name = "HScrollBar3"
        Me.HScrollBar3.Size = New System.Drawing.Size(153, 45)
        Me.HScrollBar3.TabIndex = 69
        Me.HScrollBar3.TabStop = True
        '
        'HScrollBar4
        '
        Me.HScrollBar4.Location = New System.Drawing.Point(658, 197)
        Me.HScrollBar4.Maximum = 255
        Me.HScrollBar4.Name = "HScrollBar4"
        Me.HScrollBar4.Size = New System.Drawing.Size(153, 45)
        Me.HScrollBar4.TabIndex = 70
        Me.HScrollBar4.TabStop = True
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ResetButton.ForeColor = System.Drawing.Color.Black
        Me.ResetButton.Location = New System.Drawing.Point(973, 133)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(93, 45)
        Me.ResetButton.TabIndex = 71
        Me.ResetButton.Text = "&Reset "
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ExitButton.ForeColor = System.Drawing.Color.Black
        Me.ExitButton.Location = New System.Drawing.Point(1190, 527)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(93, 45)
        Me.ExitButton.TabIndex = 72
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 20
        Me.ListBox3.Location = New System.Drawing.Point(30, 12)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(143, 324)
        Me.ListBox3.TabIndex = 73
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(39, 361)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 55)
        Me.Button4.TabIndex = 74
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(201, 46)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(116, 24)
        Me.CheckBox2.TabIndex = 76
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(201, 94)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(116, 24)
        Me.CheckBox1.TabIndex = 75
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(82, 474)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 77
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 602)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.HScrollBar4)
        Me.Controls.Add(Me.HScrollBar3)
        Me.Controls.Add(Me.HScrollBar2)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BLabel)
        Me.Controls.Add(Me.BlueTrackBar)
        Me.Controls.Add(Me.LabelG)
        Me.Controls.Add(Me.GreenTrackBar)
        Me.Controls.Add(Me.LabelR)
        Me.Controls.Add(Me.RedTrackBar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.RedTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GreenTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlueTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RedTrackBar As TrackBar
    Friend WithEvents LabelR As Label
    Friend WithEvents GreenTrackBar As TrackBar
    Friend WithEvents LabelG As Label
    Friend WithEvents BlueTrackBar As TrackBar
    Friend WithEvents BLabel As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents HScrollBar2 As HScrollBar
    Friend WithEvents HScrollBar3 As HScrollBar
    Friend WithEvents HScrollBar4 As HScrollBar
    Friend WithEvents ResetButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents Button4 As Button
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
