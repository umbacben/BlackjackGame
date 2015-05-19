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
using BlackJackClient.ServiceReference1;


namespace BlackJackClient
{
    public partial class Form1 : Form, IChatCallback
    {
        DateTime dt;
        public string username;
        ChatClient chatProxy;
        //private BlackJackService.BlackjackClient client;
        InstanceContext context;
        LoginClient logproxy;
        public Form1()
        {
            InitializeComponent();
            context = new InstanceContext(this);
            chatProxy = new ChatClient(context);
            logproxy = new LoginClient();
            chatProxy.Subscribe();

            //client = new BlackJackService.BlackjackClient();
         
            panelLobby.Hide();
            panelLobby.BringToFront();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            chatProxy.UnSubscribe();
        }

        public void onMessageAdded(DateTime time, string playerName, string message)
        {
            lbChat.Items.Add(time + ":" + playerName + " > " + message);
          
         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool temp = logproxy.LogIn(tbUser.Text,tbPass.Text);

            if (temp)
            {
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

            chatProxy.AddMessageAsync(username,message);
        }
    }
}
