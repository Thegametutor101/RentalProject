Public Class ControllerDates

    Shared instance As ControllerDates = Nothing

    Public Shared Function getInstance() As ControllerDates
        If IsNothing(instance) Then
            instance = New ControllerDates()
        End If
        Return instance
    End Function

    Public Function isValidReturnDate(returnDate As Date) As Boolean
        Dim returnDayOfWeek As DayOfWeek = returnDate.DayOfWeek
        Dim returnDayOfYear As Integer = returnDate.DayOfYear
        Dim isLeapYear As Boolean = DateTime.IsLeapYear(returnDate.Year)
        Dim returnMonth As Integer = returnDate.Month
        If returnDayOfWeek = DayOfWeek.Saturday Or returnDayOfWeek = DayOfWeek.Sunday Then
            Return False
        End If
        Select Case returnMonth
            Case 1
                If returnDayOfYear = 1 Then
                    Return False
                End If
            Case 12
                Dim leap As Integer = 0
                If isLeapYear Then
                    leap = 1
                End If
                If returnDayOfYear = (365 + leap) Then
                    Return False
                End If
                If returnDayOfYear = (359 + leap) Then
                    Return False
                End If
                If returnDayOfYear = (358 + leap) Then
                    Return False
                End If
        End Select
        Return True
    End Function
End Class
