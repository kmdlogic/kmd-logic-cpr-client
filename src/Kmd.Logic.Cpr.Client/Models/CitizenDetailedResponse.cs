// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.Cpr.Client.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class CitizenDetailedResponse
    {
        /// <summary>
        /// Initializes a new instance of the CitizenDetailedResponse class.
        /// </summary>
        public CitizenDetailedResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CitizenDetailedResponse class.
        /// </summary>
        public CitizenDetailedResponse(System.Guid id, bool nameAndAddressProtection, string firstName = default(string), string lastName = default(string), string middleName = default(string), string cpr = default(string), string maritalStatus = default(string), System.DateTime? fromMarriedDate = default(System.DateTime?), bool? fromMarriedUncertainityMarking = default(bool?), string status = default(string), IList<Parent> parents = default(IList<Parent>), IList<LegalGuardian> legalGuardians = default(IList<LegalGuardian>), IList<AddressResponse> addresses = default(IList<AddressResponse>), IList<Citizenship> citizenships = default(IList<Citizenship>), string addressingName = default(string), System.DateTime? dateOfBirth = default(System.DateTime?), bool? dateOfBirthUncertainityMarking = default(bool?), string birthRegistrationLocationCode = default(string), string birthRegistrationLocationName = default(string), string supplementalBirthRegistartionPlace = default(string), string sex = default(string), string position = default(string), System.DateTime? statusDate = default(System.DateTime?), bool? statusDateUncertainityMarking = default(bool?), IList<Children> children = default(IList<Children>), string firstNameMarking = default(string), string middleNameMarking = default(string), string lastNameMarking = default(string), SpouseDetails spouse = default(SpouseDetails))
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Cpr = cpr;
            MaritalStatus = maritalStatus;
            FromMarriedDate = fromMarriedDate;
            FromMarriedUncertainityMarking = fromMarriedUncertainityMarking;
            Status = status;
            Parents = parents;
            LegalGuardians = legalGuardians;
            NameAndAddressProtection = nameAndAddressProtection;
            Addresses = addresses;
            Citizenships = citizenships;
            AddressingName = addressingName;
            DateOfBirth = dateOfBirth;
            DateOfBirthUncertainityMarking = dateOfBirthUncertainityMarking;
            BirthRegistrationLocationCode = birthRegistrationLocationCode;
            BirthRegistrationLocationName = birthRegistrationLocationName;
            SupplementalBirthRegistartionPlace = supplementalBirthRegistartionPlace;
            Sex = sex;
            Position = position;
            StatusDate = statusDate;
            StatusDateUncertainityMarking = statusDateUncertainityMarking;
            Children = children;
            FirstNameMarking = firstNameMarking;
            MiddleNameMarking = middleNameMarking;
            LastNameMarking = lastNameMarking;
            Spouse = spouse;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

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
        [JsonProperty(PropertyName = "cpr")]
        public string Cpr { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maritalStatus")]
        public string MaritalStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fromMarriedDate")]
        public System.DateTime? FromMarriedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fromMarriedUncertainityMarking")]
        public bool? FromMarriedUncertainityMarking { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parents")]
        public IList<Parent> Parents { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "legalGuardians")]
        public IList<LegalGuardian> LegalGuardians { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "nameAndAddressProtection")]
        public bool NameAndAddressProtection { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "addresses")]
        public IList<AddressResponse> Addresses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "citizenships")]
        public IList<Citizenship> Citizenships { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "addressingName")]
        public string AddressingName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dateOfBirth")]
        public System.DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dateOfBirthUncertainityMarking")]
        public bool? DateOfBirthUncertainityMarking { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "birthRegistrationLocationCode")]
        public string BirthRegistrationLocationCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "birthRegistrationLocationName")]
        public string BirthRegistrationLocationName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "supplementalBirthRegistartionPlace")]
        public string SupplementalBirthRegistartionPlace { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sex")]
        public string Sex { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public string Position { get; set; }

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
        [JsonProperty(PropertyName = "children")]
        public IList<Children> Children { get; set; }

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

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spouse")]
        public SpouseDetails Spouse { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
