using System.Text.Json;
using JsonValidator.App.Models;

namespace JsonValidator.App.Services
{
    public class JsonFormaterService
    {
        private readonly JsonValidatorService jsonValidatorService;

        public JsonFormaterService(JsonValidatorService jsonValidatorService)
        {
            this.jsonValidatorService = jsonValidatorService;
        }

        public (ValidationInfo ValidationInfo, string formated) FormatJson(string json)
        {
            ValidationInfo validationInfo = this.jsonValidatorService.ValidateJson(json);

            if (validationInfo.IsSuccessful == false)
            {
                return (validationInfo, "");
            }

            dynamic? parsedJson = JsonSerializer.Deserialize<dynamic>(json);

            var res = JsonSerializer.Serialize(parsedJson!, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            return (ValidationInfo.Successful(), res);
        }
    }
}