Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close() 'closes the form
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears all of the text in the textboxes/answer
        txtWeek1.Text = ""
        txtWeek2.Text = ""
        txtWeek3.Text = ""
        txtWeek4.Text = ""
        txtWeek5.Text = ""
        lblAnswer.Text = ""
        ToolStripStatusLabel1.Text = ""
    End Sub
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim week1 As Double 'Initializing all of the variabled needed
        Dim week2 As Double
        Dim week3 As Double
        Dim week4 As Double
        Dim week5 As Double
        Dim average As Double


        'Using If Then Else to check for certain values in the entered text
        If IsNumeric(txtWeek1.Text) And (-50 < txtWeek1.Text < 130) Then
            week1 = CDbl(txtWeek1.Text)

        Else
            ToolStripStatusLabel1.Text = ""
        End If

        average = (week1 + week2 + week3 + week4 + week5) / 5 ' calculating the answer
        lblAnswer.Text = average
    End Sub

End Class
