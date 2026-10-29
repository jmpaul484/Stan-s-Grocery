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
                        listBox1.Items.Add(reader.ReadLine());
                        temp = reader.ReadLine().Split(',');
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
    }
}
