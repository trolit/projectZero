using UnityEngine;

namespace Assets.Scripts.Game
{
    public class GameStateClearer : MonoBehaviour
    {
        private void Start()
        {
            gameObject.SetActive(false);
        }

        public void ClearGameState()
        {
            #region Keys data

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

            string[] levelKeys =
            {
                "PU_C#1",
                "PU_C#2",
                "PU_HTML#1",
                "PU_HTML#2",
                "PU_Java#1",
                "PU_Java#2",
                "PU_JS#1",
                "PU_JS#2",
                "PU_PHP#1",
                "PU_PHP#2",
                "PI_C#1",
                "PI_C#2",
                "PI_HTML#1",
                "PI_HTML#2",
                "PI_Java#1",
                "PI_Java#2",
                "PI_JS#1",
                "PI_JS#2",
                "PI_PHP#1",
                "PI_PHP#2",
                "MA_C#1",
                "MA_C#2",
                "MA_HTML#1",
                "MA_HTML#2",
                "MA_Java#1",
                "MA_Java#2",
                "MA_JS#1",
                "MA_JS#2",
                "MA_PHP#1",
                "MA_PHP#2",
                "SK_C#1",
                "SK_C#2",
                "SK_HTML#1",
                "SK_HTML#2",
                "SK_Java#1",
                "SK_Java#2",
                "SK_JS#1",
                "SK_JS#2",
                "SK_PHP#1",
                "SK_PHP#2"
            };

            string[] otherKeys =
            {
                "money",
                "newgame",
                "model",
                "csharp",
                "html",
                "php",
                "java",
                "javascript",
                "c#timesUnique",
                "php#timesUnique",
                "html#timesUnique",
                "js#timesUnique",
                "java#timesUnique",
                "medalsUnlocked"
            };

            #endregion

            ClearIntTypedKeys(bookKeys);

            ClearIntTypedKeys(levelKeys);

            ClearIntTypedKeys(otherKeys);
            
            ClearUniquePassedKeys(levelKeys);

            PlayerPrefs.Save();

            Debug.Log("Game status cleared!");
        }

        public void ClearSpecificDataOnNewGame()
        {
            #region Keys data

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

            string[] levelKeys =
            {
                "PU_C#1",
                "PU_C#2",
                "PU_HTML#1",
                "PU_HTML#2",
                "PU_Java#1",
                "PU_Java#2",
                "PU_JS#1",
                "PU_JS#2",
                "PU_PHP#1",
                "PU_PHP#2",
                "PI_C#1",
                "PI_C#2",
                "PI_HTML#1",
                "PI_HTML#2",
                "PI_Java#1",
                "PI_Java#2",
                "PI_JS#1",
                "PI_JS#2",
                "PI_PHP#1",
                "PI_PHP#2",
                "MA_C#1",
                "MA_C#2",
                "MA_HTML#1",
                "MA_HTML#2",
                "MA_Java#1",
                "MA_Java#2",
                "MA_JS#1",
                "MA_JS#2",
                "MA_PHP#1",
                "MA_PHP#2",
                "SK_C#1",
                "SK_C#2",
                "SK_HTML#1",
                "SK_HTML#2",
                "SK_Java#1",
                "SK_Java#2",
                "SK_JS#1",
                "SK_JS#2",
                "SK_PHP#1",
                "SK_PHP#2"
            };

            string[] otherKeys =
            {
                "money",
                "model",
                "csharp",
                "html",
                "php",
                "java",
                "javascript",
                "interactNpcTip",
                "startGameTip",
                "bookStoreTip",
                "noActiveTasksTip",
                "finishOneLandTip"
            };

            #endregion

            ClearIntTypedKeys(bookKeys);

            ClearIntTypedKeys(levelKeys);

            ClearIntTypedKeys(otherKeys);

            ClearBookReadFirstTimeKeys(bookKeys);

            PlayerPrefs.Save();
        }

        private void ClearIntTypedKeys(string[] array)
        {
            foreach (var key in array)
            {
                PlayerPrefs.SetInt(key, 0);
            }
        }

        private void ClearUniquePassedKeys(string[] array)
        {
            foreach (var key in array)
            {
                PlayerPrefs.SetInt(key + "passed", 0);
            }
        }

        private void ClearBookReadFirstTimeKeys(string[] array)
        {
            foreach (var key in array)
            {
                PlayerPrefs.SetInt(key + "_isReadFirstTime", 0);
            }
        }
    }
}
