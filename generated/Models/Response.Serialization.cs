// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace DataProtectionPlugin.Models
{
    [JsonConverter(typeof(ResponseConverter))]
    public partial class Response : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("status");
            writer.WriteStringValue(Status.ToString());
            writer.WritePropertyName("createdTime");
            writer.WriteStringValue(CreatedTime, "O");
            if (Optional.IsDefined(StartTime))
            {
                writer.WritePropertyName("startTime");
                writer.WriteStringValue(StartTime.Value, "O");
            }
            if (Optional.IsDefined(EndTime))
            {
                writer.WritePropertyName("endTime");
                writer.WriteStringValue(EndTime.Value, "O");
            }
            if (Optional.IsDefined(PurgeTime))
            {
                writer.WritePropertyName("purgeTime");
                writer.WriteStringValue(PurgeTime.Value, "O");
            }
            if (Optional.IsDefined(BaseRequest))
            {
                writer.WritePropertyName("baseRequest");
                writer.WriteObjectValue(BaseRequest);
            }
            if (Optional.IsDefined(NotStartedResponse))
            {
                writer.WritePropertyName("notStartedResponse");
                writer.WriteObjectValue(NotStartedResponse);
            }
            if (Optional.IsDefined(RunningResponse))
            {
                writer.WritePropertyName("runningResponse");
                writer.WriteObjectValue(RunningResponse);
            }
            if (Optional.IsDefined(FailedResponse))
            {
                writer.WritePropertyName("failedResponse");
                writer.WriteObjectValue(FailedResponse);
            }
            if (Optional.IsDefined(CanceledResponse))
            {
                writer.WritePropertyName("canceledResponse");
                writer.WriteObjectValue(CanceledResponse);
            }
            if (Optional.IsDefined(SucceededResponse))
            {
                writer.WritePropertyName("succeededResponse");
                writer.WriteObjectValue(SucceededResponse);
            }
            writer.WriteEndObject();
        }

        internal static Response DeserializeResponse(JsonElement element)
        {
            string id = default;
            OperationType kind = default;
            ExecutionStatus status = default;
            DateTimeOffset createdTime = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<DateTimeOffset> purgeTime = default;
            Optional<BaseRequest> baseRequest = default;
            Optional<BaseStatus> notStartedResponse = default;
            Optional<BaseStatus> runningResponse = default;
            Optional<BaseStatus> failedResponse = default;
            Optional<BaseStatus> canceledResponse = default;
            Optional<BaseStatus> succeededResponse = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = new OperationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = new ExecutionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdTime"))
                {
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("purgeTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    purgeTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("baseRequest"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    baseRequest = BaseRequest.DeserializeBaseRequest(property.Value);
                    continue;
                }
                if (property.NameEquals("notStartedResponse"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    notStartedResponse = BaseStatus.DeserializeBaseStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("runningResponse"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    runningResponse = BaseStatus.DeserializeBaseStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("failedResponse"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    failedResponse = BaseStatus.DeserializeBaseStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("canceledResponse"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    canceledResponse = BaseStatus.DeserializeBaseStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("succeededResponse"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    succeededResponse = BaseStatus.DeserializeBaseStatus(property.Value);
                    continue;
                }
            }
            return new Response(id, kind, status, createdTime, Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToNullable(purgeTime), baseRequest.Value, notStartedResponse.Value, runningResponse.Value, failedResponse.Value, canceledResponse.Value, succeededResponse.Value);
        }

        internal partial class ResponseConverter : JsonConverter<Response>
        {
            public override void Write(Utf8JsonWriter writer, Response model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override Response Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeResponse(document.RootElement);
            }
        }
    }
}