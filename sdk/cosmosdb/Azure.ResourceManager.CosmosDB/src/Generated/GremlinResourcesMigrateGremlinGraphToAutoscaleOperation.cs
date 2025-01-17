// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> Migrate an Azure Cosmos DB Gremlin graph from manual throughput to autoscale. </summary>
    public partial class GremlinResourcesMigrateGremlinGraphToAutoscaleOperation : Operation<ThroughputSettingsGetResults>, IOperationSource<ThroughputSettingsGetResults>
    {
        private readonly ArmOperationHelpers<ThroughputSettingsGetResults> _operation;

        /// <summary> Initializes a new instance of GremlinResourcesMigrateGremlinGraphToAutoscaleOperation for mocking. </summary>
        protected GremlinResourcesMigrateGremlinGraphToAutoscaleOperation()
        {
        }

        internal GremlinResourcesMigrateGremlinGraphToAutoscaleOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<ThroughputSettingsGetResults>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "GremlinResourcesMigrateGremlinGraphToAutoscaleOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ThroughputSettingsGetResults Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ThroughputSettingsGetResults>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ThroughputSettingsGetResults>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ThroughputSettingsGetResults IOperationSource<ThroughputSettingsGetResults>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ThroughputSettingsGetResults.DeserializeThroughputSettingsGetResults(document.RootElement);
        }

        async ValueTask<ThroughputSettingsGetResults> IOperationSource<ThroughputSettingsGetResults>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ThroughputSettingsGetResults.DeserializeThroughputSettingsGetResults(document.RootElement);
        }
    }
}
