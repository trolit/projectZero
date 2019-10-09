using System;
using System.Collections.Generic;
using UnityEngine;

namespace Console
{
    public class CommandHelp : ConsoleCommand
    {
        public override string Name { get; protected set; }
        public override string Command { get; protected set; }
        public override string Description { get; protected set; }
        public override string Help { get; protected set; }

        public CommandHelp()
        {
            Name = "Help";
            Command = "help";
            Description = "Returns description for specified command or all available commands if parameter is not specified";
            Help = "Syntax: help <command name> \n" +
                   "<color=lime>Parameter is optional</color>";

            AddCommandToConsole();
        }

        public override void RunCommand(string[] data)
        {
            var commands = DevConsole.Commands;

            if (data.Length == 1)
            {               
                DevConsole.AddStaticMessageToConsole("Available commands");

                int counter = 1;

                foreach (KeyValuePair<string, ConsoleCommand> command in DevConsole.Commands)
                {
                    DevConsole.AddStaticMessageToConsole(counter + ") " + command.Key);

                    counter++;
                }
            }
            else if (data.Length == 2)
            {
                var parameter = data[1].ToLower();

                var command = DevConsole.Commands[parameter];

                DevConsole.AddStaticMessageToConsole("-----------------------------------");
                DevConsole.AddStaticMessageToConsole("Name");
                DevConsole.AddStaticMessageToConsole(command.Name + "\n");
                DevConsole.AddStaticMessageToConsole("Description");
                DevConsole.AddStaticMessageToConsole(command.Description + "\n");
                DevConsole.AddStaticMessageToConsole("Usage");
                DevConsole.AddStaticMessageToConsole(command.Help + "\n");
            }
            else
            {
                DevConsole.AddStaticMessageToConsole("help command <color=yellow>syntax incorrect</color>");
            }

        }

        public static CommandHelp CreateCommand()
        {
            return new CommandHelp();
        }
    }
}

