using UnityEngine;
using static Console.DevConsole;

namespace Console
{
    public class CommandSetKeyValue : ConsoleCommand
    {
        public override string Name { get; protected set; }
        public override string Command { get; protected set; }
        public override string Description { get; protected set; }
        public override string Help { get; protected set; }
        public override string Example { get; protected set; }

        public CommandSetKeyValue()
        {
            Name = "Set";
            Command = "set";
            Description = "Sets specified key value";
            Help = "Syntax: set <key> <type> <value> \n" +
                   $"<color={RequiredColor}>All parameters are required!</color>";
            Example = "set money int 5000";

            AddCommandToConsole();
        }

        public override void RunCommand(string[] data)
        {
            if (data.Length == 4)
            {
                var type = data[2].ToLower();
                var key = data[1].ToLower();

                if (type == "float")
                {
                    var value = float.Parse(data[3]);

                    PlayerPrefs.SetFloat(key, value);

                    AddStaticMessageToConsole(ExecutedSuccessfully);
                }
                else if (type == "int")
                {
                    var value = int.Parse(data[3]);

                    PlayerPrefs.SetInt(key, value);

                    AddStaticMessageToConsole(ExecutedSuccessfully);
                }
                else
                {
                    AddStaticMessageToConsole($"Type of command <color={WarningColor}>not supported</color>!");
                }
            }
            else
            {
                AddStaticMessageToConsole(ParametersAmount);
            }
        }

        public static CommandSetKeyValue CreateCommand()
        {
            return new CommandSetKeyValue();
        }
    }
}

