Public Class basenconverter

    'cmbxin.Items.Add("Decimal")
    'cmbxin.Items.Add("Hexadecimal")
    'cmbxin.Items.Add("Binary")

    'cmbxout.Items.Add("Decimal")
    'cmbxout.Items.Add("Hexadecimal")
    'cmbxout.Items.Add("Binary")

    Private Sub btnconvert_Click(sender As Object, e As EventArgs) Handles btnconvert.Click

        Dim inputtype As String = ""
        Dim outputtype As String = ""
        Dim inarray(999) As Char
        Dim outarray(999) As Char
        Dim input As String = ""
        Dim output As String = ""

        Dim counter As Integer
        Dim index As Integer

        If cmbxin.SelectedIndex() = 0 Then                                  'collects input type
            inputtype = "dec"
        ElseIf cmbxin.SelectedIndex() = 1 Then
            inputtype = "hex"
        ElseIf cmbxin.SelectedIndex() = 2 Then
            inputtype = "bin"
        End If

        If cmbxout.SelectedIndex() = 0 Then                                         'collects output type
            outputtype = "dec"
        ElseIf cmbxout.SelectedIndex() = 1 Then
            outputtype = "hex"
        ElseIf cmbxout.SelectedIndex() = 2 Then
            outputtype = "bin"
        End If

        input = txtin.Text
        ReDim Preserve inarray(input.Length())                                      'shortens array

        For counter = 0 To input.Length() - 1                                               'populates array
            inarray(counter) = input.Substring(counter, 1)
        Next


        If inputtype = "dec" Then

            If outputtype = "dec" Then
                output = input
                rhtxtout.Text = output
            ElseIf outputtype = "hex" Then

            End If

        ElseIf inputtype = "hex" Then

            If outputtype = "hex" Then
                output = input
                rhtxtout.Text = output
            End If

        ElseIf inputtype = "bin" Then

            If outputtype = "bin" Then
                output = input
                rhtxtout.Text = output
            End If

        End If


    End Sub
End Class
