# Seasons
This is a demo of a Visual Basic function "GetUtcSeasonDate({Season}, {targetYear}, {TZ_Offset})".

The function will return the Equinoxes and Solstices based on the formulas of Jean Meeus from the book Astronomical Algorithms.  

Here is a link to the function:
https://github.com/MikishVaughn/Seasons/blob/master/Seasons/Seasons.vb

Usage examples:
  GetUtcSeasonDate({Season}, {targetYear}, {TZ_Offset})
  
      GetUtcSeasonDate("spring", 2018, -1)
      GetUtcSeasonDate("Winter", 2021, -7)

