using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Snakes_and_Ladders
{
    public partial class FormSnakesAndLadders : Form
    {
        //array to link square number to row+column
        int[,] mainArray = new int[10, 10];
        //array to where the snakes or ladders start
        int[] hotspotArray = new int[12];
        //array to where the snakes or ladders moves you
        int[] hotspotEndArray = new int[12];
        //image to hold the template
        Image myTemplate = null;

        //bitmap to draw the background image on the picturebox
        Bitmap mainBitmap;
        //bitmap to draw the counters on the picturebox
        Bitmap counterBitmap;
        //bitmap to draw the dice
        Bitmap diceBitmap;

        //graphics to draw to counterBitmap
        Graphics g;
        //graphics to draw to mainBitmap
        Graphics gBack;
        //graphics to draw to diceBitmap
        Graphics gDice;
        //images to store the player's avatar
        Image myAvatar;
        Image myAvatar2;
        //Pens and Brushes to draw the grid and numbers
        Pen myPen = new Pen(Color.Black, 1);
        Pen myBoldPen = new Pen(Color.Black, 8);
        Brush myBrush = new SolidBrush(Color.Black);
        Brush myBlueBrush = new SolidBrush(Color.LightBlue);
        Font drawFont = new Font("Arial", 10, FontStyle.Regular);

        //generate random number
        Random rnd = new Random();

        //counter variables to go throught array
        int i = 0, j = 0;

        //the width and height of bitmap
        int width, height;

        //increment to link row+column to pixel location
        int iIncrement;

        //integer to hold the random number
        int randNum;

        //coordinates to hold the position of the stationary avatar(the player that's not rolling the dice)
        int iBeforeXP1, iBeforeYP1;
        int iBeforeXP2, iBeforeYP2;

        //distance to draw smaller images
        int iDistance = 8;

        //distance value for dice
        int iDiceDistance = 8;

        //flag to differentiate between player 1 and player 2
        int mainFlag = 1;
        //flag to see if the computer is playing
        int iFlagCPU = 0;
        //flag to check for rollover when you don't roll exact 100
        int iFlagRollover = 0;
        //the position of the player on the grid
        int iSumP1, iSumP2;
        //the position of the player before rolling the dice
        int iOriginalSum;
        //the position of the player in a global variable
        int iGlobalSum;

        //various count variables
        int iCount = 0;
        int iCount2 = 0;
        int specialCount = 0;

        //integer that tells what template the player chose
        int iTemplate = 0;
        //integer to store rise,run,y2,y1,x2,x1
        int rise, run;
        int x1 = 0, x2 = 0, y1 = 0, y2 = 0;

        //the name of the player that's rolling
        String strP1, strP2;
        //name of avatar
        int avatarFlagP1, avatarFlagP2;
        //1-bird
        //2-walrus
        //3-ladybug
        //4-beaver

        public FormSnakesAndLadders()
        {
            InitializeComponent();
            //hide or show appropiate buttons, labels, radio button, panel, picturebox, ect
            lblInstruction.Hide();
            panelMain.Hide();
            btnRoll.Hide();
            rtbInstruct.Hide();
            panelAvatar.Hide();
            panelTemplate.Hide();
            btnSpecial.Hide();
            llBegin.Hide();
            rbPlayer.Checked = true;
            width = pbDisplay.Width;
            height = pbDisplay.Height;
            pbDice.Hide();
            llStart.Focus();
            //initialize mainBitmap/counterBitmap to the size of the pictureBox
            mainBitmap = new Bitmap(width, height);
            counterBitmap = new Bitmap(width, height);

            //initialize diceBitmap to the size of pbDice
            diceBitmap = new Bitmap(pbDice.Width, pbDice.Height);

            //set graphics to appropiate bitmap
            g = Graphics.FromImage(counterBitmap);
            gBack = Graphics.FromImage(mainBitmap);
            gDice = Graphics.FromImage(diceBitmap);

            //set the incrment to 1/10 the width length of picturebox
            iIncrement = width / 10;

            //call functions to draw the grid with numbers
            fillObjects();
            drawObjects();
            drawNumbers();

            //make the backgroundImage of pbDisplay to mainBitmap
            pbDisplay.BackgroundImage = mainBitmap;


        }
        void initialize()
        {
            //set all variables to default in the beginning
            timerRoll.Stop();
            timerMoveCounter.Stop();
            timerUpLadderDownSnake.Stop();
            btnRoll.Hide();
            iSumP1 = 0;
            iSumP2 = 0;
            iCount = 0;
            mainFlag = 1;
            iFlagCPU = 0;
            specialCount = 0;
            rbPlayer.Checked = true;
            btnRoll.Enabled = true;
            llRestart.Show();
            llQuit.Show();
            g.Clear(Color.Transparent);
            lblInstruction.Hide();
            panelMain.Hide();
            panelAvatar.Hide();
            panelTemplate.Hide();
            btnRoll.Hide();
            btnSpecial.Hide();
            llStart.Show();
            llInstructions.Show();
            txtP1.Clear();
            txtP2.Clear();
            cbAvatarP1.Items.Clear();
            cbAvatarP2.Items.Clear();
            rbSnL.Checked = false;
            rbSnL2.Checked = false;
            rbSnL3.Checked = false;
            pbDice.Hide();
            gBack.Clear(Color.Transparent);
            fillObjects();
            drawObjects();
            drawNumbers();
            pbDisplay.Invalidate();
            pbLogos.BackgroundImage = Image.FromFile("Snakes and Ladders Logo.JPG");


        }
        void setArray(int template)
        {
            //set locations of hotspot depending on the template
            if (template == 1)
            {
                hotspotArray[0] = 3;
                hotspotArray[1] = 20;
                hotspotArray[2] = 30;
                hotspotArray[3] = 70;
                hotspotArray[4] = 39;
                hotspotArray[5] = 52;
                hotspotArray[6] = 74;
                hotspotArray[7] = 82;
                hotspotArray[8] = 0;
                hotspotArray[9] = 0;
                hotspotArray[10] = 0;
                hotspotArray[11] = 0;
                hotspotEndArray[0] = 45;
                hotspotEndArray[1] = 41;
                hotspotEndArray[2] = 73;
                hotspotEndArray[3] = 91;
                hotspotEndArray[4] = 24;
                hotspotEndArray[5] = 34;
                hotspotEndArray[6] = 5;
                hotspotEndArray[7] = 65;
                hotspotEndArray[8] = 0;
                hotspotEndArray[9] = 0;
                hotspotEndArray[10] = 0;
                hotspotEndArray[11] = 0;
            }
            else if (template == 2)
            {
                hotspotArray[0] = 2;
                hotspotArray[1] = 9;
                hotspotArray[2] = 18;
                hotspotArray[3] = 49;
                hotspotArray[4] = 65;
                hotspotArray[5] = 67;
                hotspotArray[6] = 26;
                hotspotArray[7] = 45;
                hotspotArray[8] = 60;
                hotspotArray[9] = 68;
                hotspotArray[10] = 93;
                hotspotArray[11] = 98;
                hotspotEndArray[0] = 39;
                hotspotEndArray[1] = 32;
                hotspotEndArray[2] = 64;
                hotspotEndArray[3] = 54;
                hotspotEndArray[4] = 96;
                hotspotEndArray[5] = 86;
                hotspotEndArray[6] = 5;
                hotspotEndArray[7] = 34;
                hotspotEndArray[8] = 17;
                hotspotEndArray[9] = 13;
                hotspotEndArray[10] = 71;
                hotspotEndArray[11] = 80;
            }
            else if (template == 3)
            {
                hotspotArray[0] = 5;
                hotspotArray[1] = 9;
                hotspotArray[2] = 14;
                hotspotArray[3] = 17;
                hotspotArray[4] = 59;
                hotspotArray[5] = 68;
                hotspotArray[6] = 43;
                hotspotArray[7] = 50;
                hotspotArray[8] = 57;
                hotspotArray[9] = 76;
                hotspotArray[10] = 87;
                hotspotArray[11] = 99;
                hotspotEndArray[0] = 27;
                hotspotEndArray[1] = 31;
                hotspotEndArray[2] = 69;
                hotspotEndArray[3] = 58;
                hotspotEndArray[4] = 80;
                hotspotEndArray[5] = 93;
                hotspotEndArray[6] = 19;
                hotspotEndArray[7] = 34;
                hotspotEndArray[8] = 46;
                hotspotEndArray[9] = 62;
                hotspotEndArray[10] = 55;
                hotspotEndArray[11] = 84;
            }
        }
        private void llStart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //when you start game, show panelAvatar and panelTemplate
            llStart.Hide();
            llInstructions.Hide();
            rtbInstruct.Hide();
            panelAvatar.Show();
            panelTemplate.Show();
            txtP1.Focus();
            cbAvatarP1.Items.Add("Bird");
            cbAvatarP2.Items.Add("Bird");
            cbAvatarP1.Items.Add("Walrus");
            cbAvatarP2.Items.Add("Walrus");
            cbAvatarP1.Items.Add("Ladybug");
            cbAvatarP2.Items.Add("Ladybug");
            cbAvatarP1.Items.Add("Beaver");
            cbAvatarP2.Items.Add("Beaver");

        }
        //show the instructions on how to play game
        private void llInstructions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            rtbInstruct.Show();
        }
        //wherever you change the text in a textbox or combo box, check if the "begin button" will appear
        private void txtP1_TextChanged(object sender, EventArgs e)
        {
            checkAppear();
        }
        private void txtP2_TextChanged(object sender, EventArgs e)
        {
            checkAppear();
        }
        private void cbAvatarP1_TextChanged(object sender, EventArgs e)
        {
            checkAppear();
        }
        private void cbAvatarP2_TextChanged(object sender, EventArgs e)
        {
            checkAppear();
        }
        //set the flagComputer to true or false depending if the player wants to play another player or computer
        private void rbComputer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbComputer.Checked == true)
            {
                iFlagCPU = 1;
                txtP2.Text = "Computer";
                txtP2.Enabled = false;
                cbAvatarP2.Items.Clear();
                cbAvatarP2.Items.Add("Walrus");
                cbAvatarP2.Items.Add("Beaver");
            }
        }
        private void rbPlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPlayer.Checked == true)
            {
                iFlagCPU = 0;
                txtP2.Enabled = true;
                txtP2.Text = "";
                cbAvatarP2.Items.Clear();
                cbAvatarP2.Items.Add("Bird");
                cbAvatarP2.Items.Add("Walrus");
                cbAvatarP2.Items.Add("Ladybug");
                cbAvatarP2.Items.Add("Beaver");
                
            }
        }
        //depending on template, change the background image and values associated with the hotspotArrays
        //then check if the "begin button" will appear
        private void rbSnL_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSnL.Checked == true)
            {
                gBack.Clear(Color.Transparent);
                fillObjects();
                drawObjects();
                drawNumbers();
                iTemplate = 1;
                setArray(iTemplate);
                pbLogos.BackgroundImage = Image.FromFile("Snakes and Ladders Logo.JPG");
                myTemplate = Image.FromFile("Snakes Template.PNG");
                gBack.DrawImage(myTemplate, 0, 0, 620, 620);

            }
            pbDisplay.Invalidate();


            checkAppear();


        }
        private void rbSnL2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSnL2.Checked == true)
            {
                gBack.Clear(Color.Transparent);
                fillObjects();
                drawObjects();
                drawNumbers();
                iTemplate = 2;
                setArray(iTemplate);
                pbLogos.BackgroundImage = Image.FromFile("Snakes and Ladders Logo.JPG");
                myTemplate = Image.FromFile("Snakes Template 2.PNG");
                gBack.DrawImage(myTemplate, 0, 0, 620, 620);

            }
            pbDisplay.Invalidate();


            checkAppear();
        }
        private void rbSnL3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSnL3.Checked == true)
            {
                gBack.Clear(Color.Transparent);
                fillObjects();
                drawObjects();
                drawNumbers();
                iTemplate = 3;
                setArray(iTemplate);
                pbLogos.BackgroundImage = Image.FromFile("Hippogriff Title.JPG");
                myTemplate = Image.FromFile("Hippogriff Template.PNG");
                gBack.DrawImage(myTemplate, 0, 0, 620, 620);

            }
            pbDisplay.Invalidate();


            checkAppear();
        }
        void checkAppear()
        {
            //set the names of player 1 and two to user input
            strP1 = txtP1.Text;
            strP2 = txtP2.Text;
            //change the avatar that will appear on the board
            if (cbAvatarP1.Text == "Bird")
            {
                avatarFlagP1 = 1;
                myAvatar = Image.FromFile("bird.PNG");
            }
            else if (cbAvatarP1.Text == "Beaver")
            {
                avatarFlagP1 = 4;
                myAvatar = Image.FromFile("beaver.PNG");
            }
            else if (cbAvatarP1.Text == "Walrus")
            {
                avatarFlagP1 = 2;
                myAvatar = Image.FromFile("walrus.PNG");
            }
            else if (cbAvatarP1.Text == "Ladybug")
            {
                avatarFlagP2 = 3;
                myAvatar = Image.FromFile("ladybug.PNG");
            }
            if (cbAvatarP2.Text == "Bird")
            {
                avatarFlagP2 = 1;
                myAvatar2 = Image.FromFile("bird.PNG");

            }
            else if (cbAvatarP2.Text == "Beaver")
            {
                avatarFlagP2 = 4;
                myAvatar2 = Image.FromFile("beaver.PNG");
            }
            else if (cbAvatarP2.Text == "Walrus")
            {
                avatarFlagP2 = 2;
                myAvatar2 = Image.FromFile("walrus.PNG");
            }
            else if (cbAvatarP2.Text == "Ladybug")
            {
                avatarFlagP2 = 3;
                myAvatar2 = Image.FromFile("ladybug.PNG");
            }
            //if the user input avatars are the same, give message
            if (cbAvatarP1.Text == cbAvatarP2.Text && cbAvatarP1.Text != "")
            {
                MessageBox.Show("The game piece of 2 players cannot be the same");
                return;
            }

            //if everything is filled out, show the begin button
            if ((strP1 != "" && strP2 != "" && cbAvatarP1.Text != "" && cbAvatarP2.Text != "" && rbSnL.Checked == true)
                || (strP1 != "" && strP2 != "" && cbAvatarP1.Text != "" && cbAvatarP2.Text != "" && rbSnL2.Checked == true)
                || (strP1 != "" && strP2 != "" && cbAvatarP1.Text != "" && cbAvatarP2.Text != "" && rbSnL3.Checked == true))
            {
                llBegin.Show();
            }

        }
        private void llBegin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //show the controls for playing the game
            panelAvatar.Hide();
            panelTemplate.Hide();
            llBegin.Hide();
            panelMain.Show();
            lblInstruction.Show();
            btnRoll.Show();
            btnRoll.Focus();
            if (avatarFlagP1 == 1 || avatarFlagP1 == 3)
            {
                btnSpecial.Show();
            }

            lblInstruction.Text = strP1 + ": Roll the dice!";

        }
        //draw the gridline
        void drawObjects()
        {

            gBack.DrawRectangle(myBoldPen, 0, 0, width - 1, height - 1);


            for (i = 0; i < 10; i++)
            {
                gBack.DrawLine(myPen, 0, i * iIncrement, width, i * iIncrement);

            }
            for (i = 0; i < 10; i++)
            {
                gBack.DrawLine(myPen, i * iIncrement, 0, i * iIncrement, height);

            }

        }
        //fill the grid line to blue and white
        void fillObjects()
        {
            for (i = 0; i < 10; i += 2)
            {
                for (j = 1; j < 11; j += 2)
                {
                    gBack.FillRectangle(myBlueBrush, i * iIncrement, j * iIncrement, iIncrement, iIncrement);
                }
            }
            for (i = 1; i < 11; i += 2)
            {
                for (j = 0; j < 10; j += 2)
                {
                    gBack.FillRectangle(myBlueBrush, i * iIncrement, j * iIncrement, iIncrement, iIncrement);
                }
            }
        }
        //draw the numbers on the gridline
        void drawNumbers()
        {
            int iDisplayNumber = 100;
            int iDistance = 5;
            for (i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    for (j = 0; j < 10; j++)
                    {
                        gBack.DrawString(iDisplayNumber.ToString(), drawFont, myBrush, iDistance + j * iIncrement, iDistance + i * iIncrement);
                        mainArray[i, j] = iDisplayNumber;
                        iDisplayNumber--;
                    }
                }
                else
                {

                    for (j = 9; j >= 0; j--)
                    {
                        gBack.DrawString(iDisplayNumber.ToString(), drawFont, myBrush, iDistance + j * iIncrement, iDistance + i * iIncrement);
                        mainArray[i, j] = iDisplayNumber;
                        iDisplayNumber--;
                    }
                }

            }

        }
        void drawAvatar(int x1, int y1)
        {
            //clear the drawing surface
            g.Clear(Color.Transparent);

            //draw the game piece that's moving on the new position, draw the stationary game piece on the old position
            if (mainFlag == 1)
            {
                if (iCount > 1)
                {
                    g.DrawImage(myAvatar2, iBeforeXP2 * iIncrement + iDistance, iBeforeYP2 * iIncrement + iDistance, iIncrement - 2 * iDistance, iIncrement - 2 * iDistance);
                }
                g.DrawImage(myAvatar, x1 * iIncrement + iDistance, y1 * iIncrement + iDistance, iIncrement - 2 * iDistance, iIncrement - 2 * iDistance);
            }
            else if (mainFlag == 2)
            {
                if (iCount > 1)
                {
                    g.DrawImage(myAvatar, iBeforeXP1 * iIncrement + iDistance, iBeforeYP1 * iIncrement + iDistance, iIncrement - 2 * iDistance, iIncrement - 2 * iDistance);
                }

                g.DrawImage(myAvatar2, x1 * iIncrement + iDistance, y1 * iIncrement + iDistance, iIncrement - 2 * iDistance, iIncrement - 2 * iDistance);
            }
            //set the picture box to the bitmap
            pbDisplay.Image = counterBitmap;
            //set the previous position of this game piece
            if (mainFlag == 1)
            {
                iBeforeXP1 = x1;
                iBeforeYP1 = y1;
            }
            else if (mainFlag == 2)
            {
                iBeforeXP2 = x1;
                iBeforeYP2 = y1;
            }

        }
        void drawDice(int randNum)
        {
            //draw the dice depending on the randon number rolled
            gDice.Clear(Color.White);
            gDice.DrawRectangle(myPen, 0, 0, pbDice.Width - 1, pbDice.Height - 1);

            if (randNum == 1 || randNum == 3 || randNum == 5)
            {
                gDice.FillEllipse(myBrush, pbDice.Width / 2 - iDiceDistance, pbDice.Height / 2 - iDiceDistance, iDiceDistance * 2, iDiceDistance * 2);
                if (randNum == 3 || randNum == 5)
                {
                    gDice.FillEllipse(myBrush, iDiceDistance, pbDice.Height - 3 * iDiceDistance, iDiceDistance * 2, iDiceDistance * 2);
                    gDice.FillEllipse(myBrush, pbDice.Width - 3 * iDiceDistance, iDiceDistance, iDiceDistance * 2, iDiceDistance * 2);
                    if (randNum == 5)
                    {
                        gDice.FillEllipse(myBrush, iDiceDistance, iDiceDistance, iDiceDistance * 2, iDiceDistance * 2);
                        gDice.FillEllipse(myBrush, pbDice.Width - 3 * iDiceDistance, pbDice.Height - 3 * iDiceDistance, iDiceDistance * 2, iDiceDistance * 2);
                    }
                }

            }
            if (randNum == 2 || randNum == 4 || randNum == 6)
            {
                gDice.FillEllipse(myBrush, iDiceDistance, iDiceDistance, iDiceDistance * 2, iDiceDistance * 2);
                gDice.FillEllipse(myBrush, pbDice.Width - 3 * iDiceDistance, pbDice.Height - 3 * iDiceDistance, iDiceDistance * 2, iDiceDistance * 2);
                if (randNum == 4 || randNum == 6)
                {
                    gDice.FillEllipse(myBrush, iDiceDistance, pbDice.Height - 3 * iDiceDistance, iDiceDistance * 2, iDiceDistance * 2);
                    gDice.FillEllipse(myBrush, pbDice.Width - 3 * iDiceDistance, iDiceDistance, iDiceDistance * 2, iDiceDistance * 2);
                    if (randNum == 6)
                    {
                        gDice.FillEllipse(myBrush, pbDice.Width / 2 - iDiceDistance, iDiceDistance, iDiceDistance * 2, iDiceDistance * 2);
                        gDice.FillEllipse(myBrush, pbDice.Width / 2 - iDiceDistance, pbDice.Height - 3 * iDiceDistance, iDiceDistance * 2, iDiceDistance * 2);
                    }
                }

            }



            pbDice.Image = diceBitmap;
        }
        //method to calculate the new position of the moving game counter
        void calculateMove(ref int iSum)
        {
            iOriginalSum = iSum + 1;
            iSum += randNum;



            iGlobalSum = iSum;
            iCount++;

            timerMoveCounter.Start();
        }
        void animateMove(ref int iOriginalSum, ref int iSum)
        {

            int iPrevSum;
            //loop to check if the game piece hits a snake or ladder
            for (i = 0; i < 12; i++)
            {
                if (hotspotArray[i] == iSum && iOriginalSum == iSum)
                {
                    iFlagRollover = 0;
                    iPrevSum = iSum;
                    iOriginalSum = hotspotEndArray[i];
                    iSum = hotspotEndArray[i];
                    if (mainFlag == 1)
                    {
                        iSumP1 = hotspotEndArray[i];
                    }
                    else
                    {
                        iSumP2 = hotspotEndArray[i];
                    }
                    timerMoveCounter.Stop();
                    SnakesandLaddersAnimation(iPrevSum, iSum);
                    return;
                }
            }
            //loop to draw the avatar based on the position the game piece is on
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    if (mainArray[i, j] == iOriginalSum)
                    {
                        drawAvatar(j, i);
                        goto here;
                    }


                }

            }
        here:
            //loop to stop drawing additional avatars and stop the timer
            if (iOriginalSum == iSum)
            {
                //to move the counter backwards if you don't roll exactly 100
                if (iFlagRollover == 1)
                {
                    iFlagRollover = 0;
                    if (mainFlag == 1)
                    {
                        iSumP1 = iSum;
                    }
                    else
                    {
                        iSumP2 = iSum;
                    }
                }
                timerMoveCounter.Stop();
                //if the player rolls exactly 100, go to win method
                if (iSum == 100)
                {
                    win();
                    return;
                }

                timerWait.Start();
                return;
            }
            //conditions to deal with rollover
            if (iFlagRollover == 0)
            {
                iOriginalSum++;
            }
            if (iFlagRollover == 1)
            {
                iOriginalSum--;
            }
            if (iOriginalSum > 100)
            {
                if (avatarFlagP1 == 4 && mainFlag == 1 || avatarFlagP2 == 4 && mainFlag == 2)
                {
                    timerMoveCounter.Stop();
                    timerComputer.Stop();
                    win();
                    return;
                }
                iFlagRollover = 1;
                iSum = 200 - iSum;
                iOriginalSum = 200 - iOriginalSum;
            }


        }
        void SnakesandLaddersAnimation(int iPrevSum, int iSum)
        {
            //to animate the counter up the snake or down the ladder, calculate: rise,run before calling the timer
            int iPositiveRiseFlag = 0;
            int iNegativeRunFlag = 0;
            int Gcf;
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    if (mainArray[i, j] == iPrevSum)
                    {
                        x1 = j * iIncrement;
                        y1 = i * iIncrement;
                    }
                    if (mainArray[i, j] == iSum)
                    {
                        x2 = j * iIncrement;
                        y2 = i * iIncrement;
                        if (mainFlag == 1)
                        {
                            iBeforeXP1 = j;
                            iBeforeYP1 = i;
                        }
                        else if (mainFlag == 2)
                        {
                            iBeforeXP2 = j;
                            iBeforeYP2 = i;
                        }
                    }
                }
            }
            rise = y2 - y1;
            run = x2 - x1;
            if (rise > 0)
            {
                iPositiveRiseFlag = 1;
            }
            if (run < 0)
            {
                iNegativeRunFlag = 1;
            }
            rise = Math.Abs(y2 - y1);
            run = Math.Abs(x2 - x1);
            Gcf = gcf(rise, run);
            //divide rise and run by GCF to reduce to lowest terms
            run /= Gcf;
            rise /= Gcf;
            //account for positive/negative rise/run since the gcf function only works for positive numbers
            if (iPositiveRiseFlag == 1)
            {
                rise = rise * -1;
            }
            if (iNegativeRunFlag == 1)
            {
                run = run * -1;
            }

            timerUpLadderDownSnake.Start();

        }
        int gcf(int rise, int run)
        {
            //copied from internet, algorithm to find the gcf of the rise and run
            while (rise != 0 && run != 0)
            {
                if (rise > run)
                    rise %= run;
                else
                    run %= rise;
            }

            if (rise == 0)
                return run;
            else
                return rise;
        }
        private void timerUpLadderDownSnake_Tick(object sender, EventArgs e)
        {
            //set various endpoints based on rise and run
            if (run == 0 && rise > 0)
            {
                rise = 5;
            }
            else if (run == 0 && rise < 0)
            {
                rise = -5;
            }
            if (rise > 0 && run >= 0)
            {
                if (x1 >= x2 && y1 < y2)
                {
                    timerUpLadderDownSnake.Stop();
                    timerWait.Start();
                }
            }
            else if (rise >= 0 && run < 0)
            {
                if (x1 <= x2 && y1 < y2)
                {
                    timerUpLadderDownSnake.Stop();
                    timerWait.Start();
                }
            }
            else if (rise < 0 && run < 0)
            {
                if (x1 <= x2 && y1 > y2)
                {
                    timerUpLadderDownSnake.Stop();
                    timerWait.Start();
                }
            }
            else if (rise < 0 && run >= 0)
            {
                if (x1 >= x2 && y1 > y2)
                {

                    timerUpLadderDownSnake.Stop();
                    timerWait.Start();
                }
            }
            //draw the avatar slowly from current coordinate to endpoint
            drawAnimatedAvatar(x1, y1);
            //add the rise/run to the coordinate         
            x1 += run;
            y1 -= rise;

        }
        void drawAnimatedAvatar(int x1, int y1)
        {
            //clear the previous graphics
            g.Clear(Color.Transparent);
            //draw the avatar but also draw the location of the non moving game piece
            if (mainFlag == 1)
            {
                if (iCount > 1)
                {
                    g.DrawImage(myAvatar2, iBeforeXP2 * iIncrement + iDistance, iBeforeYP2 * iIncrement + iDistance, iIncrement - 2 * iDistance, iIncrement - 2 * iDistance);
                }
                g.DrawImage(myAvatar, x1 + iDistance, y1 + iDistance, iIncrement - 2 * iDistance, iIncrement - 2 * iDistance);
            }
            else
            {

                if (iCount > 1)
                {
                    g.DrawImage(myAvatar, iBeforeXP1 * iIncrement + iDistance, iBeforeYP1 * iIncrement + iDistance, iIncrement - 2 * iDistance, iIncrement - 2 * iDistance);

                }
                g.DrawImage(myAvatar2, x1 + iDistance, y1 + iDistance, iIncrement - 2 * iDistance, iIncrement - 2 * iDistance);
            }
            pbDisplay.Image = counterBitmap;
        }
        void win()
        {
            //if someone wins, give message
            if (mainFlag == 1)
            {

                if (MessageBox.Show(strP1 + " wins! Play again?", "Victory!", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();
                }

            }
            else if (mainFlag == 2)
            {
                if (MessageBox.Show(strP2 + " wins! Play again?", "Victory!", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            //initialize everything back to previous settings
            initialize();
            return;

        }
        private void btnRoll_Click_1(object sender, EventArgs e)
        {
            //start the timer
            timerRoll.Start();
        }
        private void btnSpecial_Click(object sender, EventArgs e)
        {

            popUp popUp = new popUp();
            popUp.ShowDialog();
            randNum = Convert.ToInt32(popUp.lblAdvance.Text);
            lblInstruction.Text = "";
            pbDice.Show();
            btnRoll.Hide();
            pbLogos.Focus();
            drawDice(randNum);
            btnSpecial.Hide();
            specialCount++;
            if (mainFlag == 1)
            {
                calculateMove(ref iSumP1);
            }
            else if (mainFlag == 2)
            {

                calculateMove(ref iSumP2);
            }
            

        }
        private void timerRoll_Tick(object sender, EventArgs e)
        {
            //show and hide controls accordinly
            lblInstruction.Text = "";
            pbDice.Show();
            btnRoll.Hide();
            pbLogos.Focus();
            btnSpecial.Hide();
            //generate 10 random numbers before stopping
            if (iCount2 > 10)
            {
                //stop the timer
                timerRoll.Stop();
                //return the count to 0
                iCount2 = 0;
                //start the logic of moving the counter
                if (mainFlag == 1)
                {
                    calculateMove(ref iSumP1);
                }
                else if (mainFlag == 2)
                {

                    calculateMove(ref iSumP2);
                }
                return;
            }

            //generation random number from 1-6 and draw appropiate dice
            randNum = rnd.Next(6) + 1;
            drawDice(randNum);

            //increment the count
            iCount2++;
        }
        private void timerWait_Tick(object sender, EventArgs e)
        {
            btnRoll.Enabled = true;

            //if beaver and rolls a 1 or 6, roll again
            if (randNum == 6 && avatarFlagP1 == 2 || randNum == 1 && avatarFlagP1 == 2)
            {
                mainFlag = 2;
            }
            if (randNum == 6 && avatarFlagP2 == 2 || randNum == 1 && avatarFlagP2 == 2)
            {
                mainFlag = 1;
            }
            

            

            //show appropiate label for another roll
            if (mainFlag == 2)
            {
                mainFlag = 1;
            }
            else
            {
                mainFlag = 2;
            }
            if (mainFlag == 1)
            {
                if (specialCount == 0)
                {
                    if (avatarFlagP1 == 1 || avatarFlagP1 == 3)
                    {
                        btnSpecial.Show();
                    }
                }
                else
                {
                    btnSpecial.Hide();
                }
                lblInstruction.Text = strP1 + ": Roll the dice!";
                pbDice.Hide();
                btnRoll.Show();
                llQuit.Show();
                llRestart.Show();

            }
            else if (mainFlag == 2)
            {
                if (specialCount == 0)
                {
                    if (avatarFlagP2 == 1 || avatarFlagP2 == 3)
                    {
                        btnSpecial.Show();
                    }
                    else
                    {
                        btnSpecial.Hide();
                    }
                }
                lblInstruction.Text = strP2 + ": Roll the dice!";
                pbDice.Hide();
                btnRoll.Show();
                llQuit.Show();
                llRestart.Show();

            }

            btnRoll.Focus();
            timerWait.Stop();
            //if someone choses computer use timer to roll the dice
            if (mainFlag == 2 && iFlagCPU == 1)
            {
                timerComputer.Start();
                pbLogos.Focus();
                btnRoll.Enabled = false;
            }
            return;
        }
        private void timerMoveCounter_Tick(object sender, EventArgs e)
        {
            //start drawing to counter to new position
            animateMove(ref iOriginalSum, ref iGlobalSum);
        }
        private void pbDisplay_Paint(object sender, PaintEventArgs e)
        {
            //repaint the picturebox
            pbDisplay.BackgroundImage = mainBitmap;
        }

        private void timerComputer_Tick(object sender, EventArgs e)
        {
            //roll the dice automatically if its the computer's turn
            btnRoll_Click_1(sender, e);
            timerComputer.Stop();
        }
        //restart or quit the game if the user chooses to do so
        private void llRestart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            initialize();
        }
        private void llQuit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }








    }
}



