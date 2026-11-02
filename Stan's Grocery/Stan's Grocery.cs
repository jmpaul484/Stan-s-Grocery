//Jonathan Paul
//RCET2265
// Fall 2026
//https://github.com/jmpaul484/Stan-s-Grocery.git
namespace Stan_s_Grocery
{
    public partial class StansGrocery : Form
    {
        public StansGrocery()
        {
            InitializeComponent();
            GroceryItems = new string[CountLinesIn(currentFile), 3];
            ReadWholeFile();
        }
        static string currentFile = "Grocery.txt";

        static string[,] GroceryItems;
        int CountLinesIn(string path)
        {
            int count = 0;
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        reader.ReadLine();
                        ++count;
                    }
                }
            }
            catch (Exception e)
            {
                //pass
                MessageBox.Show(e.Message, "Error");
            }
            return count;
        }
        void ReadWholeFile()
        {
            int index = 0;
            string[] temp;
            try
            {
                using (StreamReader reader = new StreamReader(currentFile))
                {
                    while (!reader.EndOfStream)
                    {
                        string currentLine = reader.ReadLine();

                        // Split and clean the text FIRST
                        temp = currentLine.Split(',')
                                          .Select(text => text.Replace("\"", "").Replace("$", "").Replace("ITM", "").Replace("##LOC", "").Replace("%%CAT", ""))
                                          .ToArray();

                        // Add the CLEANED text to the ListBox
                        DisplayBox.Items.Add(string.Join(", ", temp));

                        // Assign the cleaned values to 2D array
                        GroceryItems[index, 0] = temp[0];
                        GroceryItems[index, 1] = temp[1];
                        GroceryItems[index, 2] = temp[2];

                        index++;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(e.StackTrace);
            }
        }

        void Searching()
        {
            string searchText = SearchTextBox.Text.Trim();

            DisplayBox.Items.Clear();

            for (int index = 0; index < GroceryItems.GetLength(0); index++)
            {
                string itemName = GroceryItems[index, 0];

                if (string.IsNullOrWhiteSpace(searchText) ||
                    itemName.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayBox.Items.Add(string.Join(", ",
                        GroceryItems[index, 0],
                        GroceryItems[index, 1],
                        GroceryItems[index, 2]));
                }
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "zzz")
            {
                Close();
            }



        }
        private void SearchTextBox_Clicked(object sender, MouseEventArgs e)
        {
            if (SearchTextBox.Text == "Search")
            {
                SearchTextBox.Clear();
            }
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure an item is actually selected in the dropdown
            if (FilterComboBox.SelectedIndex < 0) return;

            string selectedFilter = FilterComboBox.SelectedItem.ToString();
            DisplayBox.Items.Clear();

            // Determine which column to check based on the active radio button
            int columnIndex = FilterByAisleRadioButton.Checked ? 1 : 2;

            for (int index = 0; index < GroceryItems.GetLength(0); index++)
            {
                // Filter against the correct column
                if (GroceryItems[index, columnIndex].Equals(selectedFilter, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayBox.Items.Add(string.Join(", ",
                        GroceryItems[index, 0],
                        GroceryItems[index, 1],
                        GroceryItems[index, 2]));
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. Check if an item is actually selected to prevent errors
            if (DisplayBox.SelectedItem != null)
            {
                // 2. Change 'YourLabelName' to the actual name of your Label control
                DisplayLabel.Text = ($"{DisplayBox.SelectedItem.ToString()}");
            }
        }

        private void FilterByAisleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!FilterByAisleRadioButton.Checked)
            {
                return;
            }

            FilterComboBox.Items.Clear();

            var aisles = GroceryItems.Cast<string>()
                .Where((value, index) => index % GroceryItems.GetLength(1) == 1)
                .Where(value => !string.IsNullOrWhiteSpace(value))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(value => value);

            FilterComboBox.Items.AddRange(aisles.ToArray());
            FilterComboBox.SelectedIndex = -1;
            FilterComboBox.Text = "Filter";
        }

        private void FilterByCategoryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!FilterByCategoryRadioButton.Checked)
            {
                return;
            }

            FilterComboBox.Items.Clear();

            var categories = GroceryItems.Cast<string>()
                .Where((value, index) => index % GroceryItems.GetLength(1) == 2)
                .Where(value => !string.IsNullOrWhiteSpace(value))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(value => value);

            FilterComboBox.Items.AddRange(categories.ToArray());
            FilterComboBox.SelectedIndex = -1;
            FilterComboBox.Text = "Filter";

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Searching();

            // Check if the search yielded zero items
            if (DisplayBox.Items.Count == 0)
            {
                DisplayBox.Items.Add($"Sorry no matches for {SearchTextBox.Text}");
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            DisplayBox.Items.Clear();
            FilterByCategoryRadioButton.Checked = false;
            FilterByAisleRadioButton.Checked = false;
            FilterComboBox.Items.Clear();
            FilterComboBox.Text = "Filter";
            SearchTextBox.Text = "Search";
            ReadWholeFile();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Searching();

            // Check if the search yielded zero items
            if (DisplayBox.Items.Count == 0)
            {
                DisplayBox.Items.Add($"Sorry no matches for {SearchTextBox.Text}");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Searching();

            // Check if the search yielded zero items
            if (DisplayBox.Items.Count == 0)
            {
                DisplayBox.Items.Add($"Sorry no matches for {SearchTextBox.Text}");
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
