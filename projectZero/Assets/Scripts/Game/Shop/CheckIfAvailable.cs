using UnityEngine;
using UnityEngine.UI;

// Script checks if book object is available to buy
// or if it has been bought already or if its boughtable

namespace Assets.Scripts.Game.Shop
{
    public class CheckIfAvailable : MonoBehaviour
    {
        [SerializeField]
        private GameObject _soldImage;

        [SerializeField]
        private GameObject _buyObject;

        [SerializeField]
        private Button _buyButton;

        [SerializeField]
        private Text _priceText;

        [SerializeField]
        private int _price;

        [SerializeField]
        private string _bookKey;

        public static bool IsBookAnimated = false;

        // Start is called before the first frame update
        void Start()
        {
            _priceText.text = _price.ToString();
        }

        // Update is called once per frame
        void Update()
        {
            var bookStatus = PlayerPrefs.GetInt(_bookKey);

            if (bookStatus == 1)
            {
                _soldImage.SetActive(true);
                _buyObject.SetActive(false);
            }
            else
            {
                _soldImage.SetActive(false);
                _buyObject.SetActive(true);
            }

            var currentMoney = PlayerPrefs.GetInt("money");

            if (currentMoney < _price)
            {
                _buyButton.interactable = false;
                IsBookAnimated = false;
            }
            else
            {
                _buyButton.interactable = true;
                IsBookAnimated = true;
            }
        }
    }
}
