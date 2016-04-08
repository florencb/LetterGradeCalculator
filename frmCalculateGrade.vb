Public Class frmCalculateGrade


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'this is the button calculate event listener
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'creates variable that will hold letter grade
        'converts the data type to a decimal data type
        Dim numberGrade As Decimal = CDec(txtNumberGrade.Text)

        'declares and initializes a variable that will hold the letter grade 
        Dim letterGrade As String = " "

        'takes number grade input and assigns it the appropiate letter
        If numberGrade >= 88 Then
            letterGrade = "A"
        ElseIf numberGrade >= 80 AndAlso numberGrade <= 87 Then
            letterGrade = "B"
        ElseIf numberGrade >= 68 AndAlso numberGrade <= 79 Then
            letterGrade = "C"
        ElseIf numberGrade >= 60 AndAlso numberGrade <= 67 Then
            letterGrade = "D"
        Else
            letterGrade = "F"
        End If

        ' displays letter grade in the letter grade text box
        txtLetterGrade.Text = letterGrade

        ' moves focus back to number grade text box
        txtNumberGrade.Select()
    End Sub

    Private Sub txtNumberGrade_TextChanged(sender As Object, e As EventArgs) Handles txtNumberGrade.TextChanged
       
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' closes when exit is clicked
        Me.Close()
    End Sub

    Private Sub EsleIf(p1 As Boolean)
        Throw New NotImplementedException
    End Sub

End Class
