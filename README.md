# Seasons - Equinox and Solstices
**Seasons** is an _example_ of the _Visual Basic_ function: **GetUtcSeasonDate({Season}, {targetYear}, {TZ_Offset})**.*

The [function](https://github.com/MikishVaughn/Seasons/blob/master/Seasons/Seasons.vb) returns the requested Equinox and Solstice dates, which represent the starting date and time of the requested Season.  


**Quick Usage examples:** GetUtcSeasonDate( {Season AS String}, {targetYear AS Integer Integer}, {TZ_Offset AS} )
  
      SeasonDate = GetUtcSeasonDate("Spring", 2018, -1)
      SeasonDate = GetUtcSeasonDate("Winter", 2021, -7)


*_GetUtcSeasonDate() based on the formulas of Jean Meeus from the book Astronomical Algorithms._

Visit the [Seasons Wiki](https://github.com/MikishVaughn/Seasons/wiki) for a more detailed information.
