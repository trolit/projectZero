using System.Linq;
using UnityEngine;
using static Console.DevConsole;

namespace Console
{
    public class CommandIsReady : ConsoleCommand
    {
        public sealed override string Name { get; protected set; }
        public sealed override string Command { get; protected set; }
        public sealed override string Description { get; protected set; }
        public sealed override string Help { get; protected set; }
        public sealed override string Example { get; protected set; }

        public CommandIsReady()
        {
            Name = "Is Ready";
            Command = "isReady";
            Description = "Returns MODEL=TRUE (id) if character is picked, else MODEL=FALSE.";
            Help = "Syntax: isReady";
            Example = "isReady";

            AddCommandToConsole();
        }

        public override void RunCommand(string[] data)
        {
            if (data.Length == 1)
            {
                var modelId = PlayerPrefs.GetInt("model");
                int[] correctValues = {1, 2, 3, 4};

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

        public static CommandIsReady CreateCommand()
        {
            return new CommandIsReady();
        }
    }
}

