namespace Stan_s_Grocery
{
    partial class StansGrocery
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            SearchTextBox = new TextBox();
            FilterComboBox = new ComboBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(574, 56);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(412, 529);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(574, 12);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(193, 31);
            SearchTextBox.TabIndex = 1;
            SearchTextBox.Text = "Search";
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // FilterComboBox
            // 
            FilterComboBox.FormattingEnabled = true;
            FilterComboBox.Location = new Point(773, 12);
            FilterComboBox.Name = "FilterComboBox";
            FilterComboBox.Size = new Size(213, 33);
            FilterComboBox.TabIndex = 2;
            FilterComboBox.Text = "Filter";
            FilterComboBox.SelectedIndexChanged += FilterComboBox_SelectedIndexChanged;
            // 
            // StansGrocery
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 597);
            Controls.Add(FilterComboBox);
            Controls.Add(SearchTextBox);
            Controls.Add(listBox1);
            Name = "StansGrocery";
            Text = "Stan's Grocery";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox SearchTextBox;
        private ComboBox FilterComboBox;
    }
}
