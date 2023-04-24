Option Explicit On
Option Strict On
Public Class Form1
    'Dim send As Boolean
    Dim buttons As Boolean = False
    Dim portA As String
    Dim save As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'SerialPort1.PortName = "COM5"
        'SerialPort1.BaudRate = 9600
        'SerialPort1.DataBits = 8
        'SerialPort1.StopBits = IO.Ports.StopBits.One
        'SerialPort1.Parity = IO.Ports.Parity.None
        'SerialPort1.Open()

        'Timer1.Enabled = True


        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("")
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBox1.Items.Add(sp)
        Next

        RedTrackBar.Value = 20
        GreenTrackBar.Value = 20
        BlueTrackBar.Value = 20
        HScrollBar1.Value = 123
        TrackBar1.Value = 128
        HScrollBar2.Value = 127
        HScrollBar3.Value = 127
        HScrollBar4.Value = 127


        CheckBox1.Checked = False
        CheckBox2.Checked = False
    End Sub

    Dim arrIntegerData(8) As Integer
    Dim arrSendByte(9) As Byte

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'If buttons = True Then
        ListBox3.Items.Clear()

            'arrIntegerData(0) = RedTrackBar.Value
            'arrIntegerData(1) = GreenTrackBar.Value
            'arrIntegerData(2) = BlueTrackBar.Value
            'arrIntegerData(3) = HScrollBar1.Value
            'arrIntegerData(4) = TrackBar1.Value
            'arrIntegerData(5) = HScrollBar2.Value
            'arrIntegerData(6) = HScrollBar3.Value
            'arrIntegerData(7) = HScrollBar4.Value


            'For f = 0 To 8
            '    ListBox3.Items.Add(arrIntegerData(f))
            'Next

            arrSendByte(0) = CByte(Hex(36))
            arrSendByte(1) = CByte(RedTrackBar.Value)
            arrSendByte(2) = CByte(GreenTrackBar.Value)
            arrSendByte(3) = CByte(BlueTrackBar.Value)
            arrSendByte(4) = CByte(HScrollBar1.Value)
            arrSendByte(5) = CByte(TrackBar1.Value)
            arrSendByte(6) = CByte(HScrollBar2.Value)
            arrSendByte(7) = CByte(HScrollBar3.Value)
            arrSendByte(8) = CByte(HScrollBar4.Value)
            ' SerialPort1.Write(arrSendByte, 0, 9)

            ListBox3.Items.Add("")

            For s = 0 To 9
                ListBox3.Items.Add(arrSendByte(s))
            Next
        ' End If
    End Sub
    'Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
    'If ComboBox1.Text = "" Then
    '    SerialPort1.Close()
    '    buttons = False
    'Else
    '    If portA <> ComboBox1.Text Then
    '        portA = ComboBox1.Text

    '        Try

    '            SerialPort1.Close()
    '            SerialPort1.PortName = portA
    '            SerialPort1.BaudRate = 9600
    '            SerialPort1.DataBits = 8
    '            SerialPort1.StopBits = IO.Ports.StopBits.One
    '            SerialPort1.Parity = IO.Ports.Parity.None
    '            SerialPort1.Open()

    '            Timer1.Enabled = True
    '            save = ComboBox1.Text
    '            buttons = True

    '        Catch ex As Exception
    '            MessageBox.Show("Error- Select another port")
    '            ComboBox1.Text = save
    '            buttons = False
    '        End Try
    '    End If
    'End If
    'End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        CheckBox1.Checked = True
        CheckBox2.Checked = True

        ListBox3.Items.Clear()

        'arrIntegerData(0) = RedTrackBar.Value
        'arrIntegerData(1) = GreenTrackBar.Value
        'arrIntegerData(2) = BlueTrackBar.Value
        'arrIntegerData(3) = HScrollBar1.Value
        'arrIntegerData(4) = TrackBar1.Value
        'arrIntegerData(5) = HScrollBar2.Value
        'arrIntegerData(6) = HScrollBar3.Value
        'arrIntegerData(7) = HScrollBar4.Value


        'For f = 0 To 8
        '    ListBox3.Items.Add(arrIntegerData(f))
        'Next

        ' If send = True Then

        arrSendByte(0) = CByte(Hex(36))
        arrSendByte(1) = CByte(RedTrackBar.Value)
        arrSendByte(2) = CByte(GreenTrackBar.Value)
        arrSendByte(3) = CByte(BlueTrackBar.Value)
        arrSendByte(4) = CByte(HScrollBar1.Value)
        arrSendByte(5) = CByte(TrackBar1.Value)
        arrSendByte(6) = CByte(HScrollBar2.Value)
        arrSendByte(7) = CByte(HScrollBar3.Value)
        arrSendByte(8) = CByte(HScrollBar4.Value)
        'SerialPort1.Write(arrSendByte, 0, 9)
        ListBox3.Items.Add("")

        For s = 0 To 9
            ListBox3.Items.Add(arrSendByte(s))
        Next
        SerialPort1.Write(arrSendByte, 0, 9)

        'End If
        ' send = False
        Timer1.Enabled = True
    End Sub

    'Sub Output() As Byte  
    '    arrSendByte(0) = CByte(Hex(36))
    '    arrSendByte(1) = CByte(RedTrackBar.Value)
    '    arrSendByte(2) = CByte(GreenTrackBar.Value)
    '    arrSendByte(3) = CByte(BlueTrackBar.Value)
    '    arrSendByte(4) = CByte(HScrollBar1.Value)
    '    arrSendByte(5) = CByte(TrackBar1.Value)
    '    arrSendByte(6) = CByte(HScrollBar2.Value)
    '    arrSendByte(7) = CByte(HScrollBar3.Value)
    '    arrSendByte(8) = CByte(HScrollBar4.Value)
    'End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        If buttons = True Then

        End If
    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll

    End Sub

    Private Sub HScrollBar3_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar3.Scroll

    End Sub

    Private Sub HScrollBar4_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar4.Scroll

    End Sub
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        If buttons = True Then
            TrackBar1.Value = 124
            ' yLabel.Text = CStr(TrackBar1.Value)
            HScrollBar1.Value = 150
            ' XLabel.Text = CStr(HScrollBar1.Value)
            HScrollBar2.Value = 127
            HScrollBar3.Value = 127
            HScrollBar4.Value = 127
        End If
    End Sub

    Private Sub RedTrackBar_Scroll(sender As Object, e As EventArgs) Handles RedTrackBar.Scroll
        ' If buttons = True Then
        TextBox1.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)
            LabelR.Text = CStr(RedTrackBar.Value)
            LabelR.BackColor = Color.FromArgb(RedTrackBar.Value, 0, 0)

        ' RedTextBox.Text = CStr(RedTrackBar.Value)
        'LEDTextBox.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)
        ' End If
    End Sub

    Private Sub GreenTrackBar_Scroll(sender As Object, e As EventArgs) Handles GreenTrackBar.Scroll
        TextBox1.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)
        LabelG.Text = CStr(GreenTrackBar.Value)
        LabelG.BackColor = Color.FromArgb(0, GreenTrackBar.Value, 0)

        ' GreenTextBox.Text = CStr(GreenTrackBar.Value)
        ' LEDTextBox.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)
    End Sub

    Private Sub BlueTrackBar_Scroll(sender As Object, e As EventArgs) Handles BlueTrackBar.Scroll

        TextBox1.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)
        BLabel.Text = CStr(BlueTrackBar.Value)
        BLabel.BackColor = Color.FromArgb(0, 0, BlueTrackBar.Value)

        ' BlueTextBox.Text = CStr(BlueTrackBar.Value)
        ' LEDTextBox.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        If buttons = True Then
            RedTrackBar.Value = 0
        GreenTrackBar.Value = 0
        BlueTrackBar.Value = 0
        TextBox1.BackColor = Color.FromArgb(0, 0, 0)
        LabelR.Text = ""
        LabelG.Text = ""
            BLabel.Text = "B"
        End If
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
