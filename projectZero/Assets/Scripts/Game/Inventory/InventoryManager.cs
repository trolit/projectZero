using UnityEngine;

namespace Assets.Scripts.Game.Inventory
{
    public class InventoryManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject _inventoryUi;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                _inventoryUi.SetActive(!_inventoryUi.activeInHierarchy);
            }
        }
    }

}

