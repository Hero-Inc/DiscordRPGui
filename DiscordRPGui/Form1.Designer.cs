namespace DiscordRPGui
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.lblAll = new System.Windows.Forms.Label();
            this.chkAll = new System.Windows.Forms.CheckBox();
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
            this.tabControl1.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(235, 314);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(227, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(227, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.lblAll);
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
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlActions.Location = new System.Drawing.Point(231, 0);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(186, 314);
            this.pnlActions.TabIndex = 14;
            // 
            // lblAll
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.Location = new System.Drawing.Point(36, 139);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(51, 13);
            this.lblAll.TabIndex = 18;
            this.lblAll.Text = "Select All";
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(5, 139);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(15, 14);
            this.chkAll.TabIndex = 17;
            this.chkAll.UseVisualStyleBackColor = true;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 314);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Label lblAll;
        private System.Windows.Forms.CheckBox chkAll;
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
    }
}