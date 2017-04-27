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
        ProvidedDomanHasBeenAlreadyAuthenticated = 108,
        [Description("Entered username has been already registered for another customer")]
        UsernameHasBeenAlready = 110,
        [Description("Invalid email address format")]
        InvalidEmailAddressFormat = 111,
        [Description("No customer account for the provided ID number")]
        NoCustomerAccountForTheProvidedIdNumber = 112,
        [Description("Invalid username")]
        InvalidUsername = 113,
        [Description("Invalid email address")]
        InvalidEmailAddress = 114,
        [Description("Invalid password")]
        InvalidPassword = 115,
        [Description("Invalid parameter value provided. Please check the related API documentation and pass parameter values correctly")]
        InvalidParameterValueProvided = 116,
        [Description("There are currently campaigns sending to the selected list. Please wait until the delivery gets finished")]
        ThereAreCurrentlyCampaignsSendingSelectedList = 117,
        [Description("Invalid List ID. List not found.")]
        InvalidListId = 118,
        [Description("BounceType value should be 'hard' or 'soft'.")]
        BounceTypeValueShouldBeHardOrSoft = 119,
        [Description("Website integration settings not found for the requested list ID")]
        WebsiteIntegrationSettingsNotFound = 120,
        [Description("Invalid segment ID")]
        InvalidSegmentId = 121,
        [Description("RemoveType must be set as 'all', 'segment' or 'specific'")]
        RemoveTypeMustBeSet = 122,
        [Description("This API command has been disabled")]
        ThisApiCommandHasBeenDisabled = 123,
        [Description("Invalid email address format")]
        InvalidEmailAddressFormat2 = 124,
        [Description("Email address already exists in the list")]
        EmailAddressAlreadyExitsInTheList = 125,
        [Description("Invalid email address")]
        InvalidEmailAddress3 = 126,
        [Description("No subscriber record found for the provided email address and list ID")]
        NoSubscriberRecordFound = 127,
        [Description("Invalid email address format")]
        InvalidEmailAddressFormat4 = 128,
        [Description("Invalid custom field type")]
        InvalidCustomFieldType = 129,
        [Description("Invalid custom field data type")]
        InvalidCustomFieldDataType = 130,
        [Description("FieldOptions field is missing")]
        FieldOptionsFieldIsMissing = 131,
        [Description("The provided FieldOption values and format is incorrect")]
        TheProvidedFieldOptionValuesAndFormatIsIncorrect = 132,
        [Description("Invalid segment operator")]
        InvalidSegmentOperator = 133,
        [Description("Segment rules are missing or incorrectly formatted")]
        SegmentRulesAreIncorrectly = 134,
        [Description("Custom field not found")]
        CustomFieldNotFound = 135,
        [Description("Segment not found")]
        SegmentNotFound = 136,
        [Description("Email address can not sent from from/reply-to name fields")]
        EmailAddressCanNotSent = 137,
        [Description("At least TargetListIDs or TargetSegmentIDs (or both) must be sent")]
        AtLeastListOrSegmentIdMustBeSent = 138,
        [Description("One of the provided subscriber lists not found")]
        OneOfTheProvidedSubscriberListsNotFound = 139,
        [Description("One of the provided segments not found")]
        OneOfTheProvidedSegmentsNotFound = 140,
        [Description("Invalid customer ID")]
        InvalidCustomerId = 141,
        [Description("Subject is too long. Keep it shorter.")]
        SubjectIsTooLong = 142,
        [Description("Subject contains illegal words or too short")]
        SubjectContainsIllegalWordsOrTooShort = 143,
        [Description("Unsubscription link is missing in email content")]
        UnsubscriptionLinkIsMissingInEmailContent = 144,
        [Description("The HTML content of your email campaign contains script, flash or java.")]
        TheHtmlContentContainsScriptFlashOrJava = 145,
        [Description("Unsubscription link text must be longer than 3 characters")]
        UnsubscriptionLinkTextMustBeLonger = 146,
        [Description("Trial period expired. Please upgrade your account to access API.")]
        TrialPeriodExpired = 147,
        [Description("Invalid login credentials.")]
        InvalidLoginCredentials = 148,
        [Description("User is not active.")]
        UserIsNotActive = 149,
        [Description("Too many signup attempts. Wait for a while.")]
        TooManySignupAttemps = 150,
        [Description("One or more personalization tags are invalid in subject, plain or HTML email content.")]
        OneOrMorePersonalizationTagsAreInvalidInSubject = 151,
        [Description("There's a problem with your from and/or reply-to email addresses")]
        TheresAProblemEmailAddresses = 152,
        [Description("Email subject cannot be empty")]
        EmailSubjectCannotBeEmpty = 153,
        [Description("Email must include HTML, plain text or both content parts. An empty email can not be created.")]
        EmailMustBeIncludeHtml = 154,
        [Description("HTML email content is empty")]
        HtmlEmailContentIsEmpty = 155,
        [Description("Unsubscription link is missing in HTML email content.")]
        UnsubcriptionLinkMissingInHtmlEmailContent = 156,
        [Description("Plain text email content is empty")]
        PlainTextEmailContentIsEmpty = 157,
        [Description("Unsubscription link is missing in plain text email content.")]
        UnsubscriptionLinkIsMissingContent = 158,
        [Description("The HTML content of your email has invalid image urls")]
        TheHtmlContentInvalidImageUrls = 159,
        [Description("The HTML content of your email campaign contains script, flash or java")]
        TheHtmlContentContainsScriptFlashOrJava2 = 160,
        [Description("You need to complete profile setup first. Login to your Sendloop account and go to profile settings section.")]
        YouNeedToCompleteProfileSetupFirst = 161
    }
}
