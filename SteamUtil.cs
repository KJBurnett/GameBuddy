using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

// TODO 
// Finsih this class file.

namespace Game_Buddy
{
    class SteamUtil
    {
        List<SteamGame> steamGames = new List<SteamGame>();

        private void FillSteamGames()
        {
            string line = "";
            string name = "";
            string appid = "";
            string[] s = null;
            SteamGame game = null;

            // Read in list that contains the Steam Game appids and names.
            StreamReader sr = new StreamReader("./SteamGameList.txt");

            while ((line = sr.ReadLine()) != null)
            {
                // Check if the read in line is a comment. If so, skip it.
                if (!(line.StartsWith("//")))
                    try
                    {
                        s = line.Split(new char[] { ' ' }, 2);
                        appid = s[0];
                        name = s[1];

                        // Add the game to the steamGames list.
                        game = new SteamGame(name, appid);
                        steamGames.Add(game);
                    }
                    catch (Exception ex) { GameUtil.LogError(ex.ToString()); }
            }
        }

        private string QueryOwnedGames()
        {
            string sourceCode = string.Empty;
            string steamID = File.ReadAllText("./SteamID.txt");

            try
            {
                System.Net.HttpWebRequest request;
                request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create("http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key=B6FA82B3BBB99EE246C60ED22365D929&steamid=" + steamID + "&format=xml");
                System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();

                StreamReader sr = new StreamReader(response.GetResponseStream());
                sourceCode = sr.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not query Steam.\nError has been logged.");
                GameUtil.LogError(ex.ToString());
                return "error";
            }
            return sourceCode;
        }

        private void FindSteamPlayTimes(string queriedGames)
        {
            string gameCount;
            string queryID;
            int queryPlayTime;

            // You have to make this settings variable and send it into the reader
            // So that you can parse DtdProcessing. (It's stupid that Steam does this)
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.XmlResolver = null;
            settings.DtdProcessing = DtdProcessing.Parse;

            using (XmlReader reader = XmlReader.Create(new StringReader(queriedGames), settings))
            {
                reader.ReadToFollowing("game_count");
                gameCount = reader.ReadElementContentAsString();

                for (int x = 0; x < Convert.ToInt32(gameCount); x++)
                {
                    reader.ReadToFollowing("appid");
                    queryID = reader.ReadElementContentAsString();
                    
                    reader.ReadToFollowing("playtime_forever");
                    queryPlayTime = Convert.ToInt32(reader.ReadElementContentAsString());

                    foreach (SteamGame game in steamGames)
                        if (game.appid == queryID)
                            game.playTime = queryPlayTime.ToString();
                }
            }
        }

        private void SetGamePlayTimes(List<Game> games)
        {
            foreach (Game game in games)
                foreach (SteamGame steamGame in steamGames)
                    if (game.name == steamGame.name)
                        game.steamPlayTime = steamGame.playTime;
        }

        public void UpdateGames(List<Game> games)
        {
            // Fill a list of possible Steam Game appID game names.
            FillSteamGames();

            string queriedGAmes = QueryOwnedGames();
            if (queriedGAmes == "error")
                return;

            // Fill the steamGames with their play times from the query.
            FindSteamPlayTimes(queriedGAmes);

            SetGamePlayTimes(games);

            MessageBox.Show("Steam queried successfully!");
        }

    }// end class
}// end namespace 
