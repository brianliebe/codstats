namespace CoDGameTracker
{
    partial class Tracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tracker));
            this.teamACB = new System.Windows.Forms.ComboBox();
            this.teamBCB = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.teamAScore = new System.Windows.Forms.TextBox();
            this.teamBScore = new System.Windows.Forms.TextBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.notesTB = new System.Windows.Forms.TextBox();
            this.mode1 = new System.Windows.Forms.RadioButton();
            this.mode3 = new System.Windows.Forms.RadioButton();
            this.mode2 = new System.Windows.Forms.RadioButton();
            this.map1 = new System.Windows.Forms.RadioButton();
            this.map2 = new System.Windows.Forms.RadioButton();
            this.map3 = new System.Windows.Forms.RadioButton();
            this.map4 = new System.Windows.Forms.RadioButton();
            this.map5 = new System.Windows.Forms.RadioButton();
            this.map6 = new System.Windows.Forms.RadioButton();
            this.map7 = new System.Windows.Forms.RadioButton();
            this.mapBox = new System.Windows.Forms.GroupBox();
            this.modeBox = new System.Windows.Forms.GroupBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.logButton = new System.Windows.Forms.Button();
            this.teamStats = new System.Windows.Forms.GroupBox();
            this.p5Deaths = new System.Windows.Forms.TextBox();
            this.p4Deaths = new System.Windows.Forms.TextBox();
            this.p3Deaths = new System.Windows.Forms.TextBox();
            this.p2Deaths = new System.Windows.Forms.TextBox();
            this.p5Kills = new System.Windows.Forms.TextBox();
            this.p4Kills = new System.Windows.Forms.TextBox();
            this.p3Kills = new System.Windows.Forms.TextBox();
            this.p2Kills = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.killsLabel = new System.Windows.Forms.Label();
            this.p1Deaths = new System.Windows.Forms.TextBox();
            this.p1Kills = new System.Windows.Forms.TextBox();
            this.player5Label = new System.Windows.Forms.Label();
            this.player4Label = new System.Windows.Forms.Label();
            this.player3Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.player1Label = new System.Windows.Forms.Label();
            this.startingSideGB = new System.Windows.Forms.GroupBox();
            this.coalitionRB = new System.Windows.Forms.RadioButton();
            this.allegianceRB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.minsCB = new System.Windows.Forms.ComboBox();
            this.secsCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mapBox.SuspendLayout();
            this.modeBox.SuspendLayout();
            this.teamStats.SuspendLayout();
            this.startingSideGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamACB
            // 
            this.teamACB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teamACB.FormattingEnabled = true;
            this.teamACB.Location = new System.Drawing.Point(9, 197);
            this.teamACB.Name = "teamACB";
            this.teamACB.Size = new System.Drawing.Size(243, 21);
            this.teamACB.TabIndex = 2;
            this.teamACB.SelectedIndexChanged += new System.EventHandler(this.Team_SelectedIndexChanged);
            // 
            // teamBCB
            // 
            this.teamBCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teamBCB.FormattingEnabled = true;
            this.teamBCB.Location = new System.Drawing.Point(268, 197);
            this.teamBCB.Name = "teamBCB";
            this.teamBCB.Size = new System.Drawing.Size(243, 21);
            this.teamBCB.TabIndex = 3;
            this.teamBCB.SelectedIndexChanged += new System.EventHandler(this.Team_SelectedIndexChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 181);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(44, 13);
            this.label32.TabIndex = 60;
            this.label32.Text = "Team A";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(468, 181);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(44, 13);
            this.label33.TabIndex = 61;
            this.label33.Text = "Team B";
            // 
            // teamAScore
            // 
            this.teamAScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamAScore.Location = new System.Drawing.Point(180, 228);
            this.teamAScore.Name = "teamAScore";
            this.teamAScore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.teamAScore.Size = new System.Drawing.Size(72, 31);
            this.teamAScore.TabIndex = 4;
            this.teamAScore.Text = "0";
            this.teamAScore.Enter += new System.EventHandler(this.Textbox_Enter);
            // 
            // teamBScore
            // 
            this.teamBScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamBScore.Location = new System.Drawing.Point(268, 228);
            this.teamBScore.Name = "teamBScore";
            this.teamBScore.Size = new System.Drawing.Size(72, 31);
            this.teamBScore.TabIndex = 5;
            this.teamBScore.Text = "0";
            this.teamBScore.Enter += new System.EventHandler(this.Textbox_Enter);
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(437, 620);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 12;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // notesTB
            // 
            this.notesTB.Location = new System.Drawing.Point(10, 471);
            this.notesTB.Multiline = true;
            this.notesTB.Name = "notesTB";
            this.notesTB.Size = new System.Drawing.Size(502, 144);
            this.notesTB.TabIndex = 9;
            // 
            // mode1
            // 
            this.mode1.AutoSize = true;
            this.mode1.Location = new System.Drawing.Point(8, 19);
            this.mode1.Name = "mode1";
            this.mode1.Size = new System.Drawing.Size(71, 17);
            this.mode1.TabIndex = 0;
            this.mode1.TabStop = true;
            this.mode1.Text = "Hardpoint";
            this.mode1.UseVisualStyleBackColor = true;
            // 
            // mode3
            // 
            this.mode3.AutoSize = true;
            this.mode3.Location = new System.Drawing.Point(294, 19);
            this.mode3.Name = "mode3";
            this.mode3.Size = new System.Drawing.Size(78, 17);
            this.mode3.TabIndex = 2;
            this.mode3.TabStop = true;
            this.mode3.Text = "Domination";
            this.mode3.UseVisualStyleBackColor = true;
            // 
            // mode2
            // 
            this.mode2.AutoSize = true;
            this.mode2.Location = new System.Drawing.Point(145, 19);
            this.mode2.Name = "mode2";
            this.mode2.Size = new System.Drawing.Size(119, 17);
            this.mode2.TabIndex = 1;
            this.mode2.TabStop = true;
            this.mode2.Text = "Search and Destroy";
            this.mode2.UseVisualStyleBackColor = true;
            // 
            // map1
            // 
            this.map1.AutoSize = true;
            this.map1.Location = new System.Drawing.Point(8, 19);
            this.map1.Name = "map1";
            this.map1.Size = new System.Drawing.Size(46, 17);
            this.map1.TabIndex = 0;
            this.map1.TabStop = true;
            this.map1.Text = "Map";
            this.map1.UseVisualStyleBackColor = true;
            // 
            // map2
            // 
            this.map2.AutoSize = true;
            this.map2.Location = new System.Drawing.Point(145, 19);
            this.map2.Name = "map2";
            this.map2.Size = new System.Drawing.Size(46, 17);
            this.map2.TabIndex = 1;
            this.map2.TabStop = true;
            this.map2.Text = "Map";
            this.map2.UseVisualStyleBackColor = true;
            // 
            // map3
            // 
            this.map3.AutoSize = true;
            this.map3.Location = new System.Drawing.Point(294, 19);
            this.map3.Name = "map3";
            this.map3.Size = new System.Drawing.Size(46, 17);
            this.map3.TabIndex = 2;
            this.map3.TabStop = true;
            this.map3.Text = "Map";
            this.map3.UseVisualStyleBackColor = true;
            // 
            // map4
            // 
            this.map4.AutoSize = true;
            this.map4.Location = new System.Drawing.Point(8, 43);
            this.map4.Name = "map4";
            this.map4.Size = new System.Drawing.Size(46, 17);
            this.map4.TabIndex = 3;
            this.map4.TabStop = true;
            this.map4.Text = "Map";
            this.map4.UseVisualStyleBackColor = true;
            // 
            // map5
            // 
            this.map5.AutoSize = true;
            this.map5.Location = new System.Drawing.Point(145, 43);
            this.map5.Name = "map5";
            this.map5.Size = new System.Drawing.Size(46, 17);
            this.map5.TabIndex = 4;
            this.map5.TabStop = true;
            this.map5.Text = "Map";
            this.map5.UseVisualStyleBackColor = true;
            // 
            // map6
            // 
            this.map6.AutoSize = true;
            this.map6.Location = new System.Drawing.Point(294, 43);
            this.map6.Name = "map6";
            this.map6.Size = new System.Drawing.Size(46, 17);
            this.map6.TabIndex = 5;
            this.map6.TabStop = true;
            this.map6.Text = "Map";
            this.map6.UseVisualStyleBackColor = true;
            // 
            // map7
            // 
            this.map7.AutoSize = true;
            this.map7.Location = new System.Drawing.Point(8, 66);
            this.map7.Name = "map7";
            this.map7.Size = new System.Drawing.Size(46, 17);
            this.map7.TabIndex = 6;
            this.map7.TabStop = true;
            this.map7.Text = "Map";
            this.map7.UseVisualStyleBackColor = true;
            // 
            // mapBox
            // 
            this.mapBox.Controls.Add(this.map7);
            this.mapBox.Controls.Add(this.map1);
            this.mapBox.Controls.Add(this.map6);
            this.mapBox.Controls.Add(this.map2);
            this.mapBox.Controls.Add(this.map5);
            this.mapBox.Controls.Add(this.map3);
            this.mapBox.Controls.Add(this.map4);
            this.mapBox.Location = new System.Drawing.Point(9, 72);
            this.mapBox.Name = "mapBox";
            this.mapBox.Size = new System.Drawing.Size(503, 97);
            this.mapBox.TabIndex = 1;
            this.mapBox.TabStop = false;
            this.mapBox.Text = "Map";
            // 
            // modeBox
            // 
            this.modeBox.Controls.Add(this.mode3);
            this.modeBox.Controls.Add(this.mode1);
            this.modeBox.Controls.Add(this.mode2);
            this.modeBox.Location = new System.Drawing.Point(9, 12);
            this.modeBox.Name = "modeBox";
            this.modeBox.Size = new System.Drawing.Size(502, 54);
            this.modeBox.TabIndex = 0;
            this.modeBox.TabStop = false;
            this.modeBox.Text = "Mode";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(10, 623);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 10;
            // 
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(217, 621);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(46, 23);
            this.logButton.TabIndex = 11;
            this.logButton.Text = "logs";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // teamStats
            // 
            this.teamStats.Controls.Add(this.p5Deaths);
            this.teamStats.Controls.Add(this.p4Deaths);
            this.teamStats.Controls.Add(this.p3Deaths);
            this.teamStats.Controls.Add(this.p2Deaths);
            this.teamStats.Controls.Add(this.p5Kills);
            this.teamStats.Controls.Add(this.p4Kills);
            this.teamStats.Controls.Add(this.p3Kills);
            this.teamStats.Controls.Add(this.p2Kills);
            this.teamStats.Controls.Add(this.label1);
            this.teamStats.Controls.Add(this.killsLabel);
            this.teamStats.Controls.Add(this.p1Deaths);
            this.teamStats.Controls.Add(this.p1Kills);
            this.teamStats.Controls.Add(this.player5Label);
            this.teamStats.Controls.Add(this.player4Label);
            this.teamStats.Controls.Add(this.player3Label);
            this.teamStats.Controls.Add(this.player2Label);
            this.teamStats.Controls.Add(this.player1Label);
            this.teamStats.Enabled = false;
            this.teamStats.Location = new System.Drawing.Point(9, 318);
            this.teamStats.Name = "teamStats";
            this.teamStats.Size = new System.Drawing.Size(503, 147);
            this.teamStats.TabIndex = 8;
            this.teamStats.TabStop = false;
            this.teamStats.Text = "Team Statistics";
            // 
            // p5Deaths
            // 
            this.p5Deaths.Location = new System.Drawing.Point(259, 117);
            this.p5Deaths.Name = "p5Deaths";
            this.p5Deaths.Size = new System.Drawing.Size(56, 20);
            this.p5Deaths.TabIndex = 9;
            this.p5Deaths.Text = "0";
            this.p5Deaths.Enter += new System.EventHandler(this.Textbox_Enter);
            // 
            // p4Deaths
            // 
            this.p4Deaths.Location = new System.Drawing.Point(259, 95);
            this.p4Deaths.Name = "p4Deaths";
            this.p4Deaths.Size = new System.Drawing.Size(56, 20);
            this.p4Deaths.TabIndex = 7;
            this.p4Deaths.Text = "0";
            this.p4Deaths.Enter += new System.EventHandler(this.Textbox_Enter);
            // 
            // p3Deaths
            // 
            this.p3Deaths.Location = new System.Drawing.Point(259, 73);
            this.p3Deaths.Name = "p3Deaths";
            this.p3Deaths.Size = new System.Drawing.Size(56, 20);
            this.p3Deaths.TabIndex = 5;
            this.p3Deaths.Text = "0";
            this.p3Deaths.Enter += new System.EventHandler(this.Textbox_Enter);
            // 
            // p2Deaths
            // 
            this.p2Deaths.Location = new System.Drawing.Point(259, 51);
            this.p2Deaths.Name = "p2Deaths";
            this.p2Deaths.Size = new System.Drawing.Size(56, 20);
            this.p2Deaths.TabIndex = 3;
            this.p2Deaths.Text = "0";
            this.p2Deaths.Enter += new System.EventHandler(this.Textbox_Enter);
            // 
            // p5Kills
            // 
            this.p5Kills.Location = new System.Drawing.Point(187, 117);
            this.p5Kills.Name = "p5Kills";
            this.p5Kills.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.p5Kills.Size = new System.Drawing.Size(56, 20);
            this.p5Kills.TabIndex = 8;
            this.p5Kills.Text = "0";
            this.p5Kills.Enter += new System.EventHandler(this.Textbox_Enter);
            // 
            // p4Kills
            // 
            this.p4Kills.Location = new System.Drawing.Point(187, 95);
            this.p4Kills.Name = "p4Kills";
            this.p4Kills.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.p4Kills.Size = new System.Drawing.Size(56, 20);
            this.p4Kills.TabIndex = 6;
            this.p4Kills.Text = "0";
            this.p4Kills.Enter += new System.EventHandler(this.Textbox_Enter);
            // 
            // p3Kills
            // 
            this.p3Kills.Location = new System.Drawing.Point(187, 73);
            this.p3Kills.Name = "p3Kills";
            this.p3Kills.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.p3Kills.Size = new System.Drawing.Size(56, 20);
            this.p3Kills.TabIndex = 4;
            this.p3Kills.Text = "0";
            this.p3Kills.Enter += new System.EventHandler(this.Textbox_Enter);
            // 
            // p2Kills
            // 
            this.p2Kills.Location = new System.Drawing.Point(187, 51);
            this.p2Kills.Name = "p2Kills";
            this.p2Kills.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.p2Kills.Size = new System.Drawing.Size(56, 20);
            this.p2Kills.TabIndex = 2;
            this.p2Kills.Text = "0";
            this.p2Kills.Enter += new System.EventHandler(this.Textbox_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Deaths";
            // 
            // killsLabel
            // 
            this.killsLabel.AutoSize = true;
            this.killsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killsLabel.Location = new System.Drawing.Point(184, 13);
            this.killsLabel.Name = "killsLabel";
            this.killsLabel.Size = new System.Drawing.Size(30, 13);
            this.killsLabel.TabIndex = 7;
            this.killsLabel.Text = "Kills";
            // 
            // p1Deaths
            // 
            this.p1Deaths.Location = new System.Drawing.Point(259, 29);
            this.p1Deaths.Name = "p1Deaths";
            this.p1Deaths.Size = new System.Drawing.Size(56, 20);
            this.p1Deaths.TabIndex = 1;
            this.p1Deaths.Text = "0";
            this.p1Deaths.Enter += new System.EventHandler(this.Textbox_Enter);
            // 
            // p1Kills
            // 
            this.p1Kills.Location = new System.Drawing.Point(187, 29);
            this.p1Kills.Name = "p1Kills";
            this.p1Kills.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.p1Kills.Size = new System.Drawing.Size(56, 20);
            this.p1Kills.TabIndex = 0;
            this.p1Kills.Text = "0";
            this.p1Kills.Enter += new System.EventHandler(this.Textbox_Enter);
            // 
            // player5Label
            // 
            this.player5Label.AutoSize = true;
            this.player5Label.Location = new System.Drawing.Point(9, 120);
            this.player5Label.Name = "player5Label";
            this.player5Label.Size = new System.Drawing.Size(45, 13);
            this.player5Label.TabIndex = 4;
            this.player5Label.Text = "Player 5";
            // 
            // player4Label
            // 
            this.player4Label.AutoSize = true;
            this.player4Label.Location = new System.Drawing.Point(9, 98);
            this.player4Label.Name = "player4Label";
            this.player4Label.Size = new System.Drawing.Size(45, 13);
            this.player4Label.TabIndex = 3;
            this.player4Label.Text = "Player 4";
            // 
            // player3Label
            // 
            this.player3Label.AutoSize = true;
            this.player3Label.Location = new System.Drawing.Point(9, 76);
            this.player3Label.Name = "player3Label";
            this.player3Label.Size = new System.Drawing.Size(45, 13);
            this.player3Label.TabIndex = 2;
            this.player3Label.Text = "Player 3";
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Location = new System.Drawing.Point(8, 54);
            this.player2Label.Name = "player2Label";
            this.player2Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.player2Label.Size = new System.Drawing.Size(45, 13);
            this.player2Label.TabIndex = 1;
            this.player2Label.Text = "Player 2";
            this.player2Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Location = new System.Drawing.Point(9, 32);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(45, 13);
            this.player1Label.TabIndex = 0;
            this.player1Label.Text = "Player 1";
            this.player1Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // startingSideGB
            // 
            this.startingSideGB.Controls.Add(this.allegianceRB);
            this.startingSideGB.Controls.Add(this.coalitionRB);
            this.startingSideGB.Location = new System.Drawing.Point(10, 265);
            this.startingSideGB.Name = "startingSideGB";
            this.startingSideGB.Size = new System.Drawing.Size(242, 47);
            this.startingSideGB.TabIndex = 6;
            this.startingSideGB.TabStop = false;
            this.startingSideGB.Text = "Team A Starting Side";
            // 
            // coalitionRB
            // 
            this.coalitionRB.AutoSize = true;
            this.coalitionRB.Location = new System.Drawing.Point(144, 19);
            this.coalitionRB.Name = "coalitionRB";
            this.coalitionRB.Size = new System.Drawing.Size(65, 17);
            this.coalitionRB.TabIndex = 3;
            this.coalitionRB.TabStop = true;
            this.coalitionRB.Text = "Coalition";
            this.coalitionRB.UseVisualStyleBackColor = true;
            // 
            // allegianceRB
            // 
            this.allegianceRB.AutoSize = true;
            this.allegianceRB.Location = new System.Drawing.Point(11, 19);
            this.allegianceRB.Name = "allegianceRB";
            this.allegianceRB.Size = new System.Drawing.Size(74, 17);
            this.allegianceRB.TabIndex = 4;
            this.allegianceRB.TabStop = true;
            this.allegianceRB.Text = "Allegiance";
            this.allegianceRB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.secsCB);
            this.groupBox1.Controls.Add(this.minsCB);
            this.groupBox1.Location = new System.Drawing.Point(265, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 47);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Duration";
            // 
            // minsCB
            // 
            this.minsCB.FormattingEnabled = true;
            this.minsCB.Location = new System.Drawing.Point(57, 18);
            this.minsCB.Name = "minsCB";
            this.minsCB.Size = new System.Drawing.Size(59, 21);
            this.minsCB.TabIndex = 0;
            // 
            // secsCB
            // 
            this.secsCB.FormattingEnabled = true;
            this.secsCB.Location = new System.Drawing.Point(172, 18);
            this.secsCB.Name = "secsCB";
            this.secsCB.Size = new System.Drawing.Size(59, 21);
            this.secsCB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mins";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Secs";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 653);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startingSideGB);
            this.Controls.Add(this.teamStats);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.modeBox);
            this.Controls.Add(this.mapBox);
            this.Controls.Add(this.notesTB);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.teamBScore);
            this.Controls.Add(this.teamAScore);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.teamBCB);
            this.Controls.Add(this.teamACB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tracker";
            this.Text = " CoD Game Tracker";
            this.Load += new System.EventHandler(this.Tracker_Load);
            this.mapBox.ResumeLayout(false);
            this.mapBox.PerformLayout();
            this.modeBox.ResumeLayout(false);
            this.modeBox.PerformLayout();
            this.teamStats.ResumeLayout(false);
            this.teamStats.PerformLayout();
            this.startingSideGB.ResumeLayout(false);
            this.startingSideGB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox teamACB;
        private System.Windows.Forms.ComboBox teamBCB;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox teamAScore;
        private System.Windows.Forms.TextBox teamBScore;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.TextBox notesTB;
        private System.Windows.Forms.RadioButton mode1;
        private System.Windows.Forms.RadioButton mode3;
        private System.Windows.Forms.RadioButton mode2;
        private System.Windows.Forms.RadioButton map1;
        private System.Windows.Forms.RadioButton map2;
        private System.Windows.Forms.RadioButton map3;
        private System.Windows.Forms.RadioButton map4;
        private System.Windows.Forms.RadioButton map5;
        private System.Windows.Forms.RadioButton map6;
        private System.Windows.Forms.RadioButton map7;
        private System.Windows.Forms.GroupBox mapBox;
        private System.Windows.Forms.GroupBox modeBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.GroupBox teamStats;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player5Label;
        private System.Windows.Forms.Label player4Label;
        private System.Windows.Forms.Label player3Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.TextBox p5Deaths;
        private System.Windows.Forms.TextBox p4Deaths;
        private System.Windows.Forms.TextBox p3Deaths;
        private System.Windows.Forms.TextBox p2Deaths;
        private System.Windows.Forms.TextBox p5Kills;
        private System.Windows.Forms.TextBox p4Kills;
        private System.Windows.Forms.TextBox p3Kills;
        private System.Windows.Forms.TextBox p2Kills;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label killsLabel;
        private System.Windows.Forms.TextBox p1Deaths;
        private System.Windows.Forms.TextBox p1Kills;
        private System.Windows.Forms.GroupBox startingSideGB;
        private System.Windows.Forms.RadioButton allegianceRB;
        private System.Windows.Forms.RadioButton coalitionRB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox secsCB;
        private System.Windows.Forms.ComboBox minsCB;
    }
}

