using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
    public class VerifyMedal : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [SerializeField]
        private RawImage _arrowPlace;

        // Specify texture of an arrow that will be visible
        // if medal will be completed
        [SerializeField]
        private Texture _unlockedArrow;

        [SerializeField]
        private RawImage _medal;

        [SerializeField]
        private GameObject _questionMark;

        [SerializeField]
        private GameObject _info;

        [SerializeField]
        private Text _amountText;

        [SerializeField]
        private string _keyCode;

        private int _storedValue;

        private bool _isUnlocked = false;

        private RectTransform _panelRectTransform;

        private int _maxValue;

        private void Start()
        {
            _panelRectTransform = GetComponent<RectTransform>();

            _storedValue = PlayerPrefs.GetInt(_keyCode);

            // If _keyCode means medalsUnlocked set value to 5
            // else set to 8
            _maxValue = _keyCode == "medalsUnlocked" ? 5 : 8;

            if (_storedValue < _maxValue)
            {
                _medal.color = new Color(0.5f, 0.5f, 0.5f);

                _questionMark.SetActive(true);
            }
            else
            {
                _questionMark.SetActive(false);

                // Change arrow place texture only ON objects THAT 
                // have _maxValue different than 5. 5 is restricted
                // for main medal which doesnt have arrows specified
                if (_maxValue != 5)
                {
                    _arrowPlace.texture = _unlockedArrow;
                }

                _isUnlocked = true;
            }

            _info.SetActive(false);

            _amountText.text = "";
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            if (_isUnlocked == false)
            {
                _amountText.text = $"{_storedValue} / {_maxValue}";

                _info.SetActive(true);

                _panelRectTransform.SetAsLastSibling();
            }
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            _info.SetActive(false);
        }
    }
}
