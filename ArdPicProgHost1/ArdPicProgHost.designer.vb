<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmUI_ArdPicProgHost
#Region "Vom Windows Form-Designer generierter Code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'Dieser Aufruf ist f�r den Windows Form-Designer erforderlich.
        InitializeComponent() 'generated by Windows Form Designer
        MyForm_Initialize() 'initialize application
    End Sub
    'Das Formular �berschreibt den L�schvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            mySerialLink.MyForm_Dispose()
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Wird vom Windows Form-Designer ben�tigt.
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents tHeartBeat As System.Windows.Forms.Timer
    Public WithEvents frmOuter As System.Windows.Forms.GroupBox
    'Hinweis: Die folgende Prozedur ist f�r den Windows Form-Designer erforderlich.
    'Das Ver�ndern mit dem Windows Form-Designer ist nicht m�glich.
    'Das Bearbeiten mit dem Code-Editor ist nicht m�glich.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUI_ArdPicProgHost))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tHeartBeat = New System.Windows.Forms.Timer(Me.components)
        Me.frmOuter = New System.Windows.Forms.GroupBox()
        Me.lFlashType = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lReservedRange = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lConfigurationRange = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lOsccal = New System.Windows.Forms.Label()
        Me.lConfigWord = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lEEPROMRange = New System.Windows.Forms.Label()
        Me.lProgramRange = New System.Windows.Forms.Label()
        Me.lDeviceName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.strArdPicProgFirmware = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.HexFileName = New System.Windows.Forms.TextBox()
        Me.ImportButton = New System.Windows.Forms.Button()
        Me.ReadButton = New System.Windows.Forms.Button()
        Me.EraseButton = New System.Windows.Forms.Button()
        Me.ExportButton = New System.Windows.Forms.Button()
        Me.WriteButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Led1 = New ArdPicProgHost.LED()
        Me.AvailableCOMPorts = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Status = New System.Windows.Forms.TextBox()
        Me.Led2 = New ArdPicProgHost.LED()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.HexFileDump = New System.Windows.Forms.TextBox()
        Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.EEPROMDump = New System.Windows.Forms.TextBox()
        Me.dlgSaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.frmOuter.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'tHeartBeat
        '
        Me.tHeartBeat.Interval = 5000
        '
        'frmOuter
        '
        Me.frmOuter.BackColor = System.Drawing.SystemColors.Control
        Me.frmOuter.Controls.Add(Me.lFlashType)
        Me.frmOuter.Controls.Add(Me.Label6)
        Me.frmOuter.Controls.Add(Me.lReservedRange)
        Me.frmOuter.Controls.Add(Me.Label5)
        Me.frmOuter.Controls.Add(Me.lConfigurationRange)
        Me.frmOuter.Controls.Add(Me.Label4)
        Me.frmOuter.Controls.Add(Me.lOsccal)
        Me.frmOuter.Controls.Add(Me.lConfigWord)
        Me.frmOuter.Controls.Add(Me.Label8)
        Me.frmOuter.Controls.Add(Me.Label7)
        Me.frmOuter.Controls.Add(Me.lEEPROMRange)
        Me.frmOuter.Controls.Add(Me.lProgramRange)
        Me.frmOuter.Controls.Add(Me.lDeviceName)
        Me.frmOuter.Controls.Add(Me.Label3)
        Me.frmOuter.Controls.Add(Me.Label2)
        Me.frmOuter.Controls.Add(Me.Label1)
        Me.frmOuter.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmOuter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmOuter.Location = New System.Drawing.Point(16, 13)
        Me.frmOuter.Name = "frmOuter"
        Me.frmOuter.Padding = New System.Windows.Forms.Padding(0)
        Me.frmOuter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmOuter.Size = New System.Drawing.Size(458, 145)
        Me.frmOuter.TabIndex = 2
        Me.frmOuter.TabStop = False
        Me.frmOuter.Text = "Device"
        '
        'lFlashType
        '
        Me.lFlashType.AutoSize = True
        Me.lFlashType.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lFlashType.Location = New System.Drawing.Point(127, 112)
        Me.lFlashType.Name = "lFlashType"
        Me.lFlashType.Size = New System.Drawing.Size(0, 16)
        Me.lFlashType.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(13, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Flash Type:"
        '
        'lReservedRange
        '
        Me.lReservedRange.AutoSize = True
        Me.lReservedRange.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lReservedRange.Location = New System.Drawing.Point(365, 111)
        Me.lReservedRange.Name = "lReservedRange"
        Me.lReservedRange.Size = New System.Drawing.Size(0, 16)
        Me.lReservedRange.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(230, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Reserved Range:"
        '
        'lConfigurationRange
        '
        Me.lConfigurationRange.AutoSize = True
        Me.lConfigurationRange.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lConfigurationRange.Location = New System.Drawing.Point(365, 60)
        Me.lConfigurationRange.Name = "lConfigurationRange"
        Me.lConfigurationRange.Size = New System.Drawing.Size(0, 16)
        Me.lConfigurationRange.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(230, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Configuration range:"
        '
        'lOsccal
        '
        Me.lOsccal.AutoSize = True
        Me.lOsccal.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lOsccal.Location = New System.Drawing.Point(368, 84)
        Me.lOsccal.Name = "lOsccal"
        Me.lOsccal.Size = New System.Drawing.Size(0, 16)
        Me.lOsccal.TabIndex = 9
        '
        'lConfigWord
        '
        Me.lConfigWord.AutoSize = True
        Me.lConfigWord.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lConfigWord.Location = New System.Drawing.Point(368, 36)
        Me.lConfigWord.Name = "lConfigWord"
        Me.lConfigWord.Size = New System.Drawing.Size(0, 16)
        Me.lConfigWord.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(230, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "OSCCAL:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(230, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Configuration:"
        '
        'lEEPROMRange
        '
        Me.lEEPROMRange.AutoSize = True
        Me.lEEPROMRange.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lEEPROMRange.Location = New System.Drawing.Point(127, 85)
        Me.lEEPROMRange.Name = "lEEPROMRange"
        Me.lEEPROMRange.Size = New System.Drawing.Size(0, 16)
        Me.lEEPROMRange.TabIndex = 5
        '
        'lProgramRange
        '
        Me.lProgramRange.AutoSize = True
        Me.lProgramRange.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lProgramRange.Location = New System.Drawing.Point(127, 60)
        Me.lProgramRange.Name = "lProgramRange"
        Me.lProgramRange.Size = New System.Drawing.Size(12, 16)
        Me.lProgramRange.TabIndex = 4
        Me.lProgramRange.Text = " "
        '
        'lDeviceName
        '
        Me.lDeviceName.AutoSize = True
        Me.lDeviceName.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lDeviceName.Location = New System.Drawing.Point(127, 36)
        Me.lDeviceName.Name = "lDeviceName"
        Me.lDeviceName.Size = New System.Drawing.Size(81, 16)
        Me.lDeviceName.TabIndex = 3
        Me.lDeviceName.Text = "Not present"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(13, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "EEPROM range:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(13, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Program range:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(13, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Device name:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.strArdPicProgFirmware)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox4.Location = New System.Drawing.Point(486, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox4.Size = New System.Drawing.Size(120, 66)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Firmware"
        Me.GroupBox4.UseWaitCursor = True
        '
        'strArdPicProgFirmware
        '
        Me.strArdPicProgFirmware.AcceptsReturn = True
        Me.strArdPicProgFirmware.BackColor = System.Drawing.SystemColors.Window
        Me.strArdPicProgFirmware.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.strArdPicProgFirmware.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.strArdPicProgFirmware.ForeColor = System.Drawing.SystemColors.WindowText
        Me.strArdPicProgFirmware.Location = New System.Drawing.Point(10, 28)
        Me.strArdPicProgFirmware.MaxLength = 4
        Me.strArdPicProgFirmware.Name = "strArdPicProgFirmware"
        Me.strArdPicProgFirmware.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.strArdPicProgFirmware.Size = New System.Drawing.Size(96, 21)
        Me.strArdPicProgFirmware.TabIndex = 18
        Me.strArdPicProgFirmware.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.strArdPicProgFirmware.UseWaitCursor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox7.Controls.Add(Me.ConnectButton)
        Me.GroupBox7.Controls.Add(Me.HexFileName)
        Me.GroupBox7.Controls.Add(Me.ImportButton)
        Me.GroupBox7.Controls.Add(Me.ReadButton)
        Me.GroupBox7.Controls.Add(Me.EraseButton)
        Me.GroupBox7.Controls.Add(Me.ExportButton)
        Me.GroupBox7.Controls.Add(Me.WriteButton)
        Me.GroupBox7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox7.Location = New System.Drawing.Point(16, 164)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox7.Size = New System.Drawing.Size(740, 71)
        Me.GroupBox7.TabIndex = 19
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Programmer"
        '
        'ConnectButton
        '
        Me.ConnectButton.BackColor = System.Drawing.SystemColors.Control
        Me.ConnectButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.ConnectButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConnectButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ConnectButton.Location = New System.Drawing.Point(12, 29)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ConnectButton.Size = New System.Drawing.Size(69, 26)
        Me.ConnectButton.TabIndex = 4
        Me.ConnectButton.Text = "Connect"
        Me.ConnectButton.UseVisualStyleBackColor = False
        '
        'HexFileName
        '
        Me.HexFileName.AcceptsReturn = True
        Me.HexFileName.BackColor = System.Drawing.SystemColors.Window
        Me.HexFileName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HexFileName.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.HexFileName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HexFileName.Location = New System.Drawing.Point(304, 31)
        Me.HexFileName.MaxLength = 4
        Me.HexFileName.Name = "HexFileName"
        Me.HexFileName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HexFileName.Size = New System.Drawing.Size(293, 23)
        Me.HexFileName.TabIndex = 20
        Me.HexFileName.Text = "None"
        '
        'ImportButton
        '
        Me.ImportButton.BackColor = System.Drawing.SystemColors.Control
        Me.ImportButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.ImportButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImportButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ImportButton.Location = New System.Drawing.Point(209, 29)
        Me.ImportButton.Name = "ImportButton"
        Me.ImportButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ImportButton.Size = New System.Drawing.Size(89, 26)
        Me.ImportButton.TabIndex = 5
        Me.ImportButton.Text = "Source file"
        Me.ImportButton.UseVisualStyleBackColor = False
        '
        'ReadButton
        '
        Me.ReadButton.BackColor = System.Drawing.SystemColors.Control
        Me.ReadButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.ReadButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReadButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ReadButton.Location = New System.Drawing.Point(86, 29)
        Me.ReadButton.Name = "ReadButton"
        Me.ReadButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ReadButton.Size = New System.Drawing.Size(53, 26)
        Me.ReadButton.TabIndex = 3
        Me.ReadButton.Text = "Read"
        Me.ReadButton.UseVisualStyleBackColor = False
        '
        'EraseButton
        '
        Me.EraseButton.BackColor = System.Drawing.SystemColors.Control
        Me.EraseButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.EraseButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EraseButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EraseButton.Location = New System.Drawing.Point(143, 29)
        Me.EraseButton.Name = "EraseButton"
        Me.EraseButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.EraseButton.Size = New System.Drawing.Size(60, 26)
        Me.EraseButton.TabIndex = 2
        Me.EraseButton.Text = "Erase"
        Me.EraseButton.UseVisualStyleBackColor = False
        '
        'ExportButton
        '
        Me.ExportButton.BackColor = System.Drawing.SystemColors.Control
        Me.ExportButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExportButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ExportButton.Location = New System.Drawing.Point(668, 29)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ExportButton.Size = New System.Drawing.Size(61, 26)
        Me.ExportButton.TabIndex = 1
        Me.ExportButton.Text = "Export"
        Me.ExportButton.UseVisualStyleBackColor = False
        '
        'WriteButton
        '
        Me.WriteButton.BackColor = System.Drawing.SystemColors.Control
        Me.WriteButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.WriteButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WriteButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.WriteButton.Location = New System.Drawing.Point(603, 29)
        Me.WriteButton.Name = "WriteButton"
        Me.WriteButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WriteButton.Size = New System.Drawing.Size(58, 26)
        Me.WriteButton.TabIndex = 0
        Me.WriteButton.Text = "Write"
        Me.WriteButton.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Led1)
        Me.GroupBox1.Controls.Add(Me.AvailableCOMPorts)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(612, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(144, 66)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "COM"
        '
        'Led1
        '
        Me.Led1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Led1.Blink = False
        Me.Led1.Color = ArdPicProgHost.LED.LEDColorSelection.LED_Red
        Me.Led1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Led1.Interval = CType(0, Short)
        Me.Led1.Location = New System.Drawing.Point(104, 25)
        Me.Led1.Name = "Led1"
        Me.Led1.Size = New System.Drawing.Size(29, 31)
        Me.Led1.State = False
        Me.Led1.TabIndex = 1
        '
        'AvailableCOMPorts
        '
        Me.AvailableCOMPorts.FormattingEnabled = True
        Me.AvailableCOMPorts.ItemHeight = 19
        Me.AvailableCOMPorts.Location = New System.Drawing.Point(11, 29)
        Me.AvailableCOMPorts.Name = "AvailableCOMPorts"
        Me.AvailableCOMPorts.Size = New System.Drawing.Size(87, 23)
        Me.AvailableCOMPorts.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.Status)
        Me.GroupBox2.Controls.Add(Me.Led2)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(486, 97)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(270, 61)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Status"
        '
        'Status
        '
        Me.Status.AcceptsReturn = True
        Me.Status.BackColor = System.Drawing.SystemColors.Window
        Me.Status.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Status.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Status.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Status.Location = New System.Drawing.Point(11, 23)
        Me.Status.MaxLength = 4
        Me.Status.Name = "Status"
        Me.Status.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Status.Size = New System.Drawing.Size(198, 21)
        Me.Status.TabIndex = 19
        Me.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Led2
        '
        Me.Led2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Led2.Blink = False
        Me.Led2.Color = ArdPicProgHost.LED.LEDColorSelection.LED_Red
        Me.Led2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Led2.Interval = CType(0, Short)
        Me.Led2.Location = New System.Drawing.Point(230, 16)
        Me.Led2.Name = "Led2"
        Me.Led2.Size = New System.Drawing.Size(29, 31)
        Me.Led2.State = False
        Me.Led2.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.HexFileDump)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(16, 241)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox3.Size = New System.Drawing.Size(740, 193)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Program memory"
        '
        'HexFileDump
        '
        Me.HexFileDump.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HexFileDump.Location = New System.Drawing.Point(12, 22)
        Me.HexFileDump.Multiline = True
        Me.HexFileDump.Name = "HexFileDump"
        Me.HexFileDump.ReadOnly = True
        Me.HexFileDump.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.HexFileDump.Size = New System.Drawing.Size(717, 161)
        Me.HexFileDump.TabIndex = 15
        '
        'dlgOpenFile
        '
        Me.dlgOpenFile.FileName = "OpenFileDialog1"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox5.Controls.Add(Me.EEPROMDump)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox5.Location = New System.Drawing.Point(16, 440)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox5.Size = New System.Drawing.Size(482, 121)
        Me.GroupBox5.TabIndex = 21
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "EEPROM"
        '
        'EEPROMDump
        '
        Me.EEPROMDump.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EEPROMDump.Location = New System.Drawing.Point(12, 22)
        Me.EEPROMDump.Multiline = True
        Me.EEPROMDump.Name = "EEPROMDump"
        Me.EEPROMDump.ReadOnly = True
        Me.EEPROMDump.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.EEPROMDump.Size = New System.Drawing.Size(459, 86)
        Me.EEPROMDump.TabIndex = 15
        '
        'frmUI_ArdPicProgHost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(767, 573)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.frmOuter)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUI_ArdPicProgHost"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Arduino Pic Programmer"
        Me.frmOuter.ResumeLayout(False)
        Me.frmOuter.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Public WithEvents strArdPicProgFirmware As System.Windows.Forms.TextBox
    Public WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Public WithEvents WriteButton As System.Windows.Forms.Button
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Led1 As ArdPicProgHost.LED
    Friend WithEvents AvailableCOMPorts As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lEEPROMRange As System.Windows.Forms.Label
    Friend WithEvents lProgramRange As System.Windows.Forms.Label
    Friend WithEvents lDeviceName As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lOsccal As System.Windows.Forms.Label
    Friend WithEvents lConfigWord As System.Windows.Forms.Label
    Public WithEvents EraseButton As System.Windows.Forms.Button
    Public WithEvents ExportButton As System.Windows.Forms.Button
    Public WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents Status As System.Windows.Forms.TextBox
    Friend WithEvents Led2 As ArdPicProgHost.LED
    Public WithEvents ReadButton As System.Windows.Forms.Button
    Public WithEvents ConnectButton As System.Windows.Forms.Button
    Public WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Public WithEvents HexFileName As System.Windows.Forms.TextBox
    Friend WithEvents dlgOpenFile As System.Windows.Forms.OpenFileDialog
    Public WithEvents ImportButton As System.Windows.Forms.Button
    Friend WithEvents HexFileDump As System.Windows.Forms.TextBox
    Friend WithEvents lConfigurationRange As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents EEPROMDump As System.Windows.Forms.TextBox
    Friend WithEvents dlgSaveFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lReservedRange As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lFlashType As System.Windows.Forms.Label
#End Region
End Class