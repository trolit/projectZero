using System.Collections.Generic;
using static Console.DevConsole;

namespace Console
{
    public class CommandIsReady : ConsoleCommand
    {
        public override string Name { get; protected set; }
        public override string Command { get; protected set; }
        public override string Description { get; protected set; }
        public override string Help { get; protected set; }
        public override string Example { get; protected set; }

        public CommandIsReady()
        {
            Name = "Help";
            Command = "help";
            Description = "Returns description for specified command (or all available commands if parameter is not specified)";
            Help = "Syntax: help <command name> \n" +
                   $"<color={OptionalColor}><command name></color> is optional";
            Example = "help set";

            AddCommandToConsole();
        }

        public override void RunCommand(string[] data)
        {
            if (data.Length == 1)
            {
                AddStaticMessageToConsole("--------------------------------------------------");
                AddStaticMessageToConsole("Available commands");

                int counter = 1;

                foreach (KeyValuePair<string, ConsoleCommand> command in Commands)
                {
                    AddStaticMessageToConsole(counter + ") " + command.Key);

                    counter++;
                }
            }
            else if (data.Length == 2 && Commands.ContainsKey(data[1].ToLower()))
            {
                var parameter = data[1].ToLower();

                var command = Commands[parameter];

                AddStaticMessageToConsole("--------------------------------------------------");
                AddStaticMessageToConsole("<b>Title of command</b>");
                AddStaticMessageToConsole(command.Name + "\n");
                AddStaticMessageToConsole("<b>Description</b>");
                AddStaticMessageToConsole(command.Description + "\n");
                AddStaticMessageToConsole("<b>Usage</b>");
                AddStaticMessageToConsole(command.Help + "\n");
                AddStaticMessageToConsole("<b>Example</b>");
                AddStaticMessageToConsole(command.Example + "\n");
            }
            else if (Commands.ContainsKey(data[1].ToLower()) == false)
            {
                AddStaticMessageToConsole(NotRecognized);
            }
            else
            {
                AddStaticMessageToConsole(ParametersAmount);
            }

        }

        public static CommandIsReady CreateCommand()
        {
            return new CommandIsReady();
        }
    }
}

