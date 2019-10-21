using System.Collections.Generic;
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
                _cameraTransform.position = new Vector3(playerPosX, _cameraTransform.position.y, playerPosZ);

                // Reset IsContinue value
                SceneLoader.IsContinue = false;
            }
        }
    }
}
