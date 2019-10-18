using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game.Player
{
    public class DataLoader : MonoBehaviour
    {
        public static bool GameIsPaused = false;

        public GameObject DetailsMenuUI;

        public Texture CactusAvatar;

        public Texture RobotAvatar;

        public Texture SlimeAvatar;

        public Texture KnightAvatar;

        public RawImage Avatar;

        public Text MoneyText;

        
        public Slider HtmlSlider;

        public Text HtmlText;

        public Slider CSharpSlider;

        public Text CSharpText;

        public Slider PhpSlider;

        public Text PhpText;

        public Slider JavaSlider;

        public Text JavaText;

        public Slider JavascriptSlider;

        public Text JavascriptText;

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
            else if (modelId == 4) // 4 means Knight model
            {
                Avatar.texture = KnightAvatar;
            }
            else
            {
                Debug.Log("Avatar not loaded!");
                Debug.Break();
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
                    SetLanguage(HtmlSlider, HtmlText, "html");
                    SetLanguage(JavascriptSlider, JavascriptText, "javascript");
                    SetLanguage(JavaSlider, JavaText, "java");
                    SetLanguage(PhpSlider, PhpText, "php");
                    SetLanguage(CSharpSlider, CSharpText, "csharp");
                    LoadMoney();
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

        void LoadMoney()
        {
            var money = PlayerPrefs.GetInt("money");

            MoneyText.text = money.ToString();
        }

        void SetLanguage(Slider slider, Text text, string property)
        {
            var value = PlayerPrefs.GetInt(property);

            text.text = value.ToString() + "/9";

            slider.value = value;
        }
    }
}
