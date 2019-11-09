using UnityEngine;
using static Console.DevConsole;

namespace Console
{
    public class CommandSetBooksState : ConsoleCommand
    {
        public sealed override string Name { get; protected set; }
        public sealed override string Command { get; protected set; }
        public sealed override string Description { get; protected set; }
        public sealed override string Help { get; protected set; }
        public sealed override string Example { get; protected set; }

        public CommandSetBooksState()
        {
            Name = "Set State of all books";
            Command = "setStateOfBooks";
            Description = "Sets state of all books in game.";
            Help = "Syntax: setStateOfBooks <value> \n" +
                   $"<color={RequiredColor}>Value parameter is required and must be equal 0 or 1!</color>";
            Example = "setStateOfBooks 1";

            AddCommandToConsole();
        }

        public override void RunCommand(string[] data)
        {
            if (data.Length == 2)
            {
                string[] bookKeys =
                {
                    "C#01",
                    "C#02",
                    "C#03",
                    "C#04",
                    "HTML01",
                    "HTML02",
                    "HTML03",
                    "HTML04",
                    "J01",
                    "J02",
                    "J03",
                    "J04",
                    "JS01",
                    "JS02",
                    "JS03",
                    "JS04",
                    "PHP01",
                    "PHP02",
                    "PHP03",
                    "PHP04"
                };

                var value = int.Parse(data[1]);

                if (value == 0 || value == 1)
                {
                    foreach (var bookKey in bookKeys)
                    {
                        PlayerPrefs.SetInt(bookKey, value);
                    }

                    PlayerPrefs.Save();

                    AddStaticMessageToConsole(ExecutedSuccessfully);
                }
                else
                {
                    AddStaticMessageToConsole($"Passed value is <color={RequiredColor}>not allowed</color>");
                }
            }
            else
            {
                AddStaticMessageToConsole(ParametersAmount);
            }
        }

        public static CommandSetBooksState CreateCommand()
        {
            return new CommandSetBooksState();
        }
    }
}

