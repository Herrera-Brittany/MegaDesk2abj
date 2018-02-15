using System;
using System.Windows.Forms;

namespace MegaDesk2ABJ
{
    public partial class DeskQuoteView : Form
    {
        public DeskQuoteView(DeskQuote deskQuote)
        {
            InitializeComponent();
            PopulateFormDisplay(deskQuote);        
        }

        private void PopulateFormDisplay(DeskQuote deskQuote)
        {
            CustomerName.Text = deskQuote.CustomerName;
            OrderDate.Text = deskQuote.QuoteDate.ToString("dd MMM yyyy");
            DeskWidth.Text = deskQuote.Desk.Width.ToString() + " inches";
            DeskDepth.Text = deskQuote.Desk.Depth.ToString() + " inches";
            Drawers.Text = deskQuote.Desk.NumberOfDrawers.ToString();
            Material.Text = deskQuote.Desk.DesktopMaterial.ToString();
            if (deskQuote.RushDays == 0)
            {
                RushDays.Text = "None";
            }
            else
            {
                RushDays.Text = deskQuote.RushDays.ToString() + " days";
            }
            QuoteTotal.Text = String.Format("{0:C}", deskQuote.QuoteAmount);
        }

        private void DeskOrderView_FormClosed(object sender, FormClosedEventArgs e)
        {
            var ShowMainMenu = (MainMenu)Tag;
            ShowMainMenu.Show();
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            //var ShowAddQuote = (AddQuote)Tag;
            //ShowAddQuote.Show();
            Close();

        }

        private void DeskQuoteView_Load(object sender, EventArgs e)
        {

        }
    }
}
