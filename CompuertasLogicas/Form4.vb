Public Class Form4
    Public Function clean()
        For i As Integer = 0 To 12
            For X As Integer = 0 To 31
                resultados(i, X) = Nothing
            Next
        Next
    End Function

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clean()
        Dim aa, eee

        If A_Neg Then
            aa = "A" + Char.ConvertFromUtf32(773)
        Else
            aa = "A"
        End If

        If E_Neg Then
            eee = "E" + Char.ConvertFromUtf32(773)
        Else
            eee = "E"
        End If
        If signos(0, 1) = "-" Then
            a = "- ( A " & signos(0, 0) & " B ) "
        Else
            a = "( A " & signos(0, 0) & " B ) "
        End If

        If signos(2, 1) = "-" Then
            b = "- [" & a & " " & signos(2, 0) & " " & aa & " ] "
        Else
            b = "[" & a & " " & signos(2, 0) & " " & aa & " ] "
        End If

        If signos(1, 1) = "-" Then
            c = "- ( C " & signos(1, 0) & " D )"
        Else
            c = "( C " & signos(1, 0) & " D )"
        End If
        If signos(3, 1) = "-" Then
            d = "- [ " & a & " " & signos(3, 0) & " " & c & " ]"
        Else
            d = "[ " & a & " " & signos(3, 0) & " " & c & " ]"
        End If
        If signos(4, 1) = "-" Then
            ee = "- { " & b & " " & signos(4, 0) & " " & d & " }"
        Else
            ee = "{ " & b & " " & signos(4, 0) & " " & d & " }"
        End If

        If signos(5, 1) = "-" Then
            f = "-| " & ee & " " & signos(5, 0) & " {" & eee & "} |"
        Else
            f = ee & " " & signos(5, 0) & " {" & eee & "}"
        End If
        X = f

        Label1.Text = "X = " & X
        Label7.Text = "A" + Char.ConvertFromUtf32(773)
        Label8.Text = "E" + Char.ConvertFromUtf32(773) + Char.ConvertFromUtf32(773)
        Label9.Text = a
        Label10.Text = c
        Label11.Text = d
        Label12.Text = b
        Label13.Text = ee
        Label14.Text = f

        Dim uno As Boolean = True
        For i As Integer = 1 To 32
            If i <= 16 Then
                resultados(0, i - 1) = 0
                resultados(5, i - 1) = 1
                Label2.Text = Label2.Text & vbCrLf & "0"
                Label7.Text = Label7.Text & vbCrLf & "1"
            Else
                resultados(0, i - 1) = 1
                resultados(5, i - 1) = 0
                Label2.Text = Label2.Text & vbCrLf & "1"
                Label7.Text = Label7.Text & vbCrLf & "0"
            End If

            If i <= 8 Then
                resultados(1, i - 1) = 0
                Label3.Text = Label3.Text & vbCrLf & "0"
            ElseIf i <= 16 Then
                Label3.Text = Label3.Text & vbCrLf & "1"
                resultados(1, i - 1) = 1
            ElseIf i <= 24 Then
                Label3.Text = Label3.Text & vbCrLf & "0"
                resultados(1, i - 1) = 0
            Else
                Label3.Text = Label3.Text & vbCrLf & "1"
                resultados(1, i - 1) = 1

            End If

            If i <= 4 Then
                Label4.Text = Label4.Text & vbCrLf & "0"
                resultados(2, i - 1) = 0
            ElseIf i <= 8 Then
                Label4.Text = Label4.Text & vbCrLf & "1"
                resultados(2, i - 1) = 1
            ElseIf i <= 12 Then
                Label4.Text = Label4.Text & vbCrLf & "0"
                resultados(2, i - 1) = 0
            ElseIf i <= 16 Then
                Label4.Text = Label4.Text & vbCrLf & "1"
                resultados(2, i - 1) = 1
            ElseIf i <= 20 Then
                Label4.Text = Label4.Text & vbCrLf & "0"
                resultados(2, i - 1) = 0
            ElseIf i <= 24 Then
                Label4.Text = Label4.Text & vbCrLf & "1"
                resultados(2, i - 1) = 1
            ElseIf i <= 28 Then
                Label4.Text = Label4.Text & vbCrLf & "0"
                resultados(2, i - 1) = 0
            ElseIf i <= 32 Then
                Label4.Text = Label4.Text & vbCrLf & "1"
                resultados(2, i - 1) = 1
            End If

            If i <= 2 Then
                Label5.Text = Label5.Text & vbCrLf & "0"
                resultados(3, i - 1) = 0

            ElseIf i <= 4 Then
                Label5.Text = Label5.Text & vbCrLf & "1"
                resultados(3, i - 1) = 1
            ElseIf i <= 6 Then
                Label5.Text = Label5.Text & vbCrLf & "0"
                resultados(3, i - 1) = 0
            ElseIf i <= 8 Then
                Label5.Text = Label5.Text & vbCrLf & "1"
                resultados(3, i - 1) = 1
            ElseIf i <= 10 Then
                Label5.Text = Label5.Text & vbCrLf & "0"
                resultados(3, i - 1) = 0
            ElseIf i <= 12 Then
                Label5.Text = Label5.Text & vbCrLf & "1"
                resultados(3, i - 1) = 1
            ElseIf i <= 14 Then
                Label5.Text = Label5.Text & vbCrLf & "0"
                resultados(3, i - 1) = 0
            ElseIf i <= 16 Then
                Label5.Text = Label5.Text & vbCrLf & "1"
                resultados(3, i - 1) = 1
            ElseIf i <= 18 Then
                Label5.Text = Label5.Text & vbCrLf & "0"
                resultados(3, i - 1) = 0
            ElseIf i <= 20 Then
                Label5.Text = Label5.Text & vbCrLf & "1"
                resultados(3, i - 1) = 1
            ElseIf i <= 22 Then
                Label5.Text = Label5.Text & vbCrLf & "0"
                resultados(3, i - 1) = 0
            ElseIf i <= 24 Then
                Label5.Text = Label5.Text & vbCrLf & "1"
                resultados(3, i - 1) = 1
            ElseIf i <= 26 Then
                Label5.Text = Label5.Text & vbCrLf & "0"
                resultados(3, i - 1) = 0
            ElseIf i <= 28 Then
                Label5.Text = Label5.Text & vbCrLf & "1"
                resultados(3, i - 1) = 1
            ElseIf i <= 30 Then
                Label5.Text = Label5.Text & vbCrLf & "0"
                resultados(3, i - 1) = 0
            ElseIf i <= 32 Then
                Label5.Text = Label5.Text & vbCrLf & "1"
                resultados(3, i - 1) = 1

            End If


            If uno Then
                Label6.Text = Label6.Text & vbCrLf & "0"
                Label8.Text = Label8.Text & vbCrLf & "1"
                resultados(4, i - 1) = 0
                resultados(6, i - 1) = 1
                uno = False
            Else
                Label6.Text = Label6.Text & vbCrLf & "1"
                Label8.Text = Label8.Text & vbCrLf & "0"
                resultados(4, i - 1) = 1
                resultados(6, i - 1) = 0
                uno = True
            End If
        Next

        For i As Integer = 1 To 32
            Dim results As Integer
            If signos(0, 1) = "-" Then
                If signos(0, 0) = "+" Then
                    If resultados(0, i - 1) Or resultados(1, i - 1) Then
                        resultados(7, i - 1) = 0
                    Else
                        resultados(7, i - 1) = 1
                    End If
                Else
                    If resultados(0, i - 1) And resultados(1, i - 1) Then
                        resultados(7, i - 1) = 0
                    Else
                        resultados(7, i - 1) = 1
                    End If
                End If
            Else
                If signos(0, 0) = "+" Then
                    If resultados(0, i - 1) Or resultados(1, i - 1) Then
                        resultados(7, i - 1) = 1
                    Else
                        resultados(7, i - 1) = 0
                    End If
                Else
                    If resultados(0, i - 1) And resultados(1, i - 1) Then
                        resultados(7, i - 1) = 1
                    Else
                        resultados(7, i - 1) = 0
                    End If
                End If
            End If
            If resultados(7, i - 1) Then
                results = "1"
            Else
                results = "0"
            End If
            Label9.Text = Label9.Text & vbCrLf & results
        Next

        For i As Integer = 1 To 32
            Dim results As Integer
            If signos(1, 1) = "-" Then
                If signos(1, 0) = "+" Then
                    If resultados(2, i - 1) Or resultados(3, i - 1) Then
                        resultados(8, i - 1) = 0
                    Else
                        resultados(8, i - 1) = 1
                    End If
                Else
                    If resultados(2, i - 1) And resultados(3, i - 1) Then
                        resultados(8, i - 1) = 0
                    Else
                        resultados(8, i - 1) = 1
                    End If
                End If
            Else
                If signos(1, 0) = "+" Then
                    If resultados(2, i - 1) Or resultados(3, i - 1) Then
                        resultados(8, i - 1) = 1
                    Else
                        resultados(8, i - 1) = 0
                    End If
                Else
                    If resultados(2, i - 1) And resultados(3, i - 1) Then
                        resultados(8, i - 1) = 1
                    Else
                        resultados(8, i - 1) = 0
                    End If
                End If
            End If
            If resultados(8, i - 1) Then
                results = "1"
            Else
                results = "0"
            End If
            Label10.Text = Label10.Text & vbCrLf & results
        Next
        ''''
        For i As Integer = 1 To 32
            Dim results As Integer
            If signos(3, 1) = "-" Then
                If signos(3, 0) = "+" Then
                    If resultados(7, i - 1) Or resultados(8, i - 1) Then
                        resultados(9, i - 1) = 0
                    Else
                        resultados(9, i - 1) = 1
                    End If
                Else
                    If resultados(7, i - 1) And resultados(8, i - 1) Then
                        resultados(9, i - 1) = 0
                    Else
                        resultados(9, i - 1) = 1
                    End If
                End If
            Else
                If signos(3, 0) = "+" Then
                    If resultados(7, i - 1) Or resultados(8, i - 1) Then
                        resultados(9, i - 1) = 1
                    Else
                        resultados(9, i - 1) = 0
                    End If
                Else
                    If resultados(7, i - 1) And resultados(8, i - 1) Then
                        resultados(9, i - 1) = 1
                    Else
                        resultados(9, i - 1) = 0
                    End If
                End If
            End If
            If resultados(9, i - 1) Then
                results = "1"
            Else
                results = "0"
            End If
            Label11.Text = Label11.Text & vbCrLf & results
        Next

        ''''
        For i As Integer = 1 To 32
            Dim results As Integer
            Dim cualA As Integer
            If A_Neg Then
                cualA = 5
            Else
                cualA = 0
            End If
            If signos(2, 1) = "-" Then
                If signos(2, 0) = "+" Then
                    If resultados(7, i - 1) Or resultados(cualA, i - 1) Then
                        resultados(10, i - 1) = 0
                    Else
                        resultados(10, i - 1) = 1
                    End If
                Else
                    If resultados(7, i - 1) And resultados(cualA, i - 1) Then
                        resultados(10, i - 1) = 0
                    Else
                        resultados(10, i - 1) = 1
                    End If
                End If
            Else
                If signos(2, 0) = "+" Then
                    If resultados(7, i - 1) Or resultados(cualA, i - 1) Then
                        resultados(10, i - 1) = 1
                    Else
                        resultados(10, i - 1) = 0
                    End If
                Else
                    If resultados(7, i - 1) And resultados(cualA, i - 1) Then
                        resultados(10, i - 1) = 1
                    Else
                        resultados(10, i - 1) = 0
                    End If
                End If
            End If
            If resultados(10, i - 1) Then
                results = "1"
            Else
                results = "0"
            End If
            Label12.Text = Label12.Text & vbCrLf & results
        Next
        ''
        For i As Integer = 1 To 32
            Dim results As Integer
            If signos(4, 1) = "-" Then
                If signos(4, 0) = "+" Then
                    If resultados(10, i - 1) Or resultados(9, i - 1) Then
                        resultados(11, i - 1) = 0
                    Else
                        resultados(11, i - 1) = 1
                    End If
                Else
                    If resultados(10, i - 1) And resultados(9, i - 1) Then
                        resultados(11, i - 1) = 0
                    Else
                        resultados(11, i - 1) = 1
                    End If
                End If
            Else
                If signos(4, 0) = "+" Then
                    If resultados(10, i - 1) Or resultados(9, i - 1) Then
                        resultados(11, i - 1) = 1
                    Else
                        resultados(11, i - 1) = 0
                    End If
                Else
                    If resultados(10, i - 1) And resultados(9, i - 1) Then
                        resultados(11, i - 1) = 1
                    Else
                        resultados(11, i - 1) = 0
                    End If
                End If
            End If
            If resultados(11, i - 1) Then
                results = "1"
            Else
                results = "0"
            End If
            Label13.Text = Label13.Text & vbCrLf & results
        Next

        ''''
        For i As Integer = 1 To 32
            Dim results As Integer
            Dim cualE As Integer
            If E_Neg Then
                cualE = 6
            Else
                cualE = 4
            End If
            If signos(5, 1) = "-" Then
                If signos(5, 0) = "+" Then
                    If resultados(11, i - 1) Or resultados(cualE, i - 1) Then
                        resultados(12, i - 1) = 0
                    Else
                        resultados(12, i - 1) = 1
                    End If
                Else
                    If resultados(11, i - 1) And resultados(cualE, i - 1) Then
                        resultados(12, i - 1) = 0
                    Else
                        resultados(12, i - 1) = 1
                    End If
                End If
            Else
                If signos(5, 0) = "+" Then
                    If resultados(11, i - 1) Or resultados(cualE, i - 1) Then
                        resultados(12, i - 1) = 1
                    Else
                        resultados(12, i - 1) = 0
                    End If
                Else
                    If resultados(11, i - 1) And resultados(cualE, i - 1) Then
                        resultados(12, i - 1) = 1
                    Else
                        resultados(12, i - 1) = 0
                    End If
                End If
            End If
            If resultados(12, i - 1) Then
                results = "1"
            Else
                results = "0"
            End If
            Label14.Text = Label14.Text & vbCrLf & results
        Next
        'Label1.Text = "This label contains an " + Char.ConvertFromUtf32(773) + " overscore" + Char.ConvertFromUtf32(773)
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class