Public Class basenconverter

    'cmbxin.Items.Add("Decimal")
    'cmbxin.Items.Add("Hexadecimal")
    'cmbxin.Items.Add("Binary")

    'cmbxout.Items.Add("Decimal")
    'cmbxout.Items.Add("Hexadecimal")
    'cmbxout.Items.Add("Binary")

    Private Sub btnconvert_Click(sender As Object, e As EventArgs) Handles btnconvert.Click

        Dim inputtype As String
        Dim outputtype As String
        Dim inarray(999) As Char
        Dim outarray(999) As Char

        Dim counter As Integer
        Dim index As Integer

        If cmbxin.SelectedIndex() = 0 Then
            inputtype = "dec"
        ElseIf cmbxin.SelectedIndex() = 1 Then
            inputtype = "hex"
        ElseIf cmbxin.SelectedIndex() = 2 Then
            inputtype = "bin"
        End If

        If cmbxout.SelectedIndex() = 0 Then
            outputtype = "dec"
        ElseIf cmbxout.SelectedIndex() = 1 Then
            outputtype = "hex"
        ElseIf cmbxout.SelectedIndex() = 2 Then
            outputtype = "bin"
        End If

        If inputtype = "dec" Then

        End If


    End Sub
End Class
