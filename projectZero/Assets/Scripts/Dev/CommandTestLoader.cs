using Assets.Scripts.Game;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Console.DevConsole;

namespace Console
{
    public class CommandTestLoader : ConsoleCommand
    {
        public sealed override string Name { get; protected set; }
        public sealed override string Command { get; protected set; }
        public sealed override string Description { get; protected set; }
        public sealed override string Help { get; protected set; }
        public sealed override string Example { get; protected set; }

        public CommandTestLoader()
        {
            Name = "Test minigame loader";
            Command = "test";
            Description = "Loads minigame loader (scene) by name. Loader (if not under test) will change scene if ready." +
                          "Useful to check if loading text work properly and images too in minigame loader." +
                          $" MAKE SURE that YOU PICKED CHARACTER by using <color={WarningColor}>isReady</color> command.";
            Help = "Syntax: test <scene name> \n" +
                   $"<color={RequiredColor}><scene name></color> is required!";
            Example = "test Maze_PHP_1";

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

                    LevelLoader.CrossSceneInformation = sceneName;

                    SceneManager.LoadSceneAsync("MinigameLoader");
                }              
            }
            else
            {
                AddStaticMessageToConsole(ParametersAmount);
            }
    
        }

        public static CommandTestLoader CreateCommand()
        {
            return new CommandTestLoader();
        }
    }
}

