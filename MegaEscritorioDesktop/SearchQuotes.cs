using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MegaDesk2ABJ
{
    public partial class SearchQuotes : Form
    {
        private const string QUOTEFILE = @"quotes.txt"; // location of CSV file of quotes

        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            // --- consider the Order of Events in Windows Forms: https://docs.microsoft.com/en-us/dotnet/framework/winforms/order-of-events-in-windows-forms
            
            // Populate material selection combobox with values from the DesktopMaterial Enum
            SearchByMaterialComboBox.DataSource = Enum.GetNames(typeof(DesktopMaterial));

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // This event responds to a selection in the material list combo box, populating the ListView with the appropiate records that match the material selected
            // Clear the ListView of all records except header
            SearchResultsListView.Clear();
            try
            {
               // Read the selected material from the combo box as a string only
                string MaterialSelected = SearchByMaterialComboBox.SelectedItem.ToString();
                // Read CSV formatted file contents if they exist with a StreamReader
                if (!File.Exists(QUOTEFILE))
                {
                    MessageBox.Show("A quote file was not found in the application root", "Error Reading File");
                }
                else
                {
                    // Add column headings to the search results output window - a ListView object
                    // NOTE: Set the View Property of the ListView to Details
                    // --- consider using dynamic column width algorithm/method
                    SearchResultsListView.Columns.Add("#", 30, HorizontalAlignment.Center);
                    SearchResultsListView.Columns.Add("Name", 170, HorizontalAlignment.Center);
                    SearchResultsListView.Columns.Add("Date", 180, HorizontalAlignment.Center);
                    SearchResultsListView.Columns.Add("Width", 70, HorizontalAlignment.Center);
                    SearchResultsListView.Columns.Add("Depth", 70, HorizontalAlignment.Center);
                    SearchResultsListView.Columns.Add("Drawers", 80, HorizontalAlignment.Center);
                    SearchResultsListView.Columns.Add("Desktop", 120, HorizontalAlignment.Center);
                    SearchResultsListView.Columns.Add("Days", 70, HorizontalAlignment.Center);
                    SearchResultsListView.Columns.Add("Total", 170, HorizontalAlignment.Center);

                    using (StreamReader sr = new StreamReader(QUOTEFILE))
                    {
                        int quoteCount = 0;
                        while (!sr.EndOfStream)
                        {
                            
                            string[] fieldvalue = sr.ReadLine().Split(',');
                            if (fieldvalue[5] == MaterialSelected)
                            {
                                quoteCount++;
                                SearchResultsListView.Items.Add(new ListViewItem(new[] { quoteCount.ToString(), fieldvalue[0], fieldvalue[1], fieldvalue[2], fieldvalue[3], fieldvalue[4], fieldvalue[5], fieldvalue[6], "$"+fieldvalue[7] }));
                            }

                            #region Using Contains method - simplier method IF not using columns
                                //string recordset = sr.ReadLine();
                                //if (recordset.Contains(MaterialSelected))
                                //{
                                //    SearchResultsListView.Items.Add(recordset);
                                //}
                                #endregion
                        }
                    };
                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show("Error with populating ListView using StreamReader." + "\n\n" + ex);
            }
        }

        private void SearchByMaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchResultsListView.Clear();
            try
            {
                string[] allDeskQuotes = File.ReadAllLines(QUOTEFILE);
                int quoteCount = 0;
                foreach(string quote in allDeskQuotes)
                {
                    if (quote.Contains(SearchByMaterialComboBox.SelectedValue.ToString()))
                    {
                        quoteCount++;
                        SearchResultsListView.Items.Add(quote);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("File read and population error" + ex);
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            var ShowMainMenu = (MainMenu)Tag;
            ShowMainMenu.Show();
            this.Close();
        }

        private void SearchResultsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ShowMainMenu = (MainMenu)Tag;
            ShowMainMenu.Show();
            this.Close();
        }
    }
}
