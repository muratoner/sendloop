using System.ComponentModel;

namespace Sendloop.Result {
    public enum ErrorCode {
        [Description("Invalid response format")]
        InvalidResponseFormat = 100,
        [Description("Invalid API command")]
        InvalidApiCommand = 101,
        [Description("API command module not found")]
        ApiCommandModuleNotFound = 102,
        [Description("IP address is not authorized to the API connection")]
        IpAddressIsNotAuthorizedToTheApiConnection = 103,
        [Description("Invalid API key")]
        InvalidApiKey = 104,
        [Description("Required parameter(s) missing")]
        RequiredParametersMissing = 105,
        [Description("Requested data not found")]
        RequestedDataNotFound = 106,
        [Description("Invalid sender email address domain")]
        InvalidSenderEmailAddressDomain = 107,
        [Description("Provided domain has been already authenticated")]
        ProvidedDomanHasBeenAlreadyAuthenticated = 108
    }
}
