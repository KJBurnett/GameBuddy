using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Buddy
{
    public static class TimeUtil
    {
        public static string ConvertToHoursMinutes(int minutes)
        {
            int hours = 0;
            string time = "";

            // Convert the minutes to hours.
            if (minutes >= 60)
            {
                hours = minutes / 60;
                minutes = minutes % 60;
            }

            string minuteStr = Pluralize(" Minute", minutes);
            string hourStr = Pluralize(" Hour", hours);

            if (minutes == 0)
                time = hours.ToString() + hourStr;
            else if (hours == 0)
                time = minutes.ToString() + minuteStr;
            else
                time = hours.ToString() + hourStr + " and " + minutes.ToString() + minuteStr;

            return time;
        }

        private static string Pluralize(string str, int value)
        {
            if (value != 1)
                str += "s";
            return str;
        }

        public static string GetCollectivePlayTime(List<Game> games)
        {
            string total = "";
            int minutes = 0;

            foreach (Game game in games)
                minutes += Convert.ToInt32(game.playTime) + Convert.ToInt32(game.steamPlayTime);

            total = ConvertToHoursMinutes(minutes);

            return total;
        }
    }
}
