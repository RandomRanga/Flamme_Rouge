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
            //how long you want the track
            int trackLength = 28;


            //draws the track based on what square it is drawing. 
            for (int i  = 1; i <= trackLength; i++)
            {
                //draws start squares
                if (i <= 2)
                {
                    Square startSquare = new Square("start", 0, 100);
                    track.Add(startSquare);
                }
                //draws uphill 
                else if (i >= 6 && i <= 9)
                {
                    Square uphillSquare = new Square("uphill", 0, 10);
                    track.Add(uphillSquare);
                }
                //draws downhill
                else if (i >= 14 && i <= 18)
                {
                    Square downhillSquare = new Square("downhill", 0, 10);
                    track.Add(downhillSquare);
                }
                //draws end squares
                else if ( i >= 25)
                {
                    Square endSquare = new Square("end", 0, 10);
                    track.Add(endSquare);

                }
                //draws all flat squares on unoccupided squares
                else
                {
                    Square flatSquare = new Square("flat", 0, 10);
                    track.Add(flatSquare);
                }
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

            //cretaes and draws a sprinter rider at the start line in bottom column 
            Rider sprinterRider = new Rider(5, 50, false);
            sprinterRider.DrawRiders(paper, Color.Red);
            //cretaes and draws a roller rider at the start line in bottom column 
            Rider rollerRider = new Rider(50, 50, true);
            rollerRider.DrawRiders(paper, Color.Blue);
        }

        /// <summary>
        /// creates a new deck of sprinter cards and displays the hand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSprinter_Click(object sender, EventArgs e)
        {
            //creates the deck of sprinter cards. 
            Deck cardDeck = new Deck(false, false);
            cardDeck.dealHand(listBoxCards);
            cardDeck.displayDeck();
        }

        /// <summary>
        /// creates a new deck of roller cards and tehn displays the hand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRoller_Click(object sender, EventArgs e)
        {
            Deck cardDeck = new Deck(true, false);
            cardDeck.dealHand(listBoxCards);
            cardDeck.displayDeck();
        }

        /// <summary>
        /// displays which rider moves where.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("you rider moves " + listBoxCards.SelectedItem.ToString());



        }
        
        //private void createPlayer(Graphics paper, int numPlayers)
        //{
        //    int xpos = 5;
        //    int ypos = 5;
        //    int adder = 45;

        //    for (int i = 1; i <= numPlayers; i++)
        //    {
        //        Rider sprinterRider = new Rider(xpos, ypos + (adder * i-1), false);
        //        sprinterRider.DrawRiders(paper, Color.Red);

        //        Rider rollerRider = new Rider(xpos + (adder * i), ypos + (adder * i-1), true);
        //        rollerRider.DrawRiders(paper, Color.Blue);
        //    }
        //}
      
    }
}
