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

        private void Start()
        {
            AudioMenu.SetActive(false);
        }

        // Update is called once per frame
        private void Update()
        {
            if (GameStateSaver.IsSaveButtonUsed == true)
            {
                Resume();

                // reset value
                GameStateSaver.IsSaveButtonUsed = false;
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (GameIsPaused && AudioMenu.activeInHierarchy == false)
                {
                    Resume();
                }
                else if (AudioMenu.activeInHierarchy)
                {
                    AudioText.text = "Aby wrócić do poprzedniego ekranu <color=yellow>naciśnij przycisk powrotu</color>.";
                }
                else if (MapToggler.IsMapOpened == true || NPCHandler.IsDuringConversation == true)
                {
                    // Do nothing
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

        public void ResetGameIsPausedState()
        {
            GameIsPaused = false;
        }
    }
}
