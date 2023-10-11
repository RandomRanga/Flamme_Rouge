using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flamme_Rouge
{
    public class Card
    {
        //type of card ( sprinter, roler)
        //number on the card depends what card it is
        //exhaustion card bool (sprinter, roler)


        /// <summary>
        /// constant variable to hold how many decks of cards you want. 
        /// </summary>
        private const int DECK_AMOUNT = 1;

        //Instance variables 
        /// <summary>
        /// holds what type of card it is 
        /// </summary>
        private bool _isRoller;
        /// <summary>
        /// creates lists to hold possible numbers for the 2 types of cards 
        /// </summary>
        private int[] sprinterCardList = { 2, 3, 4, 5, 9 };
        private int[] rollerCardList = { 3, 4, 5, 6, 7 };
        /// <summary>
        /// holds the value of each card
        /// </summary>
        private int _value;

        /// <summary>
        /// if it is an exhaustion card or not
        /// </summary>
        private bool _exhaustion;



        

        /// <summary>
        /// constructor for card object. 
        /// </summary>
        /// <param name="IsRoller"></param>
        /// <param name="value"></param>
        /// <param name="exhaustion"></param>
        public Card (bool IsRoller, int value, bool exhaustion)
        {
            _isRoller = IsRoller;
            _value = value;
            _exhaustion = exhaustion;


            Console.WriteLine(_isRoller);
        }

        




        /// <summary>
        /// Creates a sprinter cards with correct card numbers for amount of decks. 
        /// </summary>
        public List<Card> createSprinterDeck()
        {
            // creates list of cards to hold the full deck of sprinter cards. 
            List<Card> sprinterDeck = new List<Card>();
            //runs a for loop for how many decks you have. 
            for (int i = 0; i < DECK_AMOUNT; i++)
            {
                //runs through the sprinter card list and adds it to the deck. 
                foreach (int value in sprinterCardList)
                {
                    //creates a new card object adds it to the deck and sets the value. 
                    sprinterDeck.Add(new Card(false, _value, false)
                    {
                        _value = value,
                    });
                }
                
            }
            //returns the sprinter deck full of cards 
            return sprinterDeck;

        }

        /// <summary>
        /// Creates a roller cards with correct card numbers for amount of decks. 
        /// </summary>
        public List<Card> createRollerDeck()
        {
            // creates list of cards to hold the full deck of roller cards. 
            List<Card> rollerDeck = new List<Card>();
            //runs a for loop for how many decks you have. 
            for (int i = 0; i < DECK_AMOUNT; i++)
            {
                //runs through the sprinter card list and adds it to the deck. 
                foreach (int value in rollerCardList)
                {
                    //creates a new card object adds it to the deck and sets the value. 
                    rollerDeck.Add(new Card(true, _value, false)
                    {
                        _value = value,
                    });
                }

            }
            //returns the sprinter deck full of cards 
            return rollerDeck;

        }

        /// <summary>
        /// overides the tostring method and then turns the card into a well formated string and returns it. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string cardName;
            //checks it the card is a roller or not. 
            if(_isRoller)
            {
                cardName = "Roller";
            }
            else
            {
                cardName = "Sprinter";
            }
            
            //creates formated string. 
            cardName += ", " + _value;
            //returns the string of the well formated card. 
            return cardName;
        }

    }
}
