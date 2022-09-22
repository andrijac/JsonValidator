using System.Text.Json;
using JsonValidator.App.Properties;

namespace JsonValidator.App.Models
{
    public class AppSettings
    {
        public static bool JsonAllowTrailingCommas
        {
            get
            {
                return Settings.Default.Json_AllowTrailingCommas;
            }
            set
            {
                Settings.Default.Json_AllowTrailingCommas = value;
            }
        }

        public static bool JsonAllowComments
        {
            get
            {
                return Settings.Default.Json_AllowComments;
            }
            set
            {
                Settings.Default.Json_AllowComments = value;
            }
        }

        public static void Save()
        {
            Settings.Default.Save();
        }

        public static JsonDocumentOptions CreateJsonDocumentOptions()
        {
            return new JsonDocumentOptions()
            {
                AllowTrailingCommas = JsonAllowTrailingCommas,
                CommentHandling = JsonAllowComments ? JsonCommentHandling.Skip : JsonCommentHandling.Disallow,
            };
        }
    }
}