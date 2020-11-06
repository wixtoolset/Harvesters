// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Harvesters.Extensibility
{
    using WixToolset.Harvesters.Data;

    public interface IHeatExtension
    {
        IHeatCore Core { get; set; }

        HeatCommandLineOption[] CommandLineTypes { get; }

        void ParseOptions(string type, string[] args);
    }
}
