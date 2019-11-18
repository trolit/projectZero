using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Game
{
    // Activate script on button press

    public class MinigameDataTransferer : MonoBehaviour
    {
        // Use this on button
        public void LaunchMiniGame()
        {
            // Reset bool value IsDuringConversation
            NPCHandler.IsDuringConversation = false;

            var sceneName = NPCHandler.SceneToLoadName;

            if (string.IsNullOrWhiteSpace(sceneName) == false)
            {
                LevelLoader.CrossSceneInformation = sceneName;

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
