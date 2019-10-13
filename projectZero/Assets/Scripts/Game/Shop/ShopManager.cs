using UnityEngine;

namespace Assets.Scripts.Game.Shop
{
    public class ShopManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject _tip;

        [SerializeField]
        private GameObject _shopUI;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                _tip.SetActive(true);
            }
        }

        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                if (Input.GetKeyDown(KeyCode.B))
                {
                    _shopUI.SetActive(true);
                }
                else if (Input.GetKeyDown(KeyCode.N))
                {
                    _shopUI.SetActive(false);
                }
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                _tip.SetActive(false);

                _shopUI.SetActive(false);
            }
        }
    }
}
