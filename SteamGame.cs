using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Buddy
{
    class SteamGame
    {
        public string name      { get; set; }
        public string appid     { get; set; }
        public string playTime  { get; set; }

        public SteamGame(string name, string appid, string playTime)
        {
            this.name = name;
            this.appid = appid;
            this.playTime = playTime;
        }

        public SteamGame(string name, string appid)
        {
            this.name = name;
            this.appid = appid;
            this.playTime = "0";
        }

        public override string ToString()
        {
            return this.name + "," + this.appid + "," + this.playTime;
        }
    }
}
