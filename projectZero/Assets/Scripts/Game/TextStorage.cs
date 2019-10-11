using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Game
{
    // This file stores all texts that can be shown 
    // during minigame loading

    public class TextStorage : MonoBehaviour
    {
        public static List<string> Texts { get; set; }

        void Awake()
        {
            Texts = new List<string>();

            if (LevelLoader.CrossSceneInformation.Contains("C#"))
            {
                Texts = AddCsharpDataToTexts();
                Debug.Log("Successfully added C# data to Texts");
            }
            else if (LevelLoader.CrossSceneInformation.Contains("Java"))
            {
                Texts = AddJavaDataToTexts();
                Debug.Log("Successfully added Java data to Texts");
            }
            else if (LevelLoader.CrossSceneInformation.Contains("JS"))
            {
                Texts = AddJSDataToTexts();
                Debug.Log("Successfully added JavaScript data to Texts");
            }
            else if (LevelLoader.CrossSceneInformation.Contains("PHP"))
            {
                Texts = AddPhpDataToTexts();
                Debug.Log("Successfully added PHP data to Texts");
            }
            else if (LevelLoader.CrossSceneInformation.Contains("HTML"))
            {
                Texts = AddHtmlDataToTexts();
                Debug.Log("Successfully added HTML data to Texts");
            }
            else
            {
                Debug.LogWarning("Nothing was added to Texts!");
            }
        }

        List<string> AddCsharpDataToTexts()
        {
           return new List<string>
           {
               "Microsoft pierwszy raz wspomniał nazwę C# w 1988 roku",
               "Składnia języka C# jest podobna do języków z rodziny C jak Java, C, C++",
               "C# jest dobrym językiem do projektowania gier. Wykorzystać go można w środowisku Unity.",
               "Project Zero jest grą napisaną w języku C#.",
               ""
           };
        }

        List<string> AddJavaDataToTexts()
        {
            return new List<string>
            {
                "Początkową nazwą tego języka było Oak/dąb/. Nazwę wymyślił James Gosling na cześć wielkiego dębu, który widział z okna swojego biura w Sun Microsystems.",
                "Nazwa Oak musiała być zmieniona z racji, że istniała już firma, która miała w swojej nazwie ten wyraz na Java. ",
                "Pomysł na nazwę Java wziął się z zamiłowania do jednego z gatunków kawy",
                "Język Java powstał przez przypadek.",
                "Java wywodzi się głównie z C++ oraz SmallTalk.",
                "Język ten został zaprojektowany i zaimplementowany w laboratoriach Sun Microsystems w Kalifornii pod kierownictwem Jamesa Goslinga",
                ""
            };
        }

        List<string> AddJSDataToTexts()
        {
            return new List<string>
            {
                "Jezeli cos to cos",
                "Jak to to to"
            };
        }

        List<string> AddPhpDataToTexts()
        {
            return new List<string>
            {
                "Jezeli cos to cos",
                "Jak to to to"
            };
        }

        List<string> AddHtmlDataToTexts()
        {
            return new List<string>
            {
                "Jezeli cos to cos",
                "Jak to to to"
            };
        }
    }
}
