using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DiscordRPGui
{
    partial class frmCombined
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
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.lblToken = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tabActions = new System.Windows.Forms.TabPage();
            this.chkSearch = new System.Windows.Forms.CheckBox();
            this.pgsSearch = new System.Windows.Forms.ProgressBar();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.chkMine = new System.Windows.Forms.CheckBox();
            this.chkForage = new System.Windows.Forms.CheckBox();
            this.chkChop = new System.Windows.Forms.CheckBox();
            this.chkFish = new System.Windows.Forms.CheckBox();
            this.pgsFish = new System.Windows.Forms.ProgressBar();
            this.cmdFish = new System.Windows.Forms.Button();
            this.pgsChop = new System.Windows.Forms.ProgressBar();
            this.cmdChop = new System.Windows.Forms.Button();
            this.pgsForage = new System.Windows.Forms.ProgressBar();
            this.cmdForage = new System.Windows.Forms.Button();
            this.pgsMine = new System.Windows.Forms.ProgressBar();
            this.cmdMine = new System.Windows.Forms.Button();
            this.tabAdventure = new System.Windows.Forms.TabPage();
            this.tabInv = new System.Windows.Forms.TabPage();
            this.tmrProgress = new System.Windows.Forms.Timer(this.components);
            this.pnlStats = new System.Windows.Forms.Panel();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblAxe = new System.Windows.Forms.Label();
            this.lblPickaxe = new System.Windows.Forms.Label();
            this.lblFishingRod = new System.Windows.Forms.Label();
            this.lblNecklace = new System.Windows.Forms.Label();
            this.lblBoots = new System.Windows.Forms.Label();
            this.lblChestplate = new System.Windows.Forms.Label();
            this.lblHelmet = new System.Windows.Forms.Label();
            this.lblRing = new System.Windows.Forms.Label();
            this.lblWeaponTitle = new System.Windows.Forms.Label();
            this.cmdStats = new System.Windows.Forms.Button();
            this.lblHealthTitle = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.tbcMain.SuspendLayout();
            this.tabLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tabActions.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tabLogin);
            this.tbcMain.Controls.Add(this.tabActions);
            this.tbcMain.Controls.Add(this.tabAdventure);
            this.tbcMain.Controls.Add(this.tabInv);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbcMain.Location = new System.Drawing.Point(0, 0);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(418, 258);
            this.tbcMain.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.chkRemember);
            this.tabLogin.Controls.Add(this.lblToken);
            this.tabLogin.Controls.Add(this.txtToken);
            this.tabLogin.Controls.Add(this.cmdClose);
            this.tabLogin.Controls.Add(this.cmdLogin);
            this.tabLogin.Controls.Add(this.picLogo);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(410, 232);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.Location = new System.Drawing.Point(232, 178);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(111, 17);
            this.chkRemember.TabIndex = 4;
            this.chkRemember.Text = "Remember Token";
            this.chkRemember.UseVisualStyleBackColor = true;
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(232, 6);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(91, 13);
            this.lblToken.TabIndex = 0;
            this.lblToken.Text = "Your User Token:";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(232, 22);
            this.txtToken.Multiline = true;
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(172, 150);
            this.txtToken.TabIndex = 1;
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(329, 201);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 3;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            // 
            // cmdLogin
            // 
            this.cmdLogin.Location = new System.Drawing.Point(232, 201);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(75, 23);
            this.cmdLogin.TabIndex = 2;
            this.cmdLogin.Text = "Login";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::DiscordRPGui.Properties.Resources.ab45017ee9809b61afc0322d66bda0c7;
            this.picLogo.Location = new System.Drawing.Point(8, 6);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(218, 218);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // tabActions
            // 
            this.tabActions.Controls.Add(this.chkSearch);
            this.tabActions.Controls.Add(this.pgsSearch);
            this.tabActions.Controls.Add(this.cmdSearch);
            this.tabActions.Controls.Add(this.chkMine);
            this.tabActions.Controls.Add(this.chkForage);
            this.tabActions.Controls.Add(this.chkChop);
            this.tabActions.Controls.Add(this.chkFish);
            this.tabActions.Controls.Add(this.pgsFish);
            this.tabActions.Controls.Add(this.cmdFish);
            this.tabActions.Controls.Add(this.pgsChop);
            this.tabActions.Controls.Add(this.cmdChop);
            this.tabActions.Controls.Add(this.pgsForage);
            this.tabActions.Controls.Add(this.cmdForage);
            this.tabActions.Controls.Add(this.pgsMine);
            this.tabActions.Controls.Add(this.cmdMine);
            this.tabActions.Location = new System.Drawing.Point(4, 22);
            this.tabActions.Name = "tabActions";
            this.tabActions.Padding = new System.Windows.Forms.Padding(3);
            this.tabActions.Size = new System.Drawing.Size(410, 232);
            this.tabActions.TabIndex = 1;
            this.tabActions.Text = "Actions";
            this.tabActions.UseVisualStyleBackColor = true;
            // 
            // chkSearch
            // 
            this.chkSearch.AutoSize = true;
            this.chkSearch.Location = new System.Drawing.Point(8, 206);
            this.chkSearch.Name = "chkSearch";
            this.chkSearch.Size = new System.Drawing.Size(15, 14);
            this.chkSearch.TabIndex = 14;
            this.chkSearch.UseVisualStyleBackColor = true;
            // 
            // pgsSearch
            // 
            this.pgsSearch.Location = new System.Drawing.Point(110, 201);
            this.pgsSearch.Maximum = 1200;
            this.pgsSearch.Name = "pgsSearch";
            this.pgsSearch.Size = new System.Drawing.Size(294, 23);
            this.pgsSearch.TabIndex = 9;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(29, 201);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(75, 23);
            this.cmdSearch.TabIndex = 8;
            this.cmdSearch.Text = "Search";
            this.cmdSearch.UseVisualStyleBackColor = true;
            // 
            // chkMine
            // 
            this.chkMine.AutoSize = true;
            this.chkMine.Location = new System.Drawing.Point(8, 11);
            this.chkMine.Name = "chkMine";
            this.chkMine.Size = new System.Drawing.Size(15, 14);
            this.chkMine.TabIndex = 10;
            this.chkMine.UseVisualStyleBackColor = true;
            // 
            // chkForage
            // 
            this.chkForage.AutoSize = true;
            this.chkForage.Location = new System.Drawing.Point(8, 40);
            this.chkForage.Name = "chkForage";
            this.chkForage.Size = new System.Drawing.Size(15, 14);
            this.chkForage.TabIndex = 11;
            this.chkForage.UseVisualStyleBackColor = true;
            // 
            // chkChop
            // 
            this.chkChop.AutoSize = true;
            this.chkChop.Location = new System.Drawing.Point(8, 69);
            this.chkChop.Name = "chkChop";
            this.chkChop.Size = new System.Drawing.Size(15, 14);
            this.chkChop.TabIndex = 12;
            this.chkChop.UseVisualStyleBackColor = true;
            // 
            // chkFish
            // 
            this.chkFish.AutoSize = true;
            this.chkFish.Location = new System.Drawing.Point(8, 98);
            this.chkFish.Name = "chkFish";
            this.chkFish.Size = new System.Drawing.Size(15, 14);
            this.chkFish.TabIndex = 13;
            this.chkFish.UseVisualStyleBackColor = true;
            // 
            // pgsFish
            // 
            this.pgsFish.Location = new System.Drawing.Point(110, 93);
            this.pgsFish.Maximum = 1200;
            this.pgsFish.Name = "pgsFish";
            this.pgsFish.Size = new System.Drawing.Size(294, 23);
            this.pgsFish.TabIndex = 7;
            // 
            // cmdFish
            // 
            this.cmdFish.Location = new System.Drawing.Point(29, 93);
            this.cmdFish.Name = "cmdFish";
            this.cmdFish.Size = new System.Drawing.Size(75, 23);
            this.cmdFish.TabIndex = 6;
            this.cmdFish.Text = "Fish";
            this.cmdFish.UseVisualStyleBackColor = true;
            // 
            // pgsChop
            // 
            this.pgsChop.Location = new System.Drawing.Point(110, 64);
            this.pgsChop.Maximum = 1200;
            this.pgsChop.Name = "pgsChop";
            this.pgsChop.Size = new System.Drawing.Size(294, 23);
            this.pgsChop.TabIndex = 5;
            // 
            // cmdChop
            // 
            this.cmdChop.Location = new System.Drawing.Point(29, 64);
            this.cmdChop.Name = "cmdChop";
            this.cmdChop.Size = new System.Drawing.Size(75, 23);
            this.cmdChop.TabIndex = 4;
            this.cmdChop.Text = "Chop";
            this.cmdChop.UseVisualStyleBackColor = true;
            // 
            // pgsForage
            // 
            this.pgsForage.Location = new System.Drawing.Point(110, 35);
            this.pgsForage.Maximum = 1200;
            this.pgsForage.Name = "pgsForage";
            this.pgsForage.Size = new System.Drawing.Size(294, 23);
            this.pgsForage.TabIndex = 3;
            // 
            // cmdForage
            // 
            this.cmdForage.Location = new System.Drawing.Point(29, 35);
            this.cmdForage.Name = "cmdForage";
            this.cmdForage.Size = new System.Drawing.Size(75, 23);
            this.cmdForage.TabIndex = 2;
            this.cmdForage.Text = "Forage";
            this.cmdForage.UseVisualStyleBackColor = true;
            // 
            // pgsMine
            // 
            this.pgsMine.Location = new System.Drawing.Point(110, 6);
            this.pgsMine.Maximum = 1200;
            this.pgsMine.Name = "pgsMine";
            this.pgsMine.Size = new System.Drawing.Size(294, 23);
            this.pgsMine.TabIndex = 1;
            // 
            // cmdMine
            // 
            this.cmdMine.Location = new System.Drawing.Point(29, 6);
            this.cmdMine.Name = "cmdMine";
            this.cmdMine.Size = new System.Drawing.Size(75, 23);
            this.cmdMine.TabIndex = 0;
            this.cmdMine.Text = "Mine";
            this.cmdMine.UseVisualStyleBackColor = true;
            // 
            // tabAdventure
            // 
            this.tabAdventure.Location = new System.Drawing.Point(4, 22);
            this.tabAdventure.Name = "tabAdventure";
            this.tabAdventure.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdventure.Size = new System.Drawing.Size(410, 232);
            this.tabAdventure.TabIndex = 2;
            this.tabAdventure.Text = "Adventure";
            this.tabAdventure.UseVisualStyleBackColor = true;
            // 
            // tabInv
            // 
            this.tabInv.Location = new System.Drawing.Point(4, 22);
            this.tabInv.Name = "tabInv";
            this.tabInv.Padding = new System.Windows.Forms.Padding(3);
            this.tabInv.Size = new System.Drawing.Size(410, 232);
            this.tabInv.TabIndex = 3;
            this.tabInv.Text = "Inventory";
            this.tabInv.UseVisualStyleBackColor = true;
            // 
            // tmrProgress
            // 
            this.tmrProgress.Enabled = true;
            this.tmrProgress.Interval = 10;
            this.tmrProgress.Tick += new System.EventHandler(this.tmrProgress_Tick);
            // 
            // pnlStats
            // 
            this.pnlStats.Controls.Add(this.lblExp);
            this.pnlStats.Controls.Add(this.lblAxe);
            this.pnlStats.Controls.Add(this.lblPickaxe);
            this.pnlStats.Controls.Add(this.lblFishingRod);
            this.pnlStats.Controls.Add(this.lblNecklace);
            this.pnlStats.Controls.Add(this.lblBoots);
            this.pnlStats.Controls.Add(this.lblChestplate);
            this.pnlStats.Controls.Add(this.lblHelmet);
            this.pnlStats.Controls.Add(this.lblRing);
            this.pnlStats.Controls.Add(this.lblWeaponTitle);
            this.pnlStats.Controls.Add(this.cmdStats);
            this.pnlStats.Controls.Add(this.lblHealthTitle);
            this.pnlStats.Controls.Add(this.lblStats);
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlStats.Enabled = false;
            this.pnlStats.Location = new System.Drawing.Point(420, 0);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(215, 258);
            this.pnlStats.TabIndex = 1;
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(10, 41);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(95, 13);
            this.lblExp.TabIndex = 12;
            this.lblExp.Text = "Experience: 0/200";
            // 
            // lblAxe
            // 
            this.lblAxe.AutoSize = true;
            this.lblAxe.Location = new System.Drawing.Point(10, 158);
            this.lblAxe.Name = "lblAxe";
            this.lblAxe.Size = new System.Drawing.Size(57, 13);
            this.lblAxe.TabIndex = 11;
            this.lblAxe.Text = "Axe: None";
            // 
            // lblPickaxe
            // 
            this.lblPickaxe.AutoSize = true;
            this.lblPickaxe.Location = new System.Drawing.Point(10, 145);
            this.lblPickaxe.Name = "lblPickaxe";
            this.lblPickaxe.Size = new System.Drawing.Size(77, 13);
            this.lblPickaxe.TabIndex = 10;
            this.lblPickaxe.Text = "Pickaxe: None";
            // 
            // lblFishingRod
            // 
            this.lblFishingRod.AutoSize = true;
            this.lblFishingRod.Location = new System.Drawing.Point(10, 132);
            this.lblFishingRod.Name = "lblFishingRod";
            this.lblFishingRod.Size = new System.Drawing.Size(95, 13);
            this.lblFishingRod.TabIndex = 9;
            this.lblFishingRod.Text = "Fishing Rod: None";
            // 
            // lblNecklace
            // 
            this.lblNecklace.AutoSize = true;
            this.lblNecklace.Location = new System.Drawing.Point(10, 119);
            this.lblNecklace.Name = "lblNecklace";
            this.lblNecklace.Size = new System.Drawing.Size(85, 13);
            this.lblNecklace.TabIndex = 8;
            this.lblNecklace.Text = "Necklace: None";
            // 
            // lblBoots
            // 
            this.lblBoots.AutoSize = true;
            this.lblBoots.Location = new System.Drawing.Point(10, 106);
            this.lblBoots.Name = "lblBoots";
            this.lblBoots.Size = new System.Drawing.Size(66, 13);
            this.lblBoots.TabIndex = 7;
            this.lblBoots.Text = "Boots: None";
            // 
            // lblChestplate
            // 
            this.lblChestplate.AutoSize = true;
            this.lblChestplate.Location = new System.Drawing.Point(10, 93);
            this.lblChestplate.Name = "lblChestplate";
            this.lblChestplate.Size = new System.Drawing.Size(89, 13);
            this.lblChestplate.TabIndex = 6;
            this.lblChestplate.Text = "Chestplate: None";
            // 
            // lblHelmet
            // 
            this.lblHelmet.AutoSize = true;
            this.lblHelmet.Location = new System.Drawing.Point(10, 80);
            this.lblHelmet.Name = "lblHelmet";
            this.lblHelmet.Size = new System.Drawing.Size(72, 13);
            this.lblHelmet.TabIndex = 5;
            this.lblHelmet.Text = "Helmet: None";
            // 
            // lblRing
            // 
            this.lblRing.AutoSize = true;
            this.lblRing.Location = new System.Drawing.Point(10, 67);
            this.lblRing.Name = "lblRing";
            this.lblRing.Size = new System.Drawing.Size(61, 13);
            this.lblRing.TabIndex = 4;
            this.lblRing.Text = "Ring: None";
            // 
            // lblWeaponTitle
            // 
            this.lblWeaponTitle.AutoSize = true;
            this.lblWeaponTitle.Location = new System.Drawing.Point(10, 54);
            this.lblWeaponTitle.Name = "lblWeaponTitle";
            this.lblWeaponTitle.Size = new System.Drawing.Size(117, 13);
            this.lblWeaponTitle.TabIndex = 3;
            this.lblWeaponTitle.Text = "Weapon: Small Dagger";
            // 
            // cmdStats
            // 
            this.cmdStats.Location = new System.Drawing.Point(77, 223);
            this.cmdStats.Name = "cmdStats";
            this.cmdStats.Size = new System.Drawing.Size(75, 23);
            this.cmdStats.TabIndex = 2;
            this.cmdStats.Text = "Refresh";
            this.cmdStats.UseVisualStyleBackColor = true;
            // 
            // lblHealthTitle
            // 
            this.lblHealthTitle.AutoSize = true;
            this.lblHealthTitle.Location = new System.Drawing.Point(10, 28);
            this.lblHealthTitle.Name = "lblHealthTitle";
            this.lblHealthTitle.Size = new System.Drawing.Size(87, 13);
            this.lblHealthTitle.TabIndex = 1;
            this.lblHealthTitle.Text = "Hit Points: 50/50";
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Location = new System.Drawing.Point(10, 9);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(31, 13);
            this.lblStats.TabIndex = 0;
            this.lblStats.Text = "Stats";
            // 
            // frmCombined
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 258);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.tbcMain);
            this.Name = "frmCombined";
            this.Text = "Discord RPG UI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCombined_FormClosing);
            this.Load += new System.EventHandler(this.frmCombined_Load);
            this.tbcMain.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tabActions.ResumeLayout(false);
            this.tabActions.PerformLayout();
            this.pnlStats.ResumeLayout(false);
            this.pnlStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabActions;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ProgressBar pgsMine;
        private System.Windows.Forms.Button cmdMine;
        private System.Windows.Forms.Timer tmrProgress;
        private System.Windows.Forms.CheckBox chkMine;
        private System.Windows.Forms.CheckBox chkForage;
        private System.Windows.Forms.CheckBox chkChop;
        private System.Windows.Forms.CheckBox chkFish;
        private System.Windows.Forms.ProgressBar pgsFish;
        private System.Windows.Forms.Button cmdFish;
        private System.Windows.Forms.ProgressBar pgsChop;
        private System.Windows.Forms.Button cmdChop;
        private System.Windows.Forms.ProgressBar pgsForage;
        private System.Windows.Forms.Button cmdForage;
        private System.Windows.Forms.CheckBox chkSearch;
        private System.Windows.Forms.ProgressBar pgsSearch;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.TabPage tabAdventure;
        private System.Windows.Forms.TabPage tabInv;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.Label lblWeaponTitle;
        private System.Windows.Forms.Button cmdStats;
        private System.Windows.Forms.Label lblHealthTitle;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblAxe;
        private System.Windows.Forms.Label lblPickaxe;
        private System.Windows.Forms.Label lblFishingRod;
        private System.Windows.Forms.Label lblNecklace;
        private System.Windows.Forms.Label lblBoots;
        private System.Windows.Forms.Label lblChestplate;
        private System.Windows.Forms.Label lblHelmet;
        private System.Windows.Forms.Label lblRing;
    }
}