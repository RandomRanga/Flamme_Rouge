using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Flamme_Rouge
{
    public class Square
    {
        //creates vaiables 
        private string _type;

        private int _min = 0;

        private int _max = 10;




        //creates list of squares for the track
        List<Square> track = new List<Square>();

        //constuctor 
        public Square(string type, int min, int max) 
        { 
            _type = type;
            _min = min;
            _max = max;

        }

        public void DrawSquare(Graphics paper)
        {
            
            SolidBrush br = new SolidBrush(Color.Gray);
            // brush, x, y, width, height

            paper.FillRectangle(br,100,100,100,100);


        }




    }
}
