using Assets.Scripts.Game.Inventory;
using Assets.Scripts.Game.Shop;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game.Player
{
    public class DataLoader : MonoBehaviour
    {
        private bool _gameIsPaused = false;

        public GameObject DetailsMenuUI;

        public GameObject PauseMenuUI;

        public Texture CactusAvatar;

        public Texture RobotAvatar;

        public Texture SlimeAvatar;

        public Texture KnightAvatar;

        public RawImage Avatar;

        public Text MoneyText;

        public Text NameText;

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

        public static bool IsDataLoaderActivated = false;

        // Start is called before the first frame update
        private void Start()
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

        private void Update()
        {
            // Debug.Log("Paused? => " + PauseMenu.GameIsPaused);

            if (Input.GetKeyDown(KeyCode.I) && PauseMenu.GameIsPaused == false
                                            && BookHandler.IsBookOpen == false
                                            && ShopManager.IsShopOpened == false
                                            && MapToggler.IsMapOpened == false
                                            && NPCHandler.IsDuringConversation == false)
            {
                if (_gameIsPaused)
                {
                    Resume();

                    IsDataLoaderActivated = false;
                }
                else
                {
                    LevelCounter.instance.UpdateTextValues();

                    SetLanguage(HtmlSlider, HtmlText, "html");
                    SetLanguage(JavascriptSlider, JavascriptText, "javascript");
                    SetLanguage(JavaSlider, JavaText, "java");
                    SetLanguage(PhpSlider, PhpText, "php");
                    SetLanguage(CSharpSlider, CSharpText, "csharp");
                    LoadMoney();
                    LoadName();

                    IsDataLoaderActivated = true;

                    Pause();
                }
            }

            // If details menu UI is still active in hierarchy - keep pausing
            // and prevent from launching escape panel
            if (DetailsMenuUI.activeInHierarchy)
            {
                PauseMenuUI.GetComponent<PauseMenu>().enabled = false;

                Pause();
            }
            else if (DetailsMenuUI.activeInHierarchy == false)
            {
                PauseMenuUI.GetComponent<PauseMenu>().enabled = true;
            }
        }

        public void Resume()
        {
            DetailsMenuUI.SetActive(false);

            Time.timeScale = 1f;

            _gameIsPaused = false;
        }

        private void Pause()
        {
            DetailsMenuUI.SetActive(true);

            Time.timeScale = 0f;

            _gameIsPaused = true;
        }

        private void LoadMoney()
        {
            var money = PlayerPrefs.GetInt("money");

            MoneyText.text = money.ToString();
        }

        private void LoadName()
        {
            var characterName = PlayerPrefs.GetString("name");

            NameText.text = characterName;
        }

        private void SetLanguage(Slider slider, Text text, string property)
        {
            var value = PlayerPrefs.GetInt(property);

            text.text = value.ToString();

            slider.value = value;
        }
    }
}
