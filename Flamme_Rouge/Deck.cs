using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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
        private List<Card> _cardList;
        /// <summary>
        /// holds each new hand of cards
        /// </summary>
        private List<Card> _handList = new List<Card>();
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
            // picks the first 4 cards of the list and adds them to the hand list. 
            for (int i = 0; i < 4; i++)
            {
                Card c = _cardList[i];

                _handList.Add(c);
            }
            
            //for each card in the hand list it is displayed in the list box. 
            foreach (Card c in _handList)
            {
                listBoxCards.Items.Add(c);
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
