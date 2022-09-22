using System.Text.Json;
using System.Text.Json.Nodes;
using JsonValidator.App.Models;

namespace JsonValidator.App.Services
{
    public class JsonValidatorService
    {
        public ValidationInfo ValidateJson(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return ValidationInfo.Failed("Empty value");
            }

            if (!ValidateBasicStructure(input))
            {
                return ValidationInfo.Failed("JSON value does not start or ends with { or ]");
            }

            try
            {
                var tmpObj = JsonValue.Parse(input, documentOptions: AppSettings.CreateJsonDocumentOptions());
                return ValidationInfo.Successful();
            }
            catch (FormatException fex)
            {
                return ValidationInfo.Failed(fex.Message);
            }
            catch (JsonException jsonex) //some other exception
            {
                return new ValidationInfo(jsonex.Message, jsonex.LineNumber, jsonex.BytePositionInLine, false);
            }
            catch (Exception ex) //some other exception
            {
                return ValidationInfo.Failed(ex.Message);
            }
        }

        private static bool ValidateBasicStructure(string jsonInput)
        {
            jsonInput = jsonInput.Trim();

            return (jsonInput.StartsWith("{") && jsonInput.EndsWith("}")) ||
                (jsonInput.StartsWith("[") && jsonInput.EndsWith("]"));
        }
    }
}