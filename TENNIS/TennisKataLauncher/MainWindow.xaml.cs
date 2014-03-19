using System;
using System.Windows;
using TennisKata;

namespace TennisKataLauncher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private ITennisScorer _scorer;
        private TennisScorerViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();

            //_scorer = new TennisScorer();
            // For Testing purpose
            _scorer = new DummyScorer();

            _scorer.StartGame("Player 1", "Player 2");

            _viewModel = new TennisScorerViewModel(_scorer);
            this.DataContext = _viewModel;
        }

        private void ServerBtn_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("ServerBtn_Click");
            _viewModel.ServerWonPoint();
        }

        private void RecieverBtn_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("RecieverBtn_Click");
            _viewModel.RecieverWonPoint();

        }
    }
}
