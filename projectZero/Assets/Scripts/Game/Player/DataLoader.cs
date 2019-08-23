using UnityEngine;
using UnityEngine.UI;
using Input = UnityEngine.Input;

namespace Assets.Scripts.Game.Player
{
    public class DataLoader : MonoBehaviour
    {
        public static bool GameIsPaused = false;

        public GameObject DetailsMenuUI;

        public Texture CactusAvatar;

        public Texture RobotAvatar;

        public Texture SlimeAvatar;

        public RawImage Avatar;

        // Start is called before the first frame update
        void Start()
        {
            // Load avatar
            var modelId = PlayerPrefs.GetInt("model");

            if (modelId == 1) // 1 means Cactus model
            {
                Avatar.texture = CactusAvatar;
            }
            else if (modelId == 2) // 2 means Slime model
            {
                Avatar.texture = SlimeAvatar;
            }
            else if (modelId == 3) // 3 means Robot model
            {
                Avatar.texture = RobotAvatar;
            }
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                if (GameIsPaused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
        }

        public void Resume()
        {
            DetailsMenuUI.SetActive(false);

            Time.timeScale = 1f;

            GameIsPaused = false;
        }

        void Pause()
        {
            DetailsMenuUI.SetActive(true);

            Time.timeScale = 0f;

            GameIsPaused = true;
        }

        
    }
}
