namespace TennisKata
{
    public class DummyScorer : ITennisScorer
    {
        public string ServerName { get; set; }
        public string RecieverName { get; set; }

        private int ServerScore { get; set; }
        private int RecieverScore { get; set; }

        public void StartGame(string serverName, string recieverName)
        {
            ServerName = serverName;
            RecieverName = recieverName;
            ServerScore = 0;
            RecieverScore = 0;
        }

        public string Score {
            get
            {
                return GetScore();
            }
        }

        public string GetScore()
        {
            return string.Format("{0} - {1}", ServerScore, RecieverScore);
        }

        public void ServerWonPoint()
        {
            ServerScore++;
        }

        public void RecieverWonPoint()
        {
            RecieverScore++;
        }
    }
}
