using UnityEngine;

namespace Assets.Scripts.Game.Inventory
{
    public class InventoryManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject _inventoryUi;

        public static bool IsInventoryOpened = false;

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.B) 
                && BookHandler.IsBookOpen == false
                && MapToggler.IsMapOpened == false
                && NPCHandler.IsDuringConversation == false)
            {
                _inventoryUi.SetActive(!_inventoryUi.activeInHierarchy);

                IsInventoryOpened = _inventoryUi.activeInHierarchy;
            }
        }
    }

}

