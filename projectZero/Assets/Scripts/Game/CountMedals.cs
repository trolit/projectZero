using UnityEngine;

namespace Assets.Scripts.Game
{
    public class CountMedals : MonoBehaviour
    {
        private int _medalsAmount = 0;

        private void Start()
        {
            // GET DATA
            var csharpLevels = PlayerPrefs.GetInt("c#timesUnique");

            var phpLevels = PlayerPrefs.GetInt("php#timesUnique");

            var htmlLevels = PlayerPrefs.GetInt("html#timesUnique");

            var jsLevels = PlayerPrefs.GetInt("js#timesUnique");

            var javaLevels = PlayerPrefs.GetInt("java#timesUnique");

            // SET MEDALS AMOUNT
            CheckForMedal(csharpLevels);

            CheckForMedal(phpLevels);

            CheckForMedal(htmlLevels);

            CheckForMedal(jsLevels);

            CheckForMedal(javaLevels);
            
            // SAVE MEDALS AMOUNT
            SaveMedalAmountStatus();
        }

        private void CheckForMedal(int value)
        {
            if (value >= 8)
            {
                _medalsAmount++;
            }
        }

        private void SaveMedalAmountStatus()
        {
            PlayerPrefs.SetInt("medalsUnlocked", _medalsAmount);
        }
    }
}
