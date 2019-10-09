using UnityEngine;

namespace Console
{
    public class CommandSetKeyValue : ConsoleCommand
    {
        public override string Name { get; protected set; }
        public override string Command { get; protected set; }
        public override string Description { get; protected set; }
        public override string Help { get; protected set; }

        public CommandSetKeyValue()
        {
            Name = "Set";
            Command = "set";
            Description = "Sets key value";
            Help = "Set is command to set key value \n " +
                   "Syntax: set <key> <type> <value> \n" +
                   " <color=red>All parameters are required!</color>";

            AddCommandToConsole();
        }

        public override void RunCommand(string[] data)
        {
            var type = data[2].ToLower();
            var key = data[1].ToLower();
            
            if (type == "float")
            {
                var value = float.Parse(data[3]);

                PlayerPrefs.SetFloat(key, value);

                DevConsole.AddStaticMessageToConsole("Command executed successfully.");
            }
            else if (type == "int")
            {
                var value = int.Parse(data[3]);

                PlayerPrefs.SetInt(key, value);

                DevConsole.AddStaticMessageToConsole("Command executed successfully.");
            }
            else
            {
                DevConsole.AddStaticMessageToConsole("Type of command not supported!");
            }
        }

        public static CommandSetKeyValue CreateCommand()
        {
            return new CommandSetKeyValue();
        }
    }
}

