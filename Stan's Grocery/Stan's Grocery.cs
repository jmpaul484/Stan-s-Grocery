namespace Stan_s_Grocery
{
    public partial class StansGrocery : Form
    {
        public StansGrocery()
        {
            InitializeComponent();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            
            if(SearchTextBox.Text == "zzz")
            {
                Close();
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
