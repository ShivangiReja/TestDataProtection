// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using DataProtectionPlugin.Models;

namespace DataProtectionPlugin
{
    internal partial class LroRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of LroRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public LroRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null, string apiVersion = "2022-03-01-preview")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://pluginBaseUrl.com");
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateGetRequest(string operationId, string subscriptionId, string resourceId, string taskId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/operations/", false);
            uri.AppendPath(operationId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("subscription-id", subscriptionId);
            request.Headers.Add("resource-id", resourceId);
            request.Headers.Add("task-id", taskId);
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets the status of an LRO. </summary>
        /// <param name="operationId"> Unique id of the LRO. </param>
        /// <param name="subscriptionId"> SubscriptionId of the resource. </param>
        /// <param name="resourceId"> Unique id of the resource. </param>
        /// <param name="taskId"> Unique id of the current task. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/>, <paramref name="subscriptionId"/>, <paramref name="resourceId"/> or <paramref name="taskId"/> is null. </exception>
        public async Task<ResponseWithHeaders<Response, LroGetHeaders>> GetAsync(string operationId, string subscriptionId, string resourceId, string taskId, CancellationToken cancellationToken = default)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceId == null)
            {
                throw new ArgumentNullException(nameof(resourceId));
            }
            if (taskId == null)
            {
                throw new ArgumentNullException(nameof(taskId));
            }

            using var message = CreateGetRequest(operationId, subscriptionId, resourceId, taskId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new LroGetHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Response value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Response.DeserializeResponse(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the status of an LRO. </summary>
        /// <param name="operationId"> Unique id of the LRO. </param>
        /// <param name="subscriptionId"> SubscriptionId of the resource. </param>
        /// <param name="resourceId"> Unique id of the resource. </param>
        /// <param name="taskId"> Unique id of the current task. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/>, <paramref name="subscriptionId"/>, <paramref name="resourceId"/> or <paramref name="taskId"/> is null. </exception>
        public ResponseWithHeaders<Response, LroGetHeaders> Get(string operationId, string subscriptionId, string resourceId, string taskId, CancellationToken cancellationToken = default)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceId == null)
            {
                throw new ArgumentNullException(nameof(resourceId));
            }
            if (taskId == null)
            {
                throw new ArgumentNullException(nameof(taskId));
            }

            using var message = CreateGetRequest(operationId, subscriptionId, resourceId, taskId);
            _pipeline.Send(message, cancellationToken);
            var headers = new LroGetHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Response value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Response.DeserializeResponse(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string operationId, string subscriptionId, string resourceId, string taskId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/operations/", false);
            uri.AppendPath(operationId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("subscription-id", subscriptionId);
            request.Headers.Add("resource-id", resourceId);
            request.Headers.Add("task-id", taskId);
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Delete the LRO. </summary>
        /// <param name="operationId"> Unique id of the LRO. </param>
        /// <param name="subscriptionId"> SubscriptionId of the resource. </param>
        /// <param name="resourceId"> Unique id of the resource. </param>
        /// <param name="taskId"> Unique id of the current task. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/>, <paramref name="subscriptionId"/>, <paramref name="resourceId"/> or <paramref name="taskId"/> is null. </exception>
        public async Task<ResponseWithHeaders<LroDeleteHeaders>> DeleteAsync(string operationId, string subscriptionId, string resourceId, string taskId, CancellationToken cancellationToken = default)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceId == null)
            {
                throw new ArgumentNullException(nameof(resourceId));
            }
            if (taskId == null)
            {
                throw new ArgumentNullException(nameof(taskId));
            }

            using var message = CreateDeleteRequest(operationId, subscriptionId, resourceId, taskId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new LroDeleteHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 204:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Delete the LRO. </summary>
        /// <param name="operationId"> Unique id of the LRO. </param>
        /// <param name="subscriptionId"> SubscriptionId of the resource. </param>
        /// <param name="resourceId"> Unique id of the resource. </param>
        /// <param name="taskId"> Unique id of the current task. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/>, <paramref name="subscriptionId"/>, <paramref name="resourceId"/> or <paramref name="taskId"/> is null. </exception>
        public ResponseWithHeaders<LroDeleteHeaders> Delete(string operationId, string subscriptionId, string resourceId, string taskId, CancellationToken cancellationToken = default)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceId == null)
            {
                throw new ArgumentNullException(nameof(resourceId));
            }
            if (taskId == null)
            {
                throw new ArgumentNullException(nameof(taskId));
            }

            using var message = CreateDeleteRequest(operationId, subscriptionId, resourceId, taskId);
            _pipeline.Send(message, cancellationToken);
            var headers = new LroDeleteHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 204:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCancelRequest(string operationId, string subscriptionId, string resourceId, string taskId, CancelRequest parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/operations/", false);
            uri.AppendPath(operationId, true);
            uri.AppendPath(":cancel", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("subscription-id", subscriptionId);
            request.Headers.Add("resource-id", resourceId);
            request.Headers.Add("task-id", taskId);
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            return message;
        }

        /// <summary> Cancel the operation. Poll the LRO to get the final status. </summary>
        /// <param name="operationId"> operationId of the original request. </param>
        /// <param name="subscriptionId"> SubscriptionId of the resource. </param>
        /// <param name="resourceId"> unique id of the resource. </param>
        /// <param name="taskId"> unique id of the current task. </param>
        /// <param name="parameters"> Request body for operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/>, <paramref name="subscriptionId"/>, <paramref name="resourceId"/>, <paramref name="taskId"/> or <paramref name="parameters"/> is null. </exception>
        public async Task<ResponseWithHeaders<SyncResponse, LroCancelHeaders>> CancelAsync(string operationId, string subscriptionId, string resourceId, string taskId, CancelRequest parameters, CancellationToken cancellationToken = default)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceId == null)
            {
                throw new ArgumentNullException(nameof(resourceId));
            }
            if (taskId == null)
            {
                throw new ArgumentNullException(nameof(taskId));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCancelRequest(operationId, subscriptionId, resourceId, taskId, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new LroCancelHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SyncResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SyncResponse.DeserializeSyncResponse(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Cancel the operation. Poll the LRO to get the final status. </summary>
        /// <param name="operationId"> operationId of the original request. </param>
        /// <param name="subscriptionId"> SubscriptionId of the resource. </param>
        /// <param name="resourceId"> unique id of the resource. </param>
        /// <param name="taskId"> unique id of the current task. </param>
        /// <param name="parameters"> Request body for operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/>, <paramref name="subscriptionId"/>, <paramref name="resourceId"/>, <paramref name="taskId"/> or <paramref name="parameters"/> is null. </exception>
        public ResponseWithHeaders<SyncResponse, LroCancelHeaders> Cancel(string operationId, string subscriptionId, string resourceId, string taskId, CancelRequest parameters, CancellationToken cancellationToken = default)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceId == null)
            {
                throw new ArgumentNullException(nameof(resourceId));
            }
            if (taskId == null)
            {
                throw new ArgumentNullException(nameof(taskId));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCancelRequest(operationId, subscriptionId, resourceId, taskId, parameters);
            _pipeline.Send(message, cancellationToken);
            var headers = new LroCancelHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SyncResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SyncResponse.DeserializeSyncResponse(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRefreshTokensRequest(string operationId, string subscriptionId, string resourceId, string taskId, RefreshTokensRequest parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/operations/", false);
            uri.AppendPath(operationId, true);
            uri.AppendPath(":refreshTokens", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("subscription-id", subscriptionId);
            request.Headers.Add("resource-id", resourceId);
            request.Headers.Add("task-id", taskId);
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            return message;
        }

        /// <summary> Refresh tokens for a given operation. </summary>
        /// <param name="operationId"> operationId of the original request. </param>
        /// <param name="subscriptionId"> SubscriptionId of the resource. </param>
        /// <param name="resourceId"> unique id of the resource. </param>
        /// <param name="taskId"> unique id of the current task. </param>
        /// <param name="parameters"> Request body for operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/>, <paramref name="subscriptionId"/>, <paramref name="resourceId"/>, <paramref name="taskId"/> or <paramref name="parameters"/> is null. </exception>
        public async Task<ResponseWithHeaders<SyncResponse, LroRefreshTokensHeaders>> RefreshTokensAsync(string operationId, string subscriptionId, string resourceId, string taskId, RefreshTokensRequest parameters, CancellationToken cancellationToken = default)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceId == null)
            {
                throw new ArgumentNullException(nameof(resourceId));
            }
            if (taskId == null)
            {
                throw new ArgumentNullException(nameof(taskId));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateRefreshTokensRequest(operationId, subscriptionId, resourceId, taskId, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new LroRefreshTokensHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SyncResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SyncResponse.DeserializeSyncResponse(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Refresh tokens for a given operation. </summary>
        /// <param name="operationId"> operationId of the original request. </param>
        /// <param name="subscriptionId"> SubscriptionId of the resource. </param>
        /// <param name="resourceId"> unique id of the resource. </param>
        /// <param name="taskId"> unique id of the current task. </param>
        /// <param name="parameters"> Request body for operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/>, <paramref name="subscriptionId"/>, <paramref name="resourceId"/>, <paramref name="taskId"/> or <paramref name="parameters"/> is null. </exception>
        public ResponseWithHeaders<SyncResponse, LroRefreshTokensHeaders> RefreshTokens(string operationId, string subscriptionId, string resourceId, string taskId, RefreshTokensRequest parameters, CancellationToken cancellationToken = default)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceId == null)
            {
                throw new ArgumentNullException(nameof(resourceId));
            }
            if (taskId == null)
            {
                throw new ArgumentNullException(nameof(taskId));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateRefreshTokensRequest(operationId, subscriptionId, resourceId, taskId, parameters);
            _pipeline.Send(message, cancellationToken);
            var headers = new LroRefreshTokensHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SyncResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SyncResponse.DeserializeSyncResponse(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
