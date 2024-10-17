// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class CloudPcOnPremisesConnection : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The fully qualified domain name (FQDN) of the Active Directory domain you want to join. Maximum length is 255. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdDomainName
        {
            get { return BackingStore?.Get<string?>("adDomainName"); }
            set { BackingStore?.Set("adDomainName", value); }
        }
#nullable restore
#else
        public string AdDomainName
        {
            get { return BackingStore?.Get<string>("adDomainName"); }
            set { BackingStore?.Set("adDomainName", value); }
        }
#endif
        /// <summary>The password associated with the username of an Active Directory account (adDomainUsername).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdDomainPassword
        {
            get { return BackingStore?.Get<string?>("adDomainPassword"); }
            set { BackingStore?.Set("adDomainPassword", value); }
        }
#nullable restore
#else
        public string AdDomainPassword
        {
            get { return BackingStore?.Get<string>("adDomainPassword"); }
            set { BackingStore?.Set("adDomainPassword", value); }
        }
#endif
        /// <summary>The username of an Active Directory account (user or service account) that has permission to create computer objects in Active Directory. Required format: admin@contoso.com. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdDomainUsername
        {
            get { return BackingStore?.Get<string?>("adDomainUsername"); }
            set { BackingStore?.Set("adDomainUsername", value); }
        }
#nullable restore
#else
        public string AdDomainUsername
        {
            get { return BackingStore?.Get<string>("adDomainUsername"); }
            set { BackingStore?.Set("adDomainUsername", value); }
        }
#endif
        /// <summary>The interface URL of the partner service&apos;s resource that links to this Azure network connection. Returned only on $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlternateResourceUrl
        {
            get { return BackingStore?.Get<string?>("alternateResourceUrl"); }
            set { BackingStore?.Set("alternateResourceUrl", value); }
        }
#nullable restore
#else
        public string AlternateResourceUrl
        {
            get { return BackingStore?.Get<string>("alternateResourceUrl"); }
            set { BackingStore?.Set("alternateResourceUrl", value); }
        }
#endif
        /// <summary>Specifies how the provisioned Cloud PC joins to Microsoft Entra. It includes different types, one is Microsoft Entra ID join, which means there&apos;s no on-premises Active Directory (AD) in the current tenant, and the Cloud PC device is joined by Microsoft Entra. Another one is hybridAzureADJoin, which means there&apos;s also an on-premises Active Directory (AD) in the current tenant and the Cloud PC device joins to on-premises Active Directory (AD) and Microsoft Entra. The type also determines which types of users can be assigned and can sign into a Cloud PC. The azureADJoin type indicates that cloud-only and hybrid users can be assigned and signed into the Cloud PC. hybridAzureADJoin indicates only hybrid users can be assigned and signed into the Cloud PC. The default value is hybridAzureADJoin.</summary>
        public global::Microsoft.Graph.Models.CloudPcOnPremisesConnectionType? ConnectionType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CloudPcOnPremisesConnectionType?>("connectionType"); }
            set { BackingStore?.Set("connectionType", value); }
        }
        /// <summary>The display name for the Azure network connection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The healthCheckStatus property</summary>
        public global::Microsoft.Graph.Models.CloudPcOnPremisesConnectionStatus? HealthCheckStatus
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CloudPcOnPremisesConnectionStatus?>("healthCheckStatus"); }
            set { BackingStore?.Set("healthCheckStatus", value); }
        }
        /// <summary>Indicates the results of health checks performed on the on-premises connection. Read-only. Returned only on $select. For an example that shows how to get the inUse property, see Example 2: Get the selected properties of an Azure network connection, including healthCheckStatusDetail. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.CloudPcOnPremisesConnectionStatusDetail? HealthCheckStatusDetail
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CloudPcOnPremisesConnectionStatusDetail?>("healthCheckStatusDetail"); }
            set { BackingStore?.Set("healthCheckStatusDetail", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.CloudPcOnPremisesConnectionStatusDetail HealthCheckStatusDetail
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CloudPcOnPremisesConnectionStatusDetail>("healthCheckStatusDetail"); }
            set { BackingStore?.Set("healthCheckStatusDetail", value); }
        }
#endif
        /// <summary>When true, the Azure network connection is in use. When false, the connection isn&apos;t in use. You can&apos;t delete a connection that’s in use. Returned only on $select. For an example that shows how to get the inUse property, see Example 2: Get the selected properties of an Azure network connection, including healthCheckStatusDetail. Read-only.</summary>
        public bool? InUse
        {
            get { return BackingStore?.Get<bool?>("inUse"); }
            set { BackingStore?.Set("inUse", value); }
        }
        /// <summary>The organizational unit (OU) in which the computer account is created. If left null, the OU configured as the default (a well-known computer object container) in the tenant&apos;s Active Directory domain (OU) is used. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationalUnit
        {
            get { return BackingStore?.Get<string?>("organizationalUnit"); }
            set { BackingStore?.Set("organizationalUnit", value); }
        }
#nullable restore
#else
        public string OrganizationalUnit
        {
            get { return BackingStore?.Get<string>("organizationalUnit"); }
            set { BackingStore?.Set("organizationalUnit", value); }
        }
#endif
        /// <summary>The unique identifier of the target resource group used associated with the on-premises network connectivity for Cloud PCs. Required format: &apos;/subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceGroupId
        {
            get { return BackingStore?.Get<string?>("resourceGroupId"); }
            set { BackingStore?.Set("resourceGroupId", value); }
        }
#nullable restore
#else
        public string ResourceGroupId
        {
            get { return BackingStore?.Get<string>("resourceGroupId"); }
            set { BackingStore?.Set("resourceGroupId", value); }
        }
