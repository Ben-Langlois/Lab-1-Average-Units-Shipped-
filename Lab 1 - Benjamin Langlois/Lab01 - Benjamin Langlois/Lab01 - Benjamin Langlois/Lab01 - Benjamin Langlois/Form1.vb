' Name: Benjamin Langlois 100716077
' File Name: Lab01 - Benjamin Langlois
' Course: NETD-2202-01
' Date: 2019-01-25
' Desc: This program is to gather the units shipped each day for seven days while listing them in a text box and then once the seventh day is inputted it will find the average of the 
'       inputs and display the average through a labal at the bottom of the form.



Public Class frmAverageUnitsShipped
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim dayCount As Integer = 1 ' Declares int dayCount and assigns it the value of 1
    Dim averageUnits As Double ' Declares double averageUnits

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim unitInput As Integer = 0 ' Declares int unitInput and assigns it the value of 0
        Dim validInput As Boolean ' declares boolean variable validInput 

        If dayCount >= 7 Then ' Checking to see if its exceeding 7 days

            ' If the day count exceeds 7 days
            btnEnter.Enabled = False ' disables enter button
            txtUnitInput.Enabled = False ' disables input text box
            averageUnits /= 7 ' divides sum of all inputs by 7

            lblResults.Text = "Average per day: " + Math.Round((averageUnits), 2).ToString ' rounds the final result and displays it to lblResults
        End If

        Try
            unitInput = CInt(Int(txtUnitInput.Text)) ' trying to convert it into an integer
            validInput = True ' if it can convert it makes validInput true

        Catch ex As Exception ' if the input cant be converted to an integer

            MessageBox.Show("ERROR: User must enter whole number") ' Displays error code prompting user to input a whole number
            validInput = False ' assigns the validInput to false

        End Try

        If validInput = True Then ' If the input is valid
            averageUnits += unitInput ' adds to averageUnits
            txtResultList.Text += unitInput.ToString ' adds unitInput to the text box
            txtResultList.Text += vbCrLf ' adds the line break

            If dayCount < 7 Then ' if dayCount is less then 7
                dayCount += 1 ' increase by 1
                lblDayCount.Text = "day " + dayCount.ToString ' Displays the results
            End If
        End If

        txtUnitInput.Text = "" ' resets the input text box
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'This button resets all of the dynamic controls of the form
        txtUnitInput.Text = "" 'Clears the Unit Input text box
        lblDayCount.Text = "Day 1" 'Resets the Day Count label to "Day 1"
        txtResultList.Text = "" 'Clears the Result List text box
        lblResults.Text = "" 'Clears the Results label
        txtUnitInput.Enabled = True ' re-enables the Input box
        txtUnitInput.Focus() ' Focuses on input box
        dayCount = 1 ' Resets day count variable to 0

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit() 'Closes the form
    End Sub
End Class
