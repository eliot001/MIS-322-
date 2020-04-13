<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CapacitySimForm
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
        Me.hourPanel = New System.Windows.Forms.Panel()
        Me.displayTextBox = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.timePeriodGroupBox = New System.Windows.Forms.GroupBox()
        Me.dailyRadioButton = New System.Windows.Forms.RadioButton()
        Me.twoHourRadioButton = New System.Windows.Forms.RadioButton()
        Me.shiftRadioButton = New System.Windows.Forms.RadioButton()
        Me.hourRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ws1CapTextBox = New System.Windows.Forms.TextBox()
        Me.ws2CapTextBox = New System.Windows.Forms.TextBox()
        Me.ws3CapTextBox = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.maxTextBox = New System.Windows.Forms.TextBox()
        Me.minTextBox = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SimulationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunSimToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetSImToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.hourPanel.SuspendLayout()
        Me.timePeriodGroupBox.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'hourPanel
        '
        Me.hourPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.hourPanel.Controls.Add(Me.displayTextBox)
        Me.hourPanel.Controls.Add(Me.Label15)
        Me.hourPanel.Controls.Add(Me.Label14)
        Me.hourPanel.Controls.Add(Me.Label12)
        Me.hourPanel.Controls.Add(Me.Label11)
        Me.hourPanel.Controls.Add(Me.Label10)
        Me.hourPanel.Controls.Add(Me.Label9)
        Me.hourPanel.Controls.Add(Me.Label8)
        Me.hourPanel.Controls.Add(Me.Label7)
        Me.hourPanel.Controls.Add(Me.Label6)
        Me.hourPanel.Controls.Add(Me.Label5)
        Me.hourPanel.Controls.Add(Me.Label4)
        Me.hourPanel.Controls.Add(Me.Label3)
        Me.hourPanel.Controls.Add(Me.Label2)
        Me.hourPanel.Controls.Add(Me.Label1)
        Me.hourPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hourPanel.Location = New System.Drawing.Point(249, 80)
        Me.hourPanel.Name = "hourPanel"
        Me.hourPanel.Size = New System.Drawing.Size(423, 353)
        Me.hourPanel.TabIndex = 0
        '
        'displayTextBox
        '
        Me.displayTextBox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayTextBox.Location = New System.Drawing.Point(111, 46)
        Me.displayTextBox.Multiline = True
        Me.displayTextBox.Name = "displayTextBox"
        Me.displayTextBox.Size = New System.Drawing.Size(271, 267)
        Me.displayTextBox.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(109, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(274, 2)
        Me.Label15.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(295, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 16)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Overloaded"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(235, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 16)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "WS 3"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(172, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "WS 2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(113, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "WS 1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "4:00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "3:00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "2:00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "1:00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "12:00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "11:00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "10:00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "9:00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "8:00"
        '
        'timePeriodGroupBox
        '
        Me.timePeriodGroupBox.Controls.Add(Me.dailyRadioButton)
        Me.timePeriodGroupBox.Controls.Add(Me.twoHourRadioButton)
        Me.timePeriodGroupBox.Controls.Add(Me.shiftRadioButton)
        Me.timePeriodGroupBox.Controls.Add(Me.hourRadioButton)
        Me.timePeriodGroupBox.Location = New System.Drawing.Point(22, 80)
        Me.timePeriodGroupBox.Name = "timePeriodGroupBox"
        Me.timePeriodGroupBox.Size = New System.Drawing.Size(178, 137)
        Me.timePeriodGroupBox.TabIndex = 1
        Me.timePeriodGroupBox.TabStop = False
        Me.timePeriodGroupBox.Text = "Select Time Period"
        '
        'dailyRadioButton
        '
        Me.dailyRadioButton.AutoSize = True
        Me.dailyRadioButton.Location = New System.Drawing.Point(15, 96)
        Me.dailyRadioButton.Name = "dailyRadioButton"
        Me.dailyRadioButton.Size = New System.Drawing.Size(48, 17)
        Me.dailyRadioButton.TabIndex = 3
        Me.dailyRadioButton.Text = "Daily"
        Me.dailyRadioButton.UseVisualStyleBackColor = True
        '
        'twoHourRadioButton
        '
        Me.twoHourRadioButton.AutoSize = True
        Me.twoHourRadioButton.Location = New System.Drawing.Point(15, 50)
        Me.twoHourRadioButton.Name = "twoHourRadioButton"
        Me.twoHourRadioButton.Size = New System.Drawing.Size(95, 17)
        Me.twoHourRadioButton.TabIndex = 2
        Me.twoHourRadioButton.Text = "2 Hour Periods"
        Me.twoHourRadioButton.UseVisualStyleBackColor = True
        '
        'shiftRadioButton
        '
        Me.shiftRadioButton.AutoSize = True
        Me.shiftRadioButton.Location = New System.Drawing.Point(15, 73)
        Me.shiftRadioButton.Name = "shiftRadioButton"
        Me.shiftRadioButton.Size = New System.Drawing.Size(46, 17)
        Me.shiftRadioButton.TabIndex = 1
        Me.shiftRadioButton.Text = "Shift"
        Me.shiftRadioButton.UseVisualStyleBackColor = True
        '
        'hourRadioButton
        '
        Me.hourRadioButton.AutoSize = True
        Me.hourRadioButton.Checked = True
        Me.hourRadioButton.Location = New System.Drawing.Point(15, 27)
        Me.hourRadioButton.Name = "hourRadioButton"
        Me.hourRadioButton.Size = New System.Drawing.Size(55, 17)
        Me.hourRadioButton.TabIndex = 0
        Me.hourRadioButton.TabStop = True
        Me.hourRadioButton.Text = "Hourly"
        Me.hourRadioButton.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 256)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 16)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Work Station 1:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 285)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 16)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Work Station 2:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 314)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 16)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Work Station 3:"
        '
        'ws1CapTextBox
        '
        Me.ws1CapTextBox.Location = New System.Drawing.Point(120, 255)
        Me.ws1CapTextBox.Name = "ws1CapTextBox"
        Me.ws1CapTextBox.Size = New System.Drawing.Size(77, 20)
        Me.ws1CapTextBox.TabIndex = 6
        '
        'ws2CapTextBox
        '
        Me.ws2CapTextBox.Location = New System.Drawing.Point(120, 284)
        Me.ws2CapTextBox.Name = "ws2CapTextBox"
        Me.ws2CapTextBox.Size = New System.Drawing.Size(77, 20)
        Me.ws2CapTextBox.TabIndex = 7
        '
        'ws3CapTextBox
        '
        Me.ws3CapTextBox.Location = New System.Drawing.Point(120, 314)
        Me.ws3CapTextBox.Name = "ws3CapTextBox"
        Me.ws3CapTextBox.Size = New System.Drawing.Size(77, 20)
        Me.ws3CapTextBox.TabIndex = 8
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(123, 232)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 20)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Capacity"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(41, 387)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 16)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "Maximum:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(45, 414)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 16)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Minimum:"
        '
        'maxTextBox
        '
        Me.maxTextBox.Location = New System.Drawing.Point(120, 386)
        Me.maxTextBox.Name = "maxTextBox"
        Me.maxTextBox.Size = New System.Drawing.Size(77, 20)
        Me.maxTextBox.TabIndex = 12
        '
        'minTextBox
        '
        Me.minTextBox.Location = New System.Drawing.Point(120, 413)
        Me.minTextBox.Name = "minTextBox"
        Me.minTextBox.Size = New System.Drawing.Size(77, 20)
        Me.minTextBox.TabIndex = 13
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(123, 363)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(70, 20)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "Demand"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SimulationToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(699, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SimulationToolStripMenuItem
        '
        Me.SimulationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunSimToolStripMenuItem, Me.ResetSImToolStripMenuItem})
        Me.SimulationToolStripMenuItem.Name = "SimulationToolStripMenuItem"
        Me.SimulationToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.SimulationToolStripMenuItem.Text = "&Simulation"
        '
        'RunSimToolStripMenuItem
        '
        Me.RunSimToolStripMenuItem.Name = "RunSimToolStripMenuItem"
        Me.RunSimToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RunSimToolStripMenuItem.Text = "&Run Sim"
        '
        'ResetSImToolStripMenuItem
        '
        Me.ResetSImToolStripMenuItem.Name = "ResetSImToolStripMenuItem"
        Me.ResetSImToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ResetSImToolStripMenuItem.Text = "R&eset Sim"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'CapacitySimForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 458)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.minTextBox)
        Me.Controls.Add(Me.maxTextBox)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.ws3CapTextBox)
        Me.Controls.Add(Me.ws2CapTextBox)
        Me.Controls.Add(Me.ws1CapTextBox)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.timePeriodGroupBox)
        Me.Controls.Add(Me.hourPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CapacitySimForm"
        Me.Text = "System Capacity Analysis"
        Me.hourPanel.ResumeLayout(False)
        Me.hourPanel.PerformLayout()
        Me.timePeriodGroupBox.ResumeLayout(False)
        Me.timePeriodGroupBox.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents hourPanel As Panel
    Friend WithEvents displayTextBox As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents timePeriodGroupBox As GroupBox
    Friend WithEvents dailyRadioButton As RadioButton
    Friend WithEvents twoHourRadioButton As RadioButton
    Friend WithEvents shiftRadioButton As RadioButton
    Friend WithEvents hourRadioButton As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents ws1CapTextBox As TextBox
    Friend WithEvents ws2CapTextBox As TextBox
    Friend WithEvents ws3CapTextBox As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents maxTextBox As TextBox
    Friend WithEvents minTextBox As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SimulationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RunSimToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetSImToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
