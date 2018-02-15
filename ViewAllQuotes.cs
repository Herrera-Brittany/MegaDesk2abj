using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace MegaDesk2ABJ
{
    public partial class ViewAllQuotes : Form
    {
        //private List<DeskQuote> AllQuotesList;

        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void LoadDataGridViewButton_Click(object sender, EventArgs e)
        {
            DataTable DataTable = new DataTable("AllQuotesView");
            DataTable.Columns.AddRange(new DataColumn[8]
            {
              new DataColumn("Name", typeof(String)),
              new DataColumn("Date", typeof(String)),
              new DataColumn("Width", typeof(String)),
              new DataColumn("Depth", typeof(String)),
              new DataColumn("Drawers", typeof(String)),
              new DataColumn("Material", typeof(String)),
              new DataColumn("Rush Days", typeof(String)),
              new DataColumn("Total", typeof(String))
            });

            try
            {
                using (StreamReader sr = new StreamReader(@"quotes.txt"))
                {
                    int recordCount = 0;
                    while (!sr.EndOfStream)
                    {
                        string[] fieldvalue = sr.ReadLine().Split(',');
                        DataTable.Rows.Add();
                        for (var i = 0; i < fieldvalue.Length; i++)
                        {
                            DataTable.Rows[recordCount][i] = fieldvalue[i];
                        }
                        recordCount++;
                    }
                };

                LoadDataGridViewButton.Enabled = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
            AllQuotesDataGridView.DataSource = DataTable;
        }

        private void LoadListViewButton_Click(object sender, EventArgs e)
        {
            AllQuotesListView.Columns.Add("Name", 170, HorizontalAlignment.Center);
            AllQuotesListView.Columns.Add("Date", 172, HorizontalAlignment.Center);
            AllQuotesListView.Columns.Add("Width", 70, HorizontalAlignment.Center);
            AllQuotesListView.Columns.Add("Depth", 70, HorizontalAlignment.Center);
            AllQuotesListView.Columns.Add("Drawers", 80, HorizontalAlignment.Center);
            AllQuotesListView.Columns.Add("Desktop", 150, HorizontalAlignment.Center);
            AllQuotesListView.Columns.Add("Days", 70, HorizontalAlignment.Center);
            AllQuotesListView.Columns.Add("Total", 172, HorizontalAlignment.Center);

            try  // to read quotes.txt
            {
                using (StreamReader sr = new StreamReader(@"quotes.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fieldvalue = sr.ReadLine().Split(',');
                        AllQuotesListView.Items.Add(new ListViewItem(new[]
                        {
                            fieldvalue[0], fieldvalue[1], fieldvalue[2], fieldvalue[3], fieldvalue[4], fieldvalue[5], fieldvalue[6], fieldvalue[7]
                        }));
                    }
                };

                LoadListViewButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with populating ListView!" + "\n\n" + ex);

            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            var ShowMainMenu = (MainMenu)Tag;
            ShowMainMenu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ShowMainMenu = (MainMenu)Tag;
            ShowMainMenu.Show();
            this.Close();
        }

        private void AllQuotesListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
