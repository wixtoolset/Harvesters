// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Harvesters.Data
{
    /// <summary>
    /// A command line option.
    /// </summary>
    public struct HeatCommandLineOption
    {
        public string Option;

        public string Description;

        /// <summary>
        /// Instantiates a new CommandLineOption.
        /// </summary>
        /// <param name="option">The option name.</param>
        /// <param name="description">The description of the option.</param>
        public HeatCommandLineOption(string option, string description)
        {
            this.Option = option;
            this.Description = description;
        }
    }
}
