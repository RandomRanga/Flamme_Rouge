using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flamme_Rouge
{
    public class Rider
    {
        //instant variables 
        /// <summary>
        /// holds the x pos of the rider 
        /// </summary>
        private int _xpos;
        /// <summary>
        /// holds the y pos of the rider
        /// </summary>
        private int _ypos;
        /// <summary>
        /// if it is a roller rider or not
        /// </summary>
        private bool _isRoller;

        public Rider(int xpos, int ypos, bool isRoller)
        {
            _xpos = xpos;
            _ypos = ypos;
            _isRoller = isRoller;
        }



        //draw mehtod
        public void DrawRiders(Graphics paper, Color color)
        {                 
            SolidBrush br = new SolidBrush(color);
            Pen pen1 = new Pen(Color.Black,4);

            //draws the top left rider at correct xpos and with correct color.  
            paper.FillRectangle(br, _xpos, _ypos, 30, 30);
            paper.DrawRectangle(pen1, _xpos, _ypos, 30, 30);

        }

        /// <summary>
        /// moves the rider based on the card selected. 
        /// </summary>
        /// <param name="xcur"></param>
        /// <param name="ycur"></param>
        /// <returns></returns>
        public void moveRider(string card, int moveSquares)
        {
            
            string[] cardArray = card.Split(',');

            if(cardArray[0] == "Roller")
            {
                _xpos += (moveSquares * 45);

            }
            else if (cardArray[0] == "Sprinter")
            {

            }
            else
            {
                MessageBox.Show(" Sorry something has gone wrong please try again.");
            }



            



          
        }





    }
}
