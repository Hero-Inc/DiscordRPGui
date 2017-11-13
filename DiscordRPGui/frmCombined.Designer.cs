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
            this.tabActions = new System.Windows.Forms.TabPage();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.lblToken = new System.Windows.Forms.Label();
            this.btnMine = new System.Windows.Forms.Button();
            this.tmrProgress = new System.Windows.Forms.Timer(this.components);
            this.pgsMine = new System.Windows.Forms.ProgressBar();
            this.pgsForage = new System.Windows.Forms.ProgressBar();
            this.cmdForage = new System.Windows.Forms.Button();
            this.pgsChop = new System.Windows.Forms.ProgressBar();
            this.cmdChop = new System.Windows.Forms.Button();
            this.pgsFish = new System.Windows.Forms.ProgressBar();
            this.cmdFish = new System.Windows.Forms.Button();
            this.chkFish = new System.Windows.Forms.CheckBox();
            this.chkChop = new System.Windows.Forms.CheckBox();
            this.chkForage = new System.Windows.Forms.CheckBox();
            this.chkMine = new System.Windows.Forms.CheckBox();
            this.chkSearch = new System.Windows.Forms.CheckBox();
            this.pgsSearch = new System.Windows.Forms.ProgressBar();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.tabAdventure = new System.Windows.Forms.TabPage();
            this.tabInv = new System.Windows.Forms.TabPage();
            this.tbcMain.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tabLogin);
            this.tbcMain.Controls.Add(this.tabActions);
            this.tbcMain.Controls.Add(this.tabAdventure);
            this.tbcMain.Controls.Add(this.tabInv);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(0, 0);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(555, 258);
            this.tbcMain.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.lblToken);
            this.tabLogin.Controls.Add(this.txtToken);
            this.tabLogin.Controls.Add(this.cmdClose);
            this.tabLogin.Controls.Add(this.cmdLogin);
            this.tabLogin.Controls.Add(this.picLogo);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(547, 232);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
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
            this.tabActions.Controls.Add(this.btnMine);
            this.tabActions.Location = new System.Drawing.Point(4, 22);
            this.tabActions.Name = "tabActions";
            this.tabActions.Padding = new System.Windows.Forms.Padding(3);
            this.tabActions.Size = new System.Drawing.Size(547, 232);
            this.tabActions.TabIndex = 1;
            this.tabActions.Text = "Actions";
            this.tabActions.UseVisualStyleBackColor = true;
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(8, 6);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(218, 218);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // cmdLogin
            // 
            this.cmdLogin.Location = new System.Drawing.Point(232, 201);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(75, 23);
            this.cmdLogin.TabIndex = 2;
            this.cmdLogin.Text = "Login";
            this.cmdLogin.UseVisualStyleBackColor = true;
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(464, 201);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 3;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(232, 22);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(307, 20);
            this.txtToken.TabIndex = 1;
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
            // btnMine
            // 
            this.btnMine.Location = new System.Drawing.Point(29, 6);
            this.btnMine.Name = "btnMine";
            this.btnMine.Size = new System.Drawing.Size(75, 23);
            this.btnMine.TabIndex = 0;
            this.btnMine.Text = "Mine";
            this.btnMine.UseVisualStyleBackColor = true;
            // 
            // tmrProgress
            // 
            this.tmrProgress.Enabled = true;
            this.tmrProgress.Interval = 10;
            this.tmrProgress.Tick += new System.EventHandler(this.tmrProgress_Tick);
            // 
            // pgsMine
            // 
            this.pgsMine.Location = new System.Drawing.Point(110, 6);
            this.pgsMine.Maximum = 1200;
            this.pgsMine.Name = "pgsMine";
            this.pgsMine.Size = new System.Drawing.Size(429, 23);
            this.pgsMine.TabIndex = 1;
            // 
            // pgsForage
            // 
            this.pgsForage.Location = new System.Drawing.Point(110, 35);
            this.pgsForage.Maximum = 1200;
            this.pgsForage.Name = "pgsForage";
            this.pgsForage.Size = new System.Drawing.Size(429, 23);
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
            // pgsChop
            // 
            this.pgsChop.Location = new System.Drawing.Point(110, 64);
            this.pgsChop.Maximum = 1200;
            this.pgsChop.Name = "pgsChop";
            this.pgsChop.Size = new System.Drawing.Size(429, 23);
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
            // pgsFish
            // 
            this.pgsFish.Location = new System.Drawing.Point(110, 93);
            this.pgsFish.Maximum = 1200;
            this.pgsFish.Name = "pgsFish";
            this.pgsFish.Size = new System.Drawing.Size(429, 23);
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
            // chkFish
            // 
            this.chkFish.AutoSize = true;
            this.chkFish.Location = new System.Drawing.Point(8, 98);
            this.chkFish.Name = "chkFish";
            this.chkFish.Size = new System.Drawing.Size(15, 14);
            this.chkFish.TabIndex = 13;
            this.chkFish.UseVisualStyleBackColor = true;
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
            // chkForage
            // 
            this.chkForage.AutoSize = true;
            this.chkForage.Location = new System.Drawing.Point(8, 40);
            this.chkForage.Name = "chkForage";
            this.chkForage.Size = new System.Drawing.Size(15, 14);
            this.chkForage.TabIndex = 11;
            this.chkForage.UseVisualStyleBackColor = true;
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
            this.pgsSearch.Size = new System.Drawing.Size(429, 23);
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
            // tabAdventure
            // 
            this.tabAdventure.Location = new System.Drawing.Point(4, 22);
            this.tabAdventure.Name = "tabAdventure";
            this.tabAdventure.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdventure.Size = new System.Drawing.Size(547, 232);
            this.tabAdventure.TabIndex = 2;
            this.tabAdventure.Text = "Adventure";
            this.tabAdventure.UseVisualStyleBackColor = true;
            // 
            // tabInv
            // 
            this.tabInv.Location = new System.Drawing.Point(4, 22);
            this.tabInv.Name = "tabInv";
            this.tabInv.Padding = new System.Windows.Forms.Padding(3);
            this.tabInv.Size = new System.Drawing.Size(547, 232);
            this.tabInv.TabIndex = 3;
            this.tabInv.Text = "Inventory";
            this.tabInv.UseVisualStyleBackColor = true;
            // 
            // frmCombined
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 258);
            this.Controls.Add(this.tbcMain);
            this.Name = "frmCombined";
            this.Text = "Discord RPG UI";
            this.tbcMain.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabActions.ResumeLayout(false);
            this.tabActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
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
        private System.Windows.Forms.Button btnMine;
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
    }
}