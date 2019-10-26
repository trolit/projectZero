using UnityEngine;

namespace Assets.Scripts.Game
{
    // Attach this to "Return to map" button when minigame finished
    // Specify right key name!
    public class SaveMinigameStatus : MonoBehaviour
    {
        public void SaveGameStatus(string key)
        {
            PlayerPrefs.SetInt(key, 1);

            var wasPlayedBefore = PlayerPrefs.GetInt(key + "passed");

            if (wasPlayedBefore == 0)
            {
                PlayerPrefs.SetInt(key + "passed", 1);

                var accordingUniqueKey = GetAccordingUniqueKey(key);

                if (accordingUniqueKey == "undefined")
                {
                    Debug.Log("No according unique key found! Error occured.");

                    Debug.Break();
                }

                var accordingUniqueKeyValue = PlayerPrefs.GetInt(accordingUniqueKey);

                PlayerPrefs.SetInt(accordingUniqueKey, accordingUniqueKeyValue + 1);

                Debug.Log("Saved information in " + accordingUniqueKey + " key.");
            }

            PlayerPrefs.Save();
        }

        public string GetAccordingUniqueKey(string key)
        {
            if (key.Contains("C#"))
                return "c#timesUnique";

            if (key.Contains("PHP"))
                return "php#timesUnique";

            if (key.Contains("HTML"))
                return "html#timesUnique";

            if (key.Contains("JS"))
                return "js#timesUnique";

            return key.Contains("Java") ? "java#timesUnique" : "undefined";
        }
    }
}
