using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
    public class VerifyMedal : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
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

        void Start()
        {
            _panelRectTransform = GetComponent<RectTransform>();

            _storedValue = PlayerPrefs.GetInt(_keyCode);

            // If _keyCode means medalsUnlocked set value to 5
            // else set to 10
            _maxValue = _keyCode == "medalsUnlocked" ? 5 : 10;

            if (_storedValue < _maxValue)
            {
                _medal.color = new Color(0.5f, 0.5f, 0.5f);

                _questionMark.SetActive(true);
            }
            else
            {
                _questionMark.SetActive(false);

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
