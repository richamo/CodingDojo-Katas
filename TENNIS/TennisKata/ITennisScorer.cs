namespace TennisKata
{
    public interface ITennisScorer
    {
        void StartGame(string serverName, string recieverName);

        string ServerName { get; }

        string RecieverName { get; }

        string Score { get; }

        void ServerWonPoint();

        void RecieverWonPoint();

    }
}