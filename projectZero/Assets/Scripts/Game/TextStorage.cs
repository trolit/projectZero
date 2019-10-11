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
               "Jezeli cos to cos",
               "Jak to to to"
           };
        }

        List<string> AddJavaDataToTexts()
        {
            return new List<string>
            {
                "Jezeli cos to cos",
                "Jak to to to"
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
