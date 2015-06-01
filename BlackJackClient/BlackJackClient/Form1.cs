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
    public partial class Form1 : Form
    {
        private User user;
        private BlackjackGameClient blackjackClient;
        private ChatClient chatClient;
        private PortalClient portalClient;
        InstanceContext context;
        public Form1()
        {
            InitializeComponent();
            context = new InstanceContext(this);
            blackjackClient = new BlackjackGameClient(context);
            chatClient = new ChatClient(context);
            portalClient = new PortalClient();
            user = new User();
            chatClient.Subscribe1();
            panelLobby.Hide();
            panelLobby.BringToFront();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            chatClient.UnSubscribe();
        }

        public void onMessageAdded(DateTime time, string playerName, string message)
        {
            lbChat.Items.Add(time + ":" + playerName + " > " + message);
          
         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool temp = portalClient.Login(tbUser.Text);

            if (temp)
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


        private void btnExit_Click(object sender, EventArgs e)
        {
            panelLobby.Show();
            panelLobby.BringToFront();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {

        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            string message = tbChat.Text;

            tbChat.Text = "";
            tbChat.Focus();

            chatClient.AddMessage(user.Name, message);
        }
    }
}
