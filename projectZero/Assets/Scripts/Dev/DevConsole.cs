using System.Collections.Generic;
using UnityEngine;
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

        public void AddCommandToConsole()
        {

        }

        public abstract void RunCommand();
    }

    public class DevConsole : MonoBehaviour
    {
        public static DevConsole Instance { get; set; }

        public static Dictionary<string, ConsoleCommand> Commands { get; set; }

        [Header("UI Components")]

        public Canvas consoleCanvas;

        public ScrollRect scrollRect;

        public Text consoleText;

        public Text inputText;

        public InputField consoleInput;

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
            consoleCanvas.gameObject.SetActive(false);
            consoleText.text = "Project Zero dev Console v0.5 \n";
        }

        private void CreateCommands()
        {

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
                consoleCanvas.gameObject.SetActive
                    (!consoleCanvas.gameObject.activeInHierarchy);
            }

            if (consoleCanvas.gameObject.activeInHierarchy)
            {
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    if (string.IsNullOrEmpty(inputText.text) == false)
                    {
                        AddMessageToConsole(inputText.text);

                        ParseInput(inputText.text);
                    }
                }
            }
        }

        private void AddMessageToConsole(string msg)
        {
            consoleText.text += msg + "\n";

            // 0f ==> force scrollRect to go to the bottom
            // 0.5f ==> force scrollRect ro go to the middle etc.
            scrollRect.verticalNormalizedPosition = 0f;
        }

        public static void AddStaticMessageToConsole(string msg)
        {
            DevConsole.Instance.consoleText.text += msg + "\n";
            DevConsole.Instance.scrollRect.verticalNormalizedPosition = 0f;
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
                Commands[splitInput[0]].RunCommand();
            }
        }
    }
}
