using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
    // Designed for loading scenes with UI progress bar element

    public class LevelLoader : MonoBehaviour
    {
        public static string CrossSceneInformation { get; set; }

        [SerializeField]
        private Slider _slider;

        [SerializeField]
        private GameObject _loadingScreen;

        [SerializeField]
        private string _sceneName;

        [SerializeField]
        private Text _progressText;

        [SerializeField]
        private bool _isAutomated = false;  // if marked as true - LevelLoader will start loading scene by itself

        void Start()
        {
            if (_isAutomated && string.IsNullOrWhiteSpace(_sceneName) == false)
            {
                LoadLevel();
            }
            else if (string.IsNullOrWhiteSpace(CrossSceneInformation) == false)
            {
                LoadMinigameLoader();
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

                _progressText.text = progress * 100f + "%";

                yield return null;
            }
        }
    }
}
