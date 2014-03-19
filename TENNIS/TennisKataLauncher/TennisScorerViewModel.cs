using System.ComponentModel;
using System.Runtime.CompilerServices;
using TennisKataLauncher.Annotations;

namespace TennisKata
{
    public class TennisScorerViewModel : INotifyPropertyChanged
    {
        private readonly ITennisScorer _tennisScorer;

        public string ServerName
        {
            get
            {
                return _tennisScorer.ServerName;
            }
        }

        public string RecieverName
        {
            get
            {
                return _tennisScorer.RecieverName;
            }
        }

        public TennisScorerViewModel(ITennisScorer tennisScorer)
        {
            _tennisScorer = tennisScorer;
        }

        public string Score {
            get
            {
                return _tennisScorer.Score;
            }
        }

        public void ServerWonPoint()
        {
            _tennisScorer.ServerWonPoint();
            OnPropertyChanged("Score");
        }

        public void RecieverWonPoint()
        {
            _tennisScorer.RecieverWonPoint();
            OnPropertyChanged("Score");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
