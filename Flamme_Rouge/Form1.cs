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
        //variables to hold where the rider is. 
        int xcur = 5;
        int ycur = 50;
        int length = 45;
        //creates decks for both riders. 
        Deck rollerCardDeck = new Deck(true, false);
        Deck sprinterCardDeck = new Deck(false, false);

        //creates both riders
        Rider sprinterRider;
        Rider rollerRider;
        //creates graphics 
        Graphics paper;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// displays the roller hand of cards 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSprinter_Click(object sender, EventArgs e)
        {
            //displays the hand of cards            
            sprinterCardDeck.dealHand(listBoxCards);
            //writes the deck to console. 
            sprinterCardDeck.displayDeck();
        }

        /// <summary>
        /// displays the sprinter hand of cards 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRoller_Click(object sender, EventArgs e)
        {         
            //displays the hand of cards 
            rollerCardDeck.dealHand(listBoxCards);
            //writes the deck to console. 
            rollerCardDeck.displayDeck();
        }

        /// <summary>
        /// once a card is clicked the correct rider moves the correct amount of squares.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxCards_SelectedIndexChanged(object sender, EventArgs e)
        {         
            //takes the string from list box and turns it into an array.             
            string[] cardArray = listBoxCards.SelectedItem.ToString().Split(',');
            //how many squares the rider should move. 
            int moveSquares = int.Parse(cardArray[1]);

            //part of the hills to check where the rider is in the track. 
            //to know to go fast or slow however doesn't work corretly. 
            //if (rollerRider._xpos > 250 && rollerRider._xpos < 450)
            //{

                //checkes what tpye of card it is then moves the correct rider correct amount of squares. 
                if (cardArray[0] == "Roller")
                {
                    rollerRider.moveRoller(moveSquares);

                }
                if (cardArray[0] == "Sprinter")
                {
                    sprinterRider.moveSprinter(moveSquares);

                }
            //}
            //redraws
            this.Invalidate();
        }

        /// <summary>
        /// creates the track when the button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            //creates the graphics for the track
            paper = pictureBoxDraw.CreateGraphics();

            //holds the x pos of the squares.
            int xpos = 0;
            //how long you want the track
            int trackLength = 28;


            //draws the track based on what square it is drawing. 
            for (int i = 1; i <= trackLength; i++)
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
                else if (i >= 25)
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

            //checks if is null then creates it so it doesn't override. 
            if (sprinterRider == null)
            {
                //cretaes and draws a sprinter rider at the start line in bottom column 
                sprinterRider = new Rider(xcur, ycur, false);
                
            }
            //draws the sprinter rider 
            sprinterRider.DrawRiders(paper, Color.Red);

            //checks if is null then creates it so it doesn't override. 
            if (rollerRider == null)
            {
                //cretaes and draws a roller rider at the start line in bottom column 
                rollerRider = new Rider(xcur + length, ycur, true);
                
            }
            //draws the rollerrider
            rollerRider.DrawRiders(paper, Color.Blue);

        }   
    }
}
