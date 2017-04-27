namespace Sendloop.Model.Account {
    public class AccountInfoUpdate {
        /// <summary>
        /// Username for the Sendloop account
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// New password for the Sendloop account
        /// </summary>
        public string NewPassword { get; set; }
        /// <summary>
        /// First name of the account owner
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last name of the account owner
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Email address of the account owner
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Time zone of the account owner. The time zone should be one of the Sendloop's availableSystem.TimeZones.Get options
        /// </summary>
        public string TimeZone { get; set; }
        /// <summary>
        /// Street of the account owner
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        /// City of the account owner
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// State of the account owner
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// Zip/postal code of the account owner
        /// </summary>
        public string Zip { get; set; }
        /// <summary>
        /// Country of the account owner
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// Name of the account owner company
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// Website URL
        /// </summary>
        public string Website { get; set; }
        /// <summary>
        /// Phone number
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Fax number
        /// </summary>
        public string Fax { get; set; }

    }
}
