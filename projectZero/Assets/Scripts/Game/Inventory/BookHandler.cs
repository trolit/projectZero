using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game.Inventory
{
    public class BookHandler : MonoBehaviour
    {
        [SerializeField]
        private string _bookKey;

        [SerializeField]
        private Button _button;

        [SerializeField]
        private string _languageKey;

        [SerializeField]
        private GameObject _bookObject;

        [SerializeField]
        private bool _isUnderTest = false;

        [SerializeField]
        private Animator _notifierAnimator;

        [SerializeField]
        private Texture _logoTexture;

        private bool _isInteractable = false;

        public static bool IsBookOpen = false;

        private void Awake()
        {
            if (_logoTexture == null)
            {
                Debug.LogError($"BookHandler: No texture assigned on -> {gameObject.name}");
                Debug.Break();
            }
        }

        // Update is called once per frame
        private void Update()
        {
            if (_isInteractable == false)
            {
                SetButton();
            }

            CloseBookOnKey();
        }

        public void OpenBook()
        {
            _bookObject.SetActive(true);

            IsBookOpen = true;

            var isBookOpenedFirstTime = PlayerPrefs.GetInt(_bookKey + "_isReadFirstTime");

            if (isBookOpenedFirstTime == 0)
            {
                IncreaseSkillLevel();

                _notifierAnimator.SetBool("isNotifierInvoked", true);

                Invoke("HideNotifier", 8f);

                if (_isUnderTest == false)
                {
                    PlayerPrefs.SetInt(_bookKey + "_isReadFirstTime", 1);
                    
                    // In case of lag during the game, remove this line
                    PlayerPrefs.Save();
                }
            }
            else
            {
                Debug.Log("This book is opened not the first time!");
            }
        }

        private void CloseBookOnKey()
        {
            if (gameObject.activeInHierarchy && Input.GetKeyDown(KeyCode.K))
            {
                IsBookOpen = false;

                HideNotifier();

                _bookObject.SetActive(false);
            }
        }

        private void SetButton()
        {
            var bookStatus = PlayerPrefs.GetInt(_bookKey);

            if (bookStatus != 1) // if the book has not been bought yet
            {
                _button.GetComponentInChildren<Text>().text = "Niedostępna";

                _button.interactable = false;

                _isInteractable = false;
            }
            else
            {
                _button.GetComponentInChildren<Text>().text = "Przeczytaj";

                _button.interactable = true;

                _isInteractable = true;
            }
        }

        private void IncreaseSkillLevel()
        {
            var presentSkill = 0;

            switch (_languageKey)
            {
                case "csharp":
                    var pastSkill = PlayerPrefs.GetInt("csharp");
                    presentSkill = pastSkill + 1;

                    LevelCounter.instance.HandleValueManually("C#");

                    if (_isUnderTest == false)
                    {
                        PlayerPrefs.SetInt("csharp", presentSkill);
                    }

                    break;
                case "html":
                    pastSkill = PlayerPrefs.GetInt("html");
                    presentSkill = pastSkill + 1;

                    LevelCounter.instance.HandleValueManually("HTML");

                    if (_isUnderTest == false)
                    {
                        PlayerPrefs.SetInt("html", presentSkill);
                    }

                    break;
                case "php":
                    pastSkill = PlayerPrefs.GetInt("php");
                    presentSkill = pastSkill + 1;

                    LevelCounter.instance.HandleValueManually("PHP");

                    if (_isUnderTest == false)
                    {
                        PlayerPrefs.SetInt("php", presentSkill);
                    }

                    break;
                case "java":
                    pastSkill = PlayerPrefs.GetInt("java");
                    presentSkill = pastSkill + 1;

                    LevelCounter.instance.HandleValueManually("JAVA");

                    if (_isUnderTest == false)
                    {
                        PlayerPrefs.SetInt("java", presentSkill);
                    }

                    break;
                case "javascript":
                    pastSkill = PlayerPrefs.GetInt("javascript");
                    presentSkill = pastSkill + 1;

                    LevelCounter.instance.HandleValueManually("JAVASCRIPT");

                    if (_isUnderTest == false)
                    {
                        PlayerPrefs.SetInt("javascript", presentSkill);
                    }

                    break;
                default:
                    Debug.LogError($"Language key - {_languageKey} is not correct on {gameObject.name}");
                    Debug.Break();
                    break;
            }

            NotifierHandler.instance.LevelValue = presentSkill;
            NotifierHandler.instance.LogoTexture = _logoTexture;

            NotifierHandler.instance.SetupNotifier();
        }

        private void HideNotifier()
        {
            _notifierAnimator.SetBool("isNotifierInvoked", false);
        }
    }
}
    



