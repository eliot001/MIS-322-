'Elliott Soelter
'MIS 322
'Capacity Simulation Form
'11/19/2019

Option Explicit On
Option Strict On

Public Class CapacitySimForm


    Public timePeriod As String  ' Set variable so SetPeriod will know how to arrange form

    Private Sub hourRadioButton_Click(sender As Object, e As EventArgs) Handles hourRadioButton.Click

        timePeriod = "Hourly"
        SetPeriod()

    End Sub

    Private Sub twoHourRadioButton_Click(sender As Object, e As EventArgs) Handles twoHourRadioButton.Click

        timePeriod = "TwoHour"
        SetPeriod()

    End Sub

    Private Sub shiftRadioButton_Click(sender As Object, e As EventArgs) Handles shiftRadioButton.Click

        timePeriod = "Shift"
        SetPeriod()

    End Sub
    Private Sub dailyRadioButton_Click(sender As Object, e As EventArgs) Handles dailyRadioButton.Click

        timePeriod = "Daily"
        SetPeriod()

    End Sub
    Private Sub SetPeriod()

        ' The labels within the panel will be set according
        ' to the time period selected by user

        displayTextBox.Clear()
        Select Case timePeriod
            Case "Hourly"
                Label1.Text = "8:00"
                Label2.Text = "9:00"
                Label3.Text = "10:00"
                Label4.Text = "11:00"
                Label5.Text = "12:00"
                Label6.Text = "1:00"
                Label7.Text = "2:00"
                Label8.Text = "3:00"
                Label9.Text = "4:00"
            Case "TwoHour"
                Label1.Text = "8 to 10"
                Label2.Text = "10 to 12"
                Label3.Text = "12 to 2"
                Label4.Text = "2 to 4"
                Label5.Text = ""
                Label6.Text = ""
                Label7.Text = ""
                Label8.Text = ""
                Label9.Text = ""
            Case "Shift"
                Label1.Text = "Morning"
                Label2.Text = "Mid"
                Label3.Text = "Afternoon"
                Label4.Text = "Swing"
                Label5.Text = "Night"
                Label6.Text = ""
                Label7.Text = ""
                Label8.Text = ""
                Label9.Text = ""
            Case "Daily"
                Label1.Text = "Monday"
                Label2.Text = "Tuesday"
                Label3.Text = "Wednesday"
                Label4.Text = "Thursday"
                Label5.Text = "Friday"
                Label6.Text = "Saturday"
                Label7.Text = "Sunday"
                Label8.Text = ""
                Label9.Text = ""
        End Select

    End Sub

    Public Function DemandSimulation(ByVal station1 As Double,
                                     ByVal station2 As Double,
                                     ByVal station3 As Double,
                                     ByVal maximum As Integer,
                                     ByVal minimum As Integer,
                                     ByVal count As Integer
                                     ) As String
        'Define string locations and variables 
        Dim display As String = "{0,8}{1,8}{2,8}{3,8}"
        Dim ws1 As Integer
        Dim ws2 As Integer
        Dim ws3 As Integer
        Dim overload As String
        Dim randNum1 As New Random
        Dim random1 As Integer
        Dim random2 As Integer
        Dim random3 As Integer
        'Generate random number 

        'Do While loop
        Do While count > 0

            'ends loop when appropiate
            count -= 1

            'Generates random numbers 
            random1 = randNum1.Next(minimum, (maximum + 1))
            random2 = randNum1.Next(minimum, (maximum + 1))
            random3 = randNum1.Next(minimum, (maximum + 1))
            ws1 = random1
            ws2 = random2
            ws3 = random3

            'Checks for overload
            If ws1 > station1 Or ws2 > station2 Or ws3 > station3 Then

                overload = "Yes"

            Else overload = "No"

            End If

            displayTextBox.AppendText(String.Format(display, ws3, ws2, ws3, overload) & vbNewLine)

        Loop

        Return (displayTextBox.Text)
    End Function
    Private Sub RunSimToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunSimToolStripMenuItem.Click

        'Sets count to right number 
        Dim count As Integer

        If hourRadioButton.Checked = True Then
            count = 9
        ElseIf twoHourRadioButton.Checked = True Then
            count = 4
        ElseIf shiftRadioButton.Checked = True Then
            count = 5
        ElseIf dailyRadioButton.Checked = True Then
            count = 7
        End If

        'Runs Sim and checks input 
        Dim station1 As Double
        Dim station2 As Double
        Dim station3 As Double
        Dim maximum As Integer
        Dim minimum As Integer

        'Makes sure integers and doubles get read in
        Try

            station1 = Convert.ToDouble(ws1CapTextBox.Text)
            station2 = Convert.ToDouble(ws2CapTextBox.Text)
            station3 = Convert.ToDouble(ws3CapTextBox.Text)

            maximum = Convert.ToInt32(maxTextBox.Text)
            minimum = Convert.ToInt32(minTextBox.Text)

        Catch fe As FormatException
            MessageBox.Show(fe.Message, "Input Error")
            Exit Sub
        End Try

        'Error Catch input is positive
        If station1 < 0 Or station2 < 0 Or station3 < 0 Then
            MessageBox.Show("Please input positive numbers.", "Input Error")
            Exit Sub
        End If

        'Checks for max greater than min
        If maximum < minimum Then
            MessageBox.Show("Please ensure maximum is smaller than minimum.", "Input Error")
            Exit Sub
        End If

        'Calls function
        DemandSimulation(station1, station2, station3, maximum, minimum, count)

    End Sub

    Private Sub ResetSImToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetSImToolStripMenuItem.Click

        'Resets system 
        ws1CapTextBox.Clear()
        ws2CapTextBox.Clear()
        ws3CapTextBox.Clear()
        maxTextBox.Clear()
        minTextBox.Clear()
        displayTextBox.Clear()
        hourRadioButton.Checked = True

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Closees Form
        Me.Close()
    End Sub
End Class
