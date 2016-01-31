Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PriceTxt_TextChanged(sender As Object, e As EventArgs) Handles PriceTxt.TextChanged
        'Declare x as a brand new integer
        Dim x As Integer
        Dim lstOut As Object = Nothing
        lstOut.Items.Add(x)
    End Sub

    Private Sub CreditsTxt_TextChanged(sender As Object, e As EventArgs) Handles CreditsTxt.TextChanged
        'Declare x as variable
        Dim x As Double
        Dim lstOut As Object = Nothing
        lstOut.Items.Add(x)
    End Sub

    Private Sub fstNameTxt_TextChanged(sender As Object, e As EventArgs) Handles fstNameTxt.TextChanged
        'Add myDble Variable
        Dim myDbl As Double
        Dim lstOut As Object = Nothing
        lstOut.Items.Add(myDbl)
    End Sub

    Private Sub LastNameTxt_TextChanged(sender As Object, e As EventArgs) Handles LastNameTxt.TextChanged
        'Declare x as Entry event Log
        Dim x As EntryWrittenEventArgs
        x = Nothing
    End Sub

    Private Sub LevelTxt_TextChanged(sender As Object, e As EventArgs) Handles LevelTxt.TextChanged
        'Declare x as entry written event logs
        Dim x As EntryWrittenEventArgs
        x = Nothing
    End Sub

    Private Sub items(x As EntryWrittenEventArgs)
        Throw New NotImplementedException()
    End Sub

    Private Sub CostBtn_Click(sender As Object, e As EventArgs) Handles CostBtn.Click
        'Declare myDbl
        Dim myDbl As Double
        myDbl = myDbl
    End Sub
End Class
