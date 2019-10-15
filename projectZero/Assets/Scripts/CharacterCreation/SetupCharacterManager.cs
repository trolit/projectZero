using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.CharacterCreation
{
    public class SetupCharacterManager : MonoBehaviour
    {
        private List<Transform> _models;

        [SerializeField]
        private Button[] buttons;

        [SerializeField]
        private int _pointsAmount = 5;

        [SerializeField]
        private Text _pointsDisplay;

        private int _pointsLeft;

        private int _CSharp;
        private int _HTML;
        private int _Java;
        private int _Javascript;
        private int _PHP;

        [SerializeField]
        private Text _CSharpText;

        [SerializeField]
        private Text _HTMLText;

        [SerializeField]
        private Text _JavaText;

        [SerializeField]
        private Text _JavascriptText;

        [SerializeField]
        private Text _PHPText;

        void Start()
        {
            var medalsAmount = PlayerPrefs.GetInt("medalsUnlocked");
            
            if (medalsAmount >= 3)
            {
                _pointsAmount = 6;
            }

            _pointsLeft = _pointsAmount;

            
            // Default model is 1 (cactus)
            PlayerPrefs.SetInt("model", 1);
        }

        private void Awake()
        {
            _models = new List<Transform>();

            for (int i = 0; i < transform.childCount; i++)
            {
                var model = transform.GetChild(i);

                _models.Add(model);

                model.gameObject.SetActive(i == 0);
            }
        }

        void Update()
        {
            if (_pointsLeft == 1 || _pointsLeft == 2)
            {
                _pointsDisplay.color = Color.yellow;
            }
            else if (_pointsLeft == 0)
            {
                _pointsDisplay.color = Color.red;
            }
            else
            {
                _pointsDisplay.color = Color.white;
            }
        }

        public void EnableModel(Transform modelTransform)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                var transformToToggle = transform.GetChild(i);

                bool shouldBeActive = transformToToggle == modelTransform;

                transformToToggle.gameObject.SetActive(shouldBeActive);
            }
        }

        
        public List<Transform> GetModels()
        {
            return new List<Transform>();
        }

        public void SaveChoice(int id)
        {
            // saves id which model was picked (by default cactus is picked)
            PlayerPrefs.SetInt("model", id);
        }

        public void SaveName(InputField nameField)
        {
            if (string.IsNullOrWhiteSpace(nameField.text))
            {
                nameField.text = "Mars";
            }

            PlayerPrefs.SetString("name", nameField.text);
        }

        public void AddCSharp()
        {
            if (_pointsLeft > 0)
            {
                _CSharp++;

                _pointsLeft--;

                _pointsDisplay.text = $"{_pointsLeft}";

                _CSharpText.text = $"({_CSharp})";
            }
        }

        public void RemoveCSharp()
        {
            if (_CSharp > 0)
            {
                _CSharp--;

                _pointsLeft++;

                _pointsDisplay.text = $"{_pointsLeft}";

                _CSharpText.text = $"({_CSharp})";
            }
        }

        public void AddHtml()
        {
            if (_pointsLeft > 0)
            {
                _HTML++;

                _pointsLeft--;

                _pointsDisplay.text = $"{_pointsLeft}";

                _HTMLText.text = $"({_HTML})";
            }
        }

        public void RemoveHtml()
        {
            if (_HTML > 0)
            {
                _HTML--;

                _pointsLeft++;

                _pointsDisplay.text = $"{_pointsLeft}";

                _HTMLText.text = $"({_HTML})";
            }
        }

        public void AddPhp()
        {
            if (_pointsLeft > 0)
            {
                _PHP++;

                _pointsLeft--;

                _pointsDisplay.text = $"{_pointsLeft}";

                _PHPText.text = $"({_PHP})";
            }
        }

        public void RemovePhp()
        {
            if (_PHP > 0)
            {
                _PHP--;

                _pointsLeft++;

                _pointsDisplay.text = $"{_pointsLeft}";

                _PHPText.text = $"({_PHP})";
            }
        }

        public void AddJava()
        {
            if (_pointsLeft > 0)
            {
                _Java++;

                _pointsLeft--;

                _pointsDisplay.text = $"{_pointsLeft}";

                _JavaText.text = $"({_Java})";
            }
        }

        public void RemoveJava()
        {
            if (_Java > 0)
            {
                _Java--;

                _pointsLeft++;

                _pointsDisplay.text = $"{_pointsLeft}";

                _JavaText.text = $"({_Java})";
            }
        }

        public void AddJavascript()
        {
            if (_pointsLeft > 0)
            {
                _Javascript++;

                _pointsLeft--;

                _pointsDisplay.text = $"{_pointsLeft}";

                _JavascriptText.text = $"({_Javascript})";
            }
        }

        public void RemoveJavascript()
        {
            if (_Javascript > 0)
            {
                _Javascript--;

                _pointsLeft++;

                _pointsDisplay.text = $"{_pointsLeft}";

                _JavascriptText.text = $"({_Javascript})";
            }
        }

        public void SaveSkills()
        {
            PlayerPrefs.SetInt("csharp", _CSharp);
            PlayerPrefs.SetInt("html", _HTML);
            PlayerPrefs.SetInt("php", _PHP);
            PlayerPrefs.SetInt("java", _Java);
            PlayerPrefs.SetInt("javascript", _Javascript);
        }

        public void SaveThatGameStarted()
        {
            PlayerPrefs.SetInt("newgame", 1);
        }

        public void SetInteractables()
        {
            int choice = PlayerPrefs.GetInt("model") - 1;

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].interactable = true;

                if (i == choice)
                {
                    buttons[choice].interactable = false;
                }
            }
        }
    }
}
