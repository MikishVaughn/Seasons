# Seasons - Equinoxes and Solstices
**Seasons** is a Windows Desktop _example_ of the included _Visual Basic_ function: **GetUtcSeasonDate(** _Season, targetYear, tz_Offset_ **)**.*

The [function](https://github.com/MikishVaughn/Seasons/blob/master/Seasons/Seasons.vb) returns the requested Equinox or Solstice date, which represents the starting date of the queried Season.  




### **Quick Examples:**

**GetUtcSeasonDate(** _{season AS String}, {targetYear AS Integer}, {tz_Offset AS Integer}_ **) AS Date**
  
      SeasonDate = GetUtcSeasonDate("Spring", 2018, -1)
      SeasonDate = GetUtcSeasonDate("Winter", 2021, -7)
      SeasonDate = GetUtcSeasonDate("aUtmun", 1888, 0)




Visit the [Seasons Wiki](https://github.com/MikishVaughn/Seasons/wiki) for a more detailed information.

###### *GetUtcSeasonDate() is based on the work of Jean Meeus from the book Astronomical Algorithms.
