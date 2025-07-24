namespace Rock_Paper_Scisor
{
    public partial class Form1 : Form
    {
        string PlayerC;
        string CPUC;
        string[] Options = { "R", "P", "S", "P", "S", "R" };
        Random random = new Random();
        int ComputerScore;
        int PlayerScore;
        string draw;
        public Form1()
        {
            InitializeComponent();
        }

        private string UpdateTextandImage(string text, PictureBox pic)
        {
            string word = null;
            switch(text)
            {
                case "R":
                    word = "Rock";
                    pic.Image = Properties.Resources.ROCK;
                    break;
                case "P":
                    word = "Paper";
                    pic.Image = Properties.Resources.PAPER;
                    break;
                case "S":
                    word = "Scissor";
                    pic.Image = Properties.Resources.SCISSORS;
                    break;
            }
            return word;
        }

        private void CheckGame()
        {
            if (CPUC == PlayerC)
            {
                draw = " Draw!";
            }
            else if (PlayerC == "R" && CPUC == "P" || PlayerC == "S" && CPUC == "R" || PlayerC == "P" && CPUC == "S")
            {
                ComputerScore++;
                draw = null;
            }
            else
            {
                PlayerScore++;
                draw = null;
            }
            label1.Text = "Computer Score: " + ComputerScore + Environment.NewLine + draw;
            label2.Text = "Player Score: " + PlayerScore + Environment.NewLine + draw;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MakeChoiceEvent(object sender, EventArgs e)
        {
            Button tempButton = sender as Button;

            PlayerC = (string)tempButton.Tag;

            int i = random.Next(0, Options.Length);
            CPUC = Options[i];

            if (PLAYER_PIC != null && CPUPIC != null)
            {
                lb2.Text = "Player is: " + UpdateTextandImage(PlayerC, PLAYER_PIC);
                lb1.Text = "Computer is: " + UpdateTextandImage(CPUC, CPUPIC);
            }
            else
            {
                MessageBox.Show("PictureBox controls are not initialized.");
            }


            CheckGame();
        }
    }
}
