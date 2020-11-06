// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Harvesters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using WixToolset.Data;
    using WixToolset.Extensibility.Data;
    using WixToolset.Extensibility.Services;
    using WixToolset.Harvesters.Data;
    using WixToolset.Harvesters.Extensibility;

    internal class HeatCommandLine : IHeatCommandLine
    {
        private readonly List<IHeatExtension> extensions;
        private readonly IMessaging messaging;
        private readonly IWixToolsetServiceProvider serviceProvider;

        public HeatCommandLine(IWixToolsetServiceProvider serviceProvider, IEnumerable<IHeatExtension> heatExtensions)
        {
            this.extensions = new List<IHeatExtension> { new IIsHeatExtension(), new UtilHeatExtension(), new VSHeatExtension() };
            if (heatExtensions != null)
            {
                this.extensions.AddRange(heatExtensions);
            }
            this.messaging = serviceProvider.GetService<IMessaging>();
            this.serviceProvider = serviceProvider;
        }

        public ICommandLineCommand ParseStandardCommandLine(ICommandLineArguments arguments)
        {
            ICommandLineCommand command = null;
            var parser = arguments.Parse();

            while (command?.StopParsing != true &&
                   String.IsNullOrEmpty(parser.ErrorArgument) &&
                   parser.TryGetNextSwitchOrArgument(out var arg))
            {
                if (String.IsNullOrWhiteSpace(arg)) // skip blank arguments.
                {
                    continue;
                }

                // First argument must be the command or global switch (that creates a command).
                if (command == null)
                {
                    if (!this.TryParseUnknownCommandArg(arg, parser, out command))
                    {
                        this.messaging.Write(ErrorMessages.HarvestTypeNotFound(arg));
                        parser.ErrorArgument = arg;
                    }
                }
                else if (!command.TryParseArgument(parser, arg))
                {
                    parser.ErrorArgument = arg;
                }
            }

            return command ?? new HelpCommand(this.extensions);
        }

        public bool TryParseUnknownCommandArg(string arg, ICommandLineParser parser, out ICommandLineCommand command)
        {
            command = null;

            if (parser.IsSwitch(arg))
            {
                var parameter = arg.Substring(1);
                switch (parameter.ToLowerInvariant())
                {
                    case "?":
                    case "h":
                    case "help":
                        command = new HelpCommand(this.extensions);
                        return true;
                }
            }

            foreach (var heatExtension in this.extensions)
            {
                if (heatExtension.CommandLineTypes.Any(o => o.Option == arg))
                {
                    command = new HeatCommand(arg, this.extensions, this.serviceProvider);
                    return true;
                }
            }

            return false;
        }
    }
}
