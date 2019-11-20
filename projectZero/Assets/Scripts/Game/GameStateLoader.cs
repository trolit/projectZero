using System.Collections.Generic;
using Assets.Scripts.Game.Inventory;
using Assets.Scripts.Game.Shop;
using UnityEngine;

namespace Assets.Scripts.Game
{
    public class GameStateLoader : MonoBehaviour
    {
        [SerializeField]
        private List<GameObject> _playerModels;

        [SerializeField]
        private Transform _cameraTransform;

        private void Awake()
        {
            // If scene was loaded with IsContinue marked as true load last state
            if (SceneLoader.IsContinue)
            {
                // SET PLAYER POSITION
                var playerPosX = PlayerPrefs.GetFloat("playerX");
                var playerPosZ = PlayerPrefs.GetFloat("playerZ");

                foreach (var playerModel in _playerModels)
                {
                    playerModel.transform.position =
                        new Vector3(playerPosX, playerModel.transform.position.y, playerPosZ);
                }

                // SET CAMERA POSITION
                _cameraTransform.position = 
                    new Vector3(playerPosX, _cameraTransform.position.y, playerPosZ);

                // SET NPC POSITIONS
                var npcs = NPCCollector.instance.NpcGameObjects;
                var i = 0;

                foreach (var npc in npcs)
                {
                    var npcPosX = PlayerPrefs.GetFloat($"{i}npcX");
                    var npcPosZ = PlayerPrefs.GetFloat($"{i}npcZ");

                    npc.transform.position = new Vector3(npcPosX, npc.transform.position.y, npcPosZ);

                    // Debug.Log($"Positioning {npc.gameObject.name} on X-{npcPosX}, Z-{npcPosZ}");

                    i++;
                }

                // Reset IsContinue value
                SceneLoader.IsContinue = false;

                // Reset other values 
                ResetFlags();

                // Set to normal time (in case)
                Time.timeScale = 1f;
            }
            else
            {
                var newGameTipState = PlayerPrefs.GetInt("startGameTip");

                if (newGameTipState == 0)
                {
                    TipManager.instance.InvokeNewGameTip();
                }
            }
        }

        private void ResetFlags()
        {
            BookHandler.IsBookOpen = false;
            MapToggler.IsMapOpened = false;
            NPCHandler.IsDuringConversation = false;
            PauseMenu.GameIsPaused = false;
            ShopManager.IsShopOpened = false;
        }
    }
}
