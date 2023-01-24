using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class UserSecurityState : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>AAD User object identifier (GUID) - represents the physical/multi-account user entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AadUserId {
            get { return BackingStore?.Get<string?>("aadUserId"); }
            set { BackingStore?.Set("aadUserId", value); }
        }
#nullable restore
#else
        public string AadUserId {
            get { return BackingStore?.Get<string>("aadUserId"); }
            set { BackingStore?.Set("aadUserId", value); }
        }
#endif
        /// <summary>Account name of user account (without Active Directory domain or DNS domain) - (also called mailNickName).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountName {
            get { return BackingStore?.Get<string?>("accountName"); }
            set { BackingStore?.Set("accountName", value); }
        }
#nullable restore
#else
        public string AccountName {
            get { return BackingStore?.Get<string>("accountName"); }
            set { BackingStore?.Set("accountName", value); }
        }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>NetBIOS/Active Directory domain of user account (that is, domain/account format).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DomainName {
            get { return BackingStore?.Get<string?>("domainName"); }
            set { BackingStore?.Set("domainName", value); }
        }
#nullable restore
#else
        public string DomainName {
            get { return BackingStore?.Get<string>("domainName"); }
            set { BackingStore?.Set("domainName", value); }
        }
#endif
        /// <summary>For email-related alerts - user account&apos;s email &apos;role&apos;. Possible values are: unknown, sender, recipient.</summary>
        public Microsoft.Graph.Models.EmailRole? EmailRole {
            get { return BackingStore?.Get<Microsoft.Graph.Models.EmailRole?>("emailRole"); }
            set { BackingStore?.Set("emailRole", value); }
        }
        /// <summary>Indicates whether the user logged on through a VPN.</summary>
        public bool? IsVpn {
            get { return BackingStore?.Get<bool?>("isVpn"); }
            set { BackingStore?.Set("isVpn", value); }
        }
        /// <summary>Time at which the sign-in occurred. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LogonDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("logonDateTime"); }
            set { BackingStore?.Set("logonDateTime", value); }
        }
        /// <summary>User sign-in ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LogonId {
            get { return BackingStore?.Get<string?>("logonId"); }
            set { BackingStore?.Set("logonId", value); }
        }
#nullable restore
#else
        public string LogonId {
            get { return BackingStore?.Get<string>("logonId"); }
            set { BackingStore?.Set("logonId", value); }
        }
#endif
        /// <summary>IP Address the sign-in request originated from.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LogonIp {
            get { return BackingStore?.Get<string?>("logonIp"); }
            set { BackingStore?.Set("logonIp", value); }
        }
#nullable restore
#else
        public string LogonIp {
            get { return BackingStore?.Get<string>("logonIp"); }
            set { BackingStore?.Set("logonIp", value); }
        }
#endif
        /// <summary>Location (by IP address mapping) associated with a user sign-in event by this user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LogonLocation {
            get { return BackingStore?.Get<string?>("logonLocation"); }
            set { BackingStore?.Set("logonLocation", value); }
        }
#nullable restore
#else
        public string LogonLocation {
            get { return BackingStore?.Get<string>("logonLocation"); }
            set { BackingStore?.Set("logonLocation", value); }
        }
#endif
        /// <summary>Method of user sign in. Possible values are: unknown, interactive, remoteInteractive, network, batch, service.</summary>
        public Microsoft.Graph.Models.LogonType? LogonType {
            get { return BackingStore?.Get<Microsoft.Graph.Models.LogonType?>("logonType"); }
            set { BackingStore?.Set("logonType", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Active Directory (on-premises) Security Identifier (SID) of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnPremisesSecurityIdentifier {
            get { return BackingStore?.Get<string?>("onPremisesSecurityIdentifier"); }
            set { BackingStore?.Set("onPremisesSecurityIdentifier", value); }
        }
#nullable restore
#else
        public string OnPremisesSecurityIdentifier {
            get { return BackingStore?.Get<string>("onPremisesSecurityIdentifier"); }
            set { BackingStore?.Set("onPremisesSecurityIdentifier", value); }
        }
#endif
        /// <summary>Provider-generated/calculated risk score of the user account. Recommended value range of 0-1, which equates to a percentage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RiskScore {
            get { return BackingStore?.Get<string?>("riskScore"); }
            set { BackingStore?.Set("riskScore", value); }
        }
#nullable restore
#else
        public string RiskScore {
            get { return BackingStore?.Get<string>("riskScore"); }
            set { BackingStore?.Set("riskScore", value); }
        }
#endif
        /// <summary>User account type (group membership), per Windows definition. Possible values are: unknown, standard, power, administrator.</summary>
        public UserAccountSecurityType? UserAccountType {
            get { return BackingStore?.Get<UserAccountSecurityType?>("userAccountType"); }
            set { BackingStore?.Set("userAccountType", value); }
        }
        /// <summary>User sign-in name - internet format: (user account name)@(user account DNS domain name).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new userSecurityState and sets the default values.
        /// </summary>
        public UserSecurityState() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserSecurityState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserSecurityState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"aadUserId", n => { AadUserId = n.GetStringValue(); } },
                {"accountName", n => { AccountName = n.GetStringValue(); } },
                {"domainName", n => { DomainName = n.GetStringValue(); } },
                {"emailRole", n => { EmailRole = n.GetEnumValue<EmailRole>(); } },
                {"isVpn", n => { IsVpn = n.GetBoolValue(); } },
                {"logonDateTime", n => { LogonDateTime = n.GetDateTimeOffsetValue(); } },
                {"logonId", n => { LogonId = n.GetStringValue(); } },
                {"logonIp", n => { LogonIp = n.GetStringValue(); } },
                {"logonLocation", n => { LogonLocation = n.GetStringValue(); } },
                {"logonType", n => { LogonType = n.GetEnumValue<LogonType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"onPremisesSecurityIdentifier", n => { OnPremisesSecurityIdentifier = n.GetStringValue(); } },
                {"riskScore", n => { RiskScore = n.GetStringValue(); } },
                {"userAccountType", n => { UserAccountType = n.GetEnumValue<UserAccountSecurityType>(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("aadUserId", AadUserId);
            writer.WriteStringValue("accountName", AccountName);
            writer.WriteStringValue("domainName", DomainName);
            writer.WriteEnumValue<EmailRole>("emailRole", EmailRole);
            writer.WriteBoolValue("isVpn", IsVpn);
            writer.WriteDateTimeOffsetValue("logonDateTime", LogonDateTime);
            writer.WriteStringValue("logonId", LogonId);
            writer.WriteStringValue("logonIp", LogonIp);
            writer.WriteStringValue("logonLocation", LogonLocation);
            writer.WriteEnumValue<LogonType>("logonType", LogonType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("onPremisesSecurityIdentifier", OnPremisesSecurityIdentifier);
            writer.WriteStringValue("riskScore", RiskScore);
            writer.WriteEnumValue<UserAccountSecurityType>("userAccountType", UserAccountType);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
