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

        public Form1()
        {
            InitializeComponent();
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
            panelLobby.Hide();
            blackjackClient.SubscribeGame();
            
        }
        public void UpdateVisual()
        {
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
            int count=0;
            count=thegame.Player1.PlayHand.Length;
            for(int i=0;i<count;i++)
            {
                userhand[i].ImageLocation = thegame.Player1.PlayHand[i].PicLoc;
            }
            if (opponentPlayer.UserName.Name == "")
            {
                return; 
            }
            labelPlayer.Text = opponentPlayer.UserName.Name;
            count = opponentPlayer.PlayHand.Length;
            for (int i = 0; i < count; i++)
            {
                opponenthand[i].ImageLocation = "\\images\\cardback.jpg";
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

        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            string message = tbChat.Text;
            tbChat.Text = "";
            chatClient.AddMessage(user.Name, message);
            Console.Write("hello");
        }

        private void btnRaise_Click(object sender, EventArgs e)
        {
            blackjackClient.IncreasePot(thegame, Convert.ToInt32(tBoxRaise.Text));
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            blackjackClient.ReadyPlayer(thegame, curPlayer);
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
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
    }
}
