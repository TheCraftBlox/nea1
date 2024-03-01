using System;
using System.Drawing;
using System.Windows.Forms;

namespace NEA1.Forms.Stock
{
    internal class StockBar : UserControl
    {
        public StockBar() { }
        private int percentage;
        public int Percentage
        {
            get { return percentage; }
            set
            { 
                percentage = value;
                this.Invalidate(); // redraw the stockbar
            }
        }
        //when te bar is being drawn
        protected override void OnPaint(PaintEventArgs e)
        {
            //call the base UserControl one
            base.OnPaint(e);

            //fill backgrouind, creating base background
            e.Graphics.FillRectangle(Brushes.Silver, this.ClientRectangle);

            //calc needed height of bar 
            int height = (percentage * Height) / 100;

            //create the bar
            Rectangle progressRectangle = new Rectangle(0, Height - height, Width, height);

            //set colour of bar to change depending on how much stock is left
            if (percentage <10)
            {
                //draaw progress bar 
                e.Graphics.FillRectangle(Brushes.Firebrick, progressRectangle);
            }
            else if (percentage < 30)
            {
                //draaw progress bar 
                e.Graphics.FillRectangle(Brushes.Gold, progressRectangle);
            }
            else
            {
                //draaw progress bar 
                e.Graphics.FillRectangle(Brushes.YellowGreen, progressRectangle);
            }

        }
    }
}

