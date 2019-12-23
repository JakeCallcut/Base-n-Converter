﻿Public Class basenconverter

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

        Dim counter As Integer
        Dim i As Integer
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

        Dim input As String = ""
        input = txtin.Text
        ReDim Preserve inarray(input.Length())                                      'shortens array

        For counter = 0 To input.Length() - 1                                               'populates array
            inarray(counter) = input.Substring(counter, 1)
        Next counter


        If inputtype = "dec" Then

            If outputtype = "dec" Then
                Dim output As Integer
                output = input
                rhtxtout.Text = output
            ElseIf outputtype = "hex" Then

            ElseIf outputtype = "bin" Then
                Dim output As String = ""
                Dim remaining As Integer
                remaining = input

                Do While remaining <> 0

                    If remaining Mod 2 = 1 Then
                        output = output & "1"
                        remaining = remaining \ 2
                    ElseIf remaining Mod 2 = 0 Then
                        output = output & "0"
                        remaining = remaining \ 2
                    End If

                Loop

                If output.Length() < 8 Then
                    Dim leading0s As Integer
                    leading0s = 8 - output.Length()

                    For i = 1 To leading0s
                        output = "0" & output
                    Next

                    rhtxtout.Text = output
                Else
                    rhtxtout.Text = output
                End If

            End If

        ElseIf inputtype = "hex" Then

            If outputtype = "hex" Then
                Dim output As String
                output = input
                rhtxtout.Text = output
            ElseIf outputtype = "dec" Then

            End If

        ElseIf inputtype = "bin" Then

            If outputtype = "bin" Then
                Dim output As Integer
                output = input
                rhtxtout.Text = output
            ElseIf outputtype = "hex" Then                                     'bin to hex

                Dim inhalf1 As String
                Dim inhalf2 As String
                Dim outhalf1 As String = ""
                Dim outhalf2 As String = ""
                Dim totalcount As Integer
                Dim output As String = ""
                Dim hexrep(16) As Char                                         'populates hexadecimal representatives
                hexrep(1) = "1"
                hexrep(2) = "2"
                hexrep(3) = "3"
                hexrep(4) = "4"
                hexrep(5) = "5"
                hexrep(6) = "6"
                hexrep(7) = "7"
                hexrep(8) = "8"
                hexrep(9) = "9"
                hexrep(10) = "A"
                hexrep(11) = "B"
                hexrep(12) = "C"
                hexrep(13) = "D"
                hexrep(14) = "E"
                hexrep(15) = "F"

                Dim binaryrep(8) As Integer                                 'populates binary representatives
                binaryrep(1) = 1
                binaryrep(2) = 2
                binaryrep(3) = 4
                binaryrep(4) = 8
                binaryrep(5) = 16
                binaryrep(6) = 32
                binaryrep(7) = 64
                binaryrep(8) = 128

                inhalf1 = input.Substring(0, 4)
                inhalf2 = input.Substring(4, 4)

                For i = 1 To inhalf1.Length

                    If inhalf1.Substring(inhalf1.Length - i, 1) = "1" Then

                        totalcount = totalcount + binaryrep(i)

                    ElseIf input.Substring(inhalf1.Length - i, 1) = "0" Then

                    End If
                    outhalf1 = hexrep(totalcount)
                Next i

                totalcount = 0

                For index = 1 To inhalf2.Length

                    If inhalf2.Substring(inhalf2.Length - index, 1) = "1" Then

                        totalcount = totalcount + binaryrep(index)

                    ElseIf input.Substring(inhalf2.Length - index, 1) = "0" Then

                    End If
                    outhalf2 = hexrep(totalcount)
                Next index

                output = outhalf1 & outhalf2
                rhtxtout.Text = output

            ElseIf outputtype = "dec" Then                                  'dec to bin

                Dim output As Integer
                Dim binaryrep(8) As Integer                                 'populates binary representatives
                binaryrep(1) = 1
                binaryrep(2) = 2
                binaryrep(3) = 4
                binaryrep(4) = 8
                binaryrep(5) = 16
                binaryrep(6) = 32
                binaryrep(7) = 64
                binaryrep(8) = 128

                For i = 1 To input.Length
                    If input.Substring(input.Length - i, 1) = "1" Then

                        output = output + binaryrep(i)

                    ElseIf input.Substring(input.Length - i, 1) = "0" Then

                    End If
                Next i

                rhtxtout.Text = output

            End If

        End If


    End Sub

    Private Sub btnclr_Click(sender As Object, e As EventArgs) Handles btnclr.Click

        txtin.Text = ""
        rhtxtout.Text = ""

    End Sub
End Class