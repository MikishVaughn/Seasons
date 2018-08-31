# Seasons - Equinoxes and Solstices
**Seasons** is an _example_ of the _Visual Basic_ function: **GetUtcSeasonDate(Season, targetYear, tz_Offset)**.*

The [function](https://github.com/MikishVaughn/Seasons/blob/master/Seasons/Seasons.vb) returns the requested Equinox or Solstice date, which represents the starting date of the queried Season.  


**Quick Usage examples:** GetUtcSeasonDate( {season AS String}, {targetYear AS Integer Integer}, {tz_Offset AS} )
  
      SeasonDate = GetUtcSeasonDate("Spring", 2018, -1)
      SeasonDate = GetUtcSeasonDate("Winter", 2021, -7)
      SeasonDate = GetUtcSeasonDate("aUtmun", 1888, 0)



*_GetUtcSeasonDate() based on the formulas of Jean Meeus from the book Astronomical Algorithms._

Visit the [Seasons Wiki](https://github.com/MikishVaughn/Seasons/wiki) for a more detailed information.
