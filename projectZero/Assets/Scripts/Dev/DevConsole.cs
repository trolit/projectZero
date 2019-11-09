using System.Collections;
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

        private int _consoleState;

        // *********************************************************
        // LIST OF USED COLORS 
        public static string RequiredColor = "#FA8072";

        public static string OptionalColor = "#00FF7F";

        public static string WarningColor = "#ffcc00";

        public static string ExecutedColor = "#e600e6";

        // *********************************************************
        // LIST OF COMMON MESSAGES

        public static string NotRecognized = $"Command not <color={WarningColor}>recognized</color>!";

        public static string ExecutedSuccessfully = $"Command executed <color={ExecutedColor}>successfully</color>";

        public static string ParametersAmount = $"Wrong <color={WarningColor}>amount of parameters</color>";

        public static string TypeNotSupported = $"Type of command <color={WarningColor}>not supported</color>!";

        public static string SceneNotFound = $"Scene <color={WarningColor}>not found</color>!" +
                                             $" Make sure that you have placed it inside <color={WarningColor}>build settings</color>.";

        // *********************************************************

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
            ConsoleText.text = "------------------------------------------------------------------\n" +
                               "<size=30><color=#FE1862>Project Zero</color></size> dev Console <color=#FE1862><b><size=18>v0.5</size></b></color> \n" +
                               "<size=15>Last update: 09.11.2019</size> \n" +
                               "------------------------------------------------------------------\n" + 
                               "Type <color=orange>help</color> for list of available commands. \n" +
                               "Type <color=orange>help <command></color> for command details. \n \n \n";

            CreateCommands();
        }

        private void CreateCommands()
        {
            var commandSetKeyValue = CommandSetKeyValue.CreateCommand();

            var commandHelp = CommandHelp.CreateCommand();

            var commandLoadByName = CommandLoadByName.CreateCommand();

            var commandIsReady = CommandIsReady.CreateCommand();

            var commandGetKeyValue = CommandGetKeyValue.CreateCommand();

            var commandTestLoader = CommandTestLoader.CreateCommand();

            var commandSceneList = CommandSceneList.CreateCommand();

            var commandLoadById = CommandLoadById.CreateCommand();

            var commandMgStatus = CommandMgStatus.CreateCommand();

            var commandBookStatus = CommandBookStatus.CreateCommand();

            var commandSetBooksState = CommandSetBooksState.CreateCommand();
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
            _consoleState = PlayerPrefs.GetInt("devConsole");

            if (Input.GetKeyDown(KeyCode.BackQuote) && _consoleState == 1)
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

                    // Clears input
                    ConsoleInput.text = "";

                    ConsoleInput.ActivateInputField();
                    ConsoleInput.Select();
                }               
            }

            if (ConsoleCanvas.gameObject.activeInHierarchy == false)
            {
                ConsoleInput.text = "";
            }
                
        }

        private IEnumerator ScrollDown()
        {
            yield return new WaitForSeconds(0.1f);
            ScrollRect.verticalNormalizedPosition = 0f;
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
                AddMessageToConsole(NotRecognized);
                return;
            }

            // If first word isn't command from Commands Dictionary
            if (Commands.ContainsKey(splitInput[0]) == false)
            {
                AddMessageToConsole(NotRecognized);
            }
            else
            {
                Commands[splitInput[0]].RunCommand(splitInput);
            }

            StartCoroutine(ScrollDown());
        }
    }
}
