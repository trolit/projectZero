using System.Linq;
using UnityEngine;
using static Console.DevConsole;

namespace Console
{
    public class CommandGetKeyValue : ConsoleCommand
    {
        public sealed override string Name { get; protected set; }
        public sealed override string Command { get; protected set; }
        public sealed override string Description { get; protected set; }
        public sealed override string Help { get; protected set; }
        public sealed override string Example { get; protected set; }

        public CommandGetKeyValue()
        {
            Name = "Get key value";
            Command = "getKeyInfo";
            Description = "Returns value that is being held by specified key.";
            Help = "Syntax: isReady";
            Example = "isReady";

            AddCommandToConsole();
        }

        public override void RunCommand(string[] data)
        {
            if (data.Length == 1)
            {
                var modelId = PlayerPrefs.GetInt("model");
                int[] correctValues = {1, 2, 3};

                if (correctValues.Contains(modelId))
                {
                    AddStaticMessageToConsole($"MODEL = <color={OptionalColor}>TRUE</color> ({modelId})");
                }
                else
                {
                    AddStaticMessageToConsole($"MODEL = <color={RequiredColor}>FALSE</color>");
                }
            }
            else
            {
                AddStaticMessageToConsole(ParametersAmount);
            }

        }

        public static CommandGetKeyValue CreateCommand()
        {
            return new CommandGetKeyValue();
        }
    }
}

