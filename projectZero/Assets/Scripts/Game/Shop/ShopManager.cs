using UnityEngine;

namespace Assets.Scripts.Game.Shop
{
    public class ShopManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject _tip;

        [SerializeField]
        private GameObject _shopUI;

        private bool _isInShopArea = false;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                _tip.SetActive(true);

                _isInShopArea = true;
            }
        }

        private void Update()
        {
            if (_isInShopArea)
            {
                if (Input.GetKeyDown(KeyCode.B))
                {
                    _shopUI.SetActive(!_shopUI.activeInHierarchy);
                }
            }         
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                _tip.SetActive(false);

                _shopUI.SetActive(false);

                _isInShopArea = false;
            }
        }
    }
}
