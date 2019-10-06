using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
    public class LevelLoader : MonoBehaviour
    {
        [SerializeField]
        private Slider _slider;

        [SerializeField]
        private GameObject _loadingScreen;

        [SerializeField]
        private string _sceneName;

        [SerializeField]
        private Text _progressText;

        void Start()
        {
            //if (_sceneName == "Menu")
            //{
            //    LoadLevel();
            //}
        }

        public void LoadLevel()
        {
            StartCoroutine(LoadAsynchronously());
        }

        IEnumerator LoadAsynchronously()
        {
            AsyncOperation operation = SceneManager.LoadSceneAsync(_sceneName);

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
