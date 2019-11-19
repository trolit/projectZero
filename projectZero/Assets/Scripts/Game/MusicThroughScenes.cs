using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Game
{
    public class MusicThroughScenes : MonoBehaviour
    {
        private AudioSource _audioSource;

        private string _currentSceneName;

        private void Awake()
        {
            DontDestroyOnLoad(transform.gameObject);
            _audioSource = GetComponent<AudioSource>();

            _currentSceneName = SceneManager.GetActiveScene().name;
        }

        public void PlayMusic()
        {
            if (_audioSource.isPlaying) return;

            _audioSource.Play();
        }

        public void StopMusic()
        {
            _audioSource.Stop();
        }

        private void Update()
        {
            var currentScene = SceneManager.GetActiveScene().name;

            // Theme music only enabled on scenes that names are below
            if (currentScene != "Menu" &&
                currentScene != "Settings" &&
                currentScene != "Prizes" &&
                currentScene != "Medals" &&
                currentScene != "CharacterCreation")
            {
                Destroy(gameObject);

                enabled = false; 
            }
        }
    }
}
