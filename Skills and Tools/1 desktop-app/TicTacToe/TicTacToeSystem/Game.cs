using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TicTacToeSystem
{
    public class Game : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public event EventHandler? ScoreChanged;
        public enum GameStatusEnum { NotStarted, Playing, Winner, Tie }
        public enum TurnEnum { None, X, O }
        List<List<Spot>> lstwinningsets = new();

        List<Spot> lstrankedbuttons;

        bool iscomputerturn;
        GameStatusEnum _gamestatus = GameStatusEnum.NotStarted;
        TurnEnum _currentturn = TurnEnum.None;
        private static int scorexwins;
        private static int scoreowins;
        private static int scoreties;
        private static int numgames;

        public Game()
        {
            numgames++;
            this.GameName = "Game " + numgames;
            for (int i = 0; i < 9; i++)
            {
                this.Spots.Add(new Spot());
            }

            lstwinningsets = new() {
                new() {this.Spots[0], this.Spots[1], this.Spots[2] },
                new() {this.Spots[3], this.Spots[4], this.Spots[5] },
                new() {this.Spots[6], this.Spots[7], this.Spots[8] },
                new() {this.Spots[0], this.Spots[3], this.Spots[6] },
                new() {this.Spots[1], this.Spots[4], this.Spots[7] },
                new() {this.Spots[2], this.Spots[5], this.Spots[8] },
                new() {this.Spots[0], this.Spots[4], this.Spots[8] },
                new() {this.Spots[2], this.Spots[4], this.Spots[6] }
            };
            lstrankedbuttons = new() { this.Spots[4], this.Spots[0], this.Spots[2], this.Spots[6], this.Spots[8] };
            this.Spots.ForEach(b => b.BackColor = this.SpotNotStartedColor);
        }

        public List<Spot> Spots { get; private set; } = new();
        public string GameName { get; private set; }
        public GameStatusEnum GameStatus
        {
            get => _gamestatus;
            private set
            {
                _gamestatus = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("GameStatusDescription");
                this.InvokePropertyChanged("StartButtonText");
            }
        }
        public TurnEnum CurrentTurn
        {
            get => _currentturn; private set
            {
                _currentturn = value;
                this.InvokePropertyChanged("GameStatusDescription");
            }
        }
        public string GameStatusDescription
        {
            get
            {
                string s = $"{this.GameName}: {this.GameMode}: ";
                switch (this.GameStatus)
                {
                    case GameStatusEnum.NotStarted:
                        s = s + "Click start to begin playing.";
                        break;
                    case GameStatusEnum.Playing:
                        s = s + "Current Turn " + this.CurrentTurn;
                        break;
                    case GameStatusEnum.Winner:
                        s = s + this.GameStatus + " is " + this.CurrentTurn;
                        break;
                    case GameStatusEnum.Tie:
                        s = s + this.GameStatus;
                        break;
                }
                return s;
            }
        }
        public TurnEnum Winner { get; private set; }
        public bool PlayAgainstComputer { get; set; }
        public string GameMode { get => this.PlayAgainstComputer ? "Play the computer" : "2-player"; }
        public string GameModeHeader { get => "For " + this.GameName; }
        public string StartButtonText
        {
            get
            {
                string s = "";
                switch (this.GameStatus)
                {
                    case GameStatusEnum.NotStarted:
                        s = s + "Start ";
                        break;
                    case GameStatusEnum.Playing:
                    case GameStatusEnum.Winner:
                    case GameStatusEnum.Tie:
                        s = "Stop ";
                        break;
                }
                s = s + this.GameName;
                return s;
            }
        }

        public System.Drawing.Color SpotWinnerColor { get; set; } = System.Drawing.Color.Red;
        public System.Drawing.Color SpotTieColor { get; set; } = System.Drawing.Color.Gray;
        public System.Drawing.Color SpotPlayingColor { get; set; } = System.Drawing.Color.Silver;
        public System.Drawing.Color SpotNotStartedColor { get; set; } = System.Drawing.Color.Black;
        public static string Score { get => $"X wins = {scorexwins}: O wins = {scoreowins}: Ties {scoreties} "; }
        public void StartGame(bool playagainstcomputer = false)
        {
            this.PlayAgainstComputer = playagainstcomputer;
            this.GameStatus = GameStatusEnum.Playing;
            ClearButtons();
            this.CurrentTurn = TurnEnum.X;
        }
        private void ClearButtons()
        {
            this.Spots.ForEach(b =>
            {
                b.Clear();
                b.BackColor = this.SpotPlayingColor;
            });
        }
        public void StopGame()
        {
            this.GameStatus = GameStatusEnum.NotStarted;
            ClearButtons();
        }
        public void TakeSpot(int spotnum)
        {
            Spot spot = this.Spots[spotnum];

            if (spot.SpotValue == TurnEnum.None && this.GameStatus == GameStatusEnum.Playing)
            {
                spot.SpotValue = this.CurrentTurn;

                lstwinningsets.ForEach(l => DetectWinner(l));

                if (this.GameStatus == GameStatusEnum.Playing)
                {
                    DetectTie();

                    if (this.GameStatus == GameStatusEnum.Playing)
                    {
                        if (this.CurrentTurn == TurnEnum.X)
                        {
                            this.CurrentTurn = TurnEnum.O;
                        }
                        else { this.CurrentTurn = TurnEnum.X; }

                        if (IsComputerTurn())
                        {
                            DoComputerTurnOffenseDefense(TurnEnum.O);

                            if (IsComputerTurn())
                            {
                                DoComputerTurnOffenseDefense(TurnEnum.X);

                                if (IsComputerTurn())
                                {
                                    DoComputerTurnRanked();

                                    if (IsComputerTurn())
                                    {
                                        DoComputerTurnRandom();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void DetectWinner(List<Spot> lst)
        {

            if (lst.Count(b => b.SpotValue == this.CurrentTurn) == lst.Count)
            {
                this.GameStatus = GameStatusEnum.Winner;
                this.Winner = this.CurrentTurn;
                lst.ForEach(b => b.BackColor = this.SpotWinnerColor);
                if (CurrentTurn == TurnEnum.X)
                {
                    scorexwins++;
                }
                else
                {
                    scoreowins++;
                }
                ScoreChanged?.Invoke(this, new EventArgs());
            }
        }
        private void DetectTie()
        {
            if (this.Spots.Count(b => b.SpotValue == TurnEnum.None) == 0)
            {
                this.GameStatus = GameStatusEnum.Tie;
                this.Spots.ForEach(b => b.BackColor = this.SpotTieColor);
                scoreties++;
                ScoreChanged?.Invoke(this, new EventArgs());
            }
        }
        private bool IsComputerTurn()
        {
            return CurrentTurn == TurnEnum.O && GameStatus == GameStatusEnum.Playing && PlayAgainstComputer == true;
        }
        private void DoComputerTurn(Spot spot)
        {
            this.TakeSpot(this.Spots.IndexOf(spot));
        }

        private void DoComputerTurnOffenseDefense(TurnEnum turn)
        {
            //find first set that has two out of three buttons with letter 0 and one blank
            //get black button out of the set

            var lstplayerosets = lstwinningsets.FirstOrDefault(l =>
                l.Count(b => b.SpotValue == turn) == 2
                    && l.Count(b => b.SpotValue == TurnEnum.None) == 1);
            if (lstplayerosets != null)
            {
                var offensespot = lstplayerosets.First(b => b.SpotValue == TurnEnum.None);
                DoComputerTurn(offensespot);
            }
        }


        private void DoComputerTurnRanked()
        {
            var rankedspot = lstrankedbuttons.FirstOrDefault(b => b.SpotValue == TurnEnum.None);

            if (rankedspot != null)
            {
                DoComputerTurn(rankedspot);
            }
        }

        private void DoComputerTurnRandom()
        {
            var availspots = this.Spots.Where(b => b.SpotValue == TurnEnum.None).ToList();
            var spot = availspots[new Random().Next(0, availspots.Count())];
            DoComputerTurn(spot);
        }

        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

    }
}
