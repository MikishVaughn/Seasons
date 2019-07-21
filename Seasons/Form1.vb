Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set up arrays to store Season names and dates
        Dim SeasonName As String() = {"Spring", "Summer", "Autumn", "Winter"}
        Dim SeasonDate As Date() = {Date.Now(), Date.Now(), Date.Now(), Date.Now()}

        Dim targetYear As Integer = Date.Now().Year

        ' The 'Hour' returned depends whether the user is currently using DST and whether the target Season date will be using DST.
        '
        ' First we determine if we are currently using DST...and subtract and set DST_Adjustmet to subtract an hour if needed. 
        ' Later in the loop, we will detrmine if the target Season uses DST and adjust accordingly.
        Dim DST_Adjustment As Integer
        If Date.Now().IsDaylightSavingTime Then
            DST_Adjustment = -1 ' Is DST
        Else
            DST_Adjustment = 0 ' Not DST
        End If

        ' Get the DST adjusted Time zone Offset
        Dim tz_Offset As Integer = TimeZone.CurrentTimeZone.GetUtcOffset(Date.Now()).TotalHours + DST_Adjustment

        Dim count = 0
        Do While count < 4

            DST_Adjustment = -1
            SeasonDate(count) = Seasons.GetUtcSeasonDate(SeasonName(count), targetYear, tz_Offset + DST_Adjustment)

            ' Call GetUTCSeasonDate again to adjust for DST if necessary.
            ' (DST check within loop to see if adjustment for DST to the Season date is necessary)
            If SeasonDate(count).IsDaylightSavingTime Then
                DST_Adjustment = 0
                SeasonDate(count) = Seasons.GetUtcSeasonDate(SeasonName(count), targetYear, tz_Offset + DST_Adjustment)
            End If

            ' Call GetUTCSeasonDate again to use next year's Season Date if beyon current year's date.
            If SeasonDate(count) < Date.Now() Then
                SeasonDate(count) = Seasons.GetUtcSeasonDate(SeasonName(count), targetYear + 1, tz_Offset + DST_Adjustment)
            End If

            ' Get date for next Season...
            count += 1

        Loop
        Dim b As Date = (Date.Now().ToUniversalTime)
        Dim a As Date = DateTime.Now()


        'lbl_Timezone.Text = b.Subtract(a).TotalHours
        tb_Year.Text = targetYear
        tb_Spring.Text = SeasonDate(0).ToString
        tb_Summer.Text = SeasonDate(1).ToString
        tb_Autumn.Text = SeasonDate(2).ToString
        tb_Winter.Text = SeasonDate(3).ToString

    End Sub

End Class