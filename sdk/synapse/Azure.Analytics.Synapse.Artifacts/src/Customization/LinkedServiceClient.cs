﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    public partial class LinkedServiceClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedServiceClient"/>.
        /// </summary>
        public LinkedServiceClient(Uri endpoint, TokenCredential credential)
            : this(endpoint, credential, ArtifactsClientOptions.Default)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedServiceClient"/>.
        /// </summary>
        public LinkedServiceClient(Uri endpoint, TokenCredential credential, ArtifactsClientOptions options)
            : this(new ClientDiagnostics(options),
                  SynapseClientPipeline.Build(options, credential),
                  endpoint.ToString(),
                  options.VersionString)
        {
        }
    }
}
