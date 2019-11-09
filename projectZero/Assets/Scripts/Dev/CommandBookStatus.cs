using UnityEngine;
using static Console.DevConsole;

namespace Console
{
    public class CommandBookStatus : ConsoleCommand
    {
        public sealed override string Name { get; protected set; }
        public sealed override string Command { get; protected set; }
        public sealed override string Description { get; protected set; }
        public sealed override string Help { get; protected set; }
        public sealed override string Example { get; protected set; }

        public CommandBookStatus()
        {
            Name = "Command book status";
            Command = "getStateOfBooks";
            Description = "Returns state of each book whether it was read first time or not and bought or not.";
            Help = "Syntax: getStateOfBooks";
            Example = "getStateOfBooks";

            AddCommandToConsole();
        }

        public override void RunCommand(string[] data)
        {
            if (data.Length == 1)
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

                AddStaticMessageToConsole($"\n<color={ExecutedColor}>List of books and their states</color>");

                foreach (var bookKey in bookKeys)
                {
                    var buyStatus = PlayerPrefs.GetInt(bookKey);
                    var readStatus = PlayerPrefs.GetInt(bookKey + "_isReadFirstTime");
                    
                    var buyResult = buyStatus == 1 ? "<color=lime>YES</color>" : $"<color={RequiredColor}>NO</color>";

                    var readResult = readStatus == 1 ? "<color=lime>YES</color>" : $"<color={RequiredColor}>NO</color>";

                    AddStaticMessageToConsole($"Book {bookKey}: (was read first time? {readResult})," +
                                              $" (was bought? {buyResult})");
                }
            }
            else
            {
                AddStaticMessageToConsole(ParametersAmount);
            }
        }

        public static CommandBookStatus CreateCommand()
        {
            return new CommandBookStatus();
        }
    }
}

