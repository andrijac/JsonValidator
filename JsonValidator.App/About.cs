namespace JsonValidator.App
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void BtnOkClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LinkSourceLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkSource.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/andrijac/JsonValidator");
        }
    }
}