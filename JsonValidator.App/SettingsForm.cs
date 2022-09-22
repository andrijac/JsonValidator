using JsonValidator.App.Models;

namespace JsonValidator.App
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            SmallFormHelper.SetProperties(this);
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOkClick(object sender, EventArgs e)
        {
            AppSettings.JsonAllowComments = this.cbJsonAllowComments.Checked;
            AppSettings.JsonAllowTrailingCommas = this.cbJsonAllowTrailingCommas.Checked;

            AppSettings.Save();
            this.Close();
        }

        private void SettingsFormLoad(object sender, EventArgs e)
        {
            this.cbJsonAllowComments.Checked = AppSettings.JsonAllowComments;
            this.cbJsonAllowTrailingCommas.Checked = AppSettings.JsonAllowTrailingCommas;
        }
    }
}