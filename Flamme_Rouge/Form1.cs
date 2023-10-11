using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flamme_Rouge
{
    public partial class Form1 : Form
    {
        //creates list of squares for the track
        List<Square> track = new List<Square>();     
        

        public Form1()
        {
            InitializeComponent();                    
        }
    
        /// <summary>
        /// creates the track when the button is clicked. 
        /// NEED TO PUT INTO FORM1_LOAD.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDrawTrack_Click(object sender, EventArgs e)
        {

            //creates the graphics for the track
            Graphics paper = pictureBoxDraw.CreateGraphics();
            //holds the x pos of the squares.
            int xpos = 0;

            //creates the start line and squares before start line 
            for (int i = 0; i < 2; i++)
            {
                Square flatSquare = new Square("start", 0, 100);
                track.Add(flatSquare);
            }

            //create a start square and add to list 
            //Square startSquare = new Square("start", 0, 100);
            //track.Add(startSquare);

            //creates a Random object 
            Random random = new Random();

            //loop to stop repeative code of creting flat squares 
            for (int i = 0; i < 21; i++)
            {
                //creates a random number used to pick if it is flat, uphill, or downhill
                int rand = random.Next(1, 5);
                //creates a local variable to hold what type of track it is.
                string type;

                //checks what the random number is then sets that to a type 
                //allowing for a different board everytime the game is played. 
                if (rand == 1)
                {
                    type = "downhill";
                }
                else if (rand == 2)
                {
                    type = "uphill";
                }
                else
                {
                    type = "flat";
                }

                //creates middle of the track flat and adds to list
                Square randomSquare = new Square(type, 0, 10);
                track.Add(randomSquare);

            }
            //creates the finishing square and adds it to the list
            //Square endSquare = new Square("end", 0, 10);
            //track.Add(endSquare);

            //creates the finish line and squares after to see who goes the futherest
            for (int i = 0; i < 5; i++)
            {
                Square flatSquare = new Square("end", 0, 10);
                track.Add(flatSquare);
            }
            
            
            //draws each of the squares in the list and 
            //after each one moves over 45
            foreach (Square s in track)
            {
                s.DrawSquare(paper, xpos);
                xpos += 45;
            }

            //draws the outline of the track 
            Pen pen1 = new Pen(Color.Blue, 1);
            paper.DrawRectangle(pen1, 0, 0, pictureBoxDraw.Width - 2, pictureBoxDraw.Height - 2);


            Rider sprinterRider = new Rider(5, 5, false);
            sprinterRider.DrawRiders(paper, Color.Red);

            //Rider rollerRider = new Rider(45, 45, true);
            //sprinterRider.DrawRiders(paper, Color.Blue);
        }

        private void buttonSprinter_Click(object sender, EventArgs e)
        {
            //creates the deck of sprinter cards. 
            Deck cardDeck = new Deck(false, false);
            cardDeck.dealHand(listBoxCards);
            cardDeck.displayDeck();
        }

        private void buttonRoller_Click(object sender, EventArgs e)
        {
            Deck cardDeck = new Deck(true, false);
            cardDeck.dealHand(listBoxCards);
            cardDeck.displayDeck();
        }

        private void listBoxCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("you rider moves " + listBoxCards.SelectedItem.ToString());



        }

      
    }
}
