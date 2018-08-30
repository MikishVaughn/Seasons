Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SeasonName As String() = {"Spring", "Summer", "Autumn", "Winter"}
        Dim SeasonDate As Date() = {Date.Now(), Date.Now(), Date.Now(), Date.Now()}

        Dim targetYear As Integer = Date.Now().Year
        Dim DST_Adjustment As Integer = -1
        Dim tz_Offset As Integer = TimeZone.CurrentTimeZone.GetUtcOffset(Date.Now()).TotalHours - 1

        Dim count = 0
        Do While count < 4

            DST_Adjustment = -1
            SeasonDate(count) = Seasons.GetUtcSeasonDate(SeasonName(count), targetYear, tz_Offset + DST_Adjustment)

            ' Call GetUTCSeasonDate again to adjust for DST if necessary
            If SeasonDate(count).IsDaylightSavingTime Then
                DST_Adjustment = 0
                SeasonDate(count) = Seasons.GetUtcSeasonDate(SeasonName(count), targetYear, tz_Offset + DST_Adjustment)
            End If

            ' Call GetUTCSeasonDate again to use next year's Season Date if beyon current year's date.
            If SeasonDate(count) < Date.Now() Then
                SeasonDate(count) = Seasons.GetUtcSeasonDate(SeasonName(count), targetYear + 1, tz_Offset + DST_Adjustment)
            End If

            ' Get date for next Season...
            count = count + 1

        Loop

        tb_Year.Text = targetYear
        tb_Spring.Text = SeasonDate(0).ToString
        tb_Summer.Text = SeasonDate(1).ToString
        tb_Autumn.Text = SeasonDate(2).ToString
        tb_Winter.Text = SeasonDate(3).ToString

    End Sub

End Class