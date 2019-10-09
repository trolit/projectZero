using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Console
{
    public abstract class ConsoleCommand
    {
        // get - public access, set - restricted to ConsoleCommand
        // and classes that inherit from that class
        public abstract string Name { get; protected set; }

        public abstract string Command { get; protected set; }

        public abstract string Description { get; protected set; }

        public abstract string Help { get; protected set; }

        public abstract string Example { get; protected set; }

        public void AddCommandToConsole()
        {
            // string addMessage = " command has been added to the console.";
            
            DevConsole.AddCommandsToConsole(Command, this);

            // DevConsole.AddStaticMessageToConsole(Name + addMessage);
        }

        public abstract void RunCommand(string[] data);
    }

    public class DevConsole : MonoBehaviour
    {
        public static DevConsole Instance { get; set; }

        public static Dictionary<string, ConsoleCommand> Commands { get; set; }

        [Header("UI Components")]

        public Canvas ConsoleCanvas;

        public ScrollRect ScrollRect;

        public Text ConsoleText;

        public Text InputText;

        public InputField ConsoleInput;

        private void Awake()
        {
            if (Instance != null)
            {
                return;
            }

            Instance = this;

            Commands = new Dictionary<string, ConsoleCommand>();
        }

        private void Start()
        {
            ConsoleCanvas.gameObject.SetActive(false);
            ConsoleText.text = "<size=20><color=cyan>Project Zero</color></size> dev Console <color=cyan><b>v0.5</b></color> \n"
                + "Type <color=orange>help</color> for list of available commands. \n" +
                "Type <color=orange>help <command></color> for command details. \n \n \n";

            CreateCommands();
        }

        private void CreateCommands()
        {
            CommandSetKeyValue commandSetKeyValue = CommandSetKeyValue.CreateCommand();

            CommandHelp commandHelp = CommandHelp.CreateCommand();
        }

        public static void AddCommandsToConsole(string name, ConsoleCommand command)
        {
            if (!Commands.ContainsKey(name))
            {
                Commands.Add(name, command);
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.BackQuote))
            {
                ConsoleCanvas.gameObject.SetActive
                    (!ConsoleCanvas.gameObject.activeInHierarchy);

                ConsoleInput.ActivateInputField();
                ConsoleInput.Select();
            }

            if (ConsoleCanvas.gameObject.activeInHierarchy)
            {
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    if (string.IsNullOrEmpty(InputText.text) == false)
                    {
                        AddMessageToConsole(InputText.text);

                        ParseInput(InputText.text);
                    }

                    ConsoleInput.text = "";

                    ConsoleInput.ActivateInputField();
                    ConsoleInput.Select();
                }               
            }
        }

        private void AddMessageToConsole(string msg)
        {
            ConsoleText.text += msg + "\n";
        }

        public static void AddStaticMessageToConsole(string msg)
        {
            Instance.ConsoleText.text += msg + "\n";
        }

        private void ParseInput(string input)
        {
            // Separate string by whitespace (==null)
            string[] splitInput = input.Split(null);

            if (string.IsNullOrWhiteSpace(input))
            {
                AddMessageToConsole("Command not recognized!");
                return;
            }

            // If first word isn't command from Commands Dictionary
            if (Commands.ContainsKey(splitInput[0]) == false)
            {
                AddMessageToConsole("Command not recognized!");
            }
            else
            {
                Commands[splitInput[0]].RunCommand(splitInput);
            }

            Canvas.ForceUpdateCanvases();
            ScrollRect.verticalScrollbar.value = 0f;
            Canvas.ForceUpdateCanvases();
        }
    }
}
