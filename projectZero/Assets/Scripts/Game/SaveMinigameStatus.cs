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
        }
    }
}
