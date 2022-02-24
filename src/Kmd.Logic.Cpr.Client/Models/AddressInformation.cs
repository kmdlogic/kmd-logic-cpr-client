// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.Cpr.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AddressInformation
    {
        /// <summary>
        /// Initializes a new instance of the AddressInformation class.
        /// </summary>
        public AddressInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AddressInformation class.
        /// </summary>
        public AddressInformation(AddressPrivate address = default(AddressPrivate), string status = default(string), System.DateTime? effectFrom = default(System.DateTime?), bool? effectFromUncertainityMarking = default(bool?))
        {
            Address = address;
            Status = status;
            EffectFrom = effectFrom;
            EffectFromUncertainityMarking = effectFromUncertainityMarking;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public AddressPrivate Address { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectFrom")]
        public System.DateTime? EffectFrom { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectFromUncertainityMarking")]
        public bool? EffectFromUncertainityMarking { get; set; }

    }
}