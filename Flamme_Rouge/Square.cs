using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flamme_Rouge
{
    public class Square
    {
        //creates vaiables 
        /// <summary>
        /// what type of square it is
        /// </summary>
        private string _type;
        /// <summary>
        /// min speed on hte section of the track
        /// </summary>
        private int _min = 0;
        /// <summary>
        /// max speed on the section of the track 
        /// </summary>
        private int _max = 10;

        

        //constuctor 
        public Square(string type, int min, int max) 
        { 
            _type = type;
            _min = min;
            _max = max;

        }

        /// <summary>
        /// draws 2 squares at a time for the track
        /// </summary>
        /// <param name="paper"></param>
        /// <param name="xpos"></param>
        public void DrawSquare(Graphics paper, int xpos)
        {
            //checks what type the track is else sets it to a flat piece, 
            //then changes the color depending on which piece it is. 
            Color color = Color.Gray; 
            if ( _type == "start")
            {
                color = Color.Green;
            }
            if ( _type == "end")
            {
                color = Color.Red;
            }
            //creates a brush with color depending on track type. 
            SolidBrush br = new SolidBrush(color);
            //draws the top square at correct xpos and with correct color.  
            paper.FillRectangle(br, xpos, 0, 100, 50);
            //draws another rectangle below it, could have made a loop have ever overkill for this track. 
            paper.FillRectangle(br, xpos, 55, 100, 50);



        }




    }
}
