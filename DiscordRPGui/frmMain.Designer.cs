namespace DiscordRPGui
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.pnlAdventure = new System.Windows.Forms.Panel();
            this.lblAdventure = new System.Windows.Forms.Label();
            this.cmdAdventure = new System.Windows.Forms.Button();
            this.ProgressBar2 = new System.Windows.Forms.ProgressBar();
            this.cmdHeal = new System.Windows.Forms.Button();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.btnStatsRefresh = new System.Windows.Forms.Button();
            this.lblStatsTitle = new System.Windows.Forms.Label();
            this.lblLoggedInAs = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.lblActions = new System.Windows.Forms.Label();
            this.pgsFish = new System.Windows.Forms.ProgressBar();
            this.pgsChop = new System.Windows.Forms.ProgressBar();
            this.pgsForage = new System.Windows.Forms.ProgressBar();
            this.pgsMine = new System.Windows.Forms.ProgressBar();
            this.cmdAllActions = new System.Windows.Forms.Button();
            this.chkFish = new System.Windows.Forms.CheckBox();
            this.cmdFish = new System.Windows.Forms.Button();
            this.chkChop = new System.Windows.Forms.CheckBox();
            this.cmdChop = new System.Windows.Forms.Button();
            this.chkForage = new System.Windows.Forms.CheckBox();
            this.cmdForage = new System.Windows.Forms.Button();
            this.chkMine = new System.Windows.Forms.CheckBox();
            this.cmdMine = new System.Windows.Forms.Button();
            this.tmrProgress = new System.Windows.Forms.Timer(this.components);
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAdventure.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAdventure
            // 
            this.pnlAdventure.Controls.Add(this.lblAdventure);
            this.pnlAdventure.Controls.Add(this.cmdAdventure);
            this.pnlAdventure.Controls.Add(this.ProgressBar2);
            this.pnlAdventure.Controls.Add(this.cmdHeal);
            this.pnlAdventure.Controls.Add(this.ProgressBar1);
            this.pnlAdventure.Location = new System.Drawing.Point(204, 12);
            this.pnlAdventure.Name = "pnlAdventure";
            this.pnlAdventure.Size = new System.Drawing.Size(163, 166);
            this.pnlAdventure.TabIndex = 17;
            // 
            // lblAdventure
            // 
            this.lblAdventure.AutoSize = true;
            this.lblAdventure.Location = new System.Drawing.Point(3, 3);
            this.lblAdventure.Name = "lblAdventure";
            this.lblAdventure.Size = new System.Drawing.Size(56, 13);
            this.lblAdventure.TabIndex = 17;
            this.lblAdventure.Text = "Adventure";
            // 
            // cmdAdventure
            // 
            this.cmdAdventure.Location = new System.Drawing.Point(3, 19);
            this.cmdAdventure.Name = "cmdAdventure";
            this.cmdAdventure.Size = new System.Drawing.Size(75, 23);
            this.cmdAdventure.TabIndex = 6;
            this.cmdAdventure.Text = "Adventure";
            this.cmdAdventure.UseVisualStyleBackColor = true;
            // 
            // ProgressBar2
            // 
            this.ProgressBar2.Location = new System.Drawing.Point(84, 48);
            this.ProgressBar2.Maximum = 60;
            this.ProgressBar2.Name = "ProgressBar2";
            this.ProgressBar2.Size = new System.Drawing.Size(75, 23);
            this.ProgressBar2.TabIndex = 11;
            this.ProgressBar2.Value = 60;
            // 
            // cmdHeal
            // 
            this.cmdHeal.Location = new System.Drawing.Point(84, 19);
            this.cmdHeal.Name = "cmdHeal";
            this.cmdHeal.Size = new System.Drawing.Size(75, 23);
            this.cmdHeal.TabIndex = 7;
            this.cmdHeal.Text = "Heal";
            this.cmdHeal.UseVisualStyleBackColor = true;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(3, 48);
            this.ProgressBar1.Maximum = 60;
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(75, 23);
            this.ProgressBar1.TabIndex = 10;
            this.ProgressBar1.Value = 60;
            // 
            // pnlStats
            // 
            this.pnlStats.Controls.Add(this.btnStatsRefresh);
            this.pnlStats.Controls.Add(this.lblStatsTitle);
            this.pnlStats.Location = new System.Drawing.Point(373, 12);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(123, 166);
            this.pnlStats.TabIndex = 16;
            // 
            // btnStatsRefresh
            // 
            this.btnStatsRefresh.Location = new System.Drawing.Point(97, 3);
            this.btnStatsRefresh.Name = "btnStatsRefresh";
            this.btnStatsRefresh.Size = new System.Drawing.Size(23, 23);
            this.btnStatsRefresh.TabIndex = 9;
            this.btnStatsRefresh.Text = "↺";
            this.btnStatsRefresh.UseVisualStyleBackColor = true;
            // 
            // lblStatsTitle
            // 
            this.lblStatsTitle.AutoSize = true;
            this.lblStatsTitle.Location = new System.Drawing.Point(3, 3);
            this.lblStatsTitle.Name = "lblStatsTitle";
            this.lblStatsTitle.Size = new System.Drawing.Size(76, 13);
            this.lblStatsTitle.TabIndex = 8;
            this.lblStatsTitle.Text = "MrHero\'s Stats";
            // 
            // lblLoggedInAs
            // 
            this.lblLoggedInAs.AutoSize = true;
            this.lblLoggedInAs.Location = new System.Drawing.Point(93, 189);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.Size = new System.Drawing.Size(181, 13);
            this.lblLoggedInAs.TabIndex = 15;
            this.lblLoggedInAs.Text = "Currently Logged in as MrHero#1234";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 184);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.label1);
            this.pnlActions.Controls.Add(this.chkAll);
            this.pnlActions.Controls.Add(this.lblActions);
            this.pnlActions.Controls.Add(this.pgsFish);
            this.pnlActions.Controls.Add(this.pgsChop);
            this.pnlActions.Controls.Add(this.pgsForage);
            this.pnlActions.Controls.Add(this.pgsMine);
            this.pnlActions.Controls.Add(this.cmdAllActions);
            this.pnlActions.Controls.Add(this.chkFish);
            this.pnlActions.Controls.Add(this.cmdFish);
            this.pnlActions.Controls.Add(this.chkChop);
            this.pnlActions.Controls.Add(this.cmdChop);
            this.pnlActions.Controls.Add(this.chkForage);
            this.pnlActions.Controls.Add(this.cmdForage);
            this.pnlActions.Controls.Add(this.chkMine);
            this.pnlActions.Controls.Add(this.cmdMine);
            this.pnlActions.Location = new System.Drawing.Point(12, 12);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(186, 166);
            this.pnlActions.TabIndex = 13;
            // 
            // lblActions
            // 
            this.lblActions.AutoSize = true;
            this.lblActions.Location = new System.Drawing.Point(2, 3);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(42, 13);
            this.lblActions.TabIndex = 16;
            this.lblActions.Text = "Actions";
            // 
            // pgsFish
            // 
            this.pgsFish.Location = new System.Drawing.Point(107, 106);
            this.pgsFish.Maximum = 600;
            this.pgsFish.Name = "pgsFish";
            this.pgsFish.Size = new System.Drawing.Size(75, 23);
            this.pgsFish.TabIndex = 15;
            this.pgsFish.Value = 600;
            // 
            // pgsChop
            // 
            this.pgsChop.Location = new System.Drawing.Point(107, 77);
            this.pgsChop.Maximum = 600;
            this.pgsChop.Name = "pgsChop";
            this.pgsChop.Size = new System.Drawing.Size(75, 23);
            this.pgsChop.TabIndex = 14;
            this.pgsChop.Value = 600;
            // 
            // pgsForage
            // 
            this.pgsForage.Location = new System.Drawing.Point(107, 48);
            this.pgsForage.Maximum = 600;
            this.pgsForage.Name = "pgsForage";
            this.pgsForage.Size = new System.Drawing.Size(75, 23);
            this.pgsForage.TabIndex = 13;
            this.pgsForage.Value = 600;
            // 
            // pgsMine
            // 
            this.pgsMine.Location = new System.Drawing.Point(107, 19);
            this.pgsMine.Maximum = 600;
            this.pgsMine.Name = "pgsMine";
            this.pgsMine.Size = new System.Drawing.Size(75, 23);
            this.pgsMine.TabIndex = 12;
            this.pgsMine.Value = 600;
            // 
            // cmdAllActions
            // 
            this.cmdAllActions.Location = new System.Drawing.Point(107, 135);
            this.cmdAllActions.Name = "cmdAllActions";
            this.cmdAllActions.Size = new System.Drawing.Size(75, 23);
            this.cmdAllActions.TabIndex = 8;
            this.cmdAllActions.Text = "Do Selected";
            this.cmdAllActions.UseVisualStyleBackColor = true;
            this.cmdAllActions.Click += new System.EventHandler(this.cmdAllActions_Click);
            // 
            // chkFish
            // 
            this.chkFish.AutoSize = true;
            this.chkFish.Location = new System.Drawing.Point(5, 111);
            this.chkFish.Name = "chkFish";
            this.chkFish.Size = new System.Drawing.Size(15, 14);
            this.chkFish.TabIndex = 7;
            this.chkFish.UseVisualStyleBackColor = true;
            // 
            // cmdFish
            // 
            this.cmdFish.Location = new System.Drawing.Point(26, 106);
            this.cmdFish.Name = "cmdFish";
            this.cmdFish.Size = new System.Drawing.Size(75, 23);
            this.cmdFish.TabIndex = 6;
            this.cmdFish.Text = "Fish";
            this.cmdFish.UseVisualStyleBackColor = true;
            this.cmdFish.Click += new System.EventHandler(this.cmdFish_Click);
            // 
            // chkChop
            // 
            this.chkChop.AutoSize = true;
            this.chkChop.Location = new System.Drawing.Point(5, 82);
            this.chkChop.Name = "chkChop";
            this.chkChop.Size = new System.Drawing.Size(15, 14);
            this.chkChop.TabIndex = 5;
            this.chkChop.UseVisualStyleBackColor = true;
            // 
            // cmdChop
            // 
            this.cmdChop.Location = new System.Drawing.Point(26, 77);
            this.cmdChop.Name = "cmdChop";
            this.cmdChop.Size = new System.Drawing.Size(75, 23);
            this.cmdChop.TabIndex = 4;
            this.cmdChop.Text = "Chop";
            this.cmdChop.UseVisualStyleBackColor = true;
            this.cmdChop.Click += new System.EventHandler(this.cmdChop_Click);
            // 
            // chkForage
            // 
            this.chkForage.AutoSize = true;
            this.chkForage.Location = new System.Drawing.Point(5, 53);
            this.chkForage.Name = "chkForage";
            this.chkForage.Size = new System.Drawing.Size(15, 14);
            this.chkForage.TabIndex = 3;
            this.chkForage.UseVisualStyleBackColor = true;
            // 
            // cmdForage
            // 
            this.cmdForage.Location = new System.Drawing.Point(26, 48);
            this.cmdForage.Name = "cmdForage";
            this.cmdForage.Size = new System.Drawing.Size(75, 23);
            this.cmdForage.TabIndex = 2;
            this.cmdForage.Text = "Forage";
            this.cmdForage.UseVisualStyleBackColor = true;
            this.cmdForage.Click += new System.EventHandler(this.cmdForage_Click);
            // 
            // chkMine
            // 
            this.chkMine.AutoSize = true;
            this.chkMine.Location = new System.Drawing.Point(5, 24);
            this.chkMine.Name = "chkMine";
            this.chkMine.Size = new System.Drawing.Size(15, 14);
            this.chkMine.TabIndex = 1;
            this.chkMine.UseVisualStyleBackColor = true;
            // 
            // cmdMine
            // 
            this.cmdMine.Location = new System.Drawing.Point(26, 19);
            this.cmdMine.Name = "cmdMine";
            this.cmdMine.Size = new System.Drawing.Size(75, 23);
            this.cmdMine.TabIndex = 0;
            this.cmdMine.Text = "Mine";
            this.cmdMine.UseVisualStyleBackColor = true;
            this.cmdMine.Click += new System.EventHandler(this.cmdMine_Click);
            // 
            // tmrProgress
            // 
            this.tmrProgress.Enabled = true;
            this.tmrProgress.Tick += new System.EventHandler(this.tmrProgress_Tick);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(5, 139);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(15, 14);
            this.chkAll.TabIndex = 17;
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Select All";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 218);
            this.Controls.Add(this.pnlAdventure);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.lblLoggedInAs);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pnlActions);
            this.Name = "frmMain";
            this.Text = "MrHero\'s Adventure";
            this.pnlAdventure.ResumeLayout(false);
            this.pnlAdventure.PerformLayout();
            this.pnlStats.ResumeLayout(false);
            this.pnlStats.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel pnlAdventure;
        internal System.Windows.Forms.Label lblAdventure;
        internal System.Windows.Forms.Button cmdAdventure;
        internal System.Windows.Forms.ProgressBar ProgressBar2;
        internal System.Windows.Forms.Button cmdHeal;
        internal System.Windows.Forms.ProgressBar ProgressBar1;
        internal System.Windows.Forms.Panel pnlStats;
        internal System.Windows.Forms.Button btnStatsRefresh;
        internal System.Windows.Forms.Label lblStatsTitle;
        internal System.Windows.Forms.Label lblLoggedInAs;
        internal System.Windows.Forms.Button btnLogout;
        internal System.Windows.Forms.Panel pnlActions;
        internal System.Windows.Forms.Label lblActions;
        internal System.Windows.Forms.ProgressBar pgsFish;
        internal System.Windows.Forms.ProgressBar pgsChop;
        internal System.Windows.Forms.ProgressBar pgsForage;
        internal System.Windows.Forms.ProgressBar pgsMine;
        internal System.Windows.Forms.Button cmdAllActions;
        internal System.Windows.Forms.CheckBox chkFish;
        internal System.Windows.Forms.Button cmdFish;
        internal System.Windows.Forms.CheckBox chkChop;
        internal System.Windows.Forms.Button cmdChop;
        internal System.Windows.Forms.CheckBox chkForage;
        internal System.Windows.Forms.Button cmdForage;
        internal System.Windows.Forms.CheckBox chkMine;
        internal System.Windows.Forms.Button cmdMine;
        private System.Windows.Forms.Timer tmrProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkAll;
    }
}

