Public Class Form1
    Function smallest(list1() As Integer) As Integer
        'inputs list
        'returns position of smallest integer in array
        Dim intPosition As Integer
        Dim intSmallest As Integer = list1(0)
        For Each i As Integer In list1
            If i <= intSmallest Then
                intSmallest = i
                intPosition = Array.IndexOf(list1, i)
            End If

        Next

        Return intPosition


    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Sort.Click
        Dim result As String = String.Join(",", sort1(ReadInput()))
        txtOutput.Text = result

    End Sub

    Function ReadInput() As Integer()
        'Converts string text to integer array
        Dim s As String = txtInput.Text
        Dim numberstring As String() = s.Split(",")
        Dim intArray As Integer() = Array.ConvertAll(numberstring, Function(str) _
            Int32.Parse(Str))

        Return intArray

    End Function

    Function newlist(intOldList() As Integer) As _
        (intNewList1 As Integer(), smallestValue As Integer)
        'input list, returns a tuple containing :(1)new list 
        'less Index zero element (2) smallest value
        Dim intNewList1(intOldList.Length - 2) As Integer
        For i = 1 To (intOldList.Length - 1)
            intNewList1(i - 1) = intOldList(i)
        Next
        Return (intNewList1, intOldList(0))
    End Function

    Function Swap(intPosition As Integer, list1() As Integer) As Integer()
        'input position and list
        'swaps smallest value to position zero, 
        'position zero value==>swapped integer position
        'returns list with smallest at zero index position

        Dim intTempA As Integer = list1(0)
        Dim intTempB As Integer = list1(intPosition)
        Dim intList2 As Integer() = list1
        intList2(intPosition) = intTempA
        intList2(0) = intTempB

        Return intList2

    End Function

    Function sort1(intList1 As Integer()) As Integer()
        'main function to run
        Dim intSortedList(intList1.Length - 1) As Integer

        For i = 0 To (intList1.Length - 1)
            Dim intA As Integer = smallest(intList1)
            Dim intB As Integer() = Swap(intA, intList1)
            intList1 = newlist(intB).intNewList1 'new list without zero index integer
            intSortedList(i) = newlist(intB).smallestValue
            ' appends smallest to new list

        Next

        Return intSortedList


    End Function

End Class
