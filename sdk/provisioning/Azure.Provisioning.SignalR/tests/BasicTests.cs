// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.SignalR;
using Azure.Provisioning.Tests;
using NUnit.Framework;

namespace Azure.Provisioning.SignalR.Tests;

public class BasicTests(bool async) : ProvisioningTestBase(async)
{
    [Test]
    public void GetStarted()
    {
        Assert.Inconclusive("Implement me!");
    }
}