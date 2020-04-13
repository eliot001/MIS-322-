'Elliott Soelter
'MIS 322
'12/3/2019
'LAP 6

Option Strict Off
Option Explicit On

Public Class Form1
    Private Sub TblEmployBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblEmployBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblEmployBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Emp401KDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Emp401KDataSet.tblEmploy' table. You can move, or remove it, as needed.
        Me.TblEmployTableAdapter.Fill(Me.Emp401KDataSet.tblEmploy)

    End Sub

    Private Sub employeeStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles employeeStatus.SelectedIndexChanged

        'Clears textbox
        outputTextBox.Clear()
        'Sets status check
        Dim selectedStatus As String
        If employeeStatus.Text = "Full Time" Then
            selectedStatus = "F"
        ElseIf employeeStatus.Text = "Part Time" Then
            selectedStatus = "P"
        End If

        'Runs for each loop to read through table 
        Dim idNum, lastName, firstName, status, code, hireDate As String
        Dim rate, retire, hours, payrollTotal As Double
        Dim reportOutput As String = "{0,-8}{1,-20}{2,-20}{3,-20}{4,10}{5,10}{6,10}{7,12}{8,15}"
        For Each myRow In Emp401KDataSet.tblEmploy.Rows

            'reads through for output data
            idNum = Convert.ToString(myRow.Item(0))
            firstName = Convert.ToString(myRow.Item(2))
            lastName = Convert.ToString(myRow.Item(1))
            status = Convert.ToString(myRow.Item(5))
            hireDate = Convert.ToString(myRow.item(3))
            rate = Convert.ToDouble((myRow.Item(4)))
            retire = Convert.ToDouble(myRow.Item(8))
            hours = Convert.ToDouble(myRow.Item(7))
            code = Convert.ToString(myRow.Item(6))

            'Assigns total value and prints appropriate data rows based on selection
            If status = selectedStatus Then
                payrollTotal = payrollTotal + (hours * rate)
                outputTextBox.Text += String.Format(reportOutput, idNum, lastName, firstName, hireDate, hours, rate.ToString("C2"), status, code, retire.ToString("C2")) &
                    vbNewLine
            End If
        Next
        'Final textbox line output
        outputTextBox.Text += vbNewLine & "-------------------------------------------------------------------------------------------------------------------------" &
            vbNewLine & "        Weekly Payroll Total: " & payrollTotal.ToString("C2")
    End Sub
End Class
