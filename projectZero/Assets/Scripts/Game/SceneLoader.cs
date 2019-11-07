using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Game
{
    public class SceneLoader : MonoBehaviour
    {
        public static bool IsContinue = false;

        [Obsolete("Use LoadSceneAsync instead to prevent forcing all resources to load scene!")]
        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }

        public void LoadSceneAsync(string sceneName)
        {
            // Because this method is used in minigames 
            Time.timeScale = 1f;

            SceneManager.LoadSceneAsync(sceneName);
        }

        public void LoadSceneAsyncWithLastState(string sceneName)
        {
            // Because this method is used in minigames 
            Time.timeScale = 1f;

            IsContinue = true;

            if (string.IsNullOrWhiteSpace(sceneName))
            {
                sceneName = "Map";
            }

            SceneManager.LoadSceneAsync(sceneName);
        }
    }
}
