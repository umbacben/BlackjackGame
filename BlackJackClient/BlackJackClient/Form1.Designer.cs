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
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.panelLobby = new System.Windows.Forms.Panel();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnPlaySolo = new System.Windows.Forms.Button();
            this.btnSpectate = new System.Windows.Forms.Button();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.LbPlayersOnline = new System.Windows.Forms.ListBox();
            this.panelGame = new System.Windows.Forms.Panel();
            this.pb1Player1 = new System.Windows.Forms.PictureBox();
            this.pb2Player1 = new System.Windows.Forms.PictureBox();
            this.pb3Player1 = new System.Windows.Forms.PictureBox();
            this.pb3User = new System.Windows.Forms.PictureBox();
            this.pb2User = new System.Windows.Forms.PictureBox();
            this.pb1User = new System.Windows.Forms.PictureBox();
            this.pb3Dealer = new System.Windows.Forms.PictureBox();
            this.pb2Dealer = new System.Windows.Forms.PictureBox();
            this.pb1Dealer = new System.Windows.Forms.PictureBox();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelDealer = new System.Windows.Forms.Label();
            this.btnRaise = new System.Windows.Forms.Button();
            this.btnCall = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.labelPot = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelLogIn.SuspendLayout();
            this.panelLobby.SuspendLayout();
            this.panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3Dealer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2Dealer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1Dealer)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogIn
            // 
            this.panelLogIn.Controls.Add(this.btnLogIn);
            this.panelLogIn.Controls.Add(this.tbPass);
            this.panelLogIn.Controls.Add(this.tbUser);
            this.panelLogIn.Location = new System.Drawing.Point(12, 12);
            this.panelLogIn.Name = "panelLogIn";
            this.panelLogIn.Size = new System.Drawing.Size(730, 382);
            this.panelLogIn.TabIndex = 0;
            this.panelLogIn.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(330, 171);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(315, 145);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '!';
            this.tbPass.Size = new System.Drawing.Size(100, 20);
            this.tbPass.TabIndex = 1;
            this.tbPass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(315, 119);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(100, 20);
            this.tbUser.TabIndex = 0;
            this.tbUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panelLobby
            // 
            this.panelLobby.Controls.Add(this.panelGame);
            this.panelLobby.Controls.Add(this.LbPlayersOnline);
            this.panelLobby.Controls.Add(this.labelPlayers);
            this.panelLobby.Controls.Add(this.btnSpectate);
            this.panelLobby.Controls.Add(this.btnPlaySolo);
            this.panelLobby.Controls.Add(this.btnJoin);
            this.panelLobby.Location = new System.Drawing.Point(15, 9);
            this.panelLobby.Name = "panelLobby";
            this.panelLobby.Size = new System.Drawing.Size(730, 382);
            this.panelLobby.TabIndex = 3;
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(191, 62);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(242, 77);
            this.btnJoin.TabIndex = 0;
            this.btnJoin.Text = "Join Player";
            this.btnJoin.UseVisualStyleBackColor = true;
            // 
            // btnPlaySolo
            // 
            this.btnPlaySolo.Location = new System.Drawing.Point(191, 144);
            this.btnPlaySolo.Name = "btnPlaySolo";
            this.btnPlaySolo.Size = new System.Drawing.Size(242, 77);
            this.btnPlaySolo.TabIndex = 1;
            this.btnPlaySolo.Text = "Play Solo";
            this.btnPlaySolo.UseVisualStyleBackColor = true;
            this.btnPlaySolo.Click += new System.EventHandler(this.btnPlaySolo_Click);
            // 
            // btnSpectate
            // 
            this.btnSpectate.Location = new System.Drawing.Point(191, 301);
            this.btnSpectate.Name = "btnSpectate";
            this.btnSpectate.Size = new System.Drawing.Size(242, 54);
            this.btnSpectate.TabIndex = 2;
            this.btnSpectate.Text = "Spectate Game";
            this.btnSpectate.UseVisualStyleBackColor = true;
            this.btnSpectate.Click += new System.EventHandler(this.btnSpectate_Click);
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
            // LbPlayersOnline
            // 
            this.LbPlayersOnline.FormattingEnabled = true;
            this.LbPlayersOnline.Location = new System.Drawing.Point(606, 44);
            this.LbPlayersOnline.Name = "LbPlayersOnline";
            this.LbPlayersOnline.Size = new System.Drawing.Size(120, 95);
            this.LbPlayersOnline.TabIndex = 4;
            // 
            // panelGame
            // 
            this.panelGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGame.Controls.Add(this.btnExit);
            this.panelGame.Controls.Add(this.labelPot);
            this.panelGame.Controls.Add(this.btnStand);
            this.panelGame.Controls.Add(this.btnHit);
            this.panelGame.Controls.Add(this.btnCall);
            this.panelGame.Controls.Add(this.btnRaise);
            this.panelGame.Controls.Add(this.labelDealer);
            this.panelGame.Controls.Add(this.labelUser);
            this.panelGame.Controls.Add(this.labelPlayer1);
            this.panelGame.Controls.Add(this.pb3Dealer);
            this.panelGame.Controls.Add(this.pb2Dealer);
            this.panelGame.Controls.Add(this.pb1Dealer);
            this.panelGame.Controls.Add(this.pb3User);
            this.panelGame.Controls.Add(this.pb2User);
            this.panelGame.Controls.Add(this.pb1User);
            this.panelGame.Controls.Add(this.pb3Player1);
            this.panelGame.Controls.Add(this.pb2Player1);
            this.panelGame.Controls.Add(this.pb1Player1);
            this.panelGame.Location = new System.Drawing.Point(0, 0);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(730, 385);
            this.panelGame.TabIndex = 5;
            // 
            // pb1Player1
            // 
            this.pb1Player1.Location = new System.Drawing.Point(41, 222);
            this.pb1Player1.Name = "pb1Player1";
            this.pb1Player1.Size = new System.Drawing.Size(56, 84);
            this.pb1Player1.TabIndex = 0;
            this.pb1Player1.TabStop = false;
            // 
            // pb2Player1
            // 
            this.pb2Player1.Location = new System.Drawing.Point(103, 222);
            this.pb2Player1.Name = "pb2Player1";
            this.pb2Player1.Size = new System.Drawing.Size(56, 84);
            this.pb2Player1.TabIndex = 1;
            this.pb2Player1.TabStop = false;
            // 
            // pb3Player1
            // 
            this.pb3Player1.Location = new System.Drawing.Point(165, 222);
            this.pb3Player1.Name = "pb3Player1";
            this.pb3Player1.Size = new System.Drawing.Size(56, 84);
            this.pb3Player1.TabIndex = 2;
            this.pb3Player1.TabStop = false;
            // 
            // pb3User
            // 
            this.pb3User.Location = new System.Drawing.Point(492, 222);
            this.pb3User.Name = "pb3User";
            this.pb3User.Size = new System.Drawing.Size(56, 84);
            this.pb3User.TabIndex = 5;
            this.pb3User.TabStop = false;
            // 
            // pb2User
            // 
            this.pb2User.Location = new System.Drawing.Point(430, 222);
            this.pb2User.Name = "pb2User";
            this.pb2User.Size = new System.Drawing.Size(56, 84);
            this.pb2User.TabIndex = 4;
            this.pb2User.TabStop = false;
            // 
            // pb1User
            // 
            this.pb1User.Location = new System.Drawing.Point(368, 222);
            this.pb1User.Name = "pb1User";
            this.pb1User.Size = new System.Drawing.Size(56, 84);
            this.pb1User.TabIndex = 3;
            this.pb1User.TabStop = false;
            // 
            // pb3Dealer
            // 
            this.pb3Dealer.Location = new System.Drawing.Point(373, 43);
            this.pb3Dealer.Name = "pb3Dealer";
            this.pb3Dealer.Size = new System.Drawing.Size(56, 84);
            this.pb3Dealer.TabIndex = 8;
            this.pb3Dealer.TabStop = false;
            // 
            // pb2Dealer
            // 
            this.pb2Dealer.Location = new System.Drawing.Point(311, 43);
            this.pb2Dealer.Name = "pb2Dealer";
            this.pb2Dealer.Size = new System.Drawing.Size(56, 84);
            this.pb2Dealer.TabIndex = 7;
            this.pb2Dealer.TabStop = false;
            // 
            // pb1Dealer
            // 
            this.pb1Dealer.Location = new System.Drawing.Point(249, 43);
            this.pb1Dealer.Name = "pb1Dealer";
            this.pb1Dealer.Size = new System.Drawing.Size(56, 84);
            this.pb1Dealer.TabIndex = 6;
            this.pb1Dealer.TabStop = false;
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Location = new System.Drawing.Point(100, 195);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(42, 13);
            this.labelPlayer1.TabIndex = 9;
            this.labelPlayer1.Text = "Player1";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(438, 195);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(29, 13);
            this.labelUser.TabIndex = 10;
            this.labelUser.Text = "User";
            // 
            // labelDealer
            // 
            this.labelDealer.AutoSize = true;
            this.labelDealer.Location = new System.Drawing.Point(308, 11);
            this.labelDealer.Name = "labelDealer";
            this.labelDealer.Size = new System.Drawing.Size(38, 13);
            this.labelDealer.TabIndex = 11;
            this.labelDealer.Text = "Dealer";
            // 
            // btnRaise
            // 
            this.btnRaise.Location = new System.Drawing.Point(605, 195);
            this.btnRaise.Name = "btnRaise";
            this.btnRaise.Size = new System.Drawing.Size(93, 36);
            this.btnRaise.TabIndex = 12;
            this.btnRaise.Text = "Raise";
            this.btnRaise.UseVisualStyleBackColor = true;
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(605, 237);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(93, 36);
            this.btnCall.TabIndex = 13;
            this.btnCall.Text = "Call";
            this.btnCall.UseVisualStyleBackColor = true;
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(368, 318);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(88, 36);
            this.btnHit.TabIndex = 14;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(462, 318);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(88, 36);
            this.btnStand.TabIndex = 15;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            // 
            // labelPot
            // 
            this.labelPot.AutoSize = true;
            this.labelPot.Location = new System.Drawing.Point(308, 157);
            this.labelPot.Name = "labelPot";
            this.labelPot.Size = new System.Drawing.Size(59, 13);
            this.labelPot.TabIndex = 16;
            this.labelPot.Text = "PotAmount";
            this.labelPot.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(654, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 406);
            this.Controls.Add(this.panelLobby);
            this.Controls.Add(this.panelLogIn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelLogIn.ResumeLayout(false);
            this.panelLogIn.PerformLayout();
            this.panelLobby.ResumeLayout(false);
            this.panelLobby.PerformLayout();
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3Dealer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2Dealer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1Dealer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogIn;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Panel panelLobby;
        private System.Windows.Forms.ListBox LbPlayersOnline;
        private System.Windows.Forms.Label labelPlayers;
        private System.Windows.Forms.Button btnSpectate;
        private System.Windows.Forms.Button btnPlaySolo;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Label labelPot;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.Button btnRaise;
        private System.Windows.Forms.Label labelDealer;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.PictureBox pb3Dealer;
        private System.Windows.Forms.PictureBox pb2Dealer;
        private System.Windows.Forms.PictureBox pb1Dealer;
        private System.Windows.Forms.PictureBox pb3User;
        private System.Windows.Forms.PictureBox pb2User;
        private System.Windows.Forms.PictureBox pb1User;
        private System.Windows.Forms.PictureBox pb3Player1;
        private System.Windows.Forms.PictureBox pb2Player1;
        private System.Windows.Forms.PictureBox pb1Player1;
        private System.Windows.Forms.Button btnExit;
    }
}