#endif
        /// <summary>The unique identifier of the target subnet used associated with the on-premises network connectivity for Cloud PCs. Required format: &apos;/subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkId}/subnets/{subnetName}&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubnetId
        {
            get { return BackingStore?.Get<string?>("subnetId"); }
            set { BackingStore?.Set("subnetId", value); }
        }
#nullable restore
#else
        public string SubnetId
        {
            get { return BackingStore?.Get<string>("subnetId"); }
            set { BackingStore?.Set("subnetId", value); }
        }
#endif
        /// <summary>The unique identifier of the Azure subscription associated with the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubscriptionId
        {
            get { return BackingStore?.Get<string?>("subscriptionId"); }
            set { BackingStore?.Set("subscriptionId", value); }
        }
#nullable restore
#else
        public string SubscriptionId
        {
            get { return BackingStore?.Get<string>("subscriptionId"); }
            set { BackingStore?.Set("subscriptionId", value); }
        }
#endif
        /// <summary>The name of the Azure subscription is used to create an Azure network connection. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubscriptionName
        {
            get { return BackingStore?.Get<string?>("subscriptionName"); }
            set { BackingStore?.Set("subscriptionName", value); }
        }
#nullable restore
#else
        public string SubscriptionName
        {
            get { return BackingStore?.Get<string>("subscriptionName"); }
            set { BackingStore?.Set("subscriptionName", value); }
        }
#endif
        /// <summary>The unique identifier of the target virtual network used associated with the on-premises network connectivity for Cloud PCs. Required format: &apos;/subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VirtualNetworkId
        {
            get { return BackingStore?.Get<string?>("virtualNetworkId"); }
            set { BackingStore?.Set("virtualNetworkId", value); }
        }
#nullable restore
#else
        public string VirtualNetworkId
        {
            get { return BackingStore?.Get<string>("virtualNetworkId"); }
            set { BackingStore?.Set("virtualNetworkId", value); }
        }
#endif
        /// <summary>Indicates the resource location of the target virtual network. For example, the location can be eastus2, westeurope, etc. Read-only (computed value).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VirtualNetworkLocation
        {
            get { return BackingStore?.Get<string?>("virtualNetworkLocation"); }
            set { BackingStore?.Set("virtualNetworkLocation", value); }
        }
#nullable restore
#else
        public string VirtualNetworkLocation
        {
            get { return BackingStore?.Get<string>("virtualNetworkLocation"); }
            set { BackingStore?.Set("virtualNetworkLocation", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.CloudPcOnPremisesConnection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.CloudPcOnPremisesConnection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.CloudPcOnPremisesConnection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "adDomainName", n => { AdDomainName = n.GetStringValue(); } },
                { "adDomainPassword", n => { AdDomainPassword = n.GetStringValue(); } },
                { "adDomainUsername", n => { AdDomainUsername = n.GetStringValue(); } },
                { "alternateResourceUrl", n => { AlternateResourceUrl = n.GetStringValue(); } },
                { "connectionType", n => { ConnectionType = n.GetEnumValue<global::Microsoft.Graph.Models.CloudPcOnPremisesConnectionType>(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "healthCheckStatus", n => { HealthCheckStatus = n.GetEnumValue<global::Microsoft.Graph.Models.CloudPcOnPremisesConnectionStatus>(); } },
                { "healthCheckStatusDetail", n => { HealthCheckStatusDetail = n.GetObjectValue<global::Microsoft.Graph.Models.CloudPcOnPremisesConnectionStatusDetail>(global::Microsoft.Graph.Models.CloudPcOnPremisesConnectionStatusDetail.CreateFromDiscriminatorValue); } },
                { "inUse", n => { InUse = n.GetBoolValue(); } },
                { "organizationalUnit", n => { OrganizationalUnit = n.GetStringValue(); } },
                { "resourceGroupId", n => { ResourceGroupId = n.GetStringValue(); } },
                { "subnetId", n => { SubnetId = n.GetStringValue(); } },
                { "subscriptionId", n => { SubscriptionId = n.GetStringValue(); } },
                { "subscriptionName", n => { SubscriptionName = n.GetStringValue(); } },
                { "virtualNetworkId", n => { VirtualNetworkId = n.GetStringValue(); } },
                { "virtualNetworkLocation", n => { VirtualNetworkLocation = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("adDomainName", AdDomainName);
            writer.WriteStringValue("adDomainPassword", AdDomainPassword);
            writer.WriteStringValue("adDomainUsername", AdDomainUsername);
            writer.WriteStringValue("alternateResourceUrl", AlternateResourceUrl);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.CloudPcOnPremisesConnectionType>("connectionType", ConnectionType);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.CloudPcOnPremisesConnectionStatus>("healthCheckStatus", HealthCheckStatus);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.CloudPcOnPremisesConnectionStatusDetail>("healthCheckStatusDetail", HealthCheckStatusDetail);
            writer.WriteBoolValue("inUse", InUse);
            writer.WriteStringValue("organizationalUnit", OrganizationalUnit);
            writer.WriteStringValue("resourceGroupId", ResourceGroupId);
            writer.WriteStringValue("subnetId", SubnetId);
            writer.WriteStringValue("subscriptionId", SubscriptionId);
            writer.WriteStringValue("subscriptionName", SubscriptionName);
            writer.WriteStringValue("virtualNetworkId", VirtualNetworkId);
            writer.WriteStringValue("virtualNetworkLocation", VirtualNetworkLocation);
        }
    }
}
#pragma warning restore CS0618
