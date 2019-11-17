using Assets.Scripts.Game.Player;
using UnityEngine;

namespace Assets.Scripts.Game.Shop
{
    public class ShopManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject _tip;

        [SerializeField]
        private GameObject _shopUi;

        [SerializeField]
        private AudioClip _clip;

        private bool _isInShopArea = false;

        private AudioSource _audioSource;

        public static bool IsShopOpened = false;

        private void Start()
        {
            _audioSource = GetComponent<AudioSource>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                var shopTipStatus = PlayerPrefs.GetInt("bookStoreTip");

                if (shopTipStatus == 0)
                {
                    TipManager.instance.InvokeShopTip();
                }

                _tip.SetActive(true);

                _isInShopArea = true;

                _audioSource.PlayOneShot(_clip);
            }
        }

        private void Update()
        {
            if (_isInShopArea)
            {
                if (Input.GetKeyDown(KeyCode.K))
                {
                    _shopUi.SetActive(!_shopUi.activeInHierarchy);

                    IsShopOpened = _shopUi.activeInHierarchy;
                }
            }         
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                _tip.SetActive(false);

                _shopUi.SetActive(false);

                _isInShopArea = false;

                _audioSource.PlayOneShot(_clip);
            }
        }
    }
}
