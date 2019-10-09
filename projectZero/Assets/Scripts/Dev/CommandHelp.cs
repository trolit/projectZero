using System.Collections.Generic;

namespace Console
{
    public class CommandHelp : ConsoleCommand
    {
        public override string Name { get; protected set; }
        public override string Command { get; protected set; }
        public override string Description { get; protected set; }
        public override string Help { get; protected set; }
        public override string Example { get; protected set; }

        public CommandHelp()
        {
            Name = "Help";
            Command = "help";
            Description = "Returns description for specified command (or all available commands if parameter is not specified)";
            Help = "Syntax: help <command name> \n" +
                   "Parameter <color=lime><command name></color> is optional \n";
            Example = "help set";

            AddCommandToConsole();
        }

        public override void RunCommand(string[] data)
        {
            var commands = DevConsole.Commands;

            if (data.Length == 1)
            {
                DevConsole.AddStaticMessageToConsole("--------------------------------------------------");
                DevConsole.AddStaticMessageToConsole("Available commands");

                int counter = 1;

                foreach (KeyValuePair<string, ConsoleCommand> command in DevConsole.Commands)
                {
                    DevConsole.AddStaticMessageToConsole(counter + ") " + command.Key);

                    counter++;
                }
            }
            else if (data.Length == 2 && DevConsole.Commands.ContainsKey(data[1].ToLower()))
            {
                var parameter = data[1].ToLower();

                var command = DevConsole.Commands[parameter];

                DevConsole.AddStaticMessageToConsole("--------------------------------------------------");
                DevConsole.AddStaticMessageToConsole("<b>Title of command</b>");
                DevConsole.AddStaticMessageToConsole(command.Name + "\n");
                DevConsole.AddStaticMessageToConsole("<b>Description</b>");
                DevConsole.AddStaticMessageToConsole(command.Description + "\n");
                DevConsole.AddStaticMessageToConsole("<b>Usage</b>");
                DevConsole.AddStaticMessageToConsole(command.Help + "\n");
                DevConsole.AddStaticMessageToConsole("<b>Example</b>");
                DevConsole.AddStaticMessageToConsole(command.Example + "\n");
            }
            else if (DevConsole.Commands.ContainsKey(data[1].ToLower()) == false)
            {
                DevConsole.AddStaticMessageToConsole($"Unrecognized command <color=yellow>{data[1]}</color>");
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

