using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
    public class PauseMenu : MonoBehaviour
    {
        public static bool GameIsPaused = false;

        public GameObject PauseMenuUi;

        public GameObject AudioMenu;

        public Text AudioText;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (GameIsPaused && AudioMenu.activeInHierarchy == false)
                {
                    Resume();
                }
                else if (AudioMenu.activeInHierarchy)
                {
                    AudioText.text = "Aby wrócić do poprzedniego ekranu wciśnij przycisk powrotu.";

                    Invoke("TextClearer", 2f);
                }
                else
                {
                    Pause();
                }
            }
        }

        public void Resume()
        {
            PauseMenuUi.SetActive(false);

            Time.timeScale = 1f;

            GameIsPaused = false;
        }

        public void Restart()
        {
            Time.timeScale = 1f;
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadSceneAsync(scene.name);
        }

        private void Pause()
        {
            PauseMenuUi.SetActive(true);

            Time.timeScale = 0f;

            GameIsPaused = true;
        }

        private void TextClearer()
        {
            AudioText.text = "";
        }
    }
}
