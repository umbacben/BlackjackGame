using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using BlackJackClient.BlackjackService;


namespace BlackJackClient
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public partial class Form1 : Form, IBlackjackGameCallback, IChatCallback, IPortalCallback
    {
        private User user;
        private BlackjackGameClient blackjackClient;
        private ChatClient chatClient;
        private PortalClient portalClient;
        InstanceContext context;
        private Player curPlayer;
        private Player opponentPlayer;
        private List<PictureBox> userhand,opponenthand;
        private Game thegame;
        private List<Game> gList;
        private Player winner;

        public Form1()
        {
            InitializeComponent();
            userhand = new List<PictureBox>();
            opponenthand=new List<PictureBox>();
            userhand.Add(pb1User);
            userhand.Add(pb2User);
            userhand.Add(pb3User);
            userhand.Add(pb4User);
            userhand.Add(pb5User);
            opponenthand.Add(pb1Player);
            opponenthand.Add(pb2Player);
            opponenthand.Add(pb3Player);
            opponenthand.Add(pb4Player);
            opponenthand.Add(pb5Player);
            thegame = new Game();
            curPlayer = new Player();
            opponentPlayer = new Player();
            gList = new List<Game>();
            user = new User();
            context = new InstanceContext(this);
            blackjackClient = new BlackjackGameClient(context);
            chatClient = new ChatClient(context);
            chatClient.SubscribeChat();
            portalClient = new PortalClient(context);
            portalClient.SubscribePortal();
            //panelLobby.Hide();
            blackjackClient.SubscribeGame();
            winner = new Player();
        }
        public void UpdateVisual()
        {
            if (thegame.Player1.RoundDone && thegame.Player2.RoundDone)
            {
                DetermineWinner();
                DisableStuff();
                return;
            }
            labelPot.Text = "Pot amount: " + thegame.Pot.ToString();
            if (user.Name == thegame.Player1.UserName.Name)
            {
                opponentPlayer = thegame.Player2;
                curPlayer = thegame.Player1;
            }
            else
            {
                curPlayer = thegame.Player2;
                opponentPlayer = thegame.Player1;
            }
            lblYourMon.Text = "Money: $" + curPlayer.Money.ToString();
            int count=0;
            count = curPlayer.PlayHand.Length;
            for(int i=0;i<count;i++)
            {
                userhand[i].Image = getImage(curPlayer.PlayHand.ElementAt(i).PicLoc);
            }
            if (opponentPlayer.UserName.Name == "")
            {
                return; 
            }
            lblOpMon.Text = opponentPlayer.Money.ToString();
            labelPlayer.Text = opponentPlayer.UserName.Name;
            count = opponentPlayer.PlayHand.Length;
            if (count != 0)
            {
                opponenthand[0].Image = getImage(opponentPlayer.PlayHand.ElementAt(0).PicLoc);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            chatClient.UnsubscribeChat();
            portalClient.UnSubscribePortal();
            blackjackClient.UnsubscribeGame();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            panelLobby.Show();
            panelLobby.BringToFront();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            thegame = gList.Find(x => x.GameId == Convert.ToInt32(LbPlayersOnline.SelectedItem));
            if (!portalClient.JoinGame(thegame, user))
            {
                MessageBox.Show("Failed to join game");
            }
            else
            {
                panelLobby.Hide();
                labelUser.Text = user.Name;
            }
            lbInGameChat.Items.Clear();
            DisableStuff();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            string message = tbChat.Text;
            tbChat.Text = "";
            chatClient.AddMessage(user.Name, message);
        }

        private void btnRaise_Click(object sender, EventArgs e)
        {
            blackjackClient.IncreasePot(thegame, Convert.ToInt32(tBoxRaise.Text));
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            blackjackClient.ReadyPlayer(thegame, curPlayer);
            EnableStuff();
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            if (curPlayer.PlayHand.Count()>4)
            {
                MessageBox.Show("Cant hit anymore");
                btnStand_Click(sender, e);
                return;
            }
            blackjackClient.Hit(thegame, curPlayer);
        }   

        private void btnStand_Click(object sender, EventArgs e)
        {
            blackjackClient.Stay(thegame, curPlayer);
        }

        private void btnCreateGame_Click(object sender, EventArgs e)
        {
            thegame = portalClient.CreateGame(user);
            curPlayer = thegame.Player1;
            portalClient.GetGameList();
            panelLobby.Hide();
            labelUser.Text = user.Name;
            DisableStuff();
            lbInGameChat.Items.Clear();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            user = portalClient.Login(tbUser.Text);

            if (user != null)
            {
                user.Name = tbUser.Text;
                panelLogIn.Hide();
                panelLobby.Show();
                panelLobby.BringToFront();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect");
            }
        }

        public void onMessageAdded(DateTime time, string playerName, string message)
        {
            string temp = ("(" + time.Hour +" : " + time.Minute +  ") " + playerName + " : " + message);
       
             Game game = new Game();
             game = null;
             game = gList.Find(x => x.Player1.UserName.Name == playerName || x.Player2.UserName.Name == playerName );
             

            if ( game!= null)//--------------------------------------------------------------------------------------
            lbInGameChat.Items.Add(temp);
            else
                lbChat.Items.Add(temp);
        }

        public void UpdateGame(Game game)
        {
            if(game!=null)
            {
                if(game.GameId==thegame.GameId)
                {
                    thegame = game;
                    UpdateVisual();
                }
            }
        }

        private void DetermineWinner()
        {
            winner = blackjackClient.GetWinner(thegame);
            if (winner == null)
            {
                MessageBox.Show("Tie");
            }
            else
            {
                MessageBox.Show("The Winner is " + winner.UserName.Name);
            }
            DisableStuff();
        }

        private void DisableStuff()
        {
            btnHit.Enabled = false;
            btnStand.Enabled = false;
            btnReady.Enabled = true;
            btnRaise.Enabled = true;
            btnLeave.Enabled = true;
        }

        private void EnableStuff()
        {
            btnHit.Enabled = true;
            btnStand.Enabled = true;
            btnReady.Enabled = false;
            btnRaise.Enabled = false;
            btnLeave.Enabled = false;
        }

        public void UpdateGameList(Game[] gameList)
        {
            gList = gameList.ToList<Game>();
            this.updategamelistbox();
        }

        private void updategamelistbox()
        {
            LbPlayersOnline.Items.Clear();
            foreach (Game i in gList)
            {
                LbPlayersOnline.Items.Add(i.GameId.ToString());
            }
        }

        private Image getImage(string imgNum)
        {
            Image temp = null;
            switch (imgNum)
            {
                case "2":
                    temp = BlackJackClient.Properties.Resources._2;
                    break;
                case "3":
                    temp = BlackJackClient.Properties.Resources._3;
                    break;
                case "4":
                    temp = BlackJackClient.Properties.Resources._4;
                    break;
                case "5":
                    temp = BlackJackClient.Properties.Resources._5;
                    break;
                case "6":
                    temp = BlackJackClient.Properties.Resources._6;
                    break;
                case "7":
                    temp = BlackJackClient.Properties.Resources._7;
                    break;
                case "8":
                    temp = BlackJackClient.Properties.Resources._8;
                    break;
                case "9":
                    temp = BlackJackClient.Properties.Resources._9;
                    break;
                case "10":
                    temp = BlackJackClient.Properties.Resources._10;
                    break;
                case "11":
                    temp = BlackJackClient.Properties.Resources._11;
                    break;
                case "12":
                    temp = BlackJackClient.Properties.Resources._12;
                    break;
                case "13":
                    temp = BlackJackClient.Properties.Resources._13;
                    break;
                case "14":
                    temp = BlackJackClient.Properties.Resources._14;
                    break;
            }
            return temp;
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            blackjackClient.LeaveGame(thegame, curPlayer);
            panelLogIn.Hide();
            panelLobby.Show();
            panelLobby.BringToFront();
            portalClient.GetGameList();
        }

        private void btnInGameChat_Click(object sender, EventArgs e)
        {
            string message = tbInGameChat.Text;
            tbInGameChat.Text = "";
            chatClient.AddMessage(user.Name, message);
        }
    }
}
