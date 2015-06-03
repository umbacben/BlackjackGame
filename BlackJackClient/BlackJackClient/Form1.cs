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
    public partial class Form1 : Form,IBlackjackGameCallback
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
            userhand = new List<PictureBox>();
            opponenthand = new List<PictureBox>();
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
            thegame = new BlackJackGame();

            context = new InstanceContext(this);
            blackjackClient = new BlackjackGameClient(context);
            //chatClient = new ChatClient(context);
            portalClient = new PortalClient();
           // chatClient.Subscribe1();
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
                opponenthand[i].ImageLocation="C:\\Users\\Popa Vlad\\Documents\\GitHub\\BlackjackGame\\BlackJackClient\\BlackJackClient\\images\\cardback.jpg";
            }
            
        }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //chatClient.UnSubscribe();
        }

        public void onMessageAdded(DateTime time, string playerName, string message)
        {
           // lbChat.Items.Add(time + ":" + playerName + " > " + message);
          
         
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
            //string message = tbChat.Text;

            //tbChat.Text = "";
            //tbChat.Focus();

            //chatClient.AddMessage(user.Name, message);
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
    }
}
