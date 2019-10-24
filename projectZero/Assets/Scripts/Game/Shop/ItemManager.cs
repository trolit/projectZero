using UnityEngine;
using UnityEngine.UI;

// Script checks if book object is available to buy
// or if it has been bought already or if its boughtable

namespace Assets.Scripts.Game.Shop
{
    public class ItemManager : MonoBehaviour
    {
        [Header("UI Components")]

        [SerializeField]
        private GameObject _soldImage;

        [SerializeField]
        private GameObject _buyObject;

        [SerializeField]
        private Button _buyButton;

        [SerializeField]
        private Text _costText;

        [Header("Variables to define")]

        [SerializeField]
        private int _productPrice;

        [SerializeField]
        private string _productKey;

        [Header("Audio elements")]

        [SerializeField]
        private AudioSource _source;

        [SerializeField]
        private AudioClip _clip;

        public static bool IsAnimationEnabled = false;

        private bool _productStatus = false;

        // Start is called before the first frame update
        private void Start()
        {
            _productStatus = IsProductAvailable();
        }

        private void Update()
        {
            // if product is available to buy watch player money status
            if (_productStatus == true)
            {
                VerifyMoneyStatus();
            }
        }

        private bool IsProductAvailable()
        {
            var bookStatus = PlayerPrefs.GetInt(_productKey);

            // Book is not available to buy
            if (bookStatus == 1)
            {
                _soldImage.SetActive(true);
                _buyObject.SetActive(false);

                return false;
            }

            _costText.text = _productPrice.ToString();
            _soldImage.SetActive(false);
            _buyObject.SetActive(true);

            return true;
        }

        private void VerifyMoneyStatus()
        {
            var currentMoney = GetCurrentMoney();

            if (currentMoney < _productPrice)
            {
                _buyButton.interactable = false;
                IsAnimationEnabled = false;
            }
            else
            {
                _buyButton.interactable = true;
                IsAnimationEnabled = true;
            }
        }

        private int GetCurrentMoney()
        {
            return PlayerPrefs.GetInt("money");
        }

        // Pin this function tu button and specify
        // key that sets int value
        public void BuyShopItem(string itemKey)
        {
            var moneyBefore = GetCurrentMoney();

            var moneyAfter = moneyBefore - _productPrice;

            _soldImage.SetActive(true);
            _buyObject.SetActive(false);

            IsAnimationEnabled = false;

            _source.PlayOneShot(_clip);

            PlayerPrefs.SetInt(itemKey, 1);

            PlayerPrefs.SetInt("money", moneyAfter);
        }
    }
}
