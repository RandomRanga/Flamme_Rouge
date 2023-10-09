using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flamme_Rouge
{
    public partial class Form1 : Form
    {
        //creates list of squares for the track
        List<Square> track = new List<Square>();

       

        public Form1()
        {
            InitializeComponent();

            


        }
        
        


       
        /// <summary>
        /// creates the track when the picturebox is clicked. 
        /// NEED TO PUT INTO FORM1_LOAD. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxDraw_Click(object sender, EventArgs e)
        {

            Graphics paper = pictureBoxDraw.CreateGraphics();

            //create a start square and add to list 
            Square startSquare = new Square("start", 0, 100);
            track.Add(startSquare);

            //loop to stop repeative code of creting flat squares
            for (int i = 0; i < 8; i++)
            {
                //creates middle of the track flat and adds to list
                Square flatSquare = new Square("flat", 0, 100);
                track.Add(flatSquare);
            }
            //creates the finishing square and adds it to the list
            Square endSquare = new Square("end", 0, 100);
            track.Add(endSquare);
            int xpos = 0;
            //pictureBoxDraw.Refresh();
            foreach (Square s in track)
            {
                

                s.DrawSquare(paper,xpos);
                xpos += 105;
            }


            //draws the outline of the track 
            Pen pen1 = new Pen(Color.Blue, 1);        
            paper.DrawRectangle(pen1, 0, 0, pictureBoxDraw.Width-2,pictureBoxDraw.Height - 2);   

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            

        }
    }
}
