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

            if (type == "Sprinter")
            {

            }
            else if (type == "Roller")
            {

            }
            else
            {
                MessageBox.Show("Sorry There seems to be an error please resart the game.");
            }
        }


        public void createCard()
        {


        }



    }
}
