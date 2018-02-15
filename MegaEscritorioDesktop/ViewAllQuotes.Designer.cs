namespace MegaDesk2ABJ
{
    partial class ViewAllQuotes
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
            this.AllQuotesListView = new System.Windows.Forms.ListView();
            this.AllQuotesDataGridView = new System.Windows.Forms.DataGridView();
            this.LoadDataGridViewButton = new System.Windows.Forms.Button();
            this.LoadListViewButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllQuotesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.MistyRose;
            this.ReturnButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.Location = new System.Drawing.Point(1217, 1132);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(5);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(403, 51);
            this.ReturnButton.TabIndex = 11;
            this.ReturnButton.Text = "&Return to Main Menu";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // AllQuotesListView
            // 
            this.AllQuotesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllQuotesListView.GridLines = true;
            this.AllQuotesListView.Location = new System.Drawing.Point(49, 57);
            this.AllQuotesListView.Margin = new System.Windows.Forms.Padding(5);
            this.AllQuotesListView.Name = "AllQuotesListView";
            this.AllQuotesListView.Size = new System.Drawing.Size(752, 280);
            this.AllQuotesListView.TabIndex = 12;
            this.AllQuotesListView.UseCompatibleStateImageBehavior = false;
            this.AllQuotesListView.View = System.Windows.Forms.View.Details;
            this.AllQuotesListView.SelectedIndexChanged += new System.EventHandler(this.AllQuotesListView_SelectedIndexChanged);
            // 
            // AllQuotesDataGridView
            // 
            this.AllQuotesDataGridView.AllowUserToAddRows = false;
            this.AllQuotesDataGridView.AllowUserToDeleteRows = false;
            this.AllQuotesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllQuotesDataGridView.Location = new System.Drawing.Point(44, 393);
            this.AllQuotesDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.AllQuotesDataGridView.Name = "AllQuotesDataGridView";
            this.AllQuotesDataGridView.ReadOnly = true;
            this.AllQuotesDataGridView.Size = new System.Drawing.Size(757, 334);
            this.AllQuotesDataGridView.TabIndex = 13;
            // 
            // LoadDataGridViewButton
            // 
            this.LoadDataGridViewButton.Location = new System.Drawing.Point(44, 347);
            this.LoadDataGridViewButton.Margin = new System.Windows.Forms.Padding(5);
            this.LoadDataGridViewButton.Name = "LoadDataGridViewButton";
            this.LoadDataGridViewButton.Size = new System.Drawing.Size(757, 36);
            this.LoadDataGridViewButton.TabIndex = 14;
            this.LoadDataGridViewButton.Text = "Use DataGridView Object - Load";
            this.LoadDataGridViewButton.UseVisualStyleBackColor = true;
            this.LoadDataGridViewButton.Click += new System.EventHandler(this.LoadDataGridViewButton_Click);
            // 
            // LoadListViewButton
            // 
            this.LoadListViewButton.Location = new System.Drawing.Point(49, 14);
            this.LoadListViewButton.Margin = new System.Windows.Forms.Padding(5);
            this.LoadListViewButton.Name = "LoadListViewButton";
            this.LoadListViewButton.Size = new System.Drawing.Size(752, 33);
            this.LoadListViewButton.TabIndex = 15;
            this.LoadListViewButton.Text = "Use ListView Object - Load";
            this.LoadListViewButton.UseVisualStyleBackColor = true;
            this.LoadListViewButton.Click += new System.EventHandler(this.LoadListViewButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(809, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "&Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.ReturnButton;
            this.ClientSize = new System.Drawing.Size(902, 733);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoadListViewButton);
            this.Controls.Add(this.LoadDataGridViewButton);
            this.Controls.Add(this.AllQuotesDataGridView);
            this.Controls.Add(this.AllQuotesListView);
            this.Controls.Add(this.ReturnButton);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewAllQuotes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk .:|:. View All Quotes";
            ((System.ComponentModel.ISupportInitialize)(this.AllQuotesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.ListView AllQuotesListView;
        private System.Windows.Forms.DataGridView AllQuotesDataGridView;
        private System.Windows.Forms.Button LoadDataGridViewButton;
        private System.Windows.Forms.Button LoadListViewButton;
        private System.Windows.Forms.Button button1;
    }
}