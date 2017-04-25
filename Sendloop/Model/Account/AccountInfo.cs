using System;

namespace Sendloop.Model.Account {
    public class AccountInfo {
        public string Username { get; set; }
        public string Subdomain { get; set; }
        public DateTime MemberSince { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string Website { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string TimeZone { get; set; }
        public string SignUpIP { get; set; }
        public string Language { get; set; }
        /// <summary>
        /// TODO: Type convert to datetime.
        /// </summary>
        public string LastActivityDateTime { get; set; }
        /// <summary>
        /// TODO: Type convert to datetime.
        /// </summary>
        public string LastAccountUpdateDate { get; set; }
        public string EmailVerificationStatus { get; set; }
    }
}
