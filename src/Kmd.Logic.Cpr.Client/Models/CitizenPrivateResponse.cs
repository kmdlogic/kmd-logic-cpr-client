// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.Cpr.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CitizenPrivateResponse
    {
        /// <summary>
        /// Initializes a new instance of the CitizenPrivateResponse class.
        /// </summary>
        public CitizenPrivateResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CitizenPrivateResponse class.
        /// </summary>
        public CitizenPrivateResponse(string cpr = default(string), string firstName = default(string), string lastName = default(string), string middleName = default(string), LegalGuardianPrivate legalGuardian = default(LegalGuardianPrivate), DepartureAndEntry departureAndEntry = default(DepartureAndEntry), ContactAddress contactAddress = default(ContactAddress), AddressInformation addressInformation = default(AddressInformation), bool? nameAndAddressProtection = default(bool?), string status = default(string), System.DateTime? statusDate = default(System.DateTime?), bool? statusDateUncertainityMarking = default(bool?), string firstNameMarking = default(string), string middleNameMarking = default(string), string lastNameMarking = default(string))
        {
            Cpr = cpr;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            LegalGuardian = legalGuardian;
            DepartureAndEntry = departureAndEntry;
            ContactAddress = contactAddress;
            AddressInformation = addressInformation;
            NameAndAddressProtection = nameAndAddressProtection;
            Status = status;
            StatusDate = statusDate;
            StatusDateUncertainityMarking = statusDateUncertainityMarking;
            FirstNameMarking = firstNameMarking;
            MiddleNameMarking = middleNameMarking;
            LastNameMarking = lastNameMarking;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cpr")]
        public string Cpr { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "middleName")]
        public string MiddleName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "legalGuardian")]
        public LegalGuardianPrivate LegalGuardian { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "departureAndEntry")]
        public DepartureAndEntry DepartureAndEntry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactAddress")]
        public ContactAddress ContactAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "addressInformation")]
        public AddressInformation AddressInformation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "nameAndAddressProtection")]
        public bool? NameAndAddressProtection { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statusDate")]
        public System.DateTime? StatusDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statusDateUncertainityMarking")]
        public bool? StatusDateUncertainityMarking { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "firstNameMarking")]
        public string FirstNameMarking { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "middleNameMarking")]
        public string MiddleNameMarking { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastNameMarking")]
        public string LastNameMarking { get; set; }

    }
}