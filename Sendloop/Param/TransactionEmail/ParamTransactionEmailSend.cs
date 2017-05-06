namespace Sendloop.Param.TransactionEmail {
    public class ParamTransactionEmailSend {
        /// <summary>
        /// [required]
        /// Sender email address.
        /// </summary>
        public string From { get; set; }
        /// <summary>
        /// [required]
        /// Sender name.
        /// </summary>
        public string FromName { get; set; }
        /// <summary>
        /// [required]
        /// Reply-to email address. Replies will be sent to this address.
        /// </summary>
        public string ReplyTo { get; set; }
        /// <summary>
        /// [required]
        /// Name of the reply-to email address.
        /// </summary>
        public string ReplyToName { get; set; }
        /// <summary>
        /// [required]
        /// Recipient email address.
        /// </summary>
        public string To { get; set; }
        /// <summary>
        /// [optional]
        /// Recipient name.
        /// </summary>
        public string ToName { get; set; }
        /// <summary>
        /// [required]
        /// Subject of the email.
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// [required]
        /// Plain text body of the email. This parameter is optional if you have defined a HTMLBody parameter.
        /// </summary>
        public string TextBody { get; set; }
        /// <summary>
        /// [required]
        /// HTML body of the email. This parameter is optional if you have defined the TextBody parameter.
        /// </summary>
        public string HtmlBody { get; set; }
        /// <summary>
        /// [optional]
        /// Custom arguments you want to store for this message. 
        /// These custom arguments will be sent back to you with web hooks upon request. 
        /// Custom arguments must be in a key/value pair, example: {'key1':'val1', 'key2':'val2'}
        /// </summary>
        public string CustomArgs { get; set; }
        /// <summary>
        /// [optional]
        /// Merge variables are used to personalize the email being sent. 
        /// These custom arguments will be sent back to you with web hooks upon request. 
        /// Merge variables must be in key/value pair, Example: {"firstname":"John", "lastname":"Doe", "%my_variable%": "MyValue"}
        /// </summary>
        public string MergeVars { get; set; }
        /// <summary>
        /// [optional]
        /// Tags are used to categorize the email being sent. 
        /// These custom tags, can be used for grouping statistics and analyze further. 
        /// Example: ["password_reset_email", "welcome_email"]
        /// </summary>
        public string Tags { get; set; }
        /// <summary>
        /// [optional]
        /// Enable Open Tracking. Values can be, "1", "true", "on" and "yes" to enable, "0", "false", "off" and "no" to disable. 
        /// Open Tracking is disabled by default. See [Tracking] section for further information.
        /// </summary>
        public string TrackOpens { get; set; }
        /// <summary>
        /// [optional]
        /// Enable Link Tracking. Values can be, "1", "true", "on" and "yes" to enable, "0", "false", "off" and "no" to disable. 
        /// Link / Click Tracking is disabled by default. See [Tracking] section for further information.
        /// </summary>
        public string TrackClicks { get; set; }
        /// <summary>
        /// [optional]
        /// Enable Google Analytics Tracking. Values can be, "1", "true", "on" and "yes" to enable, "0", "false", "off" and "no" to disable. 
        /// Google Analytics Tracking is disabled by default. [Tracking] section for further information.
        /// </summary>
        public string TrackGA { get; set; }
        /// <summary>
        /// [optional]
        /// Define files to be attached to your emails.
        /// </summary>
        public string[] Attachments { get; set; }
        /// <summary>
        /// [optional]
        /// Define files and images to be embedded into your email content.
        /// </summary>
        public string[] Embeds { get; set; }
    }
}
