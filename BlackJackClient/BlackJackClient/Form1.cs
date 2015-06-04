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
    public partial class Form1 : Form, IBlackjackGameCallback, IChatCallback
    {
        private User user;
        private BlackjackGameClient blackjackClient;
        private ChatClient chatClient;
        private PortalClient portalClient;
        InstanceContext context;
        private Player curPlayer;
        private List<PictureBox> userhand,opponenthand;
        private BlackJackGame thegame;
        private IBlackjackGameCallback blackcallback;
        public Form1()
        {
            InitializeComponent();
            thegame = new BlackJackGame();
            context = new InstanceContext(this);
            blackjackClient = new BlackjackGameClient(context);
            chatClient = new ChatClient(context);
            chatClient.Subscribe();
            portalClient = new PortalClient();
            panelLobby.Hide();
        }
        public void UpdateVisual()
        {
            labelPot.Text=thegame.Pot.ToString();
            int count=0;
            count=thegame.Host.PlayHand.Length;
            for(int i=0;i<count;i++)
            {
                userhand[i].ImageLocation=thegame.Host.PlayHand[i].PicLoc;
            }
            count=thegame.Player2.PlayHand.Length;
            for(int i=0;i<count;i++)
            {
                opponenthand[i].ImageLocation="\\images\\cardback.jpg";
            }
            
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            chatClient.Unsubscribe();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            panelLobby.Show();
            panelLobby.BringToFront();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            blackjackClient.AddPlayer(new Player());
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
            blackjackClient.IncreasePot(Convert.ToInt32(tBoxRaise));
            labelPot.Text = "Pot amount: " + blackjackClient.GetPot().ToString();
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            blackjackClient.ReadyPlayer(curPlayer);
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            blackjackClient.Hit(curPlayer);
        }   

        private void btnStand_Click(object sender, EventArgs e)
        {
            blackjackClient.Stay(curPlayer);
        }

        private void btnCreateGame_Click(object sender, EventArgs e)
        {
            curPlayer = portalClient.CreateGame(user);
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
            string temp = (time.TimeOfDay.ToString() + ":" + playerName + " > " + message);
            lbChat.Items.Add(temp);
        }

        public void UpdateGame(BlackJackGame game)
        {
            
        }
    }
}
