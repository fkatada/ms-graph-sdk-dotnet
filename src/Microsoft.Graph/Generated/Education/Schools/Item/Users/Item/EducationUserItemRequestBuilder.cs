// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Education.Schools.Item.Users.Item.Ref;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Microsoft.Graph.Education.Schools.Item.Users.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \education\schools\{educationSchool-id}\users\{educationUser-id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class EducationUserItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the collection of educationRoot entities.</summary>
        public global::Microsoft.Graph.Education.Schools.Item.Users.Item.Ref.RefRequestBuilder Ref
        {
            get => new global::Microsoft.Graph.Education.Schools.Item.Users.Item.Ref.RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Education.Schools.Item.Users.Item.EducationUserItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EducationUserItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/education/schools/{educationSchool%2Did}/users/{educationUser%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Education.Schools.Item.Users.Item.EducationUserItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EducationUserItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/education/schools/{educationSchool%2Did}/users/{educationUser%2Did}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
