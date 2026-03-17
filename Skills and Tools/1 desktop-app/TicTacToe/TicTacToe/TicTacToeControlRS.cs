using TicTacToeSystem;

namespace TicTacToe
{
    public partial class TicTacToeControlRS : TicTacToeControl
    {
        Game game = new Game();
        List<Button> lstbtns;
        Color defaulbackcolor;


        public TicTacToeControlRS()
        {
            InitializeComponent();
            lblName.Text = "Rivky Spitzer";
            defaulbackcolor = Color.White;
            lstbtns = new() { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

            lstbtns.ForEach(b => {
                Spot spot = game.Spots[lstbtns.IndexOf(b)];
                b.Click += SpotButton_Click;
                b.DataBindings.Add("Text", spot, "SpotValueDescription");
                b.DataBindings.Add("BackColor", spot, "BackColor");

            });
            btnStart.Click += BtnStart_Click;

            lblStatus.DataBindings.Add("Text", game, "GameStatusDescription");
        }

        private void StartGame()
        {
            game.StartGame(optPlayComputer.Checked);
        }

        private void DoTurn(Button btn)
        {
            int num = lstbtns.IndexOf(btn);
            game.TakeSpot(num);
        }
        

        private void SpotButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button)
            {
                DoTurn((Button)sender);
            }
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            StartGame();
        }

    }
}
