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
        //Instance variables
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
        /// <summary>
        /// creates a square with the max and min speed dending on the 
        /// input and then also the type of square they are on. 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public Square(string type, int min, int max) 
        {
            //checks if it is uphill or downhill and then sets the max or min to correct value. 
            //else just what the input is. 
            _type = type;
            _min = min;
            _max = max;
            if (type == "uphill")
            {
                _max = 5;
            }
            else if (type == "downhill")
            {
                _min = 5;
            }
           
           

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
            Color color; 
            if ( _type == "start")
            {
                color = Color.Green;
            }
            else if ( _type == "end")
            {
                color = Color.Red;
            }
            else if (_type == "uphill")
            {
                color = Color.Pink;
            }
            else if (_type == "downhill")
            {
                color = Color.Blue;
            }
            else 
            { 
                color = Color.Gray; 
            }
            //creates a brush with color depending on track type. 
            SolidBrush br = new SolidBrush(color);
            //draws the top square at correct xpos and with correct color.  
            paper.FillRectangle(br, xpos, 0, 40, 50);
            //draws another rectangle below it, could have made a loop have ever overkill for this track. 
            paper.FillRectangle(br, xpos, 55, 40, 50);
        }




    }
}
