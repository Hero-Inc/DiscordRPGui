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
            this.cmdSelected = new System.Windows.Forms.Button();
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
            this.pnlAdvSummery = new System.Windows.Forms.Panel();
            this.lblAdventure = new System.Windows.Forms.Label();
            this.pgsHeal = new System.Windows.Forms.ProgressBar();
            this.cmdHeal = new System.Windows.Forms.Button();
            this.pgsAdv = new System.Windows.Forms.ProgressBar();
            this.cmdAdv = new System.Windows.Forms.Button();
            this.tabInv = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tmrProgress = new System.Windows.Forms.Timer(this.components);
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.lblChannel = new System.Windows.Forms.Label();
            this.cmdSaveSettings = new System.Windows.Forms.Button();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.pnlMessages = new System.Windows.Forms.Panel();
            this.cmdSend = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblWeapon = new System.Windows.Forms.Label();
            this.tbcMain.SuspendLayout();
            this.tabLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tabActions.SuspendLayout();
            this.tabAdventure.SuspendLayout();
            this.pnlAdvSummery.SuspendLayout();
            this.tabInv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.pnlMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tabLogin);
            this.tbcMain.Controls.Add(this.tabActions);
            this.tbcMain.Controls.Add(this.tabAdventure);
            this.tbcMain.Controls.Add(this.tabInv);
            this.tbcMain.Controls.Add(this.tabSettings);
            this.tbcMain.Location = new System.Drawing.Point(0, 0);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(418, 258);
            this.tbcMain.TabIndex = 0;
            this.tbcMain.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbcMain_Selecting);
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
            this.tabActions.Controls.Add(this.cmdSelected);
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
            // cmdSelected
            // 
            this.cmdSelected.Location = new System.Drawing.Point(329, 201);
            this.cmdSelected.Name = "cmdSelected";
            this.cmdSelected.Size = new System.Drawing.Size(75, 23);
            this.cmdSelected.TabIndex = 15;
            this.cmdSelected.Text = "Do Selected";
            this.cmdSelected.UseVisualStyleBackColor = true;
            this.cmdSelected.Click += new System.EventHandler(this.cmdSelected_Click);
            // 
            // chkSearch
            // 
            this.chkSearch.AutoSize = true;
            this.chkSearch.Location = new System.Drawing.Point(8, 127);
            this.chkSearch.Name = "chkSearch";
            this.chkSearch.Size = new System.Drawing.Size(15, 14);
            this.chkSearch.TabIndex = 14;
            this.chkSearch.UseVisualStyleBackColor = true;
            // 
            // pgsSearch
            // 
            this.pgsSearch.Location = new System.Drawing.Point(110, 122);
            this.pgsSearch.Maximum = 1200;
            this.pgsSearch.Name = "pgsSearch";
            this.pgsSearch.Size = new System.Drawing.Size(294, 23);
            this.pgsSearch.TabIndex = 9;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(29, 122);
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
            this.pgsFish.Maximum = 30000;
            this.pgsFish.Name = "pgsFish";
            this.pgsFish.Size = new System.Drawing.Size(294, 23);
            this.pgsFish.TabIndex = 7;
            this.pgsFish.Value = 30000;
            // 
            // cmdFish
            // 
            this.cmdFish.Location = new System.Drawing.Point(29, 93);
            this.cmdFish.Name = "cmdFish";
            this.cmdFish.Size = new System.Drawing.Size(75, 23);
            this.cmdFish.TabIndex = 6;
            this.cmdFish.Text = "Fish";
            this.cmdFish.UseVisualStyleBackColor = true;
            this.cmdFish.Click += new System.EventHandler(this.cmdFish_Click);
            // 
            // pgsChop
            // 
            this.pgsChop.Location = new System.Drawing.Point(110, 64);
            this.pgsChop.Maximum = 30000;
            this.pgsChop.Name = "pgsChop";
            this.pgsChop.Size = new System.Drawing.Size(294, 23);
            this.pgsChop.TabIndex = 5;
            this.pgsChop.Value = 30000;
            // 
            // cmdChop
            // 
            this.cmdChop.Location = new System.Drawing.Point(29, 64);
            this.cmdChop.Name = "cmdChop";
            this.cmdChop.Size = new System.Drawing.Size(75, 23);
            this.cmdChop.TabIndex = 4;
            this.cmdChop.Text = "Chop";
            this.cmdChop.UseVisualStyleBackColor = true;
            this.cmdChop.Click += new System.EventHandler(this.cmdChop_Click);
            // 
            // pgsForage
            // 
            this.pgsForage.Location = new System.Drawing.Point(110, 35);
            this.pgsForage.Maximum = 30000;
            this.pgsForage.Name = "pgsForage";
            this.pgsForage.Size = new System.Drawing.Size(294, 23);
            this.pgsForage.TabIndex = 3;
            this.pgsForage.Value = 30000;
            // 
            // cmdForage
            // 
            this.cmdForage.Location = new System.Drawing.Point(29, 35);
            this.cmdForage.Name = "cmdForage";
            this.cmdForage.Size = new System.Drawing.Size(75, 23);
            this.cmdForage.TabIndex = 2;
            this.cmdForage.Text = "Forage";
            this.cmdForage.UseVisualStyleBackColor = true;
            this.cmdForage.Click += new System.EventHandler(this.cmdForage_Click);
            // 
            // pgsMine
            // 
            this.pgsMine.Location = new System.Drawing.Point(110, 6);
            this.pgsMine.Maximum = 30000;
            this.pgsMine.Name = "pgsMine";
            this.pgsMine.Size = new System.Drawing.Size(294, 23);
            this.pgsMine.TabIndex = 1;
            this.pgsMine.Value = 30000;
            // 
            // cmdMine
            // 
            this.cmdMine.Location = new System.Drawing.Point(29, 6);
            this.cmdMine.Name = "cmdMine";
            this.cmdMine.Size = new System.Drawing.Size(75, 23);
            this.cmdMine.TabIndex = 0;
            this.cmdMine.Text = "Mine";
            this.cmdMine.UseVisualStyleBackColor = true;
            this.cmdMine.Click += new System.EventHandler(this.cmdMine_Click);
            // 
            // tabAdventure
            // 
            this.tabAdventure.Controls.Add(this.pnlAdvSummery);
            this.tabAdventure.Controls.Add(this.pgsHeal);
            this.tabAdventure.Controls.Add(this.cmdHeal);
            this.tabAdventure.Controls.Add(this.pgsAdv);
            this.tabAdventure.Controls.Add(this.cmdAdv);
            this.tabAdventure.Location = new System.Drawing.Point(4, 22);
            this.tabAdventure.Name = "tabAdventure";
            this.tabAdventure.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdventure.Size = new System.Drawing.Size(410, 232);
            this.tabAdventure.TabIndex = 2;
            this.tabAdventure.Text = "Adventure";
            this.tabAdventure.UseVisualStyleBackColor = true;
            // 
            // pnlAdvSummery
            // 
            this.pnlAdvSummery.Controls.Add(this.lblAdventure);
            this.pnlAdvSummery.Location = new System.Drawing.Point(6, 64);
            this.pnlAdvSummery.Name = "pnlAdvSummery";
            this.pnlAdvSummery.Size = new System.Drawing.Size(398, 160);
            this.pnlAdvSummery.TabIndex = 4;
            // 
            // lblAdventure
            // 
            this.lblAdventure.AutoSize = true;
            this.lblAdventure.Location = new System.Drawing.Point(3, 7);
            this.lblAdventure.Name = "lblAdventure";
            this.lblAdventure.Size = new System.Drawing.Size(93, 13);
            this.lblAdventure.TabIndex = 0;
            this.lblAdventure.Text = "Blank\'s Adventure";
            // 
            // pgsHeal
            // 
            this.pgsHeal.Location = new System.Drawing.Point(87, 35);
            this.pgsHeal.Maximum = 1000;
            this.pgsHeal.Name = "pgsHeal";
            this.pgsHeal.Size = new System.Drawing.Size(317, 23);
            this.pgsHeal.TabIndex = 3;
            this.pgsHeal.Value = 1000;
            // 
            // cmdHeal
            // 
            this.cmdHeal.Location = new System.Drawing.Point(6, 35);
            this.cmdHeal.Name = "cmdHeal";
            this.cmdHeal.Size = new System.Drawing.Size(75, 23);
            this.cmdHeal.TabIndex = 2;
            this.cmdHeal.Text = "Heal";
            this.cmdHeal.UseVisualStyleBackColor = true;
            this.cmdHeal.Click += new System.EventHandler(this.cmdHeal_Click);
            // 
            // pgsAdv
            // 
            this.pgsAdv.Location = new System.Drawing.Point(87, 6);
            this.pgsAdv.Maximum = 1200;
            this.pgsAdv.Name = "pgsAdv";
            this.pgsAdv.Size = new System.Drawing.Size(317, 23);
            this.pgsAdv.TabIndex = 1;
            this.pgsAdv.Value = 1200;
            // 
            // cmdAdv
            // 
            this.cmdAdv.Location = new System.Drawing.Point(6, 6);
            this.cmdAdv.Name = "cmdAdv";
            this.cmdAdv.Size = new System.Drawing.Size(75, 23);
            this.cmdAdv.TabIndex = 0;
            this.cmdAdv.Text = "Adventure";
            this.cmdAdv.UseVisualStyleBackColor = true;
            this.cmdAdv.Click += new System.EventHandler(this.cmdAdv_Click);
            // 
            // tabInv
            // 
            this.tabInv.Controls.Add(this.button1);
            this.tabInv.Controls.Add(this.numericUpDown1);
            this.tabInv.Location = new System.Drawing.Point(4, 22);
            this.tabInv.Name = "tabInv";
            this.tabInv.Padding = new System.Windows.Forms.Padding(3);
            this.tabInv.Size = new System.Drawing.Size(410, 232);
            this.tabInv.TabIndex = 3;
            this.tabInv.Text = "Inventory";
            this.tabInv.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 206);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // tmrProgress
            // 
            this.tmrProgress.Enabled = true;
            this.tmrProgress.Interval = 10;
            this.tmrProgress.Tick += new System.EventHandler(this.tmrProgress_Tick);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.cmdSaveSettings);
            this.tabSettings.Controls.Add(this.lblChannel);
            this.tabSettings.Controls.Add(this.txtChannel);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(410, 232);
            this.tabSettings.TabIndex = 4;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(6, 19);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(398, 20);
            this.txtChannel.TabIndex = 0;
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Location = new System.Drawing.Point(6, 3);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(60, 13);
            this.lblChannel.TabIndex = 1;
            this.lblChannel.Text = "Channel ID";
            // 
            // cmdSaveSettings
            // 
            this.cmdSaveSettings.Location = new System.Drawing.Point(6, 203);
            this.cmdSaveSettings.Name = "cmdSaveSettings";
            this.cmdSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.cmdSaveSettings.TabIndex = 2;
            this.cmdSaveSettings.Text = "Save";
            this.cmdSaveSettings.UseVisualStyleBackColor = true;
            this.cmdSaveSettings.Click += new System.EventHandler(this.cmdSaveSettings_Click);
            // 
            // pnlStats
            // 
            this.pnlStats.Controls.Add(this.lblWeapon);
            this.pnlStats.Controls.Add(this.lblExp);
            this.pnlStats.Controls.Add(this.lblHealth);
            this.pnlStats.Enabled = false;
            this.pnlStats.Location = new System.Drawing.Point(0, 256);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(418, 36);
            this.pnlStats.TabIndex = 1;
            // 
            // pnlMessages
            // 
            this.pnlMessages.Controls.Add(this.cmdSend);
            this.pnlMessages.Controls.Add(this.txtInput);
            this.pnlMessages.Controls.Add(this.lstOutput);
            this.pnlMessages.Enabled = false;
            this.pnlMessages.Location = new System.Drawing.Point(416, 2);
            this.pnlMessages.Name = "pnlMessages";
            this.pnlMessages.Size = new System.Drawing.Size(223, 289);
            this.pnlMessages.TabIndex = 2;
            // 
            // cmdSend
            // 
            this.cmdSend.Location = new System.Drawing.Point(197, 262);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(20, 20);
            this.cmdSend.TabIndex = 7;
            this.cmdSend.Text = "➡️";
            this.cmdSend.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(2, 262);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(189, 20);
            this.txtInput.TabIndex = 6;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(2, 18);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(221, 238);
            this.lstOutput.TabIndex = 5;
            // 
            // lblHealth
            // 
            this.lblHealth.Location = new System.Drawing.Point(0, 0);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(75, 36);
            this.lblHealth.TabIndex = 0;
            this.lblHealth.Text = "❤\r\n50/50 HP";
            this.lblHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExp
            // 
            this.lblExp.Location = new System.Drawing.Point(75, 0);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(75, 36);
            this.lblExp.TabIndex = 1;
            this.lblExp.Text = "⚡\r\n200/1900 XP";
            this.lblExp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeapon
            // 
            this.lblWeapon.Location = new System.Drawing.Point(150, 0);
            this.lblWeapon.Name = "lblWeapon";
            this.lblWeapon.Size = new System.Drawing.Size(75, 36);
            this.lblWeapon.TabIndex = 2;
            this.lblWeapon.Text = "🗡️\r\nSmall Dagger";
            this.lblWeapon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCombined
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 292);
            this.Controls.Add(this.pnlMessages);
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
            this.tabAdventure.ResumeLayout(false);
            this.pnlAdvSummery.ResumeLayout(false);
            this.pnlAdvSummery.PerformLayout();
            this.tabInv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.pnlStats.ResumeLayout(false);
            this.pnlMessages.ResumeLayout(false);
            this.pnlMessages.PerformLayout();
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
        private System.Windows.Forms.CheckBox chkRemember;
        private Button cmdSelected;
        private Panel pnlAdvSummery;
        private ProgressBar pgsHeal;
        private Button cmdHeal;
        private ProgressBar pgsAdv;
        private Button cmdAdv;
        private Label lblAdventure;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private TabPage tabSettings;
        private Label lblChannel;
        private TextBox txtChannel;
        private Button cmdSaveSettings;
        private Panel pnlStats;
        private Panel pnlMessages;
        private Button cmdSend;
        private TextBox txtInput;
        private ListBox lstOutput;
        private Label lblHealth;
        private Label lblExp;
        private Label lblWeapon;
    }
}