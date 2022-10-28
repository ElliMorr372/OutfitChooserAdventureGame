using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

//Elliana Morrison
//October 27thth, 2022
//Simple outfit chooser

namespace OutfitChooserAdventureGame
{
    public partial class Form1 : Form
    {
        int page = 1;
        public Form1()
        {
            InitializeComponent();
            storyOutputLabel.Text = "You are invited to your best friend's birthday party. What type of outfit do you want to wear?";
            option1Label.Text = "Casual";
            option2Label.Text = "Fancy";
            option3Button.Visible = false;
            option3Label.Visible = false;
            //option 1 images
            goldOption1Image.Visible = false;
            sneakersOption1Image.Visible = false;
            jeansOption1Image.Visible = false;
            teeOption1Image.Visible = false;
            dressOption1Image.Visible = false;
            patternedSkirtOption1Image.Visible = false;
            blouseOption1Image.Visible = false;
            nudeHeelsOption1Image.Visible = false;
            blackHeelsOption1Image.Visible = false;
            longDressOption1Image.Visible = false;
            casualOption1Image.Visible = true;
            //option 2 images
            skirtOption2Image.Visible = false;
            plainSkirtOption2Image.Visible = false;
            silverOption2Image.Visible = false;
            sweaterOption2Image.Visible = false;
            fancyBootsOption2Image.Visible = false;
            casualBootsOption2Image.Visible = false;
            kneeBootsOption2Image.Visible = false;
            flatsOption2Image.Visible = false;
            sweatpantsOption2Image.Visible = false;
            longSleeveOption2Image.Visible = false;
            shortDressOption2Image.Visible = false;
            shrugOption2Image.Visible = false;
            fancyOption2Image.Visible = true;
            //play opening sound
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1

            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 6;
            }
            else if (page == 4)
            {
                page = 8;
            }
            else if (page == 5)
            {
                page = 1;
            }
            else if (page == 6)
            {
                page = 10;
            }
            else if (page == 7)
            {
                page = 12;
            }
            else if (page == 8)
            {
                page = 30;
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 10)
            {
                page = 16;
            }
            else if (page == 11)
            {
                page = 18;
            }
            else if (page == 12)
            {
                page = 22;
            }
            else if (page == 13)
            {
                page = 22;
            }
            else if (page == 14)
            {
                page = 30;
            }
            else if (page == 15)
            {
                page = 21;
            }
            else if (page == 16)
            {
                page = 21;
            }
            else if (page == 17)
            {
                page = 21;
            }
            else if (page == 18)
            {
                page = 21;
            }
            else if (page == 19)
            {
                page = 21;
            }
            else if (page == 20)
            {
                page = 21;
            }
            else if (page == 21)
            {
                page = 1;
            }
            else if (page == 22)
            {
                page = 24;
            }
            else if (page == 23)
            {
                page = 26;
            }
            else if (page == 24)
            {
                Random randGen = new Random();
                int chance = randGen.Next(1, 101);
                if (chance < 80)
                {
                    page = 29;
                }
                else
                {
                    page = 28;
                }
            }
            else if (page == 25)
            {
                page = 22;
            }
            else if (page == 26)
            {
                page = 21;
            }
            else if (page == 27)
            {
                page = 21;
            }
            else if (page == 28)
            {
                page = 1;
            }
            else if (page == 29)
            {
                page = 1;
            }
            else if (page == 30)
            {
                page = 21;
            }

            /// Display text and game options to screen based on the 
            /// current page

