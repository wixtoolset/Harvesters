// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Harvesters
{
    using System;

    /// <summary>
    /// A command line option.
    /// </summary>
    internal struct HeatCommandLineOption
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

    /// <summary>
    /// An extension for the WiX Toolset Harvester application.
    /// </summary>
    internal abstract class HeatExtension
    {
        /// <summary>
        /// Gets or sets the heat core for the extension.
        /// </summary>
        /// <value>The heat core for the extension.</value>
        public IHeatCore Core { get; set; }

        /// <summary>
        /// Gets the supported command line types for this extension.
        /// </summary>
        /// <value>The supported command line types for this extension.</value>
        public virtual HeatCommandLineOption[] CommandLineTypes
        {
            get { return null; }
        }

        /// <summary>
        /// Parse the command line options for this extension.
        /// </summary>
        /// <param name="type">The active harvester type.</param>
        /// <param name="args">The option arguments.</param>
        public virtual void ParseOptions(string type, string[] args)
        {
        }

        public static bool IsValidArg(string[] args, int index)
        {
            if (args.Length <= index || String.IsNullOrEmpty(args[index]) || '/' == args[index][0] || '-' == args[index][0])
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
