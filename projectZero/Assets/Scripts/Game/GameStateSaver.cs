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

        [SerializeField]
        private GameObject _savingGameObject;

        public static bool IsSaveButtonUsed = false;

        public void SaveGameState(bool isAnimationDisabled = false)
        {
            _savingGameObject.SetActive(true);

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

            // NPC POSITION X,Z SAVING
            var npcs = NPCCollector.instance.NpcGameObjects;
            i = 0;

            foreach (var npc in npcs)
            {
                PlayerPrefs.SetFloat($"{i}npcX", npc.transform.position.x);

                PlayerPrefs.SetFloat($"{i}npcZ", npc.transform.position.z);

                i++;
            }

            // Save 
            _saveGameObject.SetActive(true);

            PlayerPrefs.Save();

            IsSaveButtonUsed = true;

            if (isAnimationDisabled == false)
            {
                Invoke("FunctionsInvoker", 2f);
            }
            else
            {
                Invoke("HideSavingGameObject", 2f);
            }
        }

        private void HideSavingGameObject()
        {
            _savingGameObject.SetActive(false);
        }

        private void FunctionsInvoker()
        {
            _pandaAnimator.Play("SaveGameStateAnim");

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

            _savingGameObject.SetActive(false);
        }
    }
}
