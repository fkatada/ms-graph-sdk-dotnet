using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using MicrosoftGraphSdk.Users.Item.Messages.Item.Attachments;
using MicrosoftGraphSdk.Users.Item.Messages.Item.CalendarSharingMessage;
using MicrosoftGraphSdk.Users.Item.Messages.Item.Copy;
using MicrosoftGraphSdk.Users.Item.Messages.Item.CreateForward;
using MicrosoftGraphSdk.Users.Item.Messages.Item.CreateReply;
using MicrosoftGraphSdk.Users.Item.Messages.Item.CreateReplyAll;
using MicrosoftGraphSdk.Users.Item.Messages.Item.Extensions;
using MicrosoftGraphSdk.Users.Item.Messages.Item.Forward;
using MicrosoftGraphSdk.Users.Item.Messages.Item.Move;
using MicrosoftGraphSdk.Users.Item.Messages.Item.MultiValueExtendedProperties;
using MicrosoftGraphSdk.Users.Item.Messages.Item.Reply;
using MicrosoftGraphSdk.Users.Item.Messages.Item.ReplyAll;
using MicrosoftGraphSdk.Users.Item.Messages.Item.Send;
using MicrosoftGraphSdk.Users.Item.Messages.Item.SingleValueExtendedProperties;
using MicrosoftGraphSdk.Users.Item.Messages.Item.Value;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.Users.Item.Messages.Item {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\messages\{message-id}</summary>
    public class MessageItemRequestBuilder {
        public AttachmentsRequestBuilder Attachments { get =>
            new AttachmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CalendarSharingMessageRequestBuilder CalendarSharingMessage { get =>
            new CalendarSharingMessageRequestBuilder(PathParameters, RequestAdapter);
        }
        public ContentRequestBuilder Content { get =>
            new ContentRequestBuilder(PathParameters, RequestAdapter);
        }
        public CopyRequestBuilder Copy { get =>
            new CopyRequestBuilder(PathParameters, RequestAdapter);
        }
        public CreateForwardRequestBuilder CreateForward { get =>
            new CreateForwardRequestBuilder(PathParameters, RequestAdapter);
        }
        public CreateReplyRequestBuilder CreateReply { get =>
            new CreateReplyRequestBuilder(PathParameters, RequestAdapter);
        }
        public CreateReplyAllRequestBuilder CreateReplyAll { get =>
            new CreateReplyAllRequestBuilder(PathParameters, RequestAdapter);
        }
        public ExtensionsRequestBuilder Extensions { get =>
            new ExtensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ForwardRequestBuilder Forward { get =>
            new ForwardRequestBuilder(PathParameters, RequestAdapter);
        }
        public MoveRequestBuilder Move { get =>
            new MoveRequestBuilder(PathParameters, RequestAdapter);
        }
        public MultiValueExtendedPropertiesRequestBuilder MultiValueExtendedProperties { get =>
            new MultiValueExtendedPropertiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        public ReplyRequestBuilder Reply { get =>
            new ReplyRequestBuilder(PathParameters, RequestAdapter);
        }
        public ReplyAllRequestBuilder ReplyAll { get =>
            new ReplyAllRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public SendRequestBuilder Send { get =>
            new SendRequestBuilder(PathParameters, RequestAdapter);
        }
        public SingleValueExtendedPropertiesRequestBuilder SingleValueExtendedProperties { get =>
            new SingleValueExtendedPropertiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new MessageItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public MessageItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user_id}/messages/{message_id}{?select}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new MessageItemRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public MessageItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user_id}/messages/{message_id}{?select}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The messages in a mailbox or folder. Read-only. Nullable.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The messages in a mailbox or folder. Read-only. Nullable.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (q != null) {
                var qParams = new GetQueryParameters();
                q.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The messages in a mailbox or folder. Read-only. Nullable.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Message body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The messages in a mailbox or folder. Read-only. Nullable.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// The messages in a mailbox or folder. Read-only. Nullable.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Message> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<Message>(requestInfo, Message.CreateFromDiscriminatorValue, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// The messages in a mailbox or folder. Read-only. Nullable.
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(Message body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>The messages in a mailbox or folder. Read-only. Nullable.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
