using System;
using System.Collections.Generic;
using System.Linq;
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


        //Instance variables 
        /// <summary>
        /// holds what type of card it is 
        /// </summary>
        private string _type;
        /// <summary>
        /// holds the number of the card 
        /// </summary>
        private int _number;
        /// <summary>
        /// if it is an exhaustion card or not
        /// </summary>
        private bool _exhaustion;

        //Constructor

        public Card (string type, int number, bool exhaustion)
        {
            _type = type;
            _number = number;   
            _exhaustion = exhaustion;

            //sets the card number to 2 if it is an exhaustion card.
            //if (exhaustion == true)
            //{
            //   _type = type;
            //    _number = 2;
            //    _exhaustion = exhaustion;
            //}
            ////checks if it is a spriter type of card 
            //else if (type == "sprinter" && exhaustion == false)
            //{
            //    _type = type;              
            //    _number = number;
            //    _exhaustion = exhaustion;

            //}
            //else
            //{
            //    MessageBox.Show("Sorry There seems to be an error please resart the game.");
            //}
        }


        /// <summary>
        /// Creates a sprinter card with correct card numbers. 
        /// </summary>
        public void createSprinterCard()
        {
            //checks if it an exhaustion card, if it is make it only 2. 
            if (_exhaustion)
            {
                _number = 2;
            }
            //else creates a proper sprinter card 
            else
            {
                //creates a new random number between 2 and 6 
                Random rand = new Random();
                int random = rand.Next(2,7);
                //checks what the random number is and then sets the card number to the corrasponding number. 
                switch (random)
                {                 
                    case 6:
                        _number = 9;
                        break;
                    default:
                        _number = random; 
                        break;
                }
            }
        }



    }
}
