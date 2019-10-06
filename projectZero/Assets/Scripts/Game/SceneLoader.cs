using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Game
{
    public class SceneLoader : MonoBehaviour
    {
        [Obsolete("Use LoadSceneAsync to prevent forcing all resources to load scene")]
        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }

        public void LoadSceneAsync(string sceneName)
        {
            SceneManager.LoadSceneAsync(sceneName);
        }
    }
}
