Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim tz_Offset As Double = TimeZone.CurrentTimeZone.GetUtcOffset(Date.Now()).TotalHours - 1
        Dim year As Integer = 2019

        tb_Spring.Text = Seasons.GetUtcSeasonDate("Spring", year, tz_Offset).ToString
        tb_Summer.Text = Seasons.GetUtcSeasonDate("Summer", year, tz_Offset).ToString
        tb_Autumn.Text = Seasons.GetUtcSeasonDate("Autumn", year - 1, tz_Offset).ToString
        tb_Winter.Text = Seasons.GetUtcSeasonDate("Winter", year - 1, tz_Offset).ToString

    End Sub
End Class