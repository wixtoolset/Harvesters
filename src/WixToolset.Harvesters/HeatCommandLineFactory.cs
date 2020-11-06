// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Harvesters
{
    using System.Collections.Generic;
    using WixToolset.Extensibility.Services;
    using WixToolset.Harvesters.Data;
    using WixToolset.Harvesters.Extensibility;

    public class HeatCommandLineFactory
    {
        public static IHeatCommandLine CreateCommandLine(IWixToolsetServiceProvider serviceProvider, IEnumerable<IHeatExtension> heatExtensions = null)
        {
            return new HeatCommandLine(serviceProvider, heatExtensions);
        }
    }
}
