using UnityEngine;

namespace Assets.Scripts.Game
{
    public class GameStateSaver : MonoBehaviour
    {
        [SerializeField]
        private Transform _playerTransform;

        [SerializeField]
        private GameObject _saveGameObject;

        public static bool IsSaveButtonUsed = false;

        public void SaveGameState()
        {
            // PLAYER POSITION X,Z SAVING
            var i = 0;

            var modelsAmount = _playerTransform.childCount;

            while (i < modelsAmount)
            {
                if (_playerTransform.GetChild(i).gameObject.activeInHierarchy)
                {
                    PlayerPrefs.SetFloat("playerX", _playerTransform.GetChild(i).position.x);

                    PlayerPrefs.SetFloat("playerZ", _playerTransform.GetChild(i).position.z);

                    Debug.Log("Player position saved successfully!");

                    break;
                }

                i++;

                if (i >= _playerTransform.childCount)
                {
                    break;
                }
            }

            // Save 
            PlayerPrefs.Save();

            IsSaveButtonUsed = true;

            _saveGameObject.SetActive(true);

            Invoke("HideStatus", 3f);
        }

        private void HideStatus()
        {
            _saveGameObject.SetActive(false);
        }
    }
}
