using UnityEngine;

namespace Assets.Scripts.Game
{
    public class GameStateSaver : MonoBehaviour
    {
        [SerializeField]
        private Transform _playerTransform;

        public void SaveGameState()
        {
            var i = 0;

            var modelsAmount = _playerTransform.childCount;

            while (i < modelsAmount)
            {
                Debug.Log("Pracuje -> " + i);

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
        }
    }
}
