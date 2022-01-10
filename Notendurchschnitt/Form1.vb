Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim durchschnitt As String
        Dim notenanzahl As Integer
        Dim noten As New List(Of String)
        Dim tmp1 As Integer
        Dim trennzeichen As String

        If RadioButton1.Checked = True Then
            trennzeichen = ";"
        End If
        If RadioButton2.Checked = True Then
            trennzeichen = ","
        End If



        noten = MaskedTextBox1.Text.Split(trennzeichen).ToList
        notenanzahl = noten.Count

        If Not notenanzahl = 0 Then
            Try
                For Each note In noten
                    tmp1 = tmp1 + note
                Next

                durchschnitt = tmp1 / notenanzahl

                Label2.Text = "Druchschnitt: " & durchschnitt
            Catch ex As Exception
                Label2.Text = "Druchschnitt: Berechnungsfehler"
                MsgBox("Berechnungsfehler. Haben Sie die richtige Trennoption ausgewählt?", vbCritical, Me.Text)
            End Try

        Else
            MsgBox("Keine Daten zum berechnen", vbExclamation, Me.Text)
            Label2.Text = "Druchschnitt: keine Daten"
        End If

    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Me.TopMost = CheckBox1.Checked
    End Sub
End Class
