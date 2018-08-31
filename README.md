# Seasons
This is an example of a Visual Basic function **GetUtcSeasonDate({Season}, {targetYear}, {TZ_Offset})**.

The [function](https://github.com/MikishVaughn/Seasons/blob/master/Seasons/Seasons.vb) returns the requested Equinox and Solstice dates and times which represent the beginning and ending of the four Seasons based on the formulas of Jean Meeus from the book Astronomical Algorithms.  

Usage examples:
  GetUtcSeasonDate({Season}, {targetYear}, {TZ_Offset})
  
      GetUtcSeasonDate("spring", 2018, -1)
      GetUtcSeasonDate("Winter", 2021, -7)

Be sure to visit the [Seasons Wiki](https://github.com/MikishVaughn/Seasons/wiki).
