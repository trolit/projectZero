using Assets.Scripts.Game.Inventory;
using Assets.Scripts.Game.Player;
using UnityEngine;

namespace Assets.Scripts.Game
{
    public class MapToggler : MonoBehaviour
    {
        [SerializeField]
        private GameObject _mapGameObject;

        public static bool IsMapOpened = false;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.M)
                && PauseMenu.GameIsPaused == false 
                && DataLoader.IsDataLoaderActivated == false
                && InventoryManager.IsInventoryOpened == false
                && NPCHandler.IsDuringConversation == false)
            {
                SetYouAreHere.instance.UpdateCharacterLocation();

                _mapGameObject.SetActive(!_mapGameObject.activeInHierarchy);

                IsMapOpened = _mapGameObject.activeInHierarchy;
            }
        }
    }
}
