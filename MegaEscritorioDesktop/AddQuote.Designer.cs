namespace MegaDesk2ABJ
{
    partial class AddQuote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.numDrawersLabel = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.DepthTextBox = new System.Windows.Forms.TextBox();
            this.NumDrawersComboBox = new System.Windows.Forms.ComboBox();
            this.AddDeskQuoteHeading = new System.Windows.Forms.Label();
            this.DesktopMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.materialLabel = new System.Windows.Forms.Label();
            this.rushOrderLabel = new System.Windows.Forms.Label();
            this.AddDeskQuoteButton = new System.Windows.Forms.Button();
            this.RushSevenRadio = new System.Windows.Forms.RadioButton();
            this.RushFiveRadio = new System.Windows.Forms.RadioButton();
            this.RushThreeRadio = new System.Windows.Forms.RadioButton();
            this.RushNoneRadio = new System.Windows.Forms.RadioButton();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(38, 126);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(91, 20);
            this.widthLabel.TabIndex = 0;
            this.widthLabel.Text = "Desk &Width";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(34, 172);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(94, 20);
            this.depthLabel.TabIndex = 1;
            this.depthLabel.Text = "Desk &Depth";
            // 
            // numDrawersLabel
            // 
            this.numDrawersLabel.AutoSize = true;
            this.numDrawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDrawersLabel.Location = new System.Drawing.Point(60, 219);
            this.numDrawersLabel.Name = "numDrawersLabel";
            this.numDrawersLabel.Size = new System.Drawing.Size(68, 20);
            this.numDrawersLabel.TabIndex = 2;
            this.numDrawersLabel.Text = "D&rawers";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.WidthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthTextBox.Location = new System.Drawing.Point(144, 118);
            this.WidthTextBox.MaxLength = 2;
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(51, 29);
            this.WidthTextBox.TabIndex = 1;
            this.WidthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WidthTextBox.WordWrap = false;
            this.WidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dimensions_KeyPress);
            this.WidthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.WidthTextBox_Validating);
            // 
            // DepthTextBox
            // 
            this.DepthTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DepthTextBox.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.DepthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthTextBox.Location = new System.Drawing.Point(144, 165);
            this.DepthTextBox.MaxLength = 2;
            this.DepthTextBox.Name = "DepthTextBox";
            this.DepthTextBox.Size = new System.Drawing.Size(51, 29);
            this.DepthTextBox.TabIndex = 2;
            this.DepthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DepthTextBox.WordWrap = false;
            this.DepthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dimensions_KeyPress);
            this.DepthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.DepthTextBox_Validating);
            // 
            // NumDrawersComboBox
            // 
            this.NumDrawersComboBox.DisplayMember = "Items";
            this.NumDrawersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NumDrawersComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumDrawersComboBox.FormattingEnabled = true;
            this.NumDrawersComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.NumDrawersComboBox.Location = new System.Drawing.Point(144, 213);
            this.NumDrawersComboBox.MaxLength = 1;
            this.NumDrawersComboBox.Name = "NumDrawersComboBox";
            this.NumDrawersComboBox.Size = new System.Drawing.Size(51, 32);
            this.NumDrawersComboBox.TabIndex = 3;
            // 
            // AddDeskQuoteHeading
            // 
            this.AddDeskQuoteHeading.AutoSize = true;
            this.AddDeskQuoteHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDeskQuoteHeading.ForeColor = System.Drawing.Color.Black;
            this.AddDeskQuoteHeading.Location = new System.Drawing.Point(111, 10);
            this.AddDeskQuoteHeading.Name = "AddDeskQuoteHeading";
            this.AddDeskQuoteHeading.Size = new System.Drawing.Size(213, 31);
            this.AddDeskQuoteHeading.TabIndex = 3;
            this.AddDeskQuoteHeading.Text = "Add Desk Quote";
            // 
            // DesktopMaterialComboBox
            // 
            this.DesktopMaterialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DesktopMaterialComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesktopMaterialComboBox.FormattingEnabled = true;
            this.DesktopMaterialComboBox.ItemHeight = 24;
            this.DesktopMaterialComboBox.Location = new System.Drawing.Point(144, 260);
            this.DesktopMaterialComboBox.Name = "DesktopMaterialComboBox";
            this.DesktopMaterialComboBox.Size = new System.Drawing.Size(144, 32);
            this.DesktopMaterialComboBox.TabIndex = 4;
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel.Location = new System.Drawing.Point(60, 267);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(69, 20);
            this.materialLabel.TabIndex = 5;
            this.materialLabel.Text = "D&esktop";
            // 
            // rushOrderLabel
            // 
            this.rushOrderLabel.AutoSize = true;
            this.rushOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushOrderLabel.Location = new System.Drawing.Point(11, 0);
            this.rushOrderLabel.Name = "rushOrderLabel";
            this.rushOrderLabel.Size = new System.Drawing.Size(91, 20);
            this.rushOrderLabel.TabIndex = 6;
            this.rushOrderLabel.Text = "&Rush Order";
            // 
            // AddDeskQuoteButton
            // 
            this.AddDeskQuoteButton.BackColor = System.Drawing.Color.Blue;
            this.AddDeskQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDeskQuoteButton.Location = new System.Drawing.Point(36, 314);
            this.AddDeskQuoteButton.Name = "AddDeskQuoteButton";
            this.AddDeskQuoteButton.Size = new System.Drawing.Size(396, 36);
            this.AddDeskQuoteButton.TabIndex = 9;
            this.AddDeskQuoteButton.Text = "Get &Quote";
            this.AddDeskQuoteButton.UseVisualStyleBackColor = false;
            this.AddDeskQuoteButton.Click += new System.EventHandler(this.AddDeskButton_Click);
            // 
            // RushSevenRadio
            // 
            this.RushSevenRadio.AutoSize = true;
            this.RushSevenRadio.Location = new System.Drawing.Point(37, 118);
            this.RushSevenRadio.Name = "RushSevenRadio";
            this.RushSevenRadio.Size = new System.Drawing.Size(60, 22);
            this.RushSevenRadio.TabIndex = 8;
            this.RushSevenRadio.Text = "7 day";
            this.RushSevenRadio.UseVisualStyleBackColor = true;
            // 
            // RushFiveRadio
            // 
            this.RushFiveRadio.AutoSize = true;
            this.RushFiveRadio.Location = new System.Drawing.Point(37, 88);
            this.RushFiveRadio.Name = "RushFiveRadio";
            this.RushFiveRadio.Size = new System.Drawing.Size(60, 22);
            this.RushFiveRadio.TabIndex = 7;
            this.RushFiveRadio.Text = "5 day";
            this.RushFiveRadio.UseVisualStyleBackColor = true;
            // 
            // RushThreeRadio
            // 
            this.RushThreeRadio.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.RushThreeRadio.AutoSize = true;
            this.RushThreeRadio.Location = new System.Drawing.Point(37, 57);
            this.RushThreeRadio.Name = "RushThreeRadio";
            this.RushThreeRadio.Size = new System.Drawing.Size(60, 22);
            this.RushThreeRadio.TabIndex = 6;
            this.RushThreeRadio.Text = "3 day";
            this.RushThreeRadio.UseVisualStyleBackColor = true;
            // 
            // RushNoneRadio
            // 
            this.RushNoneRadio.AutoSize = true;
            this.RushNoneRadio.Checked = true;
            this.RushNoneRadio.Location = new System.Drawing.Point(37, 27);
            this.RushNoneRadio.Name = "RushNoneRadio";
            this.RushNoneRadio.Size = new System.Drawing.Size(59, 22);
            this.RushNoneRadio.TabIndex = 5;
            this.RushNoneRadio.TabStop = true;
            this.RushNoneRadio.Text = "None";
            this.RushNoneRadio.UseVisualStyleBackColor = true;
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.Red;
            this.ReturnButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.Location = new System.Drawing.Point(360, 356);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(72, 35);
            this.ReturnButton.TabIndex = 10;
            this.ReturnButton.Text = "&Cancel";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(47, 78);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(78, 20);
            this.customerNameLabel.TabIndex = 12;
            this.customerNameLabel.Text = "&Customer";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.customerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextBox.Location = new System.Drawing.Point(144, 71);
            this.customerNameTextBox.MaxLength = 50;
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(259, 29);
            this.customerNameTextBox.TabIndex = 0;
            this.customerNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.RushSevenRadio);
            this.panel1.Controls.Add(this.RushFiveRadio);
            this.panel1.Controls.Add(this.RushThreeRadio);
            this.panel1.Controls.Add(this.RushNoneRadio);
            this.panel1.Controls.Add(this.rushOrderLabel);
            this.panel1.Location = new System.Drawing.Point(308, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 152);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Office Symbol Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "24\" - 96\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Office Symbol Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "24\" - 48\"";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.ReturnButton;
            this.ClientSize = new System.Drawing.Size(446, 400);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.AddDeskQuoteButton);
            this.Controls.Add(this.DesktopMaterialComboBox);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.AddDeskQuoteHeading);
            this.Controls.Add(this.NumDrawersComboBox);
            this.Controls.Add(this.DepthTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.numDrawersLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mega Desk .:|:. Add New Quote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label numDrawersLabel;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox DepthTextBox;
        private System.Windows.Forms.ComboBox NumDrawersComboBox;
        private System.Windows.Forms.Label AddDeskQuoteHeading;
        private System.Windows.Forms.ComboBox DesktopMaterialComboBox;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label rushOrderLabel;
        private System.Windows.Forms.Button AddDeskQuoteButton;
        private System.Windows.Forms.RadioButton RushSevenRadio;
        private System.Windows.Forms.RadioButton RushFiveRadio;
        private System.Windows.Forms.RadioButton RushThreeRadio;
        private System.Windows.Forms.RadioButton RushNoneRadio;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}