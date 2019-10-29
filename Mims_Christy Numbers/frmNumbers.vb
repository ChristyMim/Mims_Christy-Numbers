Public Class frmNumbers
    'Program: Numbers
    'Programmer: Christy Mims
    'Date: 3/29/17
    'Description:  This program allows the user to input data and calculate the information.  The program does this through the use
    'of Subrouteans, Functions, Do while and until loops, masked text boxes, list boxes, message boxes, and inputboxes.
    Private Sub btnEnterNumbers_Click(sender As Object, e As EventArgs) Handles btnEnterNumbers.Click
        'The event procedure where all the data is sent to.
        Dim sum As Double = 0, average As Double = 0, min As Double = 0, max As Double = 0

        If mtbQuantity.Text = "" Then
            MessageBox.Show("Please specify the quantity of numbers that you wish to enter.", "Error")
            mtbQuantity.Focus()
        Else
            lstOutput.Items.Clear()
            Call GetNumbersAndStats(sum, average, min, max)
            Call DisplayOutput(sum, average, min, max)
        End If
    End Sub
    Sub GetNumbersAndStats(ByRef sum As Double, ByRef average As Double, ByRef min As Double, ByRef max As Double)
        'Calculates and sends the data to the event procedure.
        Dim quantity As Integer = CInt(mtbQuantity.Text)
        Dim num, count As Double

        count = 1
        Do While count <= quantity
            num = get_a_number(count)
            If count = 1 Then
                max = num
                min = num
            Else
                If num > max Then
                    max = num
                End If
                If num < min Then
                    min = num
                End If
            End If
            sum = sum + num
            count = count + 1
        Loop

        average = sum / quantity

    End Sub

    Function get_a_number(count As Integer) As Double
        'This function gathers the data and passes to sub GetNumbersAndStats.
        Dim num As String

        Do
            num = InputBox("Enter number " & count.ToString, "Input")
        Loop Until is_nonnegative_number(num)

        Return CDbl(num)

    End Function

    Function is_nonnegative_number(num As String) As Boolean
        'Function determines if number is nonnegative.
        Dim valid As Boolean = False
        If IsNumeric(num) Then
            If CDbl(num) >= 0 Then
                valid = True
            End If
        End If
        Return valid
    End Function

    Sub DisplayOutput(ByVal sum As Double, ByVal average As Double, ByVal min As Double, ByVal max As Double)
        'Copies and sends the information to event procedure to display in the list box.
        lstOutput.Items.Add("Sum: " & sum)
        lstOutput.Items.Add("Average: " & Math.Round(average, 0))
        lstOutput.Items.Add("Minimum: " & min)
        lstOutput.Items.Add("Maximum: " & max)
    End Sub
End Class
