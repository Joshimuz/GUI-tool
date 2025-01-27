namespace GtaChaos.Forms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonMainToggle = new System.Windows.Forms.Button();
            this.progressBarMain = new System.Windows.Forms.ProgressBar();
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.checkBoxShowLastEffectsMain = new System.Windows.Forms.CheckBox();
            this.buttonResetMain = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMainCooldown = new System.Windows.Forms.ComboBox();
            this.listLastEffectsMain = new System.Windows.Forms.ListBox();
            this.tabTwitch = new System.Windows.Forms.TabPage();
            this.checkBoxTwitch3TimesCooldown = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTwitchChannel = new System.Windows.Forms.TextBox();
            this.buttonResetTwitch = new System.Windows.Forms.Button();
            this.checkBoxTwitchMajorityVoting = new System.Windows.Forms.CheckBox();
            this.checkBoxTwitchAllowOnlyEnabledEffects = new System.Windows.Forms.CheckBox();
            this.checkBoxShowLastEffectsTwitch = new System.Windows.Forms.CheckBox();
            this.labelTwitchCurrentMode = new System.Windows.Forms.Label();
            this.buttonTwitchToggle = new System.Windows.Forms.Button();
            this.comboBoxVotingCooldown = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxVotingTime = new System.Windows.Forms.ComboBox();
            this.progressBarTwitch = new System.Windows.Forms.ProgressBar();
            this.listLastEffectsTwitch = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTwitchOAuth = new System.Windows.Forms.TextBox();
            this.textBoxTwitchUsername = new System.Windows.Forms.TextBox();
            this.buttonConnectTwitch = new System.Windows.Forms.Button();
            this.tabEffects = new System.Windows.Forms.TabPage();
            this.buttonEffectsToggleAll = new System.Windows.Forms.Button();
            this.enabledEffectsView = new System.Windows.Forms.TreeView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBoxContinueTimer = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSeed = new System.Windows.Forms.TextBox();
            this.tabDebug = new System.Windows.Forms.TabPage();
            this.buttonGenericTest = new System.Windows.Forms.Button();
            this.buttonTestSeed = new System.Windows.Forms.Button();
            this.labelTestSeed = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viceCityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sanAndreasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipHandler = new System.Windows.Forms.ToolTip(this.components);
            this.buttonAutoStart = new System.Windows.Forms.Button();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.buttonSwitchMode = new System.Windows.Forms.Button();
            this.checkBoxTwitchUseChatPrefix = new System.Windows.Forms.CheckBox();
            this.checkBoxTwitchCombineChatMessages = new System.Windows.Forms.CheckBox();
            this.tabSettings.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabTwitch.SuspendLayout();
            this.tabEffects.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabDebug.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMainToggle
            // 
            this.buttonMainToggle.Location = new System.Drawing.Point(6, 6);
            this.buttonMainToggle.Name = "buttonMainToggle";
            this.buttonMainToggle.Size = new System.Drawing.Size(94, 23);
            this.buttonMainToggle.TabIndex = 0;
            this.buttonMainToggle.Text = "Start / Resume";
            this.buttonMainToggle.UseVisualStyleBackColor = true;
            this.buttonMainToggle.Click += new System.EventHandler(this.ButtonMainToggle_Click);
            // 
            // progressBarMain
            // 
            this.progressBarMain.Location = new System.Drawing.Point(206, 6);
            this.progressBarMain.Maximum = 60;
            this.progressBarMain.Name = "progressBarMain";
            this.progressBarMain.Size = new System.Drawing.Size(240, 23);
            this.progressBarMain.Step = 1;
            this.progressBarMain.TabIndex = 1;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tabMain);
            this.tabSettings.Controls.Add(this.tabTwitch);
            this.tabSettings.Controls.Add(this.tabEffects);
            this.tabSettings.Controls.Add(this.tabPage1);
            this.tabSettings.Controls.Add(this.tabDebug);
            this.tabSettings.Location = new System.Drawing.Point(12, 56);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(460, 257);
            this.tabSettings.TabIndex = 4;
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.Transparent;
            this.tabMain.Controls.Add(this.checkBoxShowLastEffectsMain);
            this.tabMain.Controls.Add(this.buttonResetMain);
            this.tabMain.Controls.Add(this.label2);
            this.tabMain.Controls.Add(this.comboBoxMainCooldown);
            this.tabMain.Controls.Add(this.buttonMainToggle);
            this.tabMain.Controls.Add(this.listLastEffectsMain);
            this.tabMain.Controls.Add(this.progressBarMain);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(452, 231);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            // 
            // checkBoxShowLastEffectsMain
            // 
            this.checkBoxShowLastEffectsMain.AutoSize = true;
            this.checkBoxShowLastEffectsMain.Checked = true;
            this.checkBoxShowLastEffectsMain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowLastEffectsMain.Location = new System.Drawing.Point(6, 107);
            this.checkBoxShowLastEffectsMain.Name = "checkBoxShowLastEffectsMain";
            this.checkBoxShowLastEffectsMain.Size = new System.Drawing.Size(112, 17);
            this.checkBoxShowLastEffectsMain.TabIndex = 8;
            this.checkBoxShowLastEffectsMain.Text = "Show Last Effects";
            this.checkBoxShowLastEffectsMain.UseVisualStyleBackColor = true;
            this.checkBoxShowLastEffectsMain.CheckedChanged += new System.EventHandler(this.CheckBoxShowLastEffectsMain_CheckedChanged);
            // 
            // buttonResetMain
            // 
            this.buttonResetMain.Location = new System.Drawing.Point(106, 6);
            this.buttonResetMain.Name = "buttonResetMain";
            this.buttonResetMain.Size = new System.Drawing.Size(94, 23);
            this.buttonResetMain.TabIndex = 7;
            this.buttonResetMain.Text = "Reset";
            this.buttonResetMain.UseVisualStyleBackColor = true;
            this.buttonResetMain.Click += new System.EventHandler(this.ButtonResetMain_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cooldown:";
            // 
            // comboBoxMainCooldown
            // 
            this.comboBoxMainCooldown.FormattingEnabled = true;
            this.comboBoxMainCooldown.Location = new System.Drawing.Point(325, 35);
            this.comboBoxMainCooldown.Name = "comboBoxMainCooldown";
            this.comboBoxMainCooldown.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMainCooldown.TabIndex = 5;
            this.comboBoxMainCooldown.SelectedIndexChanged += new System.EventHandler(this.MainCooldownComboBox_SelectedIndexChanged);
            // 
            // listLastEffectsMain
            // 
            this.listLastEffectsMain.FormattingEnabled = true;
            this.listLastEffectsMain.Location = new System.Drawing.Point(6, 130);
            this.listLastEffectsMain.Name = "listLastEffectsMain";
            this.listLastEffectsMain.Size = new System.Drawing.Size(440, 95);
            this.listLastEffectsMain.TabIndex = 4;
            // 
            // tabTwitch
            // 
            this.tabTwitch.BackColor = System.Drawing.Color.Transparent;
            this.tabTwitch.Controls.Add(this.checkBoxTwitchCombineChatMessages);
            this.tabTwitch.Controls.Add(this.checkBoxTwitchUseChatPrefix);
            this.tabTwitch.Controls.Add(this.checkBoxTwitch3TimesCooldown);
            this.tabTwitch.Controls.Add(this.label3);
            this.tabTwitch.Controls.Add(this.textBoxTwitchChannel);
            this.tabTwitch.Controls.Add(this.buttonResetTwitch);
            this.tabTwitch.Controls.Add(this.checkBoxTwitchMajorityVoting);
            this.tabTwitch.Controls.Add(this.checkBoxTwitchAllowOnlyEnabledEffects);
            this.tabTwitch.Controls.Add(this.checkBoxShowLastEffectsTwitch);
            this.tabTwitch.Controls.Add(this.labelTwitchCurrentMode);
            this.tabTwitch.Controls.Add(this.buttonTwitchToggle);
            this.tabTwitch.Controls.Add(this.comboBoxVotingCooldown);
            this.tabTwitch.Controls.Add(this.label7);
            this.tabTwitch.Controls.Add(this.label6);
            this.tabTwitch.Controls.Add(this.comboBoxVotingTime);
            this.tabTwitch.Controls.Add(this.progressBarTwitch);
            this.tabTwitch.Controls.Add(this.listLastEffectsTwitch);
            this.tabTwitch.Controls.Add(this.label5);
            this.tabTwitch.Controls.Add(this.label4);
            this.tabTwitch.Controls.Add(this.textBoxTwitchOAuth);
            this.tabTwitch.Controls.Add(this.textBoxTwitchUsername);
            this.tabTwitch.Controls.Add(this.buttonConnectTwitch);
            this.tabTwitch.Location = new System.Drawing.Point(4, 22);
            this.tabTwitch.Name = "tabTwitch";
            this.tabTwitch.Size = new System.Drawing.Size(452, 231);
            this.tabTwitch.TabIndex = 2;
            this.tabTwitch.Text = "Twitch";
            // 
            // checkBoxTwitch3TimesCooldown
            // 
            this.checkBoxTwitch3TimesCooldown.AutoSize = true;
            this.checkBoxTwitch3TimesCooldown.Location = new System.Drawing.Point(362, 81);
            this.checkBoxTwitch3TimesCooldown.Name = "checkBoxTwitch3TimesCooldown";
            this.checkBoxTwitch3TimesCooldown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxTwitch3TimesCooldown.Size = new System.Drawing.Size(87, 17);
            this.checkBoxTwitch3TimesCooldown.TabIndex = 24;
            this.checkBoxTwitch3TimesCooldown.Text = "3x Cooldown";
            this.toolTipHandler.SetToolTip(this.checkBoxTwitch3TimesCooldown, "When enabled effects will have 3x their cooldown.\r\n(Cooldown in this case is the " +
        "Voting Time + Voting Cooldown)");
            this.checkBoxTwitch3TimesCooldown.UseVisualStyleBackColor = true;
            this.checkBoxTwitch3TimesCooldown.CheckedChanged += new System.EventHandler(this.CheckBoxTwitch3TimesCooldown_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Channel:";
            // 
            // textBoxTwitchChannel
            // 
            this.textBoxTwitchChannel.Location = new System.Drawing.Point(83, 3);
            this.textBoxTwitchChannel.Name = "textBoxTwitchChannel";
            this.textBoxTwitchChannel.Size = new System.Drawing.Size(205, 20);
            this.textBoxTwitchChannel.TabIndex = 1;
            this.textBoxTwitchChannel.TextChanged += new System.EventHandler(this.TextBoxTwitchChannel_TextChanged);
            // 
            // buttonResetTwitch
            // 
            this.buttonResetTwitch.Enabled = false;
            this.buttonResetTwitch.Location = new System.Drawing.Point(294, 58);
            this.buttonResetTwitch.Name = "buttonResetTwitch";
            this.buttonResetTwitch.Size = new System.Drawing.Size(155, 20);
            this.buttonResetTwitch.TabIndex = 21;
            this.buttonResetTwitch.Text = "Reset";
            this.buttonResetTwitch.UseVisualStyleBackColor = true;
            this.buttonResetTwitch.Click += new System.EventHandler(this.ButtonResetTwitch_Click);
            // 
            // checkBoxTwitchMajorityVoting
            // 
            this.checkBoxTwitchMajorityVoting.AutoSize = true;
            this.checkBoxTwitchMajorityVoting.Checked = true;
            this.checkBoxTwitchMajorityVoting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTwitchMajorityVoting.Location = new System.Drawing.Point(265, 81);
            this.checkBoxTwitchMajorityVoting.Name = "checkBoxTwitchMajorityVoting";
            this.checkBoxTwitchMajorityVoting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxTwitchMajorityVoting.Size = new System.Drawing.Size(95, 17);
            this.checkBoxTwitchMajorityVoting.TabIndex = 20;
            this.checkBoxTwitchMajorityVoting.Text = "Majority Voting";
            this.toolTipHandler.SetToolTip(this.checkBoxTwitchMajorityVoting, "When enabled the effect that has the most votes will be enabled.");
            this.checkBoxTwitchMajorityVoting.UseVisualStyleBackColor = true;
            this.checkBoxTwitchMajorityVoting.CheckedChanged += new System.EventHandler(this.CheckBoxTwitchMajorityVoting_CheckedChanged);
            // 
            // checkBoxTwitchAllowOnlyEnabledEffects
            // 
            this.checkBoxTwitchAllowOnlyEnabledEffects.AutoSize = true;
            this.checkBoxTwitchAllowOnlyEnabledEffects.Location = new System.Drawing.Point(116, 81);
            this.checkBoxTwitchAllowOnlyEnabledEffects.Name = "checkBoxTwitchAllowOnlyEnabledEffects";
            this.checkBoxTwitchAllowOnlyEnabledEffects.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxTwitchAllowOnlyEnabledEffects.Size = new System.Drawing.Size(148, 17);
            this.checkBoxTwitchAllowOnlyEnabledEffects.TabIndex = 19;
            this.checkBoxTwitchAllowOnlyEnabledEffects.Text = "Only Enabled Effects (RF)";
            this.toolTipHandler.SetToolTip(this.checkBoxTwitchAllowOnlyEnabledEffects, "Only allow effects that are enabled\r\nin the currently active preset during Rapid-" +
        "Fire.");
            this.checkBoxTwitchAllowOnlyEnabledEffects.UseVisualStyleBackColor = true;
            this.checkBoxTwitchAllowOnlyEnabledEffects.CheckedChanged += new System.EventHandler(this.CheckBoxTwitchAllowOnlyEnabledEffects_CheckedChanged);
            // 
            // checkBoxShowLastEffectsTwitch
            // 
            this.checkBoxShowLastEffectsTwitch.AutoSize = true;
            this.checkBoxShowLastEffectsTwitch.Checked = true;
            this.checkBoxShowLastEffectsTwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowLastEffectsTwitch.Location = new System.Drawing.Point(3, 81);
            this.checkBoxShowLastEffectsTwitch.Name = "checkBoxShowLastEffectsTwitch";
            this.checkBoxShowLastEffectsTwitch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxShowLastEffectsTwitch.Size = new System.Drawing.Size(112, 17);
            this.checkBoxShowLastEffectsTwitch.TabIndex = 18;
            this.checkBoxShowLastEffectsTwitch.Text = "Show Last Effects";
            this.toolTipHandler.SetToolTip(this.checkBoxShowLastEffectsTwitch, "When enabled the effects won\'t be sent to the game but instead only to announced " +
        "in chat.");
            this.checkBoxShowLastEffectsTwitch.UseVisualStyleBackColor = true;
            this.checkBoxShowLastEffectsTwitch.CheckedChanged += new System.EventHandler(this.CheckBoxShowLastEffectsTwitch_CheckedChanged);
            // 
            // labelTwitchCurrentMode
            // 
            this.labelTwitchCurrentMode.AutoSize = true;
            this.labelTwitchCurrentMode.Location = new System.Drawing.Point(5, 208);
            this.labelTwitchCurrentMode.Name = "labelTwitchCurrentMode";
            this.labelTwitchCurrentMode.Size = new System.Drawing.Size(0, 13);
            this.labelTwitchCurrentMode.TabIndex = 17;
            // 
            // buttonTwitchToggle
            // 
            this.buttonTwitchToggle.Enabled = false;
            this.buttonTwitchToggle.Location = new System.Drawing.Point(294, 29);
            this.buttonTwitchToggle.Name = "buttonTwitchToggle";
            this.buttonTwitchToggle.Size = new System.Drawing.Size(155, 20);
            this.buttonTwitchToggle.TabIndex = 15;
            this.buttonTwitchToggle.Text = "Start / Resume";
            this.buttonTwitchToggle.UseVisualStyleBackColor = true;
            this.buttonTwitchToggle.Click += new System.EventHandler(this.ButtonTwitchToggle_Click);
            // 
            // comboBoxVotingCooldown
            // 
            this.comboBoxVotingCooldown.FormattingEnabled = true;
            this.comboBoxVotingCooldown.Location = new System.Drawing.Point(362, 149);
            this.comboBoxVotingCooldown.Name = "comboBoxVotingCooldown";
            this.comboBoxVotingCooldown.Size = new System.Drawing.Size(87, 21);
            this.comboBoxVotingCooldown.TabIndex = 14;
            this.comboBoxVotingCooldown.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVotingCooldown_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Voting Cooldown:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Voting Time:";
            // 
            // comboBoxVotingTime
            // 
            this.comboBoxVotingTime.FormattingEnabled = true;
            this.comboBoxVotingTime.Location = new System.Drawing.Point(362, 112);
            this.comboBoxVotingTime.Name = "comboBoxVotingTime";
            this.comboBoxVotingTime.Size = new System.Drawing.Size(87, 21);
            this.comboBoxVotingTime.TabIndex = 11;
            this.comboBoxVotingTime.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVotingTime_SelectedIndexChanged);
            // 
            // progressBarTwitch
            // 
            this.progressBarTwitch.Location = new System.Drawing.Point(3, 205);
            this.progressBarTwitch.Name = "progressBarTwitch";
            this.progressBarTwitch.Size = new System.Drawing.Size(446, 23);
            this.progressBarTwitch.TabIndex = 10;
            // 
            // listLastEffectsTwitch
            // 
            this.listLastEffectsTwitch.FormattingEnabled = true;
            this.listLastEffectsTwitch.Location = new System.Drawing.Point(3, 101);
            this.listLastEffectsTwitch.Name = "listLastEffectsTwitch";
            this.listLastEffectsTwitch.Size = new System.Drawing.Size(353, 82);
            this.listLastEffectsTwitch.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "OAuth Token:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Username:";
            // 
            // textBoxTwitchOAuth
            // 
            this.textBoxTwitchOAuth.Location = new System.Drawing.Point(83, 58);
            this.textBoxTwitchOAuth.Name = "textBoxTwitchOAuth";
            this.textBoxTwitchOAuth.PasswordChar = '*';
            this.textBoxTwitchOAuth.Size = new System.Drawing.Size(205, 20);
            this.textBoxTwitchOAuth.TabIndex = 3;
            this.textBoxTwitchOAuth.TextChanged += new System.EventHandler(this.TextBoxOAuth_TextChanged);
            // 
            // textBoxTwitchUsername
            // 
            this.textBoxTwitchUsername.Location = new System.Drawing.Point(83, 29);
            this.textBoxTwitchUsername.Name = "textBoxTwitchUsername";
            this.textBoxTwitchUsername.Size = new System.Drawing.Size(205, 20);
            this.textBoxTwitchUsername.TabIndex = 2;
            this.textBoxTwitchUsername.TextChanged += new System.EventHandler(this.TextBoxUsername_TextChanged);
            // 
            // buttonConnectTwitch
            // 
            this.buttonConnectTwitch.Enabled = false;
            this.buttonConnectTwitch.Location = new System.Drawing.Point(294, 2);
            this.buttonConnectTwitch.Name = "buttonConnectTwitch";
            this.buttonConnectTwitch.Size = new System.Drawing.Size(155, 21);
            this.buttonConnectTwitch.TabIndex = 1;
            this.buttonConnectTwitch.Text = "Connect to Twitch";
            this.buttonConnectTwitch.UseVisualStyleBackColor = true;
            this.buttonConnectTwitch.Click += new System.EventHandler(this.ButtonConnectTwitch_Click);
            // 
            // tabEffects
            // 
            this.tabEffects.BackColor = System.Drawing.Color.Transparent;
            this.tabEffects.Controls.Add(this.buttonEffectsToggleAll);
            this.tabEffects.Controls.Add(this.enabledEffectsView);
            this.tabEffects.Location = new System.Drawing.Point(4, 22);
            this.tabEffects.Name = "tabEffects";
            this.tabEffects.Padding = new System.Windows.Forms.Padding(3);
            this.tabEffects.Size = new System.Drawing.Size(452, 231);
            this.tabEffects.TabIndex = 1;
            this.tabEffects.Text = "Effects";
            // 
            // buttonEffectsToggleAll
            // 
            this.buttonEffectsToggleAll.Location = new System.Drawing.Point(6, 202);
            this.buttonEffectsToggleAll.Name = "buttonEffectsToggleAll";
            this.buttonEffectsToggleAll.Size = new System.Drawing.Size(440, 23);
            this.buttonEffectsToggleAll.TabIndex = 7;
            this.buttonEffectsToggleAll.Text = "Toggle All";
            this.buttonEffectsToggleAll.UseVisualStyleBackColor = true;
            this.buttonEffectsToggleAll.Click += new System.EventHandler(this.ButtonEffectsToggleAll_Click);
            // 
            // enabledEffectsView
            // 
            this.enabledEffectsView.CheckBoxes = true;
            this.enabledEffectsView.Location = new System.Drawing.Point(6, 6);
            this.enabledEffectsView.Name = "enabledEffectsView";
            this.enabledEffectsView.Size = new System.Drawing.Size(440, 190);
            this.enabledEffectsView.TabIndex = 3;
            this.enabledEffectsView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.EnabledEffectsView_AfterCheck);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.checkBoxContinueTimer);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textBoxSeed);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(452, 231);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Settings";
            // 
            // checkBoxContinueTimer
            // 
            this.checkBoxContinueTimer.AutoSize = true;
            this.checkBoxContinueTimer.Checked = true;
            this.checkBoxContinueTimer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxContinueTimer.Location = new System.Drawing.Point(6, 208);
            this.checkBoxContinueTimer.Name = "checkBoxContinueTimer";
            this.checkBoxContinueTimer.Size = new System.Drawing.Size(210, 17);
            this.checkBoxContinueTimer.TabIndex = 4;
            this.checkBoxContinueTimer.Text = "Continue Timer on Game Close / Crash";
            this.checkBoxContinueTimer.UseVisualStyleBackColor = true;
            this.checkBoxContinueTimer.CheckedChanged += new System.EventHandler(this.CheckBoxContinueTimer_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Seed:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxSeed
            // 
            this.textBoxSeed.Location = new System.Drawing.Point(47, 6);
            this.textBoxSeed.Name = "textBoxSeed";
            this.textBoxSeed.Size = new System.Drawing.Size(399, 20);
            this.textBoxSeed.TabIndex = 1;
            this.textBoxSeed.TextChanged += new System.EventHandler(this.TextBoxSeed_TextChanged);
            // 
            // tabDebug
            // 
            this.tabDebug.BackColor = System.Drawing.Color.Transparent;
            this.tabDebug.Controls.Add(this.buttonGenericTest);
            this.tabDebug.Controls.Add(this.buttonTestSeed);
            this.tabDebug.Controls.Add(this.labelTestSeed);
            this.tabDebug.Location = new System.Drawing.Point(4, 22);
            this.tabDebug.Name = "tabDebug";
            this.tabDebug.Padding = new System.Windows.Forms.Padding(3);
            this.tabDebug.Size = new System.Drawing.Size(452, 231);
            this.tabDebug.TabIndex = 4;
            this.tabDebug.Text = "Debug";
            // 
            // buttonGenericTest
            // 
            this.buttonGenericTest.Location = new System.Drawing.Point(6, 202);
            this.buttonGenericTest.Name = "buttonGenericTest";
            this.buttonGenericTest.Size = new System.Drawing.Size(91, 23);
            this.buttonGenericTest.TabIndex = 10;
            this.buttonGenericTest.Text = "Test Something";
            this.buttonGenericTest.UseVisualStyleBackColor = true;
            this.buttonGenericTest.Click += new System.EventHandler(this.ButtonGenericTest_Click);
            // 
            // buttonTestSeed
            // 
            this.buttonTestSeed.Location = new System.Drawing.Point(3, 6);
            this.buttonTestSeed.Name = "buttonTestSeed";
            this.buttonTestSeed.Size = new System.Drawing.Size(75, 23);
            this.buttonTestSeed.TabIndex = 9;
            this.buttonTestSeed.Text = "Test Seed";
            this.buttonTestSeed.UseVisualStyleBackColor = true;
            this.buttonTestSeed.Click += new System.EventHandler(this.ButtonTestSeed_Click);
            // 
            // labelTestSeed
            // 
            this.labelTestSeed.AutoSize = true;
            this.labelTestSeed.Location = new System.Drawing.Point(84, 11);
            this.labelTestSeed.Name = "labelTestSeed";
            this.labelTestSeed.Size = new System.Drawing.Size(13, 13);
            this.labelTestSeed.TabIndex = 8;
            this.labelTestSeed.Text = "0";
            this.labelTestSeed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(482, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPresetToolStripMenuItem,
            this.savePresetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadPresetToolStripMenuItem
            // 
            this.loadPresetToolStripMenuItem.Name = "loadPresetToolStripMenuItem";
            this.loadPresetToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.loadPresetToolStripMenuItem.Text = "Load Preset";
            this.loadPresetToolStripMenuItem.Click += new System.EventHandler(this.LoadPresetToolStripMenuItem_Click);
            // 
            // savePresetToolStripMenuItem
            // 
            this.savePresetToolStripMenuItem.Name = "savePresetToolStripMenuItem";
            this.savePresetToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.savePresetToolStripMenuItem.Text = "Save Preset";
            this.savePresetToolStripMenuItem.Click += new System.EventHandler(this.SavePresetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viceCityToolStripMenuItem,
            this.sanAndreasToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // viceCityToolStripMenuItem
            // 
            this.viceCityToolStripMenuItem.Name = "viceCityToolStripMenuItem";
            this.viceCityToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.viceCityToolStripMenuItem.Text = "Vice City";
            this.viceCityToolStripMenuItem.Click += new System.EventHandler(this.viceCityToolStripMenuItem_Click);
            // 
            // sanAndreasToolStripMenuItem
            // 
            this.sanAndreasToolStripMenuItem.Name = "sanAndreasToolStripMenuItem";
            this.sanAndreasToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sanAndreasToolStripMenuItem.Text = "San Andreas";
            this.sanAndreasToolStripMenuItem.Click += new System.EventHandler(this.sanAndreasToolStripMenuItem_Click);
            // 
            // buttonAutoStart
            // 
            this.buttonAutoStart.Location = new System.Drawing.Point(12, 27);
            this.buttonAutoStart.Name = "buttonAutoStart";
            this.buttonAutoStart.Size = new System.Drawing.Size(75, 23);
            this.buttonAutoStart.TabIndex = 6;
            this.buttonAutoStart.Text = "Auto-Start";
            this.buttonAutoStart.UseVisualStyleBackColor = true;
            this.buttonAutoStart.Click += new System.EventHandler(this.ButtonAutoStart_Click);
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Interval = 10;
            this.timerMain.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // buttonSwitchMode
            // 
            this.buttonSwitchMode.Location = new System.Drawing.Point(393, 27);
            this.buttonSwitchMode.Name = "buttonSwitchMode";
            this.buttonSwitchMode.Size = new System.Drawing.Size(75, 23);
            this.buttonSwitchMode.TabIndex = 7;
            this.buttonSwitchMode.Text = "Twitch";
            this.buttonSwitchMode.UseVisualStyleBackColor = true;
            this.buttonSwitchMode.Click += new System.EventHandler(this.ButtonSwitchMode_Click);
            // 
            // checkBoxTwitchUseChatPrefix
            // 
            this.checkBoxTwitchUseChatPrefix.AutoSize = true;
            this.checkBoxTwitchUseChatPrefix.Checked = true;
            this.checkBoxTwitchUseChatPrefix.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTwitchUseChatPrefix.Location = new System.Drawing.Point(3, 185);
            this.checkBoxTwitchUseChatPrefix.Name = "checkBoxTwitchUseChatPrefix";
            this.checkBoxTwitchUseChatPrefix.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxTwitchUseChatPrefix.Size = new System.Drawing.Size(77, 17);
            this.checkBoxTwitchUseChatPrefix.TabIndex = 25;
            this.checkBoxTwitchUseChatPrefix.Text = "Chat Prefix";
            this.toolTipHandler.SetToolTip(this.checkBoxTwitchUseChatPrefix, "When enabled will prefix all chat messages with [GTA Chaos]");
            this.checkBoxTwitchUseChatPrefix.UseVisualStyleBackColor = true;
            this.checkBoxTwitchUseChatPrefix.CheckedChanged += new System.EventHandler(this.CheckBoxTwitchUseChatPrefix_CheckedChanged);
            // 
            // checkBoxTwitchCombineChatMessages
            // 
            this.checkBoxTwitchCombineChatMessages.AutoSize = true;
            this.checkBoxTwitchCombineChatMessages.Checked = true;
            this.checkBoxTwitchCombineChatMessages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTwitchCombineChatMessages.Location = new System.Drawing.Point(83, 185);
            this.checkBoxTwitchCombineChatMessages.Name = "checkBoxTwitchCombineChatMessages";
            this.checkBoxTwitchCombineChatMessages.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxTwitchCombineChatMessages.Size = new System.Drawing.Size(143, 17);
            this.checkBoxTwitchCombineChatMessages.TabIndex = 26;
            this.checkBoxTwitchCombineChatMessages.Text = "Combine Chat Messages";
            this.toolTipHandler.SetToolTip(this.checkBoxTwitchCombineChatMessages, "When enabled will combine all multi messages into one message");
            this.checkBoxTwitchCombineChatMessages.UseVisualStyleBackColor = true;
            this.checkBoxTwitchCombineChatMessages.CheckedChanged += new System.EventHandler(this.CheckBoxTwitchCombineChatMessages_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 325);
            this.Controls.Add(this.buttonSwitchMode);
            this.Controls.Add(this.buttonAutoStart);
            this.Controls.Add(this.tabSettings);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GTA:SA Chaos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabSettings.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabTwitch.ResumeLayout(false);
            this.tabTwitch.PerformLayout();
            this.tabEffects.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabDebug.ResumeLayout(false);
            this.tabDebug.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMainToggle;
        private System.Windows.Forms.ProgressBar progressBarMain;
        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabEffects;
        private System.Windows.Forms.TreeView enabledEffectsView;
        private System.Windows.Forms.ListBox listLastEffectsMain;
        private System.Windows.Forms.ComboBox comboBoxMainCooldown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPresetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePresetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage tabTwitch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTwitchOAuth;
        private System.Windows.Forms.TextBox textBoxTwitchUsername;
        private System.Windows.Forms.Button buttonConnectTwitch;
        private System.Windows.Forms.ListBox listLastEffectsTwitch;
        private System.Windows.Forms.ToolTip toolTipHandler;
        private System.Windows.Forms.ComboBox comboBoxVotingCooldown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxVotingTime;
        private System.Windows.Forms.ProgressBar progressBarTwitch;
        private System.Windows.Forms.Button buttonTwitchToggle;
        private System.Windows.Forms.Button buttonAutoStart;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Button buttonSwitchMode;
        private System.Windows.Forms.Label labelTwitchCurrentMode;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSeed;
        private System.Windows.Forms.TabPage tabDebug;
        private System.Windows.Forms.Button buttonTestSeed;
        private System.Windows.Forms.Label labelTestSeed;
        private System.Windows.Forms.Button buttonGenericTest;
        private System.Windows.Forms.Button buttonResetMain;
        private System.Windows.Forms.CheckBox checkBoxContinueTimer;
        private System.Windows.Forms.CheckBox checkBoxShowLastEffectsMain;
        private System.Windows.Forms.CheckBox checkBoxShowLastEffectsTwitch;
        private System.Windows.Forms.CheckBox checkBoxTwitchAllowOnlyEnabledEffects;
        private System.Windows.Forms.CheckBox checkBoxTwitchMajorityVoting;
        private System.Windows.Forms.Button buttonResetTwitch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTwitchChannel;
        private System.Windows.Forms.CheckBox checkBoxTwitch3TimesCooldown;
        private System.Windows.Forms.Button buttonEffectsToggleAll;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viceCityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sanAndreasToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxTwitchUseChatPrefix;
        private System.Windows.Forms.CheckBox checkBoxTwitchCombineChatMessages;
    }
}

