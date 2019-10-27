using UnityEngine;
using static Console.DevConsole;

namespace Console
{
    public class CommandMgStatus : ConsoleCommand
    {
        public sealed override string Name { get; protected set; }
        public sealed override string Command { get; protected set; }
        public sealed override string Description { get; protected set; }
        public sealed override string Help { get; protected set; }
        public sealed override string Example { get; protected set; }

        public CommandMgStatus()
        {
            Name = "Minigames unique status checker";
            Command = "mgStatus";
            Description = "Returns unique state of each mini-game.";
            Help = "Syntax: mgStatus";
            Example = "mgStatus";

            AddCommandToConsole();
        }

        public override void RunCommand(string[] data)
        {
            if (data.Length == 1)
            {
                string[] levelKeys =
                {
                    "PU_C#1",
                    "PU_C#2",
                    "PU_HTML#1",
                    "PU_HTML#2",
                    "PU_Java#1",
                    "PU_Java#2",
                    "PU_JS#1",
                    "PU_JS#2",
                    "PU_PHP#1",
                    "PU_PHP#2",
                    "PI_C#1",
                    "PI_C#2",
                    "PI_HTML#1",
                    "PI_HTML#2",
                    "PI_Java#1",
                    "PI_Java#2",
                    "PI_JS#1",
                    "PI_JS#2",
                    "PI_PHP#1",
                    "PI_PHP#2",
                    "MA_C#1",
                    "MA_C#2",
                    "MA_HTML#1",
                    "MA_HTML#2",
                    "MA_Java#1",
                    "MA_Java#2",
                    "MA_JS#1",
                    "MA_JS#2",
                    "MA_PHP#1",
                    "MA_PHP#2",
                    "SK_C#1",
                    "SK_C#2",
                    "SK_HTML#1",
                    "SK_HTML#2",
                    "SK_Java#1",
                    "SK_Java#2",
                    "SK_JS#1",
                    "SK_JS#2",
                    "SK_PHP#1",
                    "SK_PHP#2"
                };

                AddStaticMessageToConsole("");

                foreach (var levelKey in levelKeys)
                {
                    var currentValue = PlayerPrefs.GetInt(levelKey + "passed");

                    if (currentValue == 1)
                    {
                        AddStaticMessageToConsole($"{levelKey}passed ? <color={OptionalColor}>TRUE (1)</color>");
                    }
                    else
                    {
                        AddStaticMessageToConsole($"{levelKey}passed ? <color={RequiredColor}>FALSE ({currentValue})</color>");
                    }
                }            
            }
            else
            {
                AddStaticMessageToConsole(ParametersAmount);
            }
        }

        public static CommandMgStatus CreateCommand()
        {
            return new CommandMgStatus();
        }
    }
}

