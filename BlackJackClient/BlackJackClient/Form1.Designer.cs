namespace BlackJackClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLogIn = new System.Windows.Forms.Panel();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.panelLobby = new System.Windows.Forms.Panel();
            this.LbPlayersOnline = new System.Windows.Forms.ListBox();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.btnSpectate = new System.Windows.Forms.Button();
            this.btnPlaySolo = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelPot = new System.Windows.Forms.Label();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnCall = new System.Windows.Forms.Button();
            this.btnRaise = new System.Windows.Forms.Button();
            this.labelDealer = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.pb3Dealer = new System.Windows.Forms.PictureBox();
            this.pb2Dealer = new System.Windows.Forms.PictureBox();
            this.pb1Dealer = new System.Windows.Forms.PictureBox();
            this.pb3User = new System.Windows.Forms.PictureBox();
            this.pb2User = new System.Windows.Forms.PictureBox();
            this.pb1User = new System.Windows.Forms.PictureBox();
            this.pb3Player = new System.Windows.Forms.PictureBox();
            this.pb2Player = new System.Windows.Forms.PictureBox();
            this.pb1Player = new System.Windows.Forms.PictureBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.panelLogIn.SuspendLayout();
            this.panelLobby.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb3Dealer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2Dealer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1Dealer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1Player)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogIn
            // 
            this.panelLogIn.Controls.Add(this.btnLogIn);
            this.panelLogIn.Controls.Add(this.tbPass);
            this.panelLogIn.Controls.Add(this.tbUser);
            this.panelLogIn.Controls.Add(this.panelLobby);
            this.panelLogIn.Location = new System.Drawing.Point(16, 15);
            this.panelLogIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogIn.Name = "panelLogIn";
            this.panelLogIn.Size = new System.Drawing.Size(973, 470);
            this.panelLogIn.TabIndex = 0;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(440, 210);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(100, 28);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(420, 146);
            this.tbUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(132, 22);
            this.tbUser.TabIndex = 0;
            // 
            // panelLobby
            // 
            this.panelLobby.Controls.Add(this.LbPlayersOnline);
            this.panelLobby.Controls.Add(this.labelPlayers);
            this.panelLobby.Controls.Add(this.btnSpectate);
            this.panelLobby.Controls.Add(this.btnPlaySolo);
            this.panelLobby.Controls.Add(this.btnJoin);
            this.panelLobby.Location = new System.Drawing.Point(0, 0);
            this.panelLobby.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLobby.Name = "panelLobby";
            this.panelLobby.Size = new System.Drawing.Size(973, 470);
            this.panelLobby.TabIndex = 3;
            // 
            // LbPlayersOnline
            // 
            this.LbPlayersOnline.FormattingEnabled = true;
            this.LbPlayersOnline.ItemHeight = 16;
            this.LbPlayersOnline.Location = new System.Drawing.Point(808, 54);
            this.LbPlayersOnline.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LbPlayersOnline.Name = "LbPlayersOnline";
            this.LbPlayersOnline.Size = new System.Drawing.Size(159, 116);
            this.LbPlayersOnline.TabIndex = 4;
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.Location = new System.Drawing.Point(804, 26);
            this.labelPlayers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(104, 17);
            this.labelPlayers.TabIndex = 3;
            this.labelPlayers.Text = "Players Online:";
            // 
            // btnSpectate
            // 
            this.btnSpectate.Location = new System.Drawing.Point(255, 370);
            this.btnSpectate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSpectate.Name = "btnSpectate";
            this.btnSpectate.Size = new System.Drawing.Size(323, 66);
            this.btnSpectate.TabIndex = 2;
            this.btnSpectate.Text = "Spectate Game";
            this.btnSpectate.UseVisualStyleBackColor = true;
            // 
            // btnPlaySolo
            // 
            this.btnPlaySolo.Location = new System.Drawing.Point(255, 177);
            this.btnPlaySolo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlaySolo.Name = "btnPlaySolo";
            this.btnPlaySolo.Size = new System.Drawing.Size(323, 95);
            this.btnPlaySolo.TabIndex = 1;
            this.btnPlaySolo.Text = "Play Solo";
            this.btnPlaySolo.UseVisualStyleBackColor = true;
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(255, 76);
            this.btnJoin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(323, 95);
            this.btnJoin.TabIndex = 0;
            this.btnJoin.Text = "Join Player";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(861, 32);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelPot
            // 
            this.labelPot.AutoSize = true;
            this.labelPot.Location = new System.Drawing.Point(400, 226);
            this.labelPot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPot.Name = "labelPot";
            this.labelPot.Size = new System.Drawing.Size(77, 17);
            this.labelPot.TabIndex = 34;
            this.labelPot.Text = "PotAmount";
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(605, 425);
            this.btnStand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(117, 44);
            this.btnStand.TabIndex = 33;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(480, 425);
            this.btnHit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(117, 44);
            this.btnHit.TabIndex = 32;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(796, 325);
            this.btnCall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(124, 44);
            this.btnCall.TabIndex = 31;
            this.btnCall.Text = "Call";
            this.btnCall.UseVisualStyleBackColor = true;
            // 
            // btnRaise
            // 
            this.btnRaise.Location = new System.Drawing.Point(796, 273);
            this.btnRaise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRaise.Name = "btnRaise";
            this.btnRaise.Size = new System.Drawing.Size(124, 44);
            this.btnRaise.TabIndex = 30;
            this.btnRaise.Text = "Raise";
            this.btnRaise.UseVisualStyleBackColor = true;
            // 
            // labelDealer
            // 
            this.labelDealer.AutoSize = true;
            this.labelDealer.Location = new System.Drawing.Point(400, 47);
            this.labelDealer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDealer.Name = "labelDealer";
            this.labelDealer.Size = new System.Drawing.Size(50, 17);
            this.labelDealer.TabIndex = 29;
            this.labelDealer.Text = "Dealer";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(573, 273);
            this.labelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(38, 17);
            this.labelUser.TabIndex = 28;
            this.labelUser.Text = "User";
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Location = new System.Drawing.Point(123, 273);
            this.labelPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(56, 17);
            this.labelPlayer.TabIndex = 27;
            this.labelPlayer.Text = "Player1";
            // 
            // pb3Dealer
            // 
            this.pb3Dealer.Location = new System.Drawing.Point(487, 86);
            this.pb3Dealer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb3Dealer.Name = "pb3Dealer";
            this.pb3Dealer.Size = new System.Drawing.Size(75, 103);
            this.pb3Dealer.TabIndex = 26;
            this.pb3Dealer.TabStop = false;
            // 
            // pb2Dealer
            // 
            this.pb2Dealer.Location = new System.Drawing.Point(404, 86);
            this.pb2Dealer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb2Dealer.Name = "pb2Dealer";
            this.pb2Dealer.Size = new System.Drawing.Size(75, 103);
            this.pb2Dealer.TabIndex = 25;
            this.pb2Dealer.TabStop = false;
            // 
            // pb1Dealer
            // 
            this.pb1Dealer.Location = new System.Drawing.Point(321, 86);
            this.pb1Dealer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb1Dealer.Name = "pb1Dealer";
            this.pb1Dealer.Size = new System.Drawing.Size(75, 103);
            this.pb1Dealer.TabIndex = 24;
            this.pb1Dealer.TabStop = false;
            // 
            // pb3User
            // 
            this.pb3User.Location = new System.Drawing.Point(645, 306);
            this.pb3User.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb3User.Name = "pb3User";
            this.pb3User.Size = new System.Drawing.Size(75, 103);
            this.pb3User.TabIndex = 23;
            this.pb3User.TabStop = false;
            // 
            // pb2User
            // 
            this.pb2User.Location = new System.Drawing.Point(563, 306);
            this.pb2User.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb2User.Name = "pb2User";
            this.pb2User.Size = new System.Drawing.Size(75, 103);
            this.pb2User.TabIndex = 22;
            this.pb2User.TabStop = false;
            // 
            // pb1User
            // 
            this.pb1User.Location = new System.Drawing.Point(480, 306);
            this.pb1User.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb1User.Name = "pb1User";
            this.pb1User.Size = new System.Drawing.Size(75, 103);
            this.pb1User.TabIndex = 21;
            this.pb1User.TabStop = false;
            // 
            // pb3Player
            // 
            this.pb3Player.Location = new System.Drawing.Point(209, 306);
            this.pb3Player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb3Player.Name = "pb3Player";
            this.pb3Player.Size = new System.Drawing.Size(75, 103);
            this.pb3Player.TabIndex = 20;
            this.pb3Player.TabStop = false;
            // 
            // pb2Player
            // 
            this.pb2Player.Location = new System.Drawing.Point(127, 306);
            this.pb2Player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb2Player.Name = "pb2Player";
            this.pb2Player.Size = new System.Drawing.Size(75, 103);
            this.pb2Player.TabIndex = 19;
            this.pb2Player.TabStop = false;
            // 
            // pb1Player
            // 
            this.pb1Player.Location = new System.Drawing.Point(44, 306);
            this.pb1Player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb1Player.Name = "pb1Player";
            this.pb1Player.Size = new System.Drawing.Size(75, 103);
            this.pb1Player.TabIndex = 18;
            this.pb1Player.TabStop = false;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(420, 178);
            this.tbPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '!';
            this.tbPass.Size = new System.Drawing.Size(132, 22);
            this.tbPass.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 500);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labelPot);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.btnRaise);
            this.Controls.Add(this.labelDealer);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.pb3Dealer);
            this.Controls.Add(this.pb2Dealer);
            this.Controls.Add(this.pb1Dealer);
            this.Controls.Add(this.pb3User);
            this.Controls.Add(this.pb2User);
            this.Controls.Add(this.pb1User);
            this.Controls.Add(this.pb3Player);
            this.Controls.Add(this.pb2Player);
            this.Controls.Add(this.pb1Player);
            this.Controls.Add(this.panelLogIn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelLogIn.ResumeLayout(false);
            this.panelLogIn.PerformLayout();
            this.panelLobby.ResumeLayout(false);
            this.panelLobby.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb3Dealer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2Dealer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1Dealer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogIn;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Panel panelLobby;
        private System.Windows.Forms.ListBox LbPlayersOnline;
        private System.Windows.Forms.Label labelPlayers;
        private System.Windows.Forms.Button btnSpectate;
        private System.Windows.Forms.Button btnPlaySolo;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelPot;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.Button btnRaise;
        private System.Windows.Forms.Label labelDealer;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.PictureBox pb3Dealer;
        private System.Windows.Forms.PictureBox pb2Dealer;
        private System.Windows.Forms.PictureBox pb1Dealer;
        private System.Windows.Forms.PictureBox pb3User;
        private System.Windows.Forms.PictureBox pb2User;
        private System.Windows.Forms.PictureBox pb1User;
        private System.Windows.Forms.PictureBox pb3Player;
        private System.Windows.Forms.PictureBox pb2Player;
        private System.Windows.Forms.PictureBox pb1Player;
        private System.Windows.Forms.TextBox tbPass;
    }
}

