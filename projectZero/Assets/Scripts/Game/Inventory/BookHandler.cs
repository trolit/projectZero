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

        private bool _isInteractable = false;

        // Update is called once per frame
        private void Update()
        {
            if (_isInteractable == false)
            {
                SetButtonInteractibility();
            }

            CloseBookOnKey();
        }

        public void OpenBook()
        {
            _bookObject.SetActive(true);

            var isBookOpenedFirstTime = PlayerPrefs.GetInt(_bookKey + "_isReadFirstTime");

            if (isBookOpenedFirstTime == 0)
            {
                if (_isUnderTest == false)
                {
                    PlayerPrefs.SetInt(_bookKey + "_isReadFirstTime", 1);
                }

                IncreaseSkillLevel();

                // PlayerPrefs.Save();
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
                _bookObject.SetActive(false);
            }
        }

        private void SetButtonInteractibility()
        {
            var bookStatus = PlayerPrefs.GetInt(_bookKey);

            if (bookStatus != 1) // if the book has not been bought yet
            {
                _button.interactable = false;

                _isInteractable = false;
            }
            else
            {
                _button.interactable = true;

                _isInteractable = true;
            }
        }

        private void IncreaseSkillLevel()
        {
            Debug.Log("Language key is -> " + _languageKey);

            switch (_languageKey)
            {
                case "csharp":
                    var currentSkill = PlayerPrefs.GetInt("csharp");
                    PlayerPrefs.SetInt("csharp", currentSkill + 1);
                    break;
                case "html":
                    currentSkill = PlayerPrefs.GetInt("html");
                    PlayerPrefs.SetInt("html", currentSkill + 1);
                    break;
                case "php":
                    currentSkill = PlayerPrefs.GetInt("php");
                    PlayerPrefs.SetInt("php", currentSkill + 1);
                    break;
                case "java":
                    currentSkill = PlayerPrefs.GetInt("java");
                    PlayerPrefs.SetInt("java", currentSkill + 1);
                    break;
                case "javascript":
                    currentSkill = PlayerPrefs.GetInt("javascript");
                    PlayerPrefs.SetInt("javascript", currentSkill + 1);
                    break;
                default:
                    Debug.LogError($"Language key - {_languageKey} is not correct on {gameObject.name}");
                    Debug.Break();
                    break;
            }
        }
    }
}
    



