using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
    // Designed for loading scenes with UI progress bar element

    public class LevelLoader : MonoBehaviour
    {
        public static string CrossSceneInformation = "";

        [SerializeField]
        private Slider _slider;

        [SerializeField]
        private GameObject _loadingScreen;

        // Leave this field empty if you want the game to load mini-game loader first
        [SerializeField]
        private string _sceneName;

        [SerializeField]
        private Text _progressText;

        // if marked as true - LevelLoader will start loading scene by itself
        [SerializeField]
        private bool _isAutomated = false;

        [Header("VARIABLES TO TEST")]

        [SerializeField]
        private bool _isUnderTest = false;

        private void Start()
        {
            if (_isUnderTest == false && _isAutomated)
            {
                if (string.IsNullOrWhiteSpace(_sceneName) == false)
                {
                    LoadLevel();
                }
                else if (string.IsNullOrWhiteSpace(CrossSceneInformation) == false)
                {
                    LoadMinigameLoader();
                }
            }
        }

        public void LoadLevel()
        {
            StartCoroutine(LoadAsynchronously(_sceneName));
        }

        public void LoadMinigameLoader()
        {
            StartCoroutine(LoadAsynchronously(CrossSceneInformation));
        }

        IEnumerator LoadAsynchronously(string sceneName)
        {
            AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

            _loadingScreen.SetActive(true);

            while (operation.isDone == false)
            {
                float progress = Mathf.Clamp01(operation.progress / .9f);

                _slider.value = progress;

                var calculatedProgress = progress * 100f;

                _progressText.text = $"{calculatedProgress:0.00} %";

                yield return null;
            }
        }
    }
}
