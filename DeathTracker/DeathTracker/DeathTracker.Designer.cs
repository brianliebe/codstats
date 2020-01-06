namespace DeathTracker
{
    partial class DeathTracker
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
            this.map = new System.Windows.Forms.PictureBox();
            this.mapBox = new System.Windows.Forms.ComboBox();
            this.mapLabel = new System.Windows.Forms.Label();
            this.modeBox = new System.Windows.Forms.ComboBox();
            this.teamABox = new System.Windows.Forms.ComboBox();
            this.modeLabel = new System.Windows.Forms.Label();
            this.teamALabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.teamBBox = new System.Windows.Forms.ComboBox();
            this.teamBLabel = new System.Windows.Forms.Label();
            this.sideLabel = new System.Windows.Forms.Label();
            this.ASideButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BSideButton = new System.Windows.Forms.Button();
            this.noteTextbox = new System.Windows.Forms.TextBox();
            this.addNoteLabel = new System.Windows.Forms.Label();
            this.addNoteButton = new System.Windows.Forms.Button();
            this.openFileCheckbox = new System.Windows.Forms.CheckBox();
            this.hardpointCombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Location = new System.Drawing.Point(12, 60);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(512, 512);
            this.map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.map.TabIndex = 0;
            this.map.TabStop = false;
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Map_MouseClick);
            // 
            // mapBox
            // 
            this.mapBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mapBox.FormattingEnabled = true;
            this.mapBox.Location = new System.Drawing.Point(59, 6);
            this.mapBox.Name = "mapBox";
            this.mapBox.Size = new System.Drawing.Size(142, 21);
            this.mapBox.TabIndex = 1;
            this.mapBox.SelectedIndexChanged += new System.EventHandler(this.MapBox_SelectedIndexChanged);
            // 
            // mapLabel
            // 
            this.mapLabel.AutoSize = true;
            this.mapLabel.Location = new System.Drawing.Point(25, 9);
            this.mapLabel.Name = "mapLabel";
            this.mapLabel.Size = new System.Drawing.Size(31, 13);
            this.mapLabel.TabIndex = 2;
            this.mapLabel.Text = "Map:";
            // 
            // modeBox
            // 
            this.modeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeBox.FormattingEnabled = true;
            this.modeBox.Location = new System.Drawing.Point(269, 6);
            this.modeBox.Name = "modeBox";
            this.modeBox.Size = new System.Drawing.Size(142, 21);
            this.modeBox.TabIndex = 3;
            this.modeBox.SelectedIndexChanged += new System.EventHandler(this.ModeBox_SelectedIndexChanged);
            // 
            // teamABox
            // 
            this.teamABox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teamABox.FormattingEnabled = true;
            this.teamABox.Location = new System.Drawing.Point(59, 33);
            this.teamABox.Name = "teamABox";
            this.teamABox.Size = new System.Drawing.Size(142, 21);
            this.teamABox.TabIndex = 4;
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new System.Drawing.Point(226, 9);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(37, 13);
            this.modeLabel.TabIndex = 5;
            this.modeLabel.Text = "Mode:";
            // 
            // teamALabel
            // 
            this.teamALabel.AutoSize = true;
            this.teamALabel.Location = new System.Drawing.Point(9, 36);
            this.teamALabel.Name = "teamALabel";
            this.teamALabel.Size = new System.Drawing.Size(47, 13);
            this.teamALabel.TabIndex = 6;
            this.teamALabel.Text = "Team A:";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(714, 578);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 7;
            this.generateButton.Text = "Done";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(12, 578);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // teamBBox
            // 
            this.teamBBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teamBBox.FormattingEnabled = true;
            this.teamBBox.Location = new System.Drawing.Point(269, 33);
            this.teamBBox.Name = "teamBBox";
            this.teamBBox.Size = new System.Drawing.Size(142, 21);
            this.teamBBox.TabIndex = 9;
            // 
            // teamBLabel
            // 
            this.teamBLabel.AutoSize = true;
            this.teamBLabel.Location = new System.Drawing.Point(216, 36);
            this.teamBLabel.Name = "teamBLabel";
            this.teamBLabel.Size = new System.Drawing.Size(47, 13);
            this.teamBLabel.TabIndex = 10;
            this.teamBLabel.Text = "Team B:";
            // 
            // sideLabel
            // 
            this.sideLabel.AutoSize = true;
            this.sideLabel.Location = new System.Drawing.Point(483, 10);
            this.sideLabel.Name = "sideLabel";
            this.sideLabel.Size = new System.Drawing.Size(41, 13);
            this.sideLabel.TabIndex = 11;
            this.sideLabel.Text = "A Side:";
            // 
            // ASideButton
            // 
            this.ASideButton.Location = new System.Drawing.Point(530, 6);
            this.ASideButton.Name = "ASideButton";
            this.ASideButton.Size = new System.Drawing.Size(39, 21);
            this.ASideButton.TabIndex = 12;
            this.ASideButton.Text = "O";
            this.ASideButton.UseVisualStyleBackColor = true;
            this.ASideButton.Click += new System.EventHandler(this.ASideButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(93, 578);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(75, 23);
            this.undoButton.TabIndex = 13;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "B Side:";
            // 
            // BSideButton
            // 
            this.BSideButton.Location = new System.Drawing.Point(530, 32);
            this.BSideButton.Name = "BSideButton";
            this.BSideButton.Size = new System.Drawing.Size(39, 21);
            this.BSideButton.TabIndex = 15;
            this.BSideButton.Text = "D";
            this.BSideButton.UseVisualStyleBackColor = true;
            this.BSideButton.Click += new System.EventHandler(this.BSideButton_Click);
            // 
            // noteTextbox
            // 
            this.noteTextbox.Location = new System.Drawing.Point(530, 76);
            this.noteTextbox.Multiline = true;
            this.noteTextbox.Name = "noteTextbox";
            this.noteTextbox.Size = new System.Drawing.Size(259, 114);
            this.noteTextbox.TabIndex = 16;
            // 
            // addNoteLabel
            // 
            this.addNoteLabel.AutoSize = true;
            this.addNoteLabel.Location = new System.Drawing.Point(527, 60);
            this.addNoteLabel.Name = "addNoteLabel";
            this.addNoteLabel.Size = new System.Drawing.Size(131, 13);
            this.addNoteLabel.TabIndex = 17;
            this.addNoteLabel.Text = "Add note to last kill/death:";
            // 
            // addNoteButton
            // 
            this.addNoteButton.Location = new System.Drawing.Point(734, 196);
            this.addNoteButton.Name = "addNoteButton";
            this.addNoteButton.Size = new System.Drawing.Size(55, 23);
            this.addNoteButton.TabIndex = 18;
            this.addNoteButton.Text = "Add";
            this.addNoteButton.UseVisualStyleBackColor = true;
            this.addNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
            // 
            // openFileCheckbox
            // 
            this.openFileCheckbox.AutoSize = true;
            this.openFileCheckbox.Location = new System.Drawing.Point(582, 582);
            this.openFileCheckbox.Name = "openFileCheckbox";
            this.openFileCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.openFileCheckbox.Size = new System.Drawing.Size(124, 17);
            this.openFileCheckbox.TabIndex = 19;
            this.openFileCheckbox.Text = "Open file when done";
            this.openFileCheckbox.UseVisualStyleBackColor = true;
            // 
            // hardpointCombobox
            // 
            this.hardpointCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hardpointCombobox.Enabled = false;
            this.hardpointCombobox.FormattingEnabled = true;
            this.hardpointCombobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.hardpointCombobox.Location = new System.Drawing.Point(415, 6);
            this.hardpointCombobox.Name = "hardpointCombobox";
            this.hardpointCombobox.Size = new System.Drawing.Size(36, 21);
            this.hardpointCombobox.TabIndex = 20;
            // 
            // DeathTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 608);
            this.Controls.Add(this.hardpointCombobox);
            this.Controls.Add(this.openFileCheckbox);
            this.Controls.Add(this.addNoteButton);
            this.Controls.Add(this.addNoteLabel);
            this.Controls.Add(this.noteTextbox);
            this.Controls.Add(this.BSideButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.ASideButton);
            this.Controls.Add(this.sideLabel);
            this.Controls.Add(this.teamBLabel);
            this.Controls.Add(this.teamBBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.teamALabel);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.teamABox);
            this.Controls.Add(this.modeBox);
            this.Controls.Add(this.mapLabel);
            this.Controls.Add(this.mapBox);
            this.Controls.Add(this.map);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DeathTracker";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Death Tracker";
            this.Load += new System.EventHandler(this.DeathTracker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox map;
        private System.Windows.Forms.ComboBox mapBox;
        private System.Windows.Forms.Label mapLabel;
        private System.Windows.Forms.ComboBox modeBox;
        private System.Windows.Forms.ComboBox teamABox;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.Label teamALabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ComboBox teamBBox;
        private System.Windows.Forms.Label teamBLabel;
        private System.Windows.Forms.Label sideLabel;
        private System.Windows.Forms.Button ASideButton;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BSideButton;
        private System.Windows.Forms.TextBox noteTextbox;
        private System.Windows.Forms.Label addNoteLabel;
        private System.Windows.Forms.Button addNoteButton;
        private System.Windows.Forms.CheckBox openFileCheckbox;
        private System.Windows.Forms.ComboBox hardpointCombobox;
    }
}

