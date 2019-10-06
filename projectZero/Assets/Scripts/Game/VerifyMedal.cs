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

        private int _gamesPlayed;

        private bool _isUnlocked = false;

        private RectTransform _panelRectTransform;

        void Start()
        {
            _panelRectTransform = GetComponent<RectTransform>();

            _gamesPlayed = PlayerPrefs.GetInt(_keyCode);

            if (_gamesPlayed < 10)
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
                _amountText.text = $"{_gamesPlayed} / 10";
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
