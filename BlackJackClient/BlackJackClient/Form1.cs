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

namespace BlackJackClient
{
    public partial class Form1 : Form
    {

        private BlackJackService.BlackjackClient client;
        InstanceContext context;
        public Form1()
        {
            InitializeComponent();
            context = new InstanceContext(this);
            client = new BlackJackService.BlackjackClient();
            panelLobby.Hide();
            panelLogIn.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool temp = client.Login(tbUser.Text, tbPass.Text);
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
    }
}
