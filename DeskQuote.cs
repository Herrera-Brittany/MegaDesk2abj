using System;
using System.IO;

namespace MegaDesk2ABJ
{
    public class DeskQuote
    {
        // DeskQuote model attribute members

        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public int RushDays { get; set; }
        public Desk Desk = new Desk();
        public int QuoteAmount { get; set; }

        // Working member variables
        private int SurfaceArea = 0; 
        
        // Constants (future source is some data source)
        private const int PRICE_BASE = 200;
        private const int SIZE_THRESHOLD = 1000;  // inches squared
        private const int PRICE_PER_DRAWER = 50;
        private const int PRICE_PER_SURFACEAREA = 1; // extra cost per square inch greater than desktop size threshold
        private const int RUSH1 = 3; // Rush order days options
        private const int RUSH2 = 5;
        private const int RUSH3 = 7; 
        private const int RUSH_THRESHOLD = 2000; // inches squared - see problem specs for rush order costs


        public DeskQuote(string customerName, DateTime quoteDate, int width, int depth, int drawers, DesktopMaterial material, int rushDays)
        {
            // Constructor when object is built - set attribute values
            CustomerName = customerName;
            QuoteDate = quoteDate;
            Desk.Width = width;
            Desk.Depth = depth;
            Desk.NumberOfDrawers = drawers;
            Desk.DesktopMaterial = material;
            RushDays = rushDays;

            // calculate Surface Area member variable for use in multiple functions
            SurfaceArea = Desk.Width * Desk.Depth;
        }

        public int CalculateQuoteTotal()
        {
            QuoteAmount = PRICE_BASE + SurfaceAreaCost() + DrawerCost() + (int)Desk.DesktopMaterial + RushOrderCost();
            return QuoteAmount;
        }

        private int SurfaceAreaCost ()
        {
            // Determine if additional cost is warranted with desk areas greater than the desktop size threshold
            if (SurfaceArea > SIZE_THRESHOLD)
            {
                return (SurfaceArea - SIZE_THRESHOLD) * PRICE_PER_SURFACEAREA;
            }
            else
            {
                return 0;
            }          
        }

        public int DrawerCost()
        {
            return Desk.NumberOfDrawers * PRICE_PER_DRAWER;
        }

        public int RushOrderCost()
        {
            int rushCost = 0; // return rush order cost variable
            // OK to not have the 2-dimensional array for rush order prices until the next version
            if (RushDays != 0)
            {
                int[,] rushOrderPrices = GetRushOrderPrices();  // call function that reads in price chart - 

                switch (RushDays)
                {
                    case RUSH1:
                        if (SurfaceArea < SIZE_THRESHOLD)
                        {
                            rushCost = rushOrderPrices[0, 0];
                        }
                        else if (SurfaceArea <= RUSH_THRESHOLD)
                        {
                            rushCost = rushOrderPrices[0, 1];
                        }
                        else
                        {
                            rushCost = rushOrderPrices[0, 2];
                        }
                        break;
                    case RUSH2:
                        if (SurfaceArea < SIZE_THRESHOLD)
                        {
                            rushCost = rushOrderPrices[1, 0];
                        }
                        else if (SurfaceArea <= RUSH_THRESHOLD)
                        {
                            rushCost = rushOrderPrices[1, 1];
                        }
                        else
                        {
                            rushCost = rushOrderPrices[1, 2];
                        }
                        break;
                    case RUSH3:
                        if (SurfaceArea < SIZE_THRESHOLD)
                        {
                            rushCost = rushOrderPrices[2, 0];
                        }
                        else if (SurfaceArea <= RUSH_THRESHOLD)
                        {
                            rushCost = rushOrderPrices[2, 1];
                        }
                        else
                        {
                            rushCost = rushOrderPrices[2, 2];
                        }
                        break;
                }
            }
            return rushCost;
        }

        // This really was for MegaDesk 2 - Week 5.
        public int[,] GetRushOrderPrices()
        {
            int[,] rushOrderPrices = new int[3, 3];
            try
            {
                string[] lines = File.ReadAllLines("rushOrderPrices.txt");
                int readLineCount = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        rushOrderPrices[i, j] = int.Parse(lines[readLineCount]);
                        readLineCount++;
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Rush Order Price Data Read Error: " + e.Message);
            }
            return rushOrderPrices;

        }
    }
}