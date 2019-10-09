using UnityEngine;
using UnityEngine.SceneManagement;
using static Console.DevConsole;

namespace Console
{
    public class CommandLoadByName : ConsoleCommand
    {
        public override string Name { get; protected set; }
        public override string Command { get; protected set; }
        public override string Description { get; protected set; }
        public override string Help { get; protected set; }
        public override string Example { get; protected set; }

        public CommandLoadByName()
        {
            Name = "Load scene by name";
            Command = "load";
            Description = "Loads specified level (scene). Scene name is case sensitive.";
            Help = "Syntax: load <scene name> \n" +
                   $"<color={RequiredColor}><scene name></color> is required!";
            Example = "load Menu";

            AddCommandToConsole();
        }

        public override void RunCommand(string[] data)
        {
            if (data.Length == 2)
            {
                var sceneName = data[1];

                if (Application.CanStreamedLevelBeLoaded(sceneName) == false)
                {
                    AddStaticMessageToConsole($"Scene <color={WarningColor}>not found</color>!" +
                                              $" Make sure that you have placed it inside <color={WarningColor}build settings</color>.");
                }
                else
                {
                    AddStaticMessageToConsole($"<color={ExecutedColor}>Executing</color> command..");

                    SceneManager.LoadSceneAsync(sceneName);
                }              
            }
            else
            {
                AddStaticMessageToConsole(ParametersAmount);
            }
        }

        public static CommandLoadByName CreateCommand()
        {
            return new CommandLoadByName();
        }
    }
}

