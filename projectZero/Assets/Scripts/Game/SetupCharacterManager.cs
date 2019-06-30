using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts.Game
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

        [SerializeField]
        private Slider _htmlSlider;

        [SerializeField]
        private Slider _csharpSlider;
        [SerializeField]

        private Slider _javaSlider;

        [SerializeField]
        private Slider _javascriptSlider;

        [SerializeField]
        private Slider _phpSlider;

        private Slider[] _sliders;

        private int _pointsLeft;

        [SerializeField]
        private Button _resetButton;

        void Start()
        {
            _pointsLeft = _pointsAmount;

            _sliders = new Slider[5];
            _sliders[0] = _htmlSlider;
            _sliders[1] = _csharpSlider;
            _sliders[2] = _javaSlider;
            _sliders[3] = _javascriptSlider;
            _sliders[4] = _phpSlider;

            PlayerPrefs.SetInt("model", 1);

            _resetButton.gameObject.SetActive(false);
        }

        void FixedUpdate()
        {
            if (_pointsLeft <= 0)
            {
                _resetButton.gameObject.SetActive(true);
            }
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
            PlayerPrefs.SetString("name", nameField.text);
        }

        public void SaveSkills()
        {
            PlayerPrefs.SetInt("csharp", (int) _csharpSlider.value);
            PlayerPrefs.SetInt("html", (int) _htmlSlider.value);
            PlayerPrefs.SetInt("php", (int) _phpSlider.value);
            PlayerPrefs.SetInt("java", (int) _javaSlider.value);
            PlayerPrefs.SetInt("javascript", (int) _javascriptSlider.value);
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

        public void CheckPoints()
        {
            int value = 0;

            foreach (var slider in _sliders)
            {
                value += (int) slider.value;
            }

            if (value >= 5)
            {
                foreach (var slider in _sliders)
                {
                    slider.interactable = false;
                }
            }

            _pointsLeft = _pointsAmount - value;

            _pointsDisplay.text = _pointsLeft.ToString();
        }

        public void ResetPoints()
        {
            foreach (var slider in _sliders)
            {
                slider.value = 0;
                slider.interactable = true;
            }

            _resetButton.gameObject.SetActive(false);

            CheckPoints();
        }
    }
}
