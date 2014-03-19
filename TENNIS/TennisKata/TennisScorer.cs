namespace TennisKata
{
    public class TennisScorer : ITennisScorer
    {
        public void StartGame(string serverName, string recieverName)
        {
            throw new System.NotImplementedException();
        }

        public string ServerName { get; private set; }
        public string RecieverName { get; private set; }

        public string Score {
            get
            {
                return GetScore();
            }
        }

        public string GetScore()
        {
            throw new System.NotImplementedException();
        }

        public void ServerWonPoint()
        {
            throw new System.NotImplementedException();
        }

        public void RecieverWonPoint()
        {
            throw new System.NotImplementedException();
        }
    }
}
