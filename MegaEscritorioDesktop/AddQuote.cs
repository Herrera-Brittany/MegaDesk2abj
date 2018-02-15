//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace MegaDesk2ABJ
{
    public partial class AddQuote : Form
    {
        #region Declarations

        string CustomerName = String.Empty;
        int DeskWidth = 0;
        int DeskDepth = 0; 
        int Drawers = 0; // number of desk drawers
        DesktopMaterial DesktopMaterial; // 
        int RushOrderDays = 0; // rush order selection in days
        int DeskQuoteTotal = 0; // desk quote total

        #endregion

        public AddQuote()
        {
            InitializeComponent();

            // Using a List<T> class to populate ComboBox of materials
            List<DesktopMaterial> DesktopMaterialList = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            DesktopMaterialComboBox.DataSource = DesktopMaterialList;

            // Enum allow direction datasource connection
            //DesktopMaterialComboBox.DataSource = Enum.GetNames(typeof(DesktopMaterial));
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            var ReturnMainMenu = (MainMenu)Tag;
            ReturnMainMenu.Show();
            this.Close();
        }

        private void WidthTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(WidthTextBox.Text, out int WidthInput))
            {
                if (WidthInput < Desk.MINWIDTH || WidthInput > Desk.MAXWIDTH)
                {
                    MessageBox.Show("Please enter a width from 24 to 96 inches.");
                    WidthTextBox.Text = String.Empty;
                    WidthTextBox.BackColor = Color.LightSalmon;
                    WidthTextBox.Focus();
                }
                else
                {
                    WidthTextBox.BackColor = Color.White;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid width measurement as a whole number.");
                WidthTextBox.Text = "";
                WidthTextBox.BackColor = Color.LightSalmon;
                WidthTextBox.Focus();
            }
        }

        private void DepthTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(DepthTextBox.Text, out int height))
            {
                if (height < Desk.MINDEPTH || height > Desk.MAXDEPTH)
                {
                    MessageBox.Show("Please enter a width from 24 to 48 inches.");
                    DepthTextBox.Text = String.Empty;
                    DepthTextBox.BackColor = Color.LightSalmon;
                    DepthTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid width measurement as a whole number.");
                DepthTextBox.Text = "";
                DepthTextBox.BackColor = Color.LightSalmon;
                DepthTextBox.Focus();
            }
        }

        private void Dimensions_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void AddDeskButton_Click(object sender, EventArgs e)
        {

            try
            {
                CustomerName = customerNameTextBox.Text;
                DeskWidth = int.Parse(WidthTextBox.Text);
                DeskDepth = int.Parse(DepthTextBox.Text);
                Drawers = int.Parse(NumDrawersComboBox.SelectedItem.ToString());
                DesktopMaterial = (DesktopMaterial)DesktopMaterialComboBox.SelectedValue;

                // Get rush order selection for selections
                if (RushThreeRadio.Checked)
                {
                    RushOrderDays = 3;
                }
                if (RushFiveRadio.Checked)
                {
                    RushOrderDays = 5;
                }
                if (RushSevenRadio.Checked)
                {
                    RushOrderDays = 7;
                }

                // Create new deskOrder object and calculate total
                DeskQuote NewQuote = new DeskQuote(CustomerName, DateTime.Now, DeskWidth, DeskDepth, Drawers, DesktopMaterial, RushOrderDays);
                DeskQuoteTotal = NewQuote.CalculateQuoteTotal();

                //json output
               // if (!File.Exists(@"quotes.json"))
               // {
                //    using (StreamWriter sw = File.CreateText("quotes.json"))
                //    {
                //        sw.WriteLine("[]");
               //     }
                    // build output string using csv
                    var DeskRecord = CustomerName + "," + DateTime.Now + "," + DeskWidth + "," + DeskDepth + "," + Drawers + "," + DesktopMaterial + "," + RushOrderDays + "," + DeskQuoteTotal;
                    string cFile = @"quotes.txt";
                    if (!File.Exists(cFile))
                    {
                        using (StreamWriter sw = File.CreateText("quotes.txt")) { }
                    }
                    using (StreamWriter swa = File.AppendText("quotes.txt")) { swa.WriteLine(DeskRecord); }

                    // Display quote using DeskQuote object *****
                    DeskQuoteView NewOrderView = new DeskQuoteView(NewQuote);

                    // Allow return to Main menu after quote view
                    var MainMenu = (MainMenu)Tag;
                    { Tag = MainMenu; };
                    NewOrderView.Show(MainMenu);
                    this.Close();
                
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            var ShowMainMenu = (MainMenu)Tag;
            ShowMainMenu.Show();
            this.Close();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
