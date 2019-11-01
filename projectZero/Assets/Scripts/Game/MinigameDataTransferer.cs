using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Game
{
    // Activate script on button press

    public class MinigameDataTransferer : MonoBehaviour
    {
        // Use this on button
        public void LaunchMiniGame(string _sceneName)
        {
            if (string.IsNullOrWhiteSpace(_sceneName) == false)
            {
                LevelLoader.CrossSceneInformation = _sceneName;

                SceneManager.LoadSceneAsync("MinigameLoader");
            }
            else
            {
                Debug.LogError($"Problem occured with _sceneName on {gameObject.name}");

                Debug.Break();
            }
        }
    }
}
