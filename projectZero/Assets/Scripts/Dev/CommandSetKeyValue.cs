using UnityEngine;
using static Console.DevConsole;

namespace Console
{
    public class CommandSetKeyValue : ConsoleCommand
    {
        public sealed override string Name { get; protected set; }
        public sealed override string Command { get; protected set; }
        public sealed override string Description { get; protected set; }
        public sealed override string Help { get; protected set; }
        public sealed override string Example { get; protected set; }

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
                var type = data[2];
                var key = data[1];

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
                    AddStaticMessageToConsole(TypeNotSupported);
                }

                PlayerPrefs.Save();
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

