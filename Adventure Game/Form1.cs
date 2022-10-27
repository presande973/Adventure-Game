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

namespace Adventure_Game
{
    public partial class Form1 : Form
    {
        int page = 1;
        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();
            outputLabel1.Text = "You wake up wondering were you are. With your vision still blurry you hear the sound of dripping water all around you. ";
            outputLabl2.Text = "You feel the need to feel around. Do you?";
            optionLabel1.Text = "Feel around";
            optionLabel2.Text = "Not right now";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void outputLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 16;
            }
            else if (page == 3)
            {
                page = 5;
            }
            else if (page == 4)
            {
                page = 16;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 16;
            }
            else if (page == 8)
            {
                page = 16;
            }
            else if (page == 9)
            {
                page = 16;
            }
            else if (page == 10)
            {
                page = 16;
            }
            else if (page == 11)
            {
                page = 13;
            }
            else if (page == 12)
            {
                page = 16;
            }
            else if (page == 13)
            {
                page = 14;
            }
            else if (page == 14)
            {
                page = 16;
            }
            else if (page == 15)
            {
                page = 16;
            }

            switch (page)
            {
                case 1:
                    outputLabel1.Text = "You wake up wondering were you are. With your vision still blurry you hear the sound of dripping water all around you.";
                    outputLabl2.Text = "You feel the need to feel around. Do you?";
                    optionLabel1.Text = "Feel around";
                    optionLabel2.Text = "Not right now";
                    break;
                case 2:
                    outputLabel1.Text = "As you feel around, the boards underneath you give out and you fall to your inky demise.";
                    outputLabl2.Text = "Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 3:
                    outputLabel1.Text = "You decide to not feel around you. Your vision begins to come back and you realize the water you heard dripping wasn't water at all, its INK dripping from every crack on the walls around you layering the floor in a thick layer of ink.";
                    outputLabl2.Text = "Do you try and stand?";
                    optionLabel1.Text = "Stand";
                    optionLabel2.Text = "Dont stand";
                    break;
                case 4:
                    outputLabel1.Text = "As you stand the boards underneath you give out and you fall to your inky demise.";
                    outputLabl2.Text = "Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 5:
                    outputLabel1.Text = "You decide not to stand and instead crawl through the ink towards a door that you see in the distance. Right before your about to reach the door an ink creature appears out of the ink behind you.";
                    outputLabl2.Text = "Do you run?";
                    optionLabel1.Text = "Run";
                    optionLabel1.Text = "Dont run";
                    break;
                case 6:
                    outputLabel1.Text = "You decide not to run and the creature reaches out and grabs your leg.";
                    outputLabl2.Text = "Do you kick at the creature?";
                    optionLabel1.Text = "Yes kick at the creature";
                    optionLabel2.Text = "Dont kick at the creature";
                    break;
                case 7:
                    outputLabel1.Text = "The creature pulls you into the depths of the ink.";
                    outputLabl2.Text = "PLay again?";
                    optionLabel1.Text = "Yes";
                    optionLabel1.Text = "No";
                    break;
                case 8:
                    outputLabel1.Text = "You reach the door just in time and slam it shut. You then feel someone or something starring at you. ";
                    outputLabl2.Text = "Do you turn around?";
                    optionLabel1.Text = "Turn around";
                    optionLabel2.Text = "Decide not to";
                    break;
                case 9:
                    outputLabel1.Text = "You turn around and  get an axe lodged into your forehead.";
                    outputLabl2.Text = "Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 10:
                    outputLabel1.Text = "After some time you get an axe lodged into the back of your head.";
                    outputLabl2.Text = "Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 11:
                    outputLabel1.Text = "You turn  around and manage to duck in time as an axe slices the air above your head. You see that there is an open door to your left and a hallway to your right.";
                    outputLabl2.Text = "What way do you go?";
                    optionLabel1.Text = "Open door";
                    optionLabel2.Text = "Hallway";
                    break;
                case 12:
                    outputLabel1.Text = "You turn and run to the open door. You realize that whoever swung the axe is not chasing you for some reason, You run through the doorway and as you do the door slams shut behind you. You try and go back through as you realize you are back at the beginning.";
                    outputLabl2.Text = "Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 13:
                    outputLabel1.Text = "You run down the hallway and make it to another door, you check to see that it is unlocked and lucky for you it is. You open the door and step outside to see your house just across the street. You walk to the crosswalk. ";
                    outputLabl2.Text = "Do you push the button and wait?";
                    optionLabel1.Text = "Push button";
                    optionLabel2.Text = "Decide to J walk";
                    break;
                case 14:
                    outputLabel1.Text = "You decide to J walk and make it home without a scratch. ";
                    outputLabl2.Text = "Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 15:
                    outputLabel1.Text = "You wait till the symbol appears before crossing. As you are crossing the road a Honda Civic runs a red light making you collateral damage to the vehicle.";
                    outputLabl2.Text = "Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 16:
                    outputLabel1.Text = "Thank you for playing.";
                    outputLabl2.Text = "";
                    optionLabel1.Text = "";
                    optionLabel2.Text = "";
                    Refresh();
                    Thread.Sleep(3000);
                    Application.Exit();


                    break;

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 1;
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 1;
            }
            else if (page == 5)
            {
                page = 8;
            }
            else if (page == 6)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 1;
            }
            else if (page == 8)
            {
                int chance = randGen.Next(1, 101);

                if (chance <= 30)
                {
                    page = 1;
                }
                else
                {
                    page = 11;
                }

            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 10)
            {
                page = 1;
            }
            else if (page == 11)
            {
                page = 12;
            }
            else if (page == 12)
            {
                page = 1;
            }
            else if (page == 13)
            {
                page = 15;
            }
            else if (page == 14)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 1;
            }

            switch (page)
            {
                case 1:
                    outputLabel1.Text = "You wake up wondering were you are. With your vision still blurry you hear the sound of dripping water all around you.";
                    outputLabl2.Text = "You feel the need to feel around. Do you?";
                    optionLabel1.Text = "Feel around";
                    optionLabel2.Text = "Not right now";
                    break;
                case 2:
                    outputLabel1.Text = "As you feel around, the boards underneath you give out and you fall to your inky demise.";
                    outputLabl2.Text = "Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 3:
                    outputLabel1.Text = "You decide to not feel around you. Your vision begins to come back and you realize the water you heard dripping wasn't water at all, its INK dripping from every crack on the walls around you layering the floor in a thick layer of ink.";
                    outputLabl2.Text = "Do you try and stand?";
                    optionLabel1.Text = "Stand";
                    optionLabel2.Text = "Dont stand";
                    break;
                case 4:
                    outputLabel1.Text = "As you stand the boards underneath you give out and you fall to your inky demise.";
                    outputLabl2.Text = "Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 5:
                    outputLabel1.Text = "You decide not to stand and instead crawl through the ink towards a door that you see in the distance. Right before your about to reach the door an ink creature appears out of the ink behind you.";
                    outputLabl2.Text = "Do you run?";
                    optionLabel1.Text = "Run";
                    optionLabel1.Text = "Dont run";
                    break;
                case 6:
                    outputLabel1.Text = "You decide not to run and the creature reaches out and grabs your leg.";
                    outputLabl2.Text = "Do you kick at the creature?";
                    optionLabel1.Text = "Yes kick at the creature";
                    optionLabel2.Text = "Dont kick at the creature";
                    break;
                case 7:
                    outputLabel1.Text = "The creature pulls you into the depths of the ink.";
                    outputLabl2.Text = "PLay again?";
                    optionLabel1.Text = "Yes";
                    optionLabel1.Text = "No";
                    break;
                case 8:
                    outputLabel1.Text = "You reach the door just in time and slam it shut. You then feel someone or something starring at you. ";
                    outputLabl2.Text = "Do you turn around?";
                    optionLabel1.Text = "Turn around";
                    optionLabel2.Text = "Decide not to";
                    break;
                case 9:
                    outputLabel1.Text = "You turn around and  get an axe lodged into your forehead.";
                    outputLabl2.Text = "Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 10:
                    outputLabel1.Text = "After some time you get an axe lodged into the back of your head.";
                    outputLabl2.Text = "Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 11:
                    outputLabel1.Text = "You turn  around and manage to duck in time as an axe slices the air above your head. You see that there is an open door to your left and a hallway to your right.";
                    outputLabl2.Text = "What way do you go?";
                    optionLabel1.Text = "Open door";
                    optionLabel2.Text = "Hallway";
                    break;
                case 12:
                    outputLabel1.Text = "You turn and run to the open door. You realize that whoever swung the axe is not chasing you for some reason, You run through the doorway and as you do the door slams shut behind you. You try and go back through as you realize you are back at the beginning.";
                    outputLabl2.Text = "Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 13:
                    outputLabel1.Text = "You run down the hallway and make it to another door, you check to see that it is unlocked and lucky for you it is. You open the door and step outside to see your house just across the street. You walk to the crosswalk. ";
                    outputLabl2.Text = "Do you push the button and wait?";
                    optionLabel1.Text = "Push button";
                    optionLabel2.Text = "Decide to J walk";
                    break;
                case 14:
                    outputLabel1.Text = "You decide to J walk and make it home without a scratch. ";
                    outputLabl2.Text = "Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 15:
                    outputLabel1.Text = "You wait till the symbol appears before crossing. As you are crossing the road a Honda Civic runs a red light making you collateral damage to the vehicle.";
                    outputLabl2.Text = "Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 16:
                    outputLabel1.Text = "Thank you for playing.";
                    outputLabl2.Text = "";
                    optionLabel1.Text = "";
                    optionLabel2.Text = "";
                    Refresh();
                    Thread.Sleep(3000);
                    Application.Exit();


                    break;


            }
        }
    }
}
