using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Dev
{
    // Script designed to easily access scenes that need to be tested
    // in release version of Project Zero

    public class DevLaunch : MonoBehaviour
    {
        [SerializeField]
        private InputField _text;

        public void LaunchScene()
        {
            if (string.IsNullOrWhiteSpace(_text.text))
            {
                Debug.LogWarning("No scene name specified!");
            }
            else if (Application.CanStreamedLevelBeLoaded(_text.text) == false)
            {
                Debug.LogWarning($"Typed scene name {_text.text} does NOT exist OR" +
                               "\n is not set up in build settings!");
            }
            else
            {
                SceneManager.LoadSceneAsync(_text.text);
            }
        }
    }
}
