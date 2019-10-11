using UnityEngine;
using UnityEngine.SceneManagement;
using static Console.DevConsole;

namespace Console
{
    public class CommandLoadByName : ConsoleCommand
    {
        public sealed override string Name { get; protected set; }
        public sealed override string Command { get; protected set; }
        public sealed override string Description { get; protected set; }
        public sealed override string Help { get; protected set; }
        public sealed override string Example { get; protected set; }

        public CommandLoadByName()
        {
            Name = "Load scene by name";
            Command = "load";
            Description = "Loads specified level (scene). Scene name is case sensitive. " +
                          $"<color={WarningColor}>BEFORE</color> running this command on minigame levels" +
                          $" MAKE SURE that YOU PICKED CHARACTER by using <color={WarningColor}>isReady</color> command.";
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
                    AddStaticMessageToConsole(SceneNotFound);
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

