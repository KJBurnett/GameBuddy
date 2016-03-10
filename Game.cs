using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Buddy
{
    public class Game
    {
        public string name                      { get; set; }
        public string gameLocation              { get; set; }
        public string saveLocation              { get; set; }
        public string genre                     { get; set; }
        public string playTime                  { get; set; }
        public string steamPlayTime             { get; set; }
        public string firstPlayed               { get; set; }
        public string lastPlayed                { get; set; }
        public string dateCompleted             { get; set; }
        public string timeToComplete            { get; set; }
        public string date100PercentCompleted   { get; set; }
        public string timeTo100Percent          { get; set; }

        public Game() { }

        public Game(string name, string gameLocation, string saveLocation, string genre, string playTime, 
            string steamPlayTime, string firstPlayed, string lastPlayed, string dateCompleted, string timeToComplete, string date100PercentCompleted, string timeTo100Percent)
        {
            this.name                       = name;
            this.gameLocation               = gameLocation;
            this.saveLocation               = saveLocation;
            this.genre                      = genre;
            this.playTime                   = playTime;
            this.steamPlayTime              = steamPlayTime;
            this.firstPlayed                = firstPlayed;
            this.lastPlayed                 = lastPlayed;
            this.dateCompleted              = dateCompleted;
            this.timeToComplete             = timeToComplete;
            this.date100PercentCompleted    = date100PercentCompleted;
            this.timeTo100Percent           = timeTo100Percent;
        }

        public override string ToString()
        {
            return this.name + "," + this.gameLocation + "," + this.saveLocation + "," + this.genre + "," + this.playTime
                 + "," + this.steamPlayTime + "," + this.firstPlayed + "," + this.lastPlayed + "," + this.dateCompleted
                  + "," + this.timeToComplete + "," + this.date100PercentCompleted + "," + this.timeTo100Percent;
        }

    }
}
