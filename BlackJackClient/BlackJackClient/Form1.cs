using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelLobby.Hide();
            panelGame.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelLogIn.Hide();
            panelLobby.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPlaySolo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelGame.Visible = true;
            panelLobby.Show();
        }

        private void btnSpectate_Click(object sender, EventArgs e)
        {
            btnHit.Show();
            panelLobby.Hide();
            panelGame.Show();
        }
    }
}
