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
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            SearchTextBox = new TextBox();
            FilterComboBox = new ComboBox();
            MenuStrip1 = new MenuStrip();
            ToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            MainToolTip = new ToolTip(components);
            FilterByAisleRadioButton = new RadioButton();
            FilterByCategoryRadioButton = new RadioButton();
            SearchButton = new Button();
            MenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 106);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(747, 529);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchTextBox.Location = new Point(347, 36);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(193, 31);
            SearchTextBox.TabIndex = 1;
            SearchTextBox.Text = "Search";
            SearchTextBox.MouseClick += SearchTextBox_Clicked;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // FilterComboBox
            // 
            FilterComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FilterComboBox.FormattingEnabled = true;
            FilterComboBox.Location = new Point(546, 36);
            FilterComboBox.Name = "FilterComboBox";
            FilterComboBox.Size = new Size(213, 33);
            FilterComboBox.TabIndex = 2;
            FilterComboBox.Text = "Filter";
            FilterComboBox.SelectedIndexChanged += FilterComboBox_SelectedIndexChanged;
            // 
            // MenuStrip1
            // 
            MenuStrip1.ImageScalingSize = new Size(24, 24);
            MenuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem });
            MenuStrip1.Location = new Point(0, 0);
            MenuStrip1.Name = "MenuStrip1";
            MenuStrip1.Size = new Size(771, 33);
            MenuStrip1.TabIndex = 3;
            MenuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchToolStripMenuItem, exitToolStripMenuItem, helpToolStripMenuItem, aboutToolStripMenuItem });
            ToolStripMenuItem.Name = "ToolStripMenuItem";
            ToolStripMenuItem.Size = new Size(54, 29);
            ToolStripMenuItem.Text = "File";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(166, 34);
            searchToolStripMenuItem.Text = "Search";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(166, 34);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(166, 34);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(166, 34);
            aboutToolStripMenuItem.Text = "About";
            // 
            // FilterByAisleRadioButton
            // 
            FilterByAisleRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FilterByAisleRadioButton.AutoSize = true;
            FilterByAisleRadioButton.Location = new Point(347, 73);
            FilterByAisleRadioButton.Name = "FilterByAisleRadioButton";
            FilterByAisleRadioButton.Size = new Size(141, 29);
            FilterByAisleRadioButton.TabIndex = 4;
            FilterByAisleRadioButton.TabStop = true;
            FilterByAisleRadioButton.Text = "Filter By Aisle";
            FilterByAisleRadioButton.UseVisualStyleBackColor = true;
            FilterByAisleRadioButton.CheckedChanged += FilterByAisleRadioButton_CheckedChanged;
            // 
            // FilterByCategoryRadioButton
            // 
            FilterByCategoryRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FilterByCategoryRadioButton.AutoSize = true;
            FilterByCategoryRadioButton.Location = new Point(546, 75);
            FilterByCategoryRadioButton.Name = "FilterByCategoryRadioButton";
            FilterByCategoryRadioButton.Size = new Size(176, 29);
            FilterByCategoryRadioButton.TabIndex = 5;
            FilterByCategoryRadioButton.TabStop = true;
            FilterByCategoryRadioButton.Text = "Filter By Category";
            FilterByCategoryRadioButton.UseVisualStyleBackColor = true;
            FilterByCategoryRadioButton.CheckedChanged += FilterByCategoryRadioButton_CheckedChanged;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(229, 36);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(112, 64);
            SearchButton.TabIndex = 6;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // StansGrocery
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 650);
            Controls.Add(SearchButton);
            Controls.Add(FilterByCategoryRadioButton);
            Controls.Add(FilterByAisleRadioButton);
            Controls.Add(FilterComboBox);
            Controls.Add(SearchTextBox);
            Controls.Add(listBox1);
            Controls.Add(MenuStrip1);
            MainMenuStrip = MenuStrip1;
            Name = "StansGrocery";
            Text = "Stan's Grocery";
            MenuStrip1.ResumeLayout(false);
            MenuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox SearchTextBox;
        private ComboBox FilterComboBox;
        private MenuStrip MenuStrip1;
        private ToolStripMenuItem ToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolTip MainToolTip;
        private RadioButton FilterByAisleRadioButton;
        private RadioButton FilterByCategoryRadioButton;
        private Button SearchButton;
    }
}
