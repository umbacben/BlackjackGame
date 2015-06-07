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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLobby = new System.Windows.Forms.Panel();
            this.tbChat = new System.Windows.Forms.TextBox();
            this.lbChat = new System.Windows.Forms.ListBox();
            this.btnChat = new System.Windows.Forms.Button();
            this.LbPlayersOnline = new System.Windows.Forms.ListBox();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.btnSpectate = new System.Windows.Forms.Button();
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelPot = new System.Windows.Forms.Label();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnRaise = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.pb3User = new System.Windows.Forms.PictureBox();
            this.pb2User = new System.Windows.Forms.PictureBox();
            this.pb1User = new System.Windows.Forms.PictureBox();
            this.pb3Player = new System.Windows.Forms.PictureBox();
            this.pb2Player = new System.Windows.Forms.PictureBox();
            this.pb1Player = new System.Windows.Forms.PictureBox();
            this.pb4Player = new System.Windows.Forms.PictureBox();
            this.pb5Player = new System.Windows.Forms.PictureBox();
            this.pb4User = new System.Windows.Forms.PictureBox();
            this.pb5User = new System.Windows.Forms.PictureBox();
            this.btnReady = new System.Windows.Forms.Button();
            this.tBoxRaise = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.panelLogIn = new System.Windows.Forms.Panel();
            this.panelLobby.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb3User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5User)).BeginInit();
            this.panelLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLobby
            // 
            this.panelLobby.Controls.Add(this.tbChat);
            this.panelLobby.Controls.Add(this.lbChat);
            this.panelLobby.Controls.Add(this.btnChat);
            this.panelLobby.Controls.Add(this.LbPlayersOnline);
            this.panelLobby.Controls.Add(this.labelPlayers);
            this.panelLobby.Controls.Add(this.btnSpectate);
            this.panelLobby.Controls.Add(this.btnCreateGame);
            this.panelLobby.Controls.Add(this.btnJoin);
            this.panelLobby.Location = new System.Drawing.Point(84, 1);
            this.panelLobby.Margin = new System.Windows.Forms.Padding(4);
            this.panelLobby.Name = "panelLobby";
            this.panelLobby.Size = new System.Drawing.Size(1010, 470);
            this.panelLobby.TabIndex = 3;
            // 
            // tbChat
            // 
            this.tbChat.Location = new System.Drawing.Point(3, 331);
            this.tbChat.Name = "tbChat";
            this.tbChat.Size = new System.Drawing.Size(155, 20);
            this.tbChat.TabIndex = 7;
            // 
            // lbChat
            // 
            this.lbChat.FormattingEnabled = true;
            this.lbChat.Location = new System.Drawing.Point(3, 58);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(155, 264);
            this.lbChat.TabIndex = 6;
            // 
            // btnChat
            // 
            this.btnChat.Location = new System.Drawing.Point(3, 357);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(75, 23);
            this.btnChat.TabIndex = 5;
            this.btnChat.Text = "Send";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // LbPlayersOnline
            // 
            this.LbPlayersOnline.FormattingEnabled = true;
            this.LbPlayersOnline.Location = new System.Drawing.Point(606, 44);
            this.LbPlayersOnline.Name = "LbPlayersOnline";
            this.LbPlayersOnline.Size = new System.Drawing.Size(120, 95);
            this.LbPlayersOnline.TabIndex = 4;
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.Location = new System.Drawing.Point(603, 21);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(77, 13);
            this.labelPlayers.TabIndex = 3;
            this.labelPlayers.Text = "Players Online:";
            // 
            // btnSpectate
            // 
            this.btnSpectate.Location = new System.Drawing.Point(191, 301);
            this.btnSpectate.Name = "btnSpectate";
            this.btnSpectate.Size = new System.Drawing.Size(242, 54);
            this.btnSpectate.TabIndex = 2;
            this.btnSpectate.Text = "Spectate Game";
            this.btnSpectate.UseVisualStyleBackColor = true;
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Location = new System.Drawing.Point(191, 144);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(242, 77);
            this.btnCreateGame.TabIndex = 1;
            this.btnCreateGame.Text = "Create Game";
            this.btnCreateGame.UseVisualStyleBackColor = true;
            this.btnCreateGame.Click += new System.EventHandler(this.btnCreateGame_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(191, 62);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(242, 77);
            this.btnJoin.TabIndex = 0;
            this.btnJoin.Text = "Join Player";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(704, -170);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelPot
            // 
            this.labelPot.AutoSize = true;
            this.labelPot.Location = new System.Drawing.Point(680, 222);
            this.labelPot.Name = "labelPot";
            this.labelPot.Size = new System.Drawing.Size(62, 13);
            this.labelPot.TabIndex = 34;
            this.labelPot.Text = "PotAmount:";
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(280, 345);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(88, 36);
            this.btnStand.TabIndex = 33;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(186, 345);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(88, 36);
            this.btnHit.TabIndex = 32;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnRaise
            // 
            this.btnRaise.Location = new System.Drawing.Point(682, 264);
            this.btnRaise.Name = "btnRaise";
            this.btnRaise.Size = new System.Drawing.Size(93, 36);
            this.btnRaise.TabIndex = 30;
            this.btnRaise.Text = "Raise";
            this.btnRaise.UseVisualStyleBackColor = true;
            this.btnRaise.Click += new System.EventHandler(this.btnRaise_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(256, 222);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(26, 13);
            this.labelUser.TabIndex = 28;
            this.labelUser.Text = "You";
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Location = new System.Drawing.Point(246, 26);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(54, 13);
            this.labelPlayer.TabIndex = 27;
            this.labelPlayer.Text = "Opponent";
            // 
            // pb3User
            // 
            this.pb3User.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb3User.BackgroundImage")));
            this.pb3User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb3User.Location = new System.Drawing.Point(310, 249);
            this.pb3User.Name = "pb3User";
            this.pb3User.Size = new System.Drawing.Size(56, 84);
            this.pb3User.TabIndex = 23;
            this.pb3User.TabStop = false;
            // 
            // pb2User
            // 
            this.pb2User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb2User.Location = new System.Drawing.Point(248, 249);
            this.pb2User.Name = "pb2User";
            this.pb2User.Size = new System.Drawing.Size(56, 84);
            this.pb2User.TabIndex = 22;
            this.pb2User.TabStop = false;
            // 
            // pb1User
            // 
            this.pb1User.Location = new System.Drawing.Point(186, 249);
            this.pb1User.Name = "pb1User";
            this.pb1User.Size = new System.Drawing.Size(56, 84);
            this.pb1User.TabIndex = 21;
            this.pb1User.TabStop = false;
            // 
            // pb3Player
            // 
            this.pb3Player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb3Player.BackgroundImage")));
            this.pb3Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb3Player.Location = new System.Drawing.Point(310, 53);
            this.pb3Player.Name = "pb3Player";
            this.pb3Player.Size = new System.Drawing.Size(56, 84);
            this.pb3Player.TabIndex = 20;
            this.pb3Player.TabStop = false;
            // 
            // pb2Player
            // 
            this.pb2Player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb2Player.BackgroundImage")));
            this.pb2Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb2Player.Location = new System.Drawing.Point(249, 53);
            this.pb2Player.Name = "pb2Player";
            this.pb2Player.Size = new System.Drawing.Size(56, 84);
            this.pb2Player.TabIndex = 19;
            this.pb2Player.TabStop = false;
            // 
            // pb1Player
            // 
            this.pb1Player.Location = new System.Drawing.Point(187, 53);
            this.pb1Player.Name = "pb1Player";
            this.pb1Player.Size = new System.Drawing.Size(56, 84);
            this.pb1Player.TabIndex = 18;
            this.pb1Player.TabStop = false;
            // 
            // pb4Player
            // 
            this.pb4Player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb4Player.BackgroundImage")));
            this.pb4Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb4Player.Location = new System.Drawing.Point(373, 53);
            this.pb4Player.Name = "pb4Player";
            this.pb4Player.Size = new System.Drawing.Size(56, 84);
            this.pb4Player.TabIndex = 36;
            this.pb4Player.TabStop = false;
            // 
            // pb5Player
            // 
            this.pb5Player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb5Player.BackgroundImage")));
            this.pb5Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb5Player.Location = new System.Drawing.Point(435, 53);
            this.pb5Player.Name = "pb5Player";
            this.pb5Player.Size = new System.Drawing.Size(56, 84);
            this.pb5Player.TabIndex = 37;
            this.pb5Player.TabStop = false;
            // 
            // pb4User
            // 
            this.pb4User.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb4User.BackgroundImage")));
            this.pb4User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb4User.Location = new System.Drawing.Point(372, 249);
            this.pb4User.Name = "pb4User";
            this.pb4User.Size = new System.Drawing.Size(56, 84);
            this.pb4User.TabIndex = 38;
            this.pb4User.TabStop = false;
            // 
            // pb5User
            // 
            this.pb5User.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb5User.BackgroundImage")));
            this.pb5User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb5User.Location = new System.Drawing.Point(434, 249);
            this.pb5User.Name = "pb5User";
            this.pb5User.Size = new System.Drawing.Size(56, 84);
            this.pb5User.TabIndex = 39;
            this.pb5User.TabStop = false;
            // 
            // btnReady
            // 
            this.btnReady.Location = new System.Drawing.Point(682, 306);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(93, 36);
            this.btnReady.TabIndex = 31;
            this.btnReady.Text = "Ready";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // tBoxRaise
            // 
            this.tBoxRaise.Location = new System.Drawing.Point(682, 240);
            this.tBoxRaise.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxRaise.Name = "tBoxRaise";
            this.tBoxRaise.Size = new System.Drawing.Size(94, 20);
            this.tBoxRaise.TabIndex = 40;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(379, 193);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(100, 20);
            this.tbUser.TabIndex = 0;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(378, 227);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '!';
            this.tbPass.Size = new System.Drawing.Size(100, 20);
            this.tbPass.TabIndex = 1;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogIn.BackgroundImage")));
            this.btnLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.Location = new System.Drawing.Point(361, 258);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(130, 53);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // panelLogIn
            // 
            this.panelLogIn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelLogIn.Controls.Add(this.btnLogIn);
            this.panelLogIn.Controls.Add(this.tbPass);
            this.panelLogIn.Controls.Add(this.tbUser);
            this.panelLogIn.Location = new System.Drawing.Point(12, 12);
            this.panelLogIn.Margin = new System.Windows.Forms.Padding(0);
            this.panelLogIn.Name = "panelLogIn";
            this.panelLogIn.Size = new System.Drawing.Size(883, 430);
            this.panelLogIn.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(934, 453);
            this.Controls.Add(this.panelLogIn);
            this.Controls.Add(this.tBoxRaise);
            this.Controls.Add(this.pb5User);
            this.Controls.Add(this.pb4User);
            this.Controls.Add(this.pb5Player);
            this.Controls.Add(this.pb4Player);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labelPot);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.panelLobby);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.btnRaise);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.pb3User);
            this.Controls.Add(this.pb2User);
            this.Controls.Add(this.pb1User);
            this.Controls.Add(this.pb3Player);
            this.Controls.Add(this.pb2Player);
            this.Controls.Add(this.pb1Player);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelLobby.ResumeLayout(false);
            this.panelLobby.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb3User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5User)).EndInit();
            this.panelLogIn.ResumeLayout(false);
            this.panelLogIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLobby;
        private System.Windows.Forms.ListBox LbPlayersOnline;
        private System.Windows.Forms.Label labelPlayers;
        private System.Windows.Forms.Button btnSpectate;
        private System.Windows.Forms.Button btnCreateGame;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelPot;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnRaise;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.PictureBox pb3User;
        private System.Windows.Forms.PictureBox pb2User;
        private System.Windows.Forms.PictureBox pb1User;
        private System.Windows.Forms.PictureBox pb3Player;
        private System.Windows.Forms.PictureBox pb2Player;
        private System.Windows.Forms.PictureBox pb1Player;
        private System.Windows.Forms.TextBox tbChat;
        private System.Windows.Forms.ListBox lbChat;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.PictureBox pb4Player;
        private System.Windows.Forms.PictureBox pb5Player;
        private System.Windows.Forms.PictureBox pb4User;
        private System.Windows.Forms.PictureBox pb5User;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.TextBox tBoxRaise;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Panel panelLogIn;
    }
}

