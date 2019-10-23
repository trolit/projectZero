using UnityEngine;
using static Console.DevConsole;

namespace Console
{
    public class CommandSceneList : ConsoleCommand
    {
        public sealed override string Name { get; protected set; }
        public sealed override string Command { get; protected set; }
        public sealed override string Description { get; protected set; }
        public sealed override string Help { get; protected set; }
        public sealed override string Example { get; protected set; }

        public CommandSceneList()
        {
            Name = "Scene list";
            Command = "sceneList";
            Description = "Returns list of available scenes.";
            Help = "Syntax: sceneList";
            Example = "sceneList";

            AddCommandToConsole();
        }

        public override void RunCommand(string[] data)
        {
            if (data.Length == 1)
            {
                var sceneCount = UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;

                var scenes = new string[sceneCount];

                for (var i = 0; i < sceneCount; i++)
                {
                    scenes[i] = System.IO.Path.GetFileNameWithoutExtension
                        (UnityEngine.SceneManagement.SceneUtility.GetScenePathByBuildIndex(i));
                }

                AddStaticMessageToConsole($"\n<color={ExecutedColor}>List of available scenes</color>");

                var value = 0;

                foreach (var scene in scenes)
                {
                    AddStaticMessageToConsole($"{value}) {scene}");
                    value++;
                }
            }
            else
            {
                AddStaticMessageToConsole(ParametersAmount);
            }

        }

        public static CommandSceneList CreateCommand()
        {
            return new CommandSceneList();
        }
    }
}

