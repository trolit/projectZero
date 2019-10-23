using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Console.DevConsole;

namespace Console
{
    public class CommandLoadById : ConsoleCommand
    {
        public sealed override string Name { get; protected set; }
        public sealed override string Command { get; protected set; }
        public sealed override string Description { get; protected set; }
        public sealed override string Help { get; protected set; }
        public sealed override string Example { get; protected set; }

        public CommandLoadById()
        {
            Name = "Load scene by Id";
            Command = "loadById";
            Description = "Loads specified level (scene). Scene Id must be valid.\n" +
                          $"<color={WarningColor}>BEFORE</color> running this command on minigame levels make sure\n" +
                          $"that you PICKED character by using <color={WarningColor}>isReady</color> command and\n" +
                          $"that Id of scene is correct (you can use <color={WarningColor}>sceneList</color> to get\n" +
                          "names of available scenes and their corresponding Id's).";
            Help = "Syntax: loadById <scene Id> \n" +
                   $"<color={RequiredColor}><scene Id></color> is required!";
            Example = "loadById 3";

            AddCommandToConsole();
        }

        public override void RunCommand(string[] data)
        {
            if (data.Length == 2)
            {
                var sceneId = Convert.ToInt32(data[1]);

                if (Application.CanStreamedLevelBeLoaded(sceneId) == false)
                {
                    AddStaticMessageToConsole(SceneNotFound);
                }
                else
                {
                    AddStaticMessageToConsole($"<color={ExecutedColor}>Executing</color> command..");

                    SceneManager.LoadSceneAsync(sceneId);
                }              
            }
            else
            {
                AddStaticMessageToConsole(ParametersAmount);
            }
        }

        public static CommandLoadById CreateCommand()
        {
            return new CommandLoadById();
        }
    }
}

