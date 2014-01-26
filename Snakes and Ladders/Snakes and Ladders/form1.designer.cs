namespace Snakes_and_Ladders
{
    partial class FormSnakesAndLadders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSnakesAndLadders));
            this.pbDisplay = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pbDice = new System.Windows.Forms.PictureBox();
            this.pbLogos = new System.Windows.Forms.PictureBox();
            this.timerWait = new System.Windows.Forms.Timer(this.components);
            this.timerMoveCounter = new System.Windows.Forms.Timer(this.components);
            this.timerRoll = new System.Windows.Forms.Timer(this.components);
            this.timerComputer = new System.Windows.Forms.Timer(this.components);
            this.llStart = new System.Windows.Forms.LinkLabel();
            this.llInstructions = new System.Windows.Forms.LinkLabel();
            this.rtbInstruct = new System.Windows.Forms.RichTextBox();
            this.panelAvatar = new System.Windows.Forms.Panel();
            this.lblP2 = new System.Windows.Forms.Label();
            this.lblP1 = new System.Windows.Forms.Label();
            this.rbComputer = new System.Windows.Forms.RadioButton();
            this.rbPlayer = new System.Windows.Forms.RadioButton();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblAvatarP2 = new System.Windows.Forms.Label();
            this.cbAvatarP2 = new System.Windows.Forms.ComboBox();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAvatarP1 = new System.Windows.Forms.Label();
            this.cbAvatarP1 = new System.Windows.Forms.ComboBox();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.panelTemplate = new System.Windows.Forms.Panel();
            this.rbSnL3 = new System.Windows.Forms.RadioButton();
            this.rbSnL2 = new System.Windows.Forms.RadioButton();
            this.rbSnL = new System.Windows.Forms.RadioButton();
            this.labelTemplate = new System.Windows.Forms.Label();
            this.llBegin = new System.Windows.Forms.LinkLabel();
            this.llRestart = new System.Windows.Forms.LinkLabel();
            this.llQuit = new System.Windows.Forms.LinkLabel();
            this.timerUpLadderDownSnake = new System.Windows.Forms.Timer(this.components);
            this.btnSpecial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogos)).BeginInit();
            this.panelAvatar.SuspendLayout();
            this.panelTemplate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbDisplay
            // 
            this.pbDisplay.BackColor = System.Drawing.Color.White;
            this.pbDisplay.Location = new System.Drawing.Point(328, 12);
            this.pbDisplay.Name = "pbDisplay";
            this.pbDisplay.Size = new System.Drawing.Size(620, 620);
            this.pbDisplay.TabIndex = 0;
            this.pbDisplay.TabStop = false;
            this.pbDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.pbDisplay_Paint);
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(22, 476);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(273, 38);
            this.btnRoll.TabIndex = 2;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click_1);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(63, 287);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(210, 24);
            this.lblInstruction.TabIndex = 4;
            this.lblInstruction.Text = "Player One: Roll the Die";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMain.Controls.Add(this.pbDice);
            this.panelMain.Location = new System.Drawing.Point(22, 325);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(273, 136);
            this.panelMain.TabIndex = 5;
            // 
            // pbDice
            // 
            this.pbDice.BackColor = System.Drawing.Color.White;
            this.pbDice.Location = new System.Drawing.Point(106, 29);
            this.pbDice.Name = "pbDice";
            this.pbDice.Size = new System.Drawing.Size(70, 70);
            this.pbDice.TabIndex = 4;
            this.pbDice.TabStop = false;
            // 
            // pbLogos
            // 
            this.pbLogos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogos.BackgroundImage")));
            this.pbLogos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogos.Location = new System.Drawing.Point(26, 12);
            this.pbLogos.Name = "pbLogos";
            this.pbLogos.Size = new System.Drawing.Size(274, 166);
            this.pbLogos.TabIndex = 6;
            this.pbLogos.TabStop = false;
            // 
            // timerWait
            // 
            this.timerWait.Interval = 500;
            this.timerWait.Tick += new System.EventHandler(this.timerWait_Tick);
            // 
            // timerMoveCounter
            // 
            this.timerMoveCounter.Interval = 200;
            this.timerMoveCounter.Tick += new System.EventHandler(this.timerMoveCounter_Tick);
            // 
            // timerRoll
            // 
            this.timerRoll.Tick += new System.EventHandler(this.timerRoll_Tick);
            // 
            // timerComputer
            // 
            this.timerComputer.Interval = 1000;
            this.timerComputer.Tick += new System.EventHandler(this.timerComputer_Tick);
            // 
            // llStart
            // 
            this.llStart.AutoSize = true;
            this.llStart.DisabledLinkColor = System.Drawing.Color.White;
            this.llStart.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llStart.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llStart.LinkColor = System.Drawing.Color.Blue;
            this.llStart.Location = new System.Drawing.Point(126, 191);
            this.llStart.Name = "llStart";
            this.llStart.Size = new System.Drawing.Size(80, 40);
            this.llStart.TabIndex = 7;
            this.llStart.TabStop = true;
            this.llStart.Text = "Start";
            this.llStart.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llStart_LinkClicked);
            // 
            // llInstructions
            // 
            this.llInstructions.AutoSize = true;
            this.llInstructions.DisabledLinkColor = System.Drawing.Color.White;
            this.llInstructions.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llInstructions.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llInstructions.LinkColor = System.Drawing.Color.Blue;
            this.llInstructions.Location = new System.Drawing.Point(77, 231);
            this.llInstructions.Name = "llInstructions";
            this.llInstructions.Size = new System.Drawing.Size(182, 40);
            this.llInstructions.TabIndex = 8;
            this.llInstructions.TabStop = true;
            this.llInstructions.Text = "How to Play";
            this.llInstructions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llInstructions_LinkClicked);
            // 
            // rtbInstruct
            // 
            this.rtbInstruct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rtbInstruct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInstruct.Location = new System.Drawing.Point(12, 299);
            this.rtbInstruct.Name = "rtbInstruct";
            this.rtbInstruct.Size = new System.Drawing.Size(296, 174);
            this.rtbInstruct.TabIndex = 9;
            this.rtbInstruct.Text = "Roll the dice and this will determine the number of positions your avatar can adv" +
                "ance.Ladders can give you major boosts but beware of snakes!\n\n\n For more info, s" +
                "ee user manual.";
            // 
            // panelAvatar
            // 
            this.panelAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelAvatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAvatar.Controls.Add(this.lblP2);
            this.panelAvatar.Controls.Add(this.lblP1);
            this.panelAvatar.Controls.Add(this.rbComputer);
            this.panelAvatar.Controls.Add(this.rbPlayer);
            this.panelAvatar.Controls.Add(this.lblName2);
            this.panelAvatar.Controls.Add(this.lblAvatarP2);
            this.panelAvatar.Controls.Add(this.cbAvatarP2);
            this.panelAvatar.Controls.Add(this.txtP2);
            this.panelAvatar.Controls.Add(this.lblName);
            this.panelAvatar.Controls.Add(this.lblAvatarP1);
            this.panelAvatar.Controls.Add(this.cbAvatarP1);
            this.panelAvatar.Controls.Add(this.txtP1);
            this.panelAvatar.Location = new System.Drawing.Point(22, 191);
            this.panelAvatar.Name = "panelAvatar";
            this.panelAvatar.Size = new System.Drawing.Size(273, 235);
            this.panelAvatar.TabIndex = 10;
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2.Location = new System.Drawing.Point(25, 116);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(65, 20);
            this.lblP2.TabIndex = 33;
            this.lblP2.Text = "Player 2";
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1.Location = new System.Drawing.Point(25, 14);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(65, 20);
            this.lblP1.TabIndex = 32;
            this.lblP1.Text = "Player 1";
            // 
            // rbComputer
            // 
            this.rbComputer.AutoSize = true;
            this.rbComputer.Location = new System.Drawing.Point(170, 140);
            this.rbComputer.Name = "rbComputer";
            this.rbComputer.Size = new System.Drawing.Size(70, 17);
            this.rbComputer.TabIndex = 31;
            this.rbComputer.TabStop = true;
            this.rbComputer.Text = "Computer";
            this.rbComputer.UseVisualStyleBackColor = true;
            this.rbComputer.CheckedChanged += new System.EventHandler(this.rbComputer_CheckedChanged);
            // 
            // rbPlayer
            // 
            this.rbPlayer.AutoSize = true;
            this.rbPlayer.Location = new System.Drawing.Point(36, 140);
            this.rbPlayer.Name = "rbPlayer";
            this.rbPlayer.Size = new System.Drawing.Size(54, 17);
            this.rbPlayer.TabIndex = 30;
            this.rbPlayer.TabStop = true;
            this.rbPlayer.Text = "Player";
            this.rbPlayer.UseVisualStyleBackColor = true;
            this.rbPlayer.CheckedChanged += new System.EventHandler(this.rbPlayer_CheckedChanged);
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(74, 170);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(35, 13);
            this.lblName2.TabIndex = 29;
            this.lblName2.Text = "Name";
            // 
            // lblAvatarP2
            // 
            this.lblAvatarP2.AutoSize = true;
            this.lblAvatarP2.Location = new System.Drawing.Point(42, 200);
            this.lblAvatarP2.Name = "lblAvatarP2";
            this.lblAvatarP2.Size = new System.Drawing.Size(65, 13);
            this.lblAvatarP2.TabIndex = 28;
            this.lblAvatarP2.Text = "Game Piece";
            // 
            // cbAvatarP2
            // 
            this.cbAvatarP2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAvatarP2.FormattingEnabled = true;
            this.cbAvatarP2.Location = new System.Drawing.Point(113, 193);
            this.cbAvatarP2.Name = "cbAvatarP2";
            this.cbAvatarP2.Size = new System.Drawing.Size(99, 21);
            this.cbAvatarP2.TabIndex = 27;
            this.cbAvatarP2.TextChanged += new System.EventHandler(this.cbAvatarP2_TextChanged);
            // 
            // txtP2
            // 
            this.txtP2.Location = new System.Drawing.Point(112, 167);
            this.txtP2.Name = "txtP2";
            this.txtP2.Size = new System.Drawing.Size(100, 20);
            this.txtP2.TabIndex = 26;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(72, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Name";
            // 
            // lblAvatarP1
            // 
            this.lblAvatarP1.AutoSize = true;
            this.lblAvatarP1.Location = new System.Drawing.Point(43, 69);
            this.lblAvatarP1.Name = "lblAvatarP1";
            this.lblAvatarP1.Size = new System.Drawing.Size(64, 13);
            this.lblAvatarP1.TabIndex = 24;
            this.lblAvatarP1.Text = "Game piece";
            // 
            // cbAvatarP1
            // 
            this.cbAvatarP1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAvatarP1.FormattingEnabled = true;
            this.cbAvatarP1.Location = new System.Drawing.Point(113, 66);
            this.cbAvatarP1.Name = "cbAvatarP1";
            this.cbAvatarP1.Size = new System.Drawing.Size(99, 21);
            this.cbAvatarP1.TabIndex = 23;
            this.cbAvatarP1.TextChanged += new System.EventHandler(this.cbAvatarP1_TextChanged);
            // 
            // txtP1
            // 
            this.txtP1.Location = new System.Drawing.Point(112, 40);
            this.txtP1.Name = "txtP1";
            this.txtP1.Size = new System.Drawing.Size(100, 20);
            this.txtP1.TabIndex = 22;
            // 
            // panelTemplate
            // 
            this.panelTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelTemplate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTemplate.Controls.Add(this.rbSnL3);
            this.panelTemplate.Controls.Add(this.rbSnL2);
            this.panelTemplate.Controls.Add(this.rbSnL);
            this.panelTemplate.Controls.Add(this.labelTemplate);
            this.panelTemplate.Location = new System.Drawing.Point(22, 432);
            this.panelTemplate.Name = "panelTemplate";
            this.panelTemplate.Size = new System.Drawing.Size(273, 154);
            this.panelTemplate.TabIndex = 11;
            // 
            // rbSnL3
            // 
            this.rbSnL3.AutoSize = true;
            this.rbSnL3.Location = new System.Drawing.Point(28, 99);
            this.rbSnL3.Name = "rbSnL3";
            this.rbSnL3.Size = new System.Drawing.Size(221, 17);
            this.rbSnL3.TabIndex = 16;
            this.rbSnL3.TabStop = true;
            this.rbSnL3.Text = "Hippogriffs and Broomsticks (Harry Potter)\r\n";
            this.rbSnL3.UseVisualStyleBackColor = true;
            this.rbSnL3.CheckedChanged += new System.EventHandler(this.rbSnL3_CheckedChanged);
            // 
            // rbSnL2
            // 
            this.rbSnL2.AutoSize = true;
            this.rbSnL2.Location = new System.Drawing.Point(28, 76);
            this.rbSnL2.Name = "rbSnL2";
            this.rbSnL2.Size = new System.Drawing.Size(165, 17);
            this.rbSnL2.TabIndex = 15;
            this.rbSnL2.TabStop = true;
            this.rbSnL2.Text = "Snakes and Ladders (Deluxe)";
            this.rbSnL2.UseVisualStyleBackColor = true;
            this.rbSnL2.CheckedChanged += new System.EventHandler(this.rbSnL2_CheckedChanged);
            // 
            // rbSnL
            // 
            this.rbSnL.AutoSize = true;
            this.rbSnL.Location = new System.Drawing.Point(28, 53);
            this.rbSnL.Name = "rbSnL";
            this.rbSnL.Size = new System.Drawing.Size(123, 17);
            this.rbSnL.TabIndex = 1;
            this.rbSnL.TabStop = true;
            this.rbSnL.Text = "Snakes and Ladders";
            this.rbSnL.UseVisualStyleBackColor = true;
            this.rbSnL.CheckedChanged += new System.EventHandler(this.rbSnL_CheckedChanged);
            // 
            // labelTemplate
            // 
            this.labelTemplate.AutoSize = true;
            this.labelTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemplate.Location = new System.Drawing.Point(52, 15);
            this.labelTemplate.Name = "labelTemplate";
            this.labelTemplate.Size = new System.Drawing.Size(156, 24);
            this.labelTemplate.TabIndex = 0;
            this.labelTemplate.Text = "Chose a template";
            // 
            // llBegin
            // 
            this.llBegin.AutoSize = true;
            this.llBegin.DisabledLinkColor = System.Drawing.Color.White;
            this.llBegin.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llBegin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llBegin.LinkColor = System.Drawing.Color.Blue;
            this.llBegin.Location = new System.Drawing.Point(130, 597);
            this.llBegin.Name = "llBegin";
            this.llBegin.Size = new System.Drawing.Size(171, 40);
            this.llBegin.TabIndex = 12;
            this.llBegin.TabStop = true;
            this.llBegin.Text = "Start Game";
            this.llBegin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llBegin_LinkClicked);
            // 
            // llRestart
            // 
            this.llRestart.AutoSize = true;
            this.llRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llRestart.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llRestart.LinkColor = System.Drawing.Color.Black;
            this.llRestart.Location = new System.Drawing.Point(762, 641);
            this.llRestart.Name = "llRestart";
            this.llRestart.Size = new System.Drawing.Size(62, 20);
            this.llRestart.TabIndex = 100;
            this.llRestart.TabStop = true;
            this.llRestart.Text = "Restart";
            this.llRestart.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRestart_LinkClicked);
            // 
            // llQuit
            // 
            this.llQuit.AutoSize = true;
            this.llQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llQuit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llQuit.LinkColor = System.Drawing.Color.Black;
            this.llQuit.Location = new System.Drawing.Point(890, 641);
            this.llQuit.Name = "llQuit";
            this.llQuit.Size = new System.Drawing.Size(38, 20);
            this.llQuit.TabIndex = 100;
            this.llQuit.TabStop = true;
            this.llQuit.Text = "Quit";
            this.llQuit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llQuit_LinkClicked);
            // 
            // timerUpLadderDownSnake
            // 
            this.timerUpLadderDownSnake.Interval = 10;
            this.timerUpLadderDownSnake.Tick += new System.EventHandler(this.timerUpLadderDownSnake_Tick);
            // 
            // btnSpecial
            // 
            this.btnSpecial.Location = new System.Drawing.Point(180, 525);
            this.btnSpecial.Name = "btnSpecial";
            this.btnSpecial.Size = new System.Drawing.Size(109, 25);
            this.btnSpecial.TabIndex = 17;
            this.btnSpecial.Text = "Use Special Ability";
            this.btnSpecial.UseVisualStyleBackColor = true;
            this.btnSpecial.Click += new System.EventHandler(this.btnSpecial_Click);
            // 
            // FormSnakesAndLadders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(961, 668);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.llQuit);
            this.Controls.Add(this.llRestart);
            this.Controls.Add(this.llBegin);
            this.Controls.Add(this.llInstructions);
            this.Controls.Add(this.llStart);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.pbLogos);
            this.Controls.Add(this.pbDisplay);
            this.Controls.Add(this.panelAvatar);
            this.Controls.Add(this.rtbInstruct);
            this.Controls.Add(this.btnSpecial);
            this.Controls.Add(this.panelTemplate);
            this.Name = "FormSnakesAndLadders";
            this.Text = "Snakes and Ladders by Charles Qi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).EndInit();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogos)).EndInit();
            this.panelAvatar.ResumeLayout(false);
            this.panelAvatar.PerformLayout();
            this.panelTemplate.ResumeLayout(false);
            this.panelTemplate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDisplay;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pbLogos;
        private System.Windows.Forms.Timer timerWait;
        private System.Windows.Forms.Timer timerMoveCounter;
        private System.Windows.Forms.Timer timerRoll;
        private System.Windows.Forms.Timer timerComputer;
        private System.Windows.Forms.LinkLabel llStart;
        private System.Windows.Forms.LinkLabel llInstructions;
        private System.Windows.Forms.RichTextBox rtbInstruct;
        private System.Windows.Forms.Panel panelAvatar;
        private System.Windows.Forms.Panel panelTemplate;
        private System.Windows.Forms.RadioButton rbSnL;
        private System.Windows.Forms.Label labelTemplate;
        private System.Windows.Forms.LinkLabel llBegin;
        private System.Windows.Forms.PictureBox pbDice;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.RadioButton rbComputer;
        private System.Windows.Forms.RadioButton rbPlayer;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblAvatarP2;
        private System.Windows.Forms.ComboBox cbAvatarP2;
        private System.Windows.Forms.TextBox txtP2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAvatarP1;
        private System.Windows.Forms.ComboBox cbAvatarP1;
        private System.Windows.Forms.TextBox txtP1;
        private System.Windows.Forms.LinkLabel llRestart;
        private System.Windows.Forms.LinkLabel llQuit;
        private System.Windows.Forms.RadioButton rbSnL2;
        private System.Windows.Forms.Timer timerUpLadderDownSnake;
        private System.Windows.Forms.RadioButton rbSnL3;
        private System.Windows.Forms.Button btnSpecial;
    }
}

