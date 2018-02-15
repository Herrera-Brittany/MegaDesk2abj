namespace MegaDesk2ABJ
{
    partial class SearchQuotes
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
            this.ReturnButton = new System.Windows.Forms.Button();
            this.SearchByMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.SearchByLabel = new System.Windows.Forms.Label();
            this.SearchResultsListView = new System.Windows.Forms.ListView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.MistyRose;
            this.ReturnButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.Location = new System.Drawing.Point(1217, 624);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(5);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(403, 51);
            this.ReturnButton.TabIndex = 12;
            this.ReturnButton.Text = "&Return to Main Menu";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // SearchByMaterialComboBox
            // 
            this.SearchByMaterialComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByMaterialComboBox.FormattingEnabled = true;
            this.SearchByMaterialComboBox.Location = new System.Drawing.Point(246, 30);
            this.SearchByMaterialComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.SearchByMaterialComboBox.Name = "SearchByMaterialComboBox";
            this.SearchByMaterialComboBox.Size = new System.Drawing.Size(381, 28);
            this.SearchByMaterialComboBox.TabIndex = 13;
            this.SearchByMaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchByMaterialComboBox_SelectedIndexChanged);
            // 
            // SearchByLabel
            // 
            this.SearchByLabel.AutoSize = true;
            this.SearchByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByLabel.Location = new System.Drawing.Point(58, 20);
            this.SearchByLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SearchByLabel.Name = "SearchByLabel";
            this.SearchByLabel.Size = new System.Drawing.Size(178, 20);
            this.SearchByLabel.TabIndex = 16;
            this.SearchByLabel.Text = "Search by Material Type";
            // 
            // SearchResultsListView
            // 
            this.SearchResultsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchResultsListView.FullRowSelect = true;
            this.SearchResultsListView.GridLines = true;
            this.SearchResultsListView.Location = new System.Drawing.Point(14, 89);
            this.SearchResultsListView.Margin = new System.Windows.Forms.Padding(5);
            this.SearchResultsListView.Name = "SearchResultsListView";
            this.SearchResultsListView.Size = new System.Drawing.Size(963, 385);
            this.SearchResultsListView.TabIndex = 17;
            this.SearchResultsListView.UseCompatibleStateImageBehavior = false;
            this.SearchResultsListView.View = System.Windows.Forms.View.Details;
            this.SearchResultsListView.SelectedIndexChanged += new System.EventHandler(this.SearchResultsListView_SelectedIndexChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(655, 20);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(186, 57);
            this.SearchButton.TabIndex = 18;
            this.SearchButton.Text = "&Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(903, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 43);
            this.button1.TabIndex = 19;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(991, 499);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchResultsListView);
            this.Controls.Add(this.SearchByLabel);
            this.Controls.Add(this.SearchByMaterialComboBox);
            this.Controls.Add(this.ReturnButton);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk .:|:. Search Quotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.ComboBox SearchByMaterialComboBox;
        private System.Windows.Forms.Label SearchByLabel;
        private System.Windows.Forms.ListView SearchResultsListView;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button button1;
    }
}