' Name:         Wedding Project
' Purpose:      Displays the number of tables needed.
' Programmer:   Austin Parker Jan 29th, 2020

Option Explicit On
Option Strict Off
Option Infer Off

Public Class frmMain

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        ' Calculate and display the number of required tables.
        Dim dblGuests As Double
        Const dblTABLE As Double = 8
        Dim dblTotalTables As Double

        'Parse text input to double for calculation with IF statement below.
        Double.TryParse(txtGuests.Text, dblGuests)

        'Calculates how many tables needed based on guest count.
        If dblGuests >= 1 Then
            dblTotalTables = dblGuests / dblTABLE
        End If

        'Converts double number of guests to a String and sends to lblRound
        lblRound.Text = dblTotalTables.ToString()

        'Rounds up dblTotalTables
        lblRound.Text = Math.Ceiling(dblTotalTables)

        'Creates focus and selects all text for Guest input after calculating.
        txtGuests.Focus()
        txtGuests.SelectAll()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblRound_Click(sender As Object, e As EventArgs) Handles lblRound.Click

    End Sub

    Private Sub txtGuests_TextChanged(sender As Object, e As EventArgs) Handles txtGuests.TextChanged

        lblRound.ResetText()

    End Sub

    Private Sub txtGuests_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGuests.KeyPress

        'Allows only numbers and backspace user input.
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
         e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

End Class
