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

                        // 1. Split and clean the text FIRST
                        temp = currentLine.Split(',')
                                          .Select(text => text.Replace("\"", "").Replace("$", "").Replace("ITM", "").Replace("##LOC", "").Replace("%%CAT", ""))
                                          .ToArray();

                        // 2. Add the CLEANED text to the ListBox
                        listBox1.Items.Add(string.Join(", ", temp));

                        // 3. Assign the cleaned values to 2D array
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

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "zzz")
            {
                Close();
            }

            string searchText = SearchTextBox.Text.Trim();

            listBox1.Items.Clear();

            for (int index = 0; index < GroceryItems.GetLength(0); index++)
            {
                string itemName = GroceryItems[index, 0];

                if (string.IsNullOrWhiteSpace(searchText) ||
                    itemName.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    listBox1.Items.Add(string.Join(", ",
                        GroceryItems[index, 0],
                        GroceryItems[index, 1],
                        GroceryItems[index, 2]));
                }
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

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
