// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Services.Runtime
{
    using System;
    using System.Fabric;

    /// <summary>
    /// Represents the runtime context of the service.
    /// </summary>
    internal interface IRuntimeContext : IDisposable
    {
        /// <summary>
        /// Gets the code package activation context.
        /// </summary>
        ICodePackageActivationContext CodePackageContext { get; }

        /// <summary>
        /// Gets the node context.
        /// </summary>
        NodeContext NodeContext { get; }
    }
}
