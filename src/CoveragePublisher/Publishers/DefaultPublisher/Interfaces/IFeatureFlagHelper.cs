﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.Azure.Pipelines.CoveragePublisher.Model;

namespace Microsoft.Azure.Pipelines.CoveragePublisher.Publishers.DefaultPublisher
{
    /// <summary>
    /// Gets feature flag state.
    /// </summary>
    /// <param name="featureAvailabilityHttpClient"><see cref="FeatureAvailabilityHttpClient"/>.</param>
    /// <param name="FFName">Feature flag name.</param>
    /// <param name="logger"><see cref="ILogger"/>.</param>
    /// <returns>Feature flag state.</returns>
    public interface IFeatureFlagHelper
    {
        bool GetFeatureFlagState(string featureFlagName, bool isTcmFeature);
    }
}
