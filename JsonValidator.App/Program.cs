using JsonValidator.App.Services;

namespace JsonValidator.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            JsonValidatorService jsonValidatorService = new();
            RichTextBoxService richTextBoxService = new();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(jsonValidatorService, richTextBoxService));
        }
    }
}