            switch (page)
            {
                case 1:
                    storyOutputLabel.Text = "You are invited to your best friend's birthday party. What type of outfit do you want to wear?";
                    option1Label.Text = "Casual";
                    option2Label.Text = "Fancy";
                    //option 1 images
                    goldOption1Image.Visible = false;
                    sneakersOption1Image.Visible = false;
                    jeansOption1Image.Visible = false;
                    teeOption1Image.Visible = false;
                    dressOption1Image.Visible = false;
                    patternedSkirtOption1Image.Visible = false;
                    blouseOption1Image.Visible = false;
                    nudeHeelsOption1Image.Visible = false;
                    blackHeelsOption1Image.Visible = false;
                    longDressOption1Image.Visible = false;
                    casualOption1Image.Visible = true;
                    //option 2 images
                    skirtOption2Image.Visible = false;
                    plainSkirtOption2Image.Visible = false;
                    silverOption2Image.Visible = false;
                    sweaterOption2Image.Visible = false;
                    fancyBootsOption2Image.Visible = false;
                    casualBootsOption2Image.Visible = false;
                    kneeBootsOption2Image.Visible = false;
                    flatsOption2Image.Visible = false;
                    sweatpantsOption2Image.Visible = false;
                    longSleeveOption2Image.Visible = false;
                    shortDressOption2Image.Visible = false;
                    shrugOption2Image.Visible = false;
                    fancyOption2Image.Visible = true;
                    //play opening sound
                    break;
                case 2:
                    storyOutputLabel.Text = "So, you are going casual, but how casual??";
                    option1Label.Text = "Jeans";
                    option2Label.Text = "Sweatpants";

                    casualOption1Image.Visible = false;
                    jeansOption1Image.Visible = true;

                    fancyOption2Image.Visible = false;
                    sweatpantsOption2Image.Visible = true;
                    SoundPlayer firstChoice = new SoundPlayer(Properties.Resources.firstChoice);
                    firstChoice.Play();
                    break;
                case 3:
                    storyOutputLabel.Text = "Ooh, you are going fancy! What makes you feel the fanciest?";
                    option1Label.Text = "Dress";
                    option2Label.Text = "Skirt";

                    fancyOption2Image.Visible = false;
                    dressOption1Image.Visible = true;

                    casualOption1Image.Visible = false;
                    skirtOption2Image.Visible = true;
                    break;
                case 4:
                    storyOutputLabel.Text = "Nice, jeans are a respectable choice. Now choose a top...";
                    option1Label.Text = "Graphic Tee";
                    option2Label.Text = "Plain long-sleeve";

                    jeansOption1Image.Visible = false;
                    teeOption1Image.Visible = true;

                    sweatpantsOption2Image.Visible = false;
                    longSleeveOption2Image.Visible = true;
                    break;
                case 5:
                    storyOutputLabel.Text = "Really? Sweatpants to your best friend's birthday party... Want to try again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    jeansOption1Image.Visible = false;
                    sweatpantsOption2Image.Visible = false;
                    break;
                case 6:
                    storyOutputLabel.Text = "What length of dress is the vibe?";
                    option1Label.Text = "Short";
                    option2Label.Text = "Long";

                    dressOption1Image.Visible = false;
                    longDressOption1Image.Visible = true;

                    skirtOption2Image.Visible = false;
                    shortDressOption2Image.Visible = true;
                    break;
                case 7:
                    storyOutputLabel.Text = "Okay, but how interesting do you want your skirt to be?";
                    option1Label.Text = "Patterned";
                    option2Label.Text = "Plain";

                    dressOption1Image.Visible = false;
                    patternedSkirtOption1Image.Visible = true;

                    skirtOption2Image.Visible = false;
                    plainSkirtOption2Image.Visible = true;
                    break;
                case 8:
                    storyOutputLabel.Text = "Cute! Now what type of jewelry would you like to wear?";
                    option1Label.Text = "Gold";
                    option2Label.Text = "Silver";

                    teeOption1Image.Visible = false;
                    goldOption1Image.Visible = true;

                    longSleeveOption2Image.Visible = false;
                    silverOption2Image.Visible = true;
                    break;
                case 9:
                    storyOutputLabel.Text = "That's a bit boring.. Want to try again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    teeOption1Image.Visible = false;

                    longSleeveOption2Image.Visible = false;
                    break;
                case 10:
                    storyOutputLabel.Text = "Nice bold choice. Now, what type of jewelry would you like to compliment your look?";
                    option1Label.Text = "Gold";
                    option2Label.Text = "Silver";

                    longDressOption1Image.Visible = false;
                    goldOption1Image.Visible = true;

                    shortDressOption2Image.Visible = false;
                    silverOption2Image.Visible = true;
                    break;
                case 11:
                    storyOutputLabel.Text = "Nice choice. Now what type of jewelry would you like?";
                    option1Label.Text = "Gold";
                    option2Label.Text = "Silver";
                    option3Label.Text = "None";

                    longDressOption1Image.Visible = false;
                    goldOption1Image.Visible = true;

                    shortDressOption2Image.Visible = false;
                    silverOption2Image.Visible = true;
                    break;
                case 12:
                    storyOutputLabel.Text = "Exciting, now what type of top do you want?";
                    option1Label.Text = "Blouse";
                    option2Label.Text = "Sweater";

                    goldOption1Image.Visible = false;
                    patternedSkirtOption1Image.Visible = false;
                    blouseOption1Image.Visible = true;

                    plainSkirtOption2Image.Visible = false;
                    silverOption2Image.Visible = false;
                    sweaterOption2Image.Visible = true;
                    break;
                case 13:
                    storyOutputLabel.Text = "Strong choice, now what type of top do you want?";
                    option1Label.Text = "Blouse";
                    option2Label.Text = "Sweater";

                    goldOption1Image.Visible = false;
                    patternedSkirtOption1Image.Visible = false;
                    blouseOption1Image.Visible = true;

                    plainSkirtOption2Image.Visible = false;
                    silverOption2Image.Visible = false;
                    sweaterOption2Image.Visible = true;
                    break;
                case 14:
                    storyOutputLabel.Text = "Alright, now just one final choice. What type of shoes to complete the look?";
                    option1Label.Text = "Sneakers";
                    option2Label.Text = "Ankle Boots";

                    goldOption1Image.Visible = false;
                    teeOption1Image.Visible = false;
                    sneakersOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    longSleeveOption2Image.Visible = false;
                    casualBootsOption2Image.Visible = true;
                    break;
                case 15:
                    storyOutputLabel.Text = "Nice, now just one final choice. What type of shoes to complete the look?";
                    option1Label.Text = "Sneakers";
                    option2Label.Text = "Ankle Boots";

                    goldOption1Image.Visible = false;
                    sneakersOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    casualBootsOption2Image.Visible = true;
                    break;
                case 16:
                    storyOutputLabel.Text = "Good bold choice. Now what type of shoes would you like?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Knee-high Boots";

                    goldOption1Image.Visible = false;
                    blackHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    kneeBootsOption2Image.Visible = true;
                    break;
                case 17:
                    storyOutputLabel.Text = "Good choice. Now what type of footwear would you like?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Knee-high Boots";

                    goldOption1Image.Visible = false;
                    blackHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    kneeBootsOption2Image.Visible = true;
                    break;
                case 18:
                    storyOutputLabel.Text = "Nice bold choice. Now what type of shoes would you like?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Knee-high Boots";

                    goldOption1Image.Visible = false;
                    blackHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    kneeBootsOption2Image.Visible = true;
                    break;
                case 19:
                    storyOutputLabel.Text = "Nice choice. Now what type of shoes would you like?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Knee-high Boots";

                    goldOption1Image.Visible = false;
                    blackHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    kneeBootsOption2Image.Visible = true;
                    break;
                case 20:
                    storyOutputLabel.Text = "Respectable choice. Now final step, what footwear would you like to wear?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Knee-high Boots";

                    goldOption1Image.Visible = false;
                    blackHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    kneeBootsOption2Image.Visible = true;
                    break;
                case 21:
                    storyOutputLabel.Text = "Good choice, quite fashionable! Want to try again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    sneakersOption1Image.Visible = false;
                    nudeHeelsOption1Image.Visible = false;
                    blackHeelsOption1Image.Visible = false;

                    fancyBootsOption2Image.Visible = false;
                    kneeBootsOption2Image.Visible = false;
                    casualBootsOption2Image.Visible = false;
                    flatsOption2Image.Visible = false;
                    shrugOption2Image.Visible = true;
                    break;
                case 22:
                    storyOutputLabel.Text = "Fancy! Now what type of jewelry would you like to wear?";
                    option1Label.Text = "Gold";
                    option2Label.Text = "Silver";

                    blouseOption1Image.Visible = false;
                    goldOption1Image.Visible = true;

                    sweaterOption2Image.Visible = false;
                    silverOption2Image.Visible = true;
                    break;
                case 23:
                    storyOutputLabel.Text = "Cute! Now what type of jewelry would you like to wear?";
                    option1Label.Text = "Gold";
                    option2Label.Text = "Silver";

                    blouseOption1Image.Visible = false;
                    goldOption1Image.Visible = true;

                    sweaterOption2Image.Visible = false;
                    silverOption2Image.Visible = true;
                    break;
                case 24:
                    storyOutputLabel.Text = "Good choice, now final decision...What type of footwear?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Heeled boots";

                    goldOption1Image.Visible = false;
                    nudeHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    fancyBootsOption2Image.Visible = true;
                    break;
                case 25:
                    storyOutputLabel.Text = "Nice choice, now finally... decision...What type of shoes?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Heeled boots";

                    goldOption1Image.Visible = false;
                    nudeHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    fancyBootsOption2Image.Visible = true;
                    break;
                case 26:
                    storyOutputLabel.Text = "Good choice, now finally...What type of footwear?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Flats";

                    goldOption1Image.Visible = false;
                    nudeHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    flatsOption2Image.Visible = true;
                    break;
                case 27:
                    storyOutputLabel.Text = "Good choice, now finally...What type of shoes?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Flats";

                    goldOption1Image.Visible = false;
                    nudeHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    flatsOption2Image.Visible = true;
                    break;
                case 28:
                    storyOutputLabel.Text = "Perfect choice, you have great style! Want to try again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    nudeHeelsOption1Image.Visible = false;
                    fancyBootsOption2Image.Visible = false;
                    shrugOption2Image.Visible = true;
                    break;
                case 29:
                    storyOutputLabel.Text = "Perfect choice, you have such great style that your best friend rents a limo for you to arrive in! Want to try again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    nudeHeelsOption1Image.Visible = false;
                    fancyBootsOption2Image.Visible = false;
                    shrugOption2Image.Visible = true;
                    SoundPlayer limoEnding = new SoundPlayer(Properties.Resources.limoEnding);
                    limoEnding.Play();
                    break;
                case 30:
                    storyOutputLabel.Text = "Alright, now just one final choice. What type of shoes to complete the look?";
                    option1Label.Text = "Sneakers";
                    option2Label.Text = "Ankle Boots";

                    goldOption1Image.Visible = false;
                    sneakersOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    casualBootsOption2Image.Visible = true;
                    break;
                case 31:
                    storyOutputLabel.Text = "Thanks for trying, best of luck with your friendship.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    shrugOption2Image.Visible = false;
                    Refresh();
                    SoundPlayer badFriendEnding = new SoundPlayer(Properties.Resources.badFriendEnding);
                    badFriendEnding.Play();
                    Thread.Sleep(3000);
                    Application.Exit();
                    break;
                case 32:
                    storyOutputLabel.Text = "Good job. You are a good friend, enjoy the party!!";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    shrugOption2Image.Visible = false;
                    Refresh();
                    SoundPlayer goodFriendEnding = new SoundPlayer(Properties.Resources.goodFriendEnding);
                    goodFriendEnding.Play();
                    Thread.Sleep(3000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
        private void option2Button_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 2

            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 7;
            }
            else if (page == 4)
            {
                Random randGen = new Random();
                int chance = randGen.Next(1, 101);
                if (chance < 50)
                {
                    page = 9;
                }
                else
                {
                    page = 14;
                }
            }
            else if (page == 5)
            {
                page = 31;
            }
            else if (page == 6)
            {
                page = 11;
            }
            else if (page == 7)
            {
                page = 13;
            }
            else if (page == 8)
            {
                page = 15;
            }
            else if (page == 9)
            {
                page = 31;
            }
            else if (page == 10)
            {
                page = 17;
            }
            else if (page == 11)
            {
                page = 19;
            }
            else if (page == 12)
            {
                page = 23;
            }
            else if (page == 13)
            {
                page = 23;
            }
            else if (page == 14)
            {
                page = 15;
            }
            else if (page == 15)
            {
                page = 21;
            }
            else if (page == 16)
            {
                page = 21;
            }
            else if (page == 17)
            {
                page = 21;
            }
            else if (page == 18)
            {
                page = 21;
            }
            else if (page == 19)
            {
                page = 21;
            }
            else if (page == 20)
            {
                page = 21;
            }
            else if (page == 21)
            {
                page = 32;
            }
            else if (page == 22)
            {
                page = 25;
            }
            else if (page == 23)
            {
                page = 27;
            }
            else if (page == 24)
            {
                page = 21;
            }
            else if (page == 25)
            {
                page = 21;
            }
            else if (page == 26)
            {
                page = 21;
            }
            else if (page == 27)
            {
                page = 21;
            }
            else if (page == 28)
            {
                page = 32;
            }
            else if (page == 29)
            {
                page = 32;
            }
            else if (page == 30)
            {
                page = 21;
            }

            /// Display text and game options to screen based on the 
            /// current page

            switch (page)
            {
                case 1:
                    storyOutputLabel.Text = "You are invited to your best friend's birthday party. What type of outfit do you want to wear?";
                    option1Label.Text = "Casual";
                    option2Label.Text = "Fancy";
                    //option 1 images
                    goldOption1Image.Visible = false;
                    sneakersOption1Image.Visible = false;
                    jeansOption1Image.Visible = false;
                    teeOption1Image.Visible = false;
                    dressOption1Image.Visible = false;
                    patternedSkirtOption1Image.Visible = false;
                    blouseOption1Image.Visible = false;
                    nudeHeelsOption1Image.Visible = false;
                    blackHeelsOption1Image.Visible = false;
                    longDressOption1Image.Visible = false;
                    casualOption1Image.Visible = true;
                    //option 2 images
                    skirtOption2Image.Visible = false;
                    plainSkirtOption2Image.Visible = false;
                    silverOption2Image.Visible = false;
                    sweaterOption2Image.Visible = false;
                    fancyBootsOption2Image.Visible = false;
                    casualBootsOption2Image.Visible = false;
                    kneeBootsOption2Image.Visible = false;
                    flatsOption2Image.Visible = false;
                    sweatpantsOption2Image.Visible = false;
                    longSleeveOption2Image.Visible = false;
                    shortDressOption2Image.Visible = false;
                    shrugOption2Image.Visible = false;
                    fancyOption2Image.Visible = true;
                    //play opening sound
                    break;
                case 2:
                    storyOutputLabel.Text = "So, you are going casual, but how casual??";
                    option1Label.Text = "Jeans";
                    option2Label.Text = "Sweatpants";

                    casualOption1Image.Visible = false;
                    jeansOption1Image.Visible = true;

                    fancyOption2Image.Visible = false;
                    sweatpantsOption2Image.Visible = true;
                    SoundPlayer firstChoice = new SoundPlayer(Properties.Resources.firstChoice);
                    firstChoice.Play();
                    break;
                case 3:
                    storyOutputLabel.Text = "Ooh, you are going fancy! What makes you feel the fanciest?";
                    option1Label.Text = "Dress";
                    option2Label.Text = "Skirt";

                    fancyOption2Image.Visible = false;
                    dressOption1Image.Visible = true;

                    casualOption1Image.Visible = false;
                    skirtOption2Image.Visible = true;
                    break;
                case 4:
                    storyOutputLabel.Text = "Nice, jeans are a respectable choice. Now choose a top...";
                    option1Label.Text = "Graphic Tee";
                    option2Label.Text = "Plain long-sleeve";

                    jeansOption1Image.Visible = false;
                    teeOption1Image.Visible = true;

                    sweatpantsOption2Image.Visible = false;
                    longSleeveOption2Image.Visible = true;
                    break;
                case 5:
                    storyOutputLabel.Text = "Really? Sweatpants to your best friend's birthday party... Want to try again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    jeansOption1Image.Visible = false;
                    sweatpantsOption2Image.Visible = false;
                    break;
                case 6:
                    storyOutputLabel.Text = "What length of dress is the vibe?";
                    option1Label.Text = "Short";
                    option2Label.Text = "Long";

                    dressOption1Image.Visible = false;
                    longDressOption1Image.Visible = true;

                    skirtOption2Image.Visible = false;
                    shortDressOption2Image.Visible = true;
                    break;
                case 7:
                    storyOutputLabel.Text = "Okay, but how interesting do you want your skirt to be?";
                    option1Label.Text = "Patterned";
                    option2Label.Text = "Plain";

                    dressOption1Image.Visible = false;
                    patternedSkirtOption1Image.Visible = true;

                    skirtOption2Image.Visible = false;
                    plainSkirtOption2Image.Visible = true;
                    break;
                case 8:
                    storyOutputLabel.Text = "Cute! Now what type of jewelry would you like to wear?";
                    option1Label.Text = "Gold";
                    option2Label.Text = "Silver";

                    teeOption1Image.Visible = false;
                    goldOption1Image.Visible = true;

                    longSleeveOption2Image.Visible = false;
                    silverOption2Image.Visible = true;
                    break;
                case 9:
                    storyOutputLabel.Text = "That's a bit boring.. Want to try again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    teeOption1Image.Visible = false;

                    longSleeveOption2Image.Visible = false;
                    break;
                case 10:
                    storyOutputLabel.Text = "Nice bold choice. Now, what type of jewelry would you like to compliment your look?";
                    option1Label.Text = "Gold";
                    option2Label.Text = "Silver";

                    longDressOption1Image.Visible = false;
                    goldOption1Image.Visible = true;

                    shortDressOption2Image.Visible = false;
                    silverOption2Image.Visible = true;
                    break;
                case 11:
                    storyOutputLabel.Text = "Nice choice. Now what type of jewelry would you like?";
                    option1Label.Text = "Gold";
                    option2Label.Text = "Silver";
                    option3Label.Text = "None";

                    longDressOption1Image.Visible = false;
                    goldOption1Image.Visible = true;

                    shortDressOption2Image.Visible = false;
                    silverOption2Image.Visible = true;
                    break;
                case 12:
                    storyOutputLabel.Text = "Exciting, now what type of top do you want?";
                    option1Label.Text = "Blouse";
                    option2Label.Text = "Sweater";

                    goldOption1Image.Visible = false;
                    patternedSkirtOption1Image.Visible = false;
                    blouseOption1Image.Visible = true;

                    plainSkirtOption2Image.Visible = false;
                    silverOption2Image.Visible = false;
                    sweaterOption2Image.Visible = true;
                    break;
                case 13:
                    storyOutputLabel.Text = "Strong choice, now what type of top do you want?";
                    option1Label.Text = "Blouse";
                    option2Label.Text = "Sweater";

                    goldOption1Image.Visible = false;
                    patternedSkirtOption1Image.Visible = false;
                    blouseOption1Image.Visible = true;

                    plainSkirtOption2Image.Visible = false;
                    silverOption2Image.Visible = false;
                    sweaterOption2Image.Visible = true;
                    break;
                case 14:
                    storyOutputLabel.Text = "Alright, now just one final choice. What type of shoes to complete the look?";
                    option1Label.Text = "Sneakers";
                    option2Label.Text = "Ankle Boots";

                    goldOption1Image.Visible = false;
                    teeOption1Image.Visible = false;
                    sneakersOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    longSleeveOption2Image.Visible = false;
                    casualBootsOption2Image.Visible = true;
                    break;
                case 15:
                    storyOutputLabel.Text = "Nice, now just one final choice. What type of shoes to complete the look?";
                    option1Label.Text = "Sneakers";
                    option2Label.Text = "Ankle Boots";

                    goldOption1Image.Visible = false;
                    sneakersOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    casualBootsOption2Image.Visible = true;
                    break;
                case 16:
                    storyOutputLabel.Text = "Good bold choice. Now what type of shoes would you like?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Knee-high Boots";

                    goldOption1Image.Visible = false;
                    blackHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    kneeBootsOption2Image.Visible = true;
                    break;
                case 17:
                    storyOutputLabel.Text = "Good choice. Now what type of footwear would you like?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Knee-high Boots";

                    goldOption1Image.Visible = false;
                    blackHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    kneeBootsOption2Image.Visible = true;
                    break;
                case 18:
                    storyOutputLabel.Text = "Nice bold choice. Now what type of shoes would you like?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Knee-high Boots";

                    goldOption1Image.Visible = false;
                    blackHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    kneeBootsOption2Image.Visible = true;
                    break;
                case 19:
                    storyOutputLabel.Text = "Nice choice. Now what type of shoes would you like?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Knee-high Boots";

                    goldOption1Image.Visible = false;
                    blackHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    kneeBootsOption2Image.Visible = true;
                    break;
                case 20:
                    storyOutputLabel.Text = "Respectable choice. Now final step, what footwear would you like to wear?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Knee-high Boots";

                    goldOption1Image.Visible = false;
                    blackHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    kneeBootsOption2Image.Visible = true;
                    break;
                case 21:
                    storyOutputLabel.Text = "Good choice, quite fashionable! Want to try again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    sneakersOption1Image.Visible = false;
                    nudeHeelsOption1Image.Visible = false;
                    blackHeelsOption1Image.Visible = false;

                    fancyBootsOption2Image.Visible = false;
                    kneeBootsOption2Image.Visible = false;
                    casualBootsOption2Image.Visible = false;
                    flatsOption2Image.Visible = false;
                    shrugOption2Image.Visible = true;
                    break;
                case 22:
                    storyOutputLabel.Text = "Fancy! Now what type of jewelry would you like to wear?";
                    option1Label.Text = "Gold";
                    option2Label.Text = "Silver";

                    blouseOption1Image.Visible = false;
                    goldOption1Image.Visible = true;

                    sweaterOption2Image.Visible = false;
                    silverOption2Image.Visible = true;
                    break;
                case 23:
                    storyOutputLabel.Text = "Cute! Now what type of jewelry would you like to wear?";
                    option1Label.Text = "Gold";
                    option2Label.Text = "Silver";

                    blouseOption1Image.Visible = false;
                    goldOption1Image.Visible = true;

                    sweaterOption2Image.Visible = false;
                    silverOption2Image.Visible = true;
                    break;
                case 24:
                    storyOutputLabel.Text = "Good choice, now final decision...What type of footwear?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Heeled boots";

                    goldOption1Image.Visible = false;
                    nudeHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    fancyBootsOption2Image.Visible = true;
                    break;
                case 25:
                    storyOutputLabel.Text = "Nice choice, now finally... decision...What type of shoes?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Heeled boots";

                    goldOption1Image.Visible = false;
                    nudeHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    fancyBootsOption2Image.Visible = true;
                    break;
                case 26:
                    storyOutputLabel.Text = "Good choice, now finally...What type of footwear?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Flats";

                    goldOption1Image.Visible = false;
                    nudeHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    flatsOption2Image.Visible = true;
                    break;
                case 27:
                    storyOutputLabel.Text = "Good choice, now finally...What type of shoes?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Flats";

                    goldOption1Image.Visible = false;
                    nudeHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    flatsOption2Image.Visible = true;
                    break;
                case 28:
                    storyOutputLabel.Text = "Perfect choice, you have great style! Want to try again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    nudeHeelsOption1Image.Visible = false;
                    fancyBootsOption2Image.Visible = false;
                    shrugOption2Image.Visible = true;
                    break;
                case 29:
                    storyOutputLabel.Text = "Perfect choice, you have such great style that your best friend rents a limo for you to arrive in! Want to try again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    nudeHeelsOption1Image.Visible = false;
                    fancyBootsOption2Image.Visible = false;
                    shrugOption2Image.Visible = true;
                    SoundPlayer limoEnding = new SoundPlayer(Properties.Resources.limoEnding);
                    limoEnding.Play();
                    break;
                case 30:
                    storyOutputLabel.Text = "Alright, now just one final choice. What type of shoes to complete the look?";
                    option1Label.Text = "Sneakers";
                    option2Label.Text = "Ankle Boots";

                    goldOption1Image.Visible = false;
                    sneakersOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    casualBootsOption2Image.Visible = true;
                    break;
                case 31:
                    storyOutputLabel.Text = "Thanks for trying, best of luck with your friendship.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    shrugOption2Image.Visible = false;
                    Refresh();
                    SoundPlayer badFriendEnding = new SoundPlayer(Properties.Resources.badFriendEnding);
                    badFriendEnding.Play();
                    Thread.Sleep(3000);
                    Application.Exit();
                    break;
                case 32:
                    storyOutputLabel.Text = "Good job. You are a good friend, enjoy the party!!";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    shrugOption2Image.Visible = false;
                    Refresh();
                    SoundPlayer goodFriendEnding = new SoundPlayer(Properties.Resources.goodFriendEnding);
                    goodFriendEnding.Play();
                    Thread.Sleep(3000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 3

            if (page == 11)
            {
                page = 20;
            }

            switch (page)
            {
                case 1:
                    storyOutputLabel.Text = "You are invited to your best friend's birthday party. What type of outfit do you want to wear?";
                    option1Label.Text = "Casual";
                    option2Label.Text = "Fancy";
                    //option 1 images
                    goldOption1Image.Visible = false;
                    sneakersOption1Image.Visible = false;
                    jeansOption1Image.Visible = false;
                    teeOption1Image.Visible = false;
                    dressOption1Image.Visible = false;
                    patternedSkirtOption1Image.Visible = false;
                    blouseOption1Image.Visible = false;
                    nudeHeelsOption1Image.Visible = false;
                    blackHeelsOption1Image.Visible = false;
                    longDressOption1Image.Visible = false;
                    casualOption1Image.Visible = true;
                    //option 2 images
                    skirtOption2Image.Visible = false;
                    plainSkirtOption2Image.Visible = false;
                    silverOption2Image.Visible = false;
                    sweaterOption2Image.Visible = false;
                    fancyBootsOption2Image.Visible = false;
                    casualBootsOption2Image.Visible = false;
                    kneeBootsOption2Image.Visible = false;
                    flatsOption2Image.Visible = false;
                    sweatpantsOption2Image.Visible = false;
                    longSleeveOption2Image.Visible = false;
                    shortDressOption2Image.Visible = false;
                    shrugOption2Image.Visible = false;
                    fancyOption2Image.Visible = true;
                    //play opening sound
                    break;
                case 2:
                    storyOutputLabel.Text = "So, you are going casual, but how casual??";
                    option1Label.Text = "Jeans";
                    option2Label.Text = "Sweatpants";

                    casualOption1Image.Visible = false;
                    jeansOption1Image.Visible = true;

                    fancyOption2Image.Visible = false;
                    sweatpantsOption2Image.Visible = true;
                    SoundPlayer firstChoice = new SoundPlayer(Properties.Resources.firstChoice);
                    firstChoice.Play();
                    break;
                case 3:
                    storyOutputLabel.Text = "Ooh, you are going fancy! What makes you feel the fanciest?";
                    option1Label.Text = "Dress";
                    option2Label.Text = "Skirt";

                    fancyOption2Image.Visible = false;
                    dressOption1Image.Visible = true;

                    casualOption1Image.Visible = false;
                    skirtOption2Image.Visible = true;
                    break;
                case 4:
                    storyOutputLabel.Text = "Nice, jeans are a respectable choice. Now choose a top...";
                    option1Label.Text = "Graphic Tee";
                    option2Label.Text = "Plain long-sleeve";

                    jeansOption1Image.Visible = false;
                    teeOption1Image.Visible = true;

                    sweatpantsOption2Image.Visible = false;
                    longSleeveOption2Image.Visible = true;
                    break;
                case 5:
                    storyOutputLabel.Text = "Really? Sweatpants to your best friend's birthday party... Want to try again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    jeansOption1Image.Visible = false;
                    sweatpantsOption2Image.Visible = false;
                    break;
                case 6:
                    storyOutputLabel.Text = "What length of dress is the vibe?";
                    option1Label.Text = "Short";
                    option2Label.Text = "Long";

                    dressOption1Image.Visible = false;
                    longDressOption1Image.Visible = true;

                    skirtOption2Image.Visible = false;
                    shortDressOption2Image.Visible = true;
                    break;
                case 7:
                    storyOutputLabel.Text = "Okay, but how interesting do you want your skirt to be?";
                    option1Label.Text = "Patterned";
                    option2Label.Text = "Plain";

                    dressOption1Image.Visible = false;
                    patternedSkirtOption1Image.Visible = true;

                    skirtOption2Image.Visible = false;
                    plainSkirtOption2Image.Visible = true;
                    break;
                case 8:
                    storyOutputLabel.Text = "Cute! Now what type of jewelry would you like to wear?";
                    option1Label.Text = "Gold";
                    option2Label.Text = "Silver";

                    teeOption1Image.Visible = false;
                    goldOption1Image.Visible = true;

                    longSleeveOption2Image.Visible = false;
                    silverOption2Image.Visible = true;
                    break;
                case 9:
                    storyOutputLabel.Text = "That's a bit boring.. Want to try again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    teeOption1Image.Visible = false;

                    longSleeveOption2Image.Visible = false;
                    break;
                case 10:
                    storyOutputLabel.Text = "Nice bold choice. Now, what type of jewelry would you like to compliment your look?";
                    option1Label.Text = "Gold";
                    option2Label.Text = "Silver";

                    longDressOption1Image.Visible = false;
                    goldOption1Image.Visible = true;

                    shortDressOption2Image.Visible = false;
                    silverOption2Image.Visible = true;
                    break;
                case 11:
                    storyOutputLabel.Text = "Nice choice. Now what type of jewelry would you like?";
                    option1Label.Text = "Gold";
                    option2Label.Text = "Silver";
                    option3Label.Text = "None";

                    longDressOption1Image.Visible = false;
                    goldOption1Image.Visible = true;

                    shortDressOption2Image.Visible = false;
                    silverOption2Image.Visible = true;
                    break;
                case 12:
                    storyOutputLabel.Text = "Exciting, now what type of top do you want?";
                    option1Label.Text = "Blouse";
                    option2Label.Text = "Sweater";

                    goldOption1Image.Visible = false;
                    patternedSkirtOption1Image.Visible = false;
                    blouseOption1Image.Visible = true;

                    plainSkirtOption2Image.Visible = false;
                    silverOption2Image.Visible = false;
                    sweaterOption2Image.Visible = true;
                    break;
                case 13:
                    storyOutputLabel.Text = "Strong choice, now what type of top do you want?";
                    option1Label.Text = "Blouse";
                    option2Label.Text = "Sweater";

                    goldOption1Image.Visible = false;
                    patternedSkirtOption1Image.Visible = false;
                    blouseOption1Image.Visible = true;

                    plainSkirtOption2Image.Visible = false;
                    silverOption2Image.Visible = false;
                    sweaterOption2Image.Visible = true;
                    break;
                case 14:
                    storyOutputLabel.Text = "Alright, now just one final choice. What type of shoes to complete the look?";
                    option1Label.Text = "Sneakers";
                    option2Label.Text = "Ankle Boots";

                    goldOption1Image.Visible = false;
                    teeOption1Image.Visible = false;
                    sneakersOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    longSleeveOption2Image.Visible = false;
                    casualBootsOption2Image.Visible = true;
                    break;
                case 15:
                    storyOutputLabel.Text = "Nice, now just one final choice. What type of shoes to complete the look?";
                    option1Label.Text = "Sneakers";
                    option2Label.Text = "Ankle Boots";

                    goldOption1Image.Visible = false;
                    sneakersOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    casualBootsOption2Image.Visible = true;
                    break;
                case 16:
                    storyOutputLabel.Text = "Good bold choice. Now what type of shoes would you like?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Knee-high Boots";

                    goldOption1Image.Visible = false;
                    blackHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    kneeBootsOption2Image.Visible = true;
                    break;
                case 17:
                    storyOutputLabel.Text = "Good choice. Now what type of footwear would you like?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Knee-high Boots";

                    goldOption1Image.Visible = false;
                    blackHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    kneeBootsOption2Image.Visible = true;
                    break;
                case 18:
                    storyOutputLabel.Text = "Nice bold choice. Now what type of shoes would you like?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Knee-high Boots";

                    goldOption1Image.Visible = false;
                    blackHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    kneeBootsOption2Image.Visible = true;
                    break;
                case 19:
                    storyOutputLabel.Text = "Nice choice. Now what type of shoes would you like?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Knee-high Boots";

                    goldOption1Image.Visible = false;
                    blackHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    kneeBootsOption2Image.Visible = true;
                    break;
                case 20:
                    storyOutputLabel.Text = "Respectable choice. Now final step, what footwear would you like to wear?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Knee-high Boots";

                    goldOption1Image.Visible = false;
                    blackHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    kneeBootsOption2Image.Visible = true;
                    break;
                case 21:
                    storyOutputLabel.Text = "Good choice, quite fashionable! Want to try again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    sneakersOption1Image.Visible = false;
                    nudeHeelsOption1Image.Visible = false;
                    blackHeelsOption1Image.Visible = false;

                    fancyBootsOption2Image.Visible = false;
                    kneeBootsOption2Image.Visible = false;
                    casualBootsOption2Image.Visible = false;
                    flatsOption2Image.Visible = false;
                    shrugOption2Image.Visible = true;
                    break;
                case 22:
                    storyOutputLabel.Text = "Fancy! Now what type of jewelry would you like to wear?";
                    option1Label.Text = "Gold";
                    option2Label.Text = "Silver";

                    blouseOption1Image.Visible = false;
                    goldOption1Image.Visible = true;

                    sweaterOption2Image.Visible = false;
                    silverOption2Image.Visible = true;
                    break;
                case 23:
                    storyOutputLabel.Text = "Cute! Now what type of jewelry would you like to wear?";
                    option1Label.Text = "Gold";
                    option2Label.Text = "Silver";

                    blouseOption1Image.Visible = false;
                    goldOption1Image.Visible = true;

                    sweaterOption2Image.Visible = false;
                    silverOption2Image.Visible = true;
                    break;
                case 24:
                    storyOutputLabel.Text = "Good choice, now final decision...What type of footwear?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Heeled boots";

                    goldOption1Image.Visible = false;
                    nudeHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    fancyBootsOption2Image.Visible = true;
                    break;
                case 25:
                    storyOutputLabel.Text = "Nice choice, now finally... decision...What type of shoes?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Heeled boots";

                    goldOption1Image.Visible = false;
                    nudeHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    fancyBootsOption2Image.Visible = true;
                    break;
                case 26:
                    storyOutputLabel.Text = "Good choice, now finally...What type of footwear?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Flats";

                    goldOption1Image.Visible = false;
                    nudeHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    flatsOption2Image.Visible = true;
                    break;
                case 27:
                    storyOutputLabel.Text = "Good choice, now finally...What type of shoes?";
                    option1Label.Text = "Heels";
                    option2Label.Text = "Flats";

                    goldOption1Image.Visible = false;
                    nudeHeelsOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    flatsOption2Image.Visible = true;
                    break;
                case 28:
                    storyOutputLabel.Text = "Perfect choice, you have great style! Want to try again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    nudeHeelsOption1Image.Visible = false;
                    fancyBootsOption2Image.Visible = false;
                    shrugOption2Image.Visible = true;
                    break;
                case 29:
                    storyOutputLabel.Text = "Perfect choice, you have such great style that your best friend rents a limo for you to arrive in! Want to try again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    nudeHeelsOption1Image.Visible = false;
                    fancyBootsOption2Image.Visible = false;
                    shrugOption2Image.Visible = true;
                    SoundPlayer limoEnding = new SoundPlayer(Properties.Resources.limoEnding);
                    limoEnding.Play();
                    break;
                case 30:
                    storyOutputLabel.Text = "Alright, now just one final choice. What type of shoes to complete the look?";
                    option1Label.Text = "Sneakers";
                    option2Label.Text = "Ankle Boots";

                    goldOption1Image.Visible = false;
                    sneakersOption1Image.Visible = true;

                    silverOption2Image.Visible = false;
                    casualBootsOption2Image.Visible = true;
                    break;
                case 31:
                    storyOutputLabel.Text = "Thanks for trying, best of luck with your friendship.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    shrugOption2Image.Visible = false;
                    Refresh();
                    SoundPlayer badFriendEnding = new SoundPlayer(Properties.Resources.badFriendEnding);
                    badFriendEnding.Play();
                    Thread.Sleep(3000);
                    Application.Exit();
                    break;
                case 32:
                    storyOutputLabel.Text = "Good job. You are a good friend, enjoy the party!!";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    shrugOption2Image.Visible = false;
                    Refresh();
                    SoundPlayer goodFriendEnding = new SoundPlayer(Properties.Resources.goodFriendEnding);
                    goodFriendEnding.Play();
                    Thread.Sleep(3000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
    }
}
