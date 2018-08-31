# Seasons - Equinoxes and Solstices
### A Windows Desktop example of the Visual Basic function: **GetUtcSeasonDate()**.*

The [function](https://github.com/MikishVaughn/Seasons/blob/master/Seasons/Seasons.vb) returns the requested Equinox or Solstice Date representing the starting date and time of the queried Season (ie. "Spring", "Summer", Autumn", or "Winter").  

### **Quick Examples:**
Parameters should be self-explanitory, but to elaborate:
* **season** is a quoted string of one of the four Seasons (ie. "Spring", "Summer", Autumn", or "Winter")
* **targetYear** is the Season's desired year to calculate
* **tz_Offset** is an adjustment for Time Zone. (0 returns Utc, -6 returns US Central Time)

**Note:** tz_Offset can be used to adjust the 'Hour' of the date returned by Time Zone, but does nothing to accomodate DST (Daylight Savings Time). The Seasons App uses the computer's settings to determine whether the current 'Hour' is adjusted by DST, plus whether the Season's time returned will need to be adjusted before desplaying. 

**GetUtcSeasonDate(** _{**season** AS String}, {**targetYear** AS Integer}, {**tz_Offset** AS Integer}_ **) AS Date**
  
      Dim seasonStartDate AS Date
      
      seasonStartDate = GetUtcSeasonDate("Spring", 2018, -1)
      seasonStartDate = GetUtcSeasonDate("Winter", 2021, -7)
      seasonStartDate = GetUtcSeasonDate("aUtmun", 1888, 0)

Visit the [Seasons Wiki](https://github.com/MikishVaughn/Seasons/wiki) for a more detailed information.

###### *GetUtcSeasonDate() is based on the work of Jean Meeus from his book, Astronomical Algorithms.
