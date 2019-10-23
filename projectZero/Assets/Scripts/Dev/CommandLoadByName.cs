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
            Command = "loadByName";
            Description = "Loads specified level (scene). Scene name is case sensitive.\n" +
                          $"<color={WarningColor}>BEFORE</color> running this command on minigame levels make sure\n" +
                          $"that you PICKED character by using <color={WarningColor}>isReady</color> command.";
            Help = "Syntax: loadByName <scene name> \n" +
                   $"<color={RequiredColor}><scene name></color> is required!";
            Example = "loadByName Menu";

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

