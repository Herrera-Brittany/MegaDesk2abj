using System;
using System.Windows.Forms;

namespace MegaDesk2ABJ
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void newQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote AddQuoteForm = new AddQuote { Tag = this };
            AddQuoteForm.Show(this);
            this.Hide();
        }
        
        private void viewQuotesButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes ViewAllQuotesForm = new ViewAllQuotes { Tag = this };
            ViewAllQuotesForm.Show(this);
            this.Hide();
        }

        private void appExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchQuotesButton_Click(object sender, EventArgs e)
        {
            SearchQuotes SearchQuotesForm = new SearchQuotes { Tag = this };
            SearchQuotesForm.Show(this);
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}