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
        public int _xpos;
        /// <summary>
        /// holds the y pos of the rider
        /// </summary>
        private int _ypos;
        /// <summary>
        /// if it is a roller rider or not
        /// </summary>
        private bool _isRoller;

        /// <summary>
        /// constucts the rider objects 
        /// </summary>
        /// <param name="xpos"></param>
        /// <param name="ypos"></param>
        /// <param name="isRoller"></param>
        public Rider(int xpos, int ypos, bool isRoller)
        {
            _xpos = xpos;
            _ypos = ypos;
            _isRoller = isRoller;
        }

        

        /// <summary>
        /// draws each rider at the correct location with the correct color. 
        /// </summary>
        /// <param name="paper"></param>
        /// <param name="color">the inside color of the riders</param>
        public void DrawRiders(Graphics paper, Color color)
        {
            SolidBrush br = new SolidBrush(color);
            Pen pen1 = new Pen(Color.Black, 4);

            //draws the top left rider at correct xpos and with correct color.  
            paper.FillRectangle(br, _xpos, _ypos, 30, 30);
            paper.DrawRectangle(pen1, _xpos, _ypos, 30, 30);

        }

        /// <summary>
        /// moves the roller rider the correct distance. 
        /// </summary>
        /// <param name="moveSquares">amount of squares for the roller to move.</param>
        public void moveRoller(int moveSquares)
        {
            _xpos += (moveSquares * 45);
        }

        /// <summary>
        /// moves the sprinter rider the correct distance. 
        /// </summary>
        /// <param name="moveSquares">amount of squares for the sprinter to move.</param>
        public void moveSprinter(int moveSquares)
        {
            _xpos += (moveSquares * 45);
        }

        








    }
}
