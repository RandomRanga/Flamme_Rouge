using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flamme_Rouge
{
    public class Deck 
    {
        //instant vaiables
        /// <summary>
        /// holds a list of cards 
        /// </summary>
        private List<Card> _cardList = new List<Card>();
        /// <summary>
        /// holds each new hand of cards
        /// </summary>
        private List<Card> _handList = new List<Card>();
        /// <summary>
        /// holds all the recyled cards in a list. 
        /// </summary>
        List<Card> _recyledDeck = new List<Card>();
        /// <summary>
        /// random variable to shuffle cards
        /// </summary>
        private Random _rand = new Random();
        /// <summary>
        /// boolean for if it is a roller cylist or not
        /// </summary>
        private bool _IsRoller;
        /// <summary>
        /// if it is an exhaustion card or not
        /// </summary>
        private bool _exhaustion;


        /// <summary>
        /// creates a new card object and then a list of cards using the create deck methods.
        /// </summary>
        /// <param name="isRoller">If it is a roller cylist or not</param>
        public Deck(bool isRoller, bool exhaustion) 
        {
            _IsRoller = isRoller;
            _exhaustion = exhaustion;
            //creates a new card object
            Card card = new Card(_IsRoller, 0, _exhaustion);
            //creates a list of cards depending on what type of card it is. 
            if (_IsRoller)
            {
                _cardList = card.createRollerDeck();
            }
            else if (!_IsRoller) 
            {
                _cardList = card.createSprinterDeck();
            }
           
        }

        

        /// <summary>
        /// displays the whole deck into the console
        /// </summary>
        public void displayDeck()
        {
            //for each card in the card list will be writien to the console. 
            foreach (Card c in _cardList)
            {
                Console.WriteLine(c);
            }
            
        }

       

        /// <summary>
        /// finds the first four cards from the card list and displays them to the list box. 
        /// </summary>
        /// <param name="listBoxCards"></param>
        public void dealHand(ListBox listBoxCards)
        {

            ShuffleDeck();
            ///clears the list box
            listBoxCards.Items.Clear();

            int j = -1;
            // picks the first 4 cards of the list and adds them to the hand list. 
            for (int i = 0; i < 4; i++)
            {
                //Checks if card list is empty if it is runs the recyleddeck and adds it to the hand list                 
                if (_cardList.Count > 0)
                {

                    Card c = _cardList[i-i];
                    
                    //adds each card to the handlist. 
                    _handList.Add(c);
                    //removes each card in the hand from the deck. 
                    _cardList.Remove(c);
                    //adds each card in the hand to the recyled deck. 
                    _recyledDeck.Add(c);
                    j++;
                }

                //
                else
                {
                    Card recyledCard = _recyledDeck[i - j];

                    _handList.Add(recyledCard);
                }


            }
            //for each card in the hand list it is displayed in the list box. 
            
            for( int i  = 0; i < 4;i++) 
            {
                //adds each drawn card to the hand. 
                listBoxCards.Items.Add(_handList[0]);
                
                
                
                

                _handList.Remove(_handList[0]);

            }    
            
        }

        /// <summary>
        /// shuffles all the cards in the deck 
        /// </summary>
        public void ShuffleDeck()
        {
            int index1;
            int index2;
            Card temp;

            //checks to shuffle recyling deck or cardlist. 
            if (_cardList.Count < 4)
            {
                //randomly swaps Cards 100 times 
                for (int i = 1; i <= 100; i++)
                {
                    //creates 2 random numbers 
                    index1 = _rand.Next(_recyledDeck.Count);
                    index2 = _rand.Next(_recyledDeck.Count);
                    //temperary card to store the card
                    temp = _recyledDeck[index1];
                    _recyledDeck[index1] = _recyledDeck[index2];
                    _recyledDeck[index2] = temp;
                }
            }
            else
            {
                //still need to remove the choosen card from the deck. 
                //randomly swaps Cards 100 times 
                for (int i = 1; i <= 100; i++)
                {
                    //creates 2 random numbers 
                    index1 = _rand.Next(_cardList.Count);
                    index2 = _rand.Next(_cardList.Count);
                    //temperary card to store the card
                    temp = _cardList[index1];
                    _cardList[index1] = _cardList[index2];
                    _cardList[index2] = temp;
                }

            }



        }

       


    }
}
