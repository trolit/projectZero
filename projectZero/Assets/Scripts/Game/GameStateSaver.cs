using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
    public class GameStateSaver : MonoBehaviour
    {
        [SerializeField]
        private Transform _playerTransform;

        [SerializeField]
        private GameObject _saveGameObject;

        [SerializeField]
        private GameObject _bubbleGameObject;

        [SerializeField]
        private RawImage _pandaImage;

        [SerializeField]
        private Animator _pandaAnimator;

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

            _pandaAnimator.Play("SaveGameStateAnim");

            IsSaveButtonUsed = true;

            _saveGameObject.SetActive(true);

            Invoke("ShowBubble", 1.9f);

            Invoke("HideStatus", 3f);

            Invoke("HidePanda", 3.1f);
        }

        private void ShowBubble()
        {
            _bubbleGameObject.SetActive(true);
        }

        private void HideStatus()
        {
            _bubbleGameObject.SetActive(false);          
        }

        private void HidePanda()
        {
            _pandaAnimator.Play("HidePandaAnim");
        }
    }
}
