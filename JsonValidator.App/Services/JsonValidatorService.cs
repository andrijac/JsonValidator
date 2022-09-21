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
                var tmpObj = JsonValue.Parse(input);
                return ValidationInfo.Successful();
            }
            catch (FormatException fex)
            {
                return ValidationInfo.Failed(fex.Message);
            }
            catch (System.Text.Json.JsonException jsonex) //some other exception
            {
                return new ValidationInfo(jsonex.Message, jsonex.LineNumber, jsonex.BytePositionInLine, false);
            }
            catch (Exception ex) //some other exception
            {
                return ValidationInfo.Failed(ex.Message);
            }
        }

        private bool ValidateBasicStructure(string strInput)
        {
            strInput = strInput.Trim();

            return (strInput.StartsWith("{") && strInput.EndsWith("}")) ||
                (strInput.StartsWith("[") && strInput.EndsWith("]"));
        }
    }
}