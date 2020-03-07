// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ManagedServiceIdentity.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes an identity resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class IdentityUpdate : Resource
    {
        /// <summary>
        /// Initializes a new instance of the IdentityUpdate class.
        /// </summary>
        public IdentityUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IdentityUpdate class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="tenantId">The id of the tenant which the identity
        /// belongs to.</param>
        /// <param name="principalId">The id of the service principal object
        /// associated with the created identity.</param>
        /// <param name="clientId">The id of the app associated with the
        /// identity. This is a random generated UUID by MSI.</param>
        public IdentityUpdate(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), System.Guid? tenantId = default(System.Guid?), System.Guid? principalId = default(System.Guid?), System.Guid? clientId = default(System.Guid?))
            : base(id, name, type)
        {
            Location = location;
            Tags = tags;
            TenantId = tenantId;
            PrincipalId = principalId;
            ClientId = clientId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the geo-location where the resource lives
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets the id of the tenant which the identity belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tenantId")]
        public System.Guid? TenantId { get; private set; }

        /// <summary>
        /// Gets the id of the service principal object associated with the
        /// created identity.
        /// </summary>
        [JsonProperty(PropertyName = "properties.principalId")]
        public System.Guid? PrincipalId { get; private set; }

        /// <summary>
        /// Gets the id of the app associated with the identity. This is a
        /// random generated UUID by MSI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clientId")]
        public System.Guid? ClientId { get; private set; }

    }
}