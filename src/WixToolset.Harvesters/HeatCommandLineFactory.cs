// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Harvesters
{
    using WixToolset.Extensibility.Services;

    public class HeatCommandLineFactory
    {
        public static IHeatCommandLine CreateCommandLine(IWixToolsetServiceProvider serviceProvider, bool runningInMsBuild = false)
        {
            return new HeatCommandLine(serviceProvider, runningInMsBuild);
        }
    }
}